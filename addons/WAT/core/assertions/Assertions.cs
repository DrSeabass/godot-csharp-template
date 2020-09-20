using Godot;
using System;
using System.Collections.Generic;
using GDArray = Godot.Collections.Array;

namespace WAT {
		
	public class Assertions : Reference
	{
		
		public Reference assertions;
	
		public Assertions()
		{
			String path = "res://addons/WAT/core/assertions/assertions.gd";
			Godot.Script script = (Godot.Script)ResourceLoader.Load(path);
			assertions = (Reference)script.Call("new");
		}
		
		public void IsTrue(bool a, String Context = "")
		{
			assertions.Call("is_true", a, Context);
		}
		
		public void IsFalse(bool a, String Context = "")
		{
			assertions.Call("is_false", a, Context);
		}
		
		public void IsEqual(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("is_equal", a, b, Context);
		}
		
		public void IsNotEqual(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("is_not_equal", a, b, Context);
		}
		
		public void IsGreaterThan(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("is_greater_than", a, b, Context);
		}
		
		public void IsLessThan(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("is_less_than", a, b, Context);
		}
		
		public void IsEqualOrGreaterThan(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("is_equal_or_greater_than", a, b, Context);
		}
		
		public void IsEqualOrLessThan(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("is_equal_or_less_than", a, b, Context);
		}

		public void SignalWasEmitted(Godot.Object Emitter, String Event, String Context = "")
		{
			assertions.Call("signal_was_emitted", Emitter, Event, Context);
		}
		
		public void SignalWasEmittedXTimes(Godot.Object Emitter, String Event, int Times, String Context = "")
		{
			assertions.Call("signal_was_emitted_x_times", Emitter, Event, Times, Context);
		}
		
		public void SignalWasNotEmitted(Godot.Object Emitter, String Event, String Context = "")
		{
			assertions.Call("signal_was_not_emitted", Emitter, Event, Context);
		}
	
		public void SignalWasEmittedWithArguments(Godot.Object Emitter, String Event, GDArray Args, String Context = "")
		{
			assertions.Call("signal_was_emitted_with_arguments", Emitter, Event, Args, Context);
		}
		
		public void IsInRange(System.Object a, System.Object b, System.Object c, String Context = "")
		{
			assertions.Call("is_in_range", a,  b,  c, Context);
		}
		
		public void IsNotInRange(System.Object a, System.Object b, System.Object c, String Context = "")
		{
			assertions.Call("is_not_in_range", a,  b,  c, Context);
		}
		
		public void Has(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("has", a,  b, Context);
		}
		
		public void DoesNotHave(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("does_not_have", a,  b, Context);
		}
		
		public void IsClassInstance(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("is_class_instance", a,  b, Context);
		}
		
		public void IsNotClassInstance(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("is_not_class_instance", a,  b, Context);
		}
		
		public void IsBuiltInType(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("is_built_in_type", a,  b, Context);
		}
		
		public void IsNotBuiltInType(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("is_not_built_in_type", a,  b, Context);
		}
		
		public void IsNull(System.Object a, String Context = "")
		{
			assertions.Call("is_null", a, Context);
		}
		
		public void IsNotNull(System.Object a, String Context = "")
		{
			assertions.Call("is_not_null", a, Context);
		}
		
		public void StringContains(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("string_contains", a,  b, Context);
		}
		
		public void StringDoesNotContain(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("string_does_not_contain", a,  b, Context);
		}
		
		public void StringBeginsWith(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("string_begins_with", a,  b, Context);
		}
		
		public void StringDoesNotBeginWith(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("string_does_not_begin_with", a,  b, Context);
		}
		
		public void StringEndsWith(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("string_ends_with", a,  b, Context);
		}
		
		public void StringDoesNotEndWith(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("string_does_not_end_with", a,  b, Context);
		}
		
		public void WasCalled(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("was_called", a,  b, Context);
		}
		
		public void WasNotCalled(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("was_not_called", a,  b, Context);
		}
		
		public void WasCalledWithArguments(System.Object a, System.Object b, System.Object c, String Context = "")
		{
			assertions.Call("was_called_with_arguments", a,  b,  c, Context);
		}
		
		public void FileExists(String Context = "")
		{
			assertions.Call("file_exists",Context);
		}
		
		public void FileDoesNotExist(String Context = "")
		{
			assertions.Call("file_does_not_exist",Context);
		}
		
		public void That(System.Object a, System.Object b, System.Object c, System.Object d, System.Object e, String Context = "")
		{
			assertions.Call("that", a,  b,  c,  d,  e, Context);
		}
		
		public void ObjectHasMeta(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("object_has_meta", a,  b, Context);
		}
		
		public void ObjectDoesNotHaveMeta(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("object_does_not_have_meta", a,  b, Context);
		}
		
		public void ObjectHasMethod(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("object_has_method", a,  b, Context);
		}
		
		public void ObjectDoesNotHaveMethod(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("object_does_not_have_method", a,  b, Context);
		}
		
		public void ObjectIsQueuedForDeletion(System.Object a, String Context = "")
		{
			assertions.Call("object_is_queued_for_deletion", a, Context);
		}
		
		public void ObjectIsNotQueuedForDeletion(System.Object a, String Context = "")
		{
			assertions.Call("object_is_not_queued_for_deletion", a, Context);
		}
		
		public void ObjectIsConnected(System.Object a, System.Object b, System.Object c, System.Object d, String Context = "")
		{
			assertions.Call("object_is_connected", a,  b,  c,  d, Context);
		}
		
		public void ObjectIsNotConnected(System.Object a, System.Object b, System.Object c, System.Object d, String Context = "")
		{
			assertions.Call("object_is_not_connected", a,  b,  c,  d, Context);
		}
		
		public void ObjectIsBlockingSignals(System.Object a, String Context = "")
		{
			assertions.Call("object_is_blocking_signals", a, Context);
		}
		
		public void ObjectIsNotBlockingSignals(System.Object a, String Context = "")
		{
			assertions.Call("object_is_not_blocking_signals", a, Context);
		}
		
		public void ObjectHasUserSignal(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("object_has_user_signal", a,  b, Context);
		}
		
		public void ObjectDoesNotHaveUserSignal(System.Object a, System.Object b, String Context = "")
		{
			assertions.Call("object_does_not_have_user_signal", a,  b, Context);
		}
		
		public void IsFreed(System.Object a, String Context = "")
		{
			assertions.Call("is_freed", a, Context);
		}
		
		public void IsNotFreed(System.Object a, String Context = "")
		{
			assertions.Call("is_not_freed", a, Context);
		}
		
		public void IsAABB(System.Object a, String Context = "")
		{
			assertions.Call("is_AABB", a, Context);
		}
		
		public void IsNotAABB(System.Object a, String Context = "")
		{
			assertions.Call("is_not_AABB", a, Context);
		}
		
		public void IsBool(System.Object a, String Context = "")
		{
			assertions.Call("is_bool", a, Context);
		}
		
		public void IsNotBool(System.Object a, String Context = "")
		{
			assertions.Call("is_not_bool", a, Context);
		}
		
		public void IsInt(System.Object a, String Context = "")
		{
			assertions.Call("is_int", a, Context);
		}
		
		public void IsNotInt(System.Object a, String Context = "")
		{
			assertions.Call("is_not_int", a, Context);
		}
		
		public void IsFloat(System.Object a, String Context = "")
		{
			assertions.Call("is_float", a, Context);
		}
		
		public void IsNotFloat(System.Object a, String Context = "")
		{
			assertions.Call("is_not_float", a, Context);
		}
		
		public void IsString(System.Object a, String Context = "")
		{
			assertions.Call("is_String", a, Context);
		}
		
		public void IsNotString(System.Object a, String Context = "")
		{
			assertions.Call("is_not_String", a, Context);
		}
		
		public void IsVector2(System.Object a, String Context = "")
		{
			assertions.Call("is_Vector2", a, Context);
		}
		
		public void IsNotVector2(System.Object a, String Context = "")
		{
			assertions.Call("is_not_Vector2", a, Context);
		}
		
		public void IsRect2(System.Object a, String Context = "")
		{
			assertions.Call("is_Rect2", a, Context);
		}
		
		public void IsNotRect2(System.Object a, String Context = "")
		{
			assertions.Call("is_not_Rect2", a, Context);
		}
		
		public void IsVector3(System.Object a, String Context = "")
		{
			assertions.Call("is_Vector3", a, Context);
		}
		
		public void IsNotVector3(System.Object a, String Context = "")
		{
			assertions.Call("is_not_Vector3", a, Context);
		}
		
		public void IsTransform2D(System.Object a, String Context = "")
		{
			assertions.Call("is_Transform2D", a, Context);
		}
		
		public void IsNotTransform2D(System.Object a, String Context = "")
		{
			assertions.Call("is_not_Transform2D", a, Context);
		}
		
		public void IsPlane(System.Object a, String Context = "")
		{
			assertions.Call("is_Plane", a, Context);
		}
		
		public void IsNotPlane(System.Object a, String Context = "")
		{
			assertions.Call("is_not_Plane", a, Context);
		}
		
		public void IsQuat(System.Object a, String Context = "")
		{
			assertions.Call("is_Quat", a, Context);
		}
		
		public void IsNotQuat(System.Object a, String Context = "")
		{
			assertions.Call("is_not_Quat", a, Context);
		}
		
		public void IsAabb(System.Object a, String Context = "")
		{
			assertions.Call("is_AABB", a, Context);
		}
		
		public void IsNotAabb(System.Object a, String Context = "")
		{
			assertions.Call("is_not_AABB", a, Context);
		}
		
		public void IsBasis(System.Object a, String Context = "")
		{
			assertions.Call("is_Basis", a, Context);
		}
		
		public void IsNotBasis(System.Object a, String Context = "")
		{
			assertions.Call("is_not_Basis", a, Context);
		}
		
		public void IsTransform(System.Object a, String Context = "")
		{
			assertions.Call("is_Transform", a, Context);
		}
		
		public void IsNotTransform(System.Object a, String Context = "")
		{
			assertions.Call("is_not_Transform", a, Context);
		}
		
		public void IsColor(System.Object a, String Context = "")
		{
			assertions.Call("is_Color", a, Context);
		}
		
		public void IsNotColor(System.Object a, String Context = "")
		{
			assertions.Call("is_not_Color", a, Context);
		}
		
		public void IsNodePath(System.Object a, String Context = "")
		{
			assertions.Call("is_NodePath", a, Context);
		}
		
		public void IsNotNodePath(System.Object a, String Context = "")
		{
			assertions.Call("is_not_NodePath", a, Context);
		}
		
		public void IsRID(System.Object a, String Context = "")
		{
			assertions.Call("is_RID", a, Context);
		}
		
		public void IsNotRID(System.Object a, String Context = "")
		{
			assertions.Call("is_not_RID", a, Context);
		}
		
		public void IsObject(System.Object a, String Context = "")
		{
			assertions.Call("is_Object", a, Context);
		}
		
		public void IsNotObject(System.Object a, String Context = "")
		{
			assertions.Call("is_not_Object", a, Context);
		}
		
		public void IsDictionary(System.Object a, String Context = "")
		{
			assertions.Call("is_Dictionary", a, Context);
		}
		
		public void IsNotDictionary(System.Object a, String Context = "")
		{
			assertions.Call("is_not_Dictionary", a, Context);
		}
		
		public void IsArray(System.Object a, String Context = "")
		{
			assertions.Call("is_Array", a, Context);
		}
		
		public void IsNotArray(System.Object a, String Context = "")
		{
			assertions.Call("is_not_Array", a, Context);
		}
		
		public void Fail(String Context = "")
		{
			assertions.Call("fail",Context);
		}
	}
}
