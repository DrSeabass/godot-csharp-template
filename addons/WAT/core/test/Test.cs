using Godot;
using System;
using Godot.Collections;
using GodotArray = Godot.Collections.Array;
using GodotDictionary = Godot.Collections.Dictionary;
using System.Reflection;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace WAT {
	
	public class Test : Node
	{
		
		[AttributeUsage(AttributeTargets.Method)]
		public class TestAttribute : Attribute {}
		
		[AttributeUsage(AttributeTargets.Method, AllowMultiple=true)]
		public class RunWith : Attribute 
		{
			public System.Object[] arguments;
			public RunWith(params System.Object[] args) { arguments = args; }
		}
		
		public const String YIELD = "finished";
		const bool TEST = true;
		protected Assertions Assert;
		private Reference Testcase;
		public Timer Yielder;
		public Reference Watcher;
		// private Script recorder;
		
		[Signal]
		delegate void Described(String MethodDescription);
		
		public virtual void Start() {}
		public virtual void Pre() {}
		public virtual void Post() {}
		public virtual void End() {}
		
		public void SetUp(Reference testcase)
		{

			Assert = new Assertions();
			Testcase = testcase;
			
			Script yielder = (Script)ResourceLoader.Load("res://addons/WAT/core/test/yielder.gd");
			Yielder = (Timer)yielder.Call("new");
			
			Script watcher = (Script)ResourceLoader.Load("res://addons/WAT/core/test/watcher.gd");
			Watcher = (Reference)watcher.Call("new");

		}
		
		public override void _Ready()
		{
			Assert.assertions.Call("connect", "asserted", Testcase, "_on_asserted");
			Connect("Described", Testcase, "_on_test_method_described");
		}
		
		public virtual String Title()
		{
			return GetType().Name;
		}
		
		public GodotArray GetTestMethods()
		{
			
			
			GodotArray Methods = new GodotArray();
			foreach(MethodInfo m in GetType().GetMethods())
			{
				if(m.IsDefined(typeof(TestAttribute)))
				{
					Methods.Add(m.Name);
				}
			}

			return Methods;
		}
		
		public GodotArray GetTestMethod(string MethodName)
		{
			// Inefficient but I'm so tired
			GodotArray Methods = GetMethods();
			GodotArray MethodCopies = new GodotArray();
			foreach(GodotDictionary dict in Methods){
				GD.Print(dict["title"]);
				if((string)dict["title"] == (string)MethodName)
				{
					MethodCopies.Add(dict);
				}
			}
			return MethodCopies;
		}
		
		public GodotArray GetMethods()
		{
			GodotArray Methods = new GodotArray();
			
			List<MethodInfo> MethodInfos = GetType().GetMethods().Where(m => m.IsDefined(typeof(TestAttribute))).ToList();
			foreach(MethodInfo m in MethodInfos) {
					if(m.IsDefined(typeof(RunWith)))
					{
						System.Attribute[] attrs = System.Attribute.GetCustomAttributes(m);
						foreach(System.Attribute attr in attrs)
						{
							if(attr is RunWith)
							{
								GodotDictionary Method = new GodotDictionary();
								GodotArray Arguments = new GodotArray();
								RunWith runWith = (RunWith)attr;
								
								foreach(var arg in runWith.arguments)
								{
									Arguments.Add(arg);
								}
								
								Method["title"] = m.Name;
								Method["args"] = Arguments;
								Methods.Add(Method);
							}
						}
					}
					
					else 
					{
						
						GodotDictionary Method = new GodotDictionary();
						Method["title"] = m.Name;
						Method["args"] = new GodotArray();
						Methods.Add(Method);
					}
			}
			
			return Methods;
		}
		
		public bool IsTestSuite()
		{
			return true;
		}
		
		static public String get_instance_base_type()
		{
			return "WAT.Test";
		}
		
		protected void Describe(String MethodDescription)
		{
			EmitSignal("Described", MethodDescription);
		}
		
		public void Watch(Godot.Object Emitter, String Event)
		{
			Watcher.Call("watch", Emitter, Event);
		}
		
		public void UnWatch(Godot.Object Emitter, String Event)
		{
			Watcher.Call("unwatch", Emitter, Event);
		}
		
		public void Simulate(Node obj, int times, float delta)
		{
			for (int i = 0; i < times; i ++)
			{
				if(obj.HasMethod("_Process")) {
					obj._Process(delta);
				}
				
				if(obj.HasMethod("_PhysicsProcess")) {
					obj._PhysicsProcess(delta);
				}
				
				foreach(Node kid in obj.GetChildren()) {
					Simulate(kid, 1, delta);
				}
			}
		}
		
		public Recorder Record(Godot.Object Who, GodotArray Properties) 
		{
			Recorder recorder = new Recorder();
			recorder.Record(Who, Properties);
			AddChild(recorder);
			return recorder;

		}

		public Timer UntilSignal(Godot.Object Emitter, String Event, double TimeLimit)
		{
			Watcher.Call("watch", Emitter, Event);
			return (Timer)Yielder.Call("until_signal", TimeLimit, Emitter, Event);
		}
		
		public Timer UntilTimeout(double TimeLimit)
		{
			return (Timer)Yielder.Call("until_timeout", TimeLimit);
		}
	}
}
