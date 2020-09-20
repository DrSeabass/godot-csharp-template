using Godot;
using System;

public class TestExample : WAT.Test
{
    [Test]
    public void PassingTest()
    {
        Assert.IsTrue(true);
    }

    [Test]
    public void FailingTest()
    {
        Assert.IsFalse(true);
    }

    [Test]
    public void FixMe()
    {
        Assert.IsEqual("Hello", "NotHello");
    }
}
