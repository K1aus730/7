using NUnit.Framework;

using HelloWorld;


namespace NUnitTestHelloWorld
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Program.Main(null);
            Assert.Pass();
        }
    }
}