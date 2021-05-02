using NUnit.Framework;
using PorfirioPartida;
using PorfirioPartida.SampleNamespace.Utils;

namespace PorfirioPartida.Tests.EditModeTests
{
    public class SampleUnitTest
    {      
        // Arrange
        [TestCase(1, 1, 2)]
        [TestCase(2, 2, 4)]
        [TestCase(3, 1, 3)]
        [TestCase(0, 5, 0)]
        [Test]
        public void TestCleanFileLine(int inputA, int inputB, int expected)
        {
            //Arrange
            SampleClass sc = new SampleClass();
            // Act
            var result = sc.Mult(inputA, inputB);
            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}