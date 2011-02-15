
using NUnit.Framework;
using Spring.Context.Support;
using Spring.Context;
using TripleLands.Blogger.EndToEndTest.springcomponent;
namespace TripleLands.Blogger.EndToEndTest
{
    [TestFixture]
    class InversionOfControlTester
    {
        [Test]
        public void TestObjectContext() {
            IApplicationContext context = ContextRegistry.GetContext();
            Calculator c = (Calculator) context.GetObject("Calculator");
            Assert.AreEqual(4, c.Add(2, 2));
        }
    }
}
