using NUnit.Framework;

namespace NUG.Tests
{
  [TestFixture(TypeArgs = new [] { typeof(Godot.Object), typeof(Godot.RefCounted) })]
  public class TestGenericFixture<TBase, TSub>
  {
    [Test]
    public void HasCorrectBaseType()
    {
      Assert.AreEqual(typeof(TBase), typeof(TSub).BaseType);
    }
  }
}