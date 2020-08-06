using NUnit.Framework;
using System;
using System.IO;

namespace TestProb1
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
            Assert.Pass();
        }

        [Test]
        public void Test_PracticeProb1()
        {
            // Arrange
            PracticeProb1.Program.Main(new FakeUserInput());
            int expected = 8;

            // Act

            // Assert
         //   Assert.AreEqual(expected);
        }
    }
}