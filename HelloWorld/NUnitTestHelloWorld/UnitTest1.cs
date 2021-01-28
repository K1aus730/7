using NUnit.Framework;
using System.IO;
using HelloWorld;
using System;

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
            using(var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.Main(null);
                Assert.AreEqual(sw.ToString(), "Hello World!\r\n");
            }
        }
        [Test]
        public void Test2()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.Main(null);
                Assert.IsTrue(sw.ToString().Equals("Hello World!\r\n"));
            }
        }
    }
}