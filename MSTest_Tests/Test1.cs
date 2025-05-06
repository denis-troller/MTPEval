namespace MSTest_Tests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new MTPEval.Class1();

            Assert.IsTrue(c.Method1(true));
        }
    }
}
