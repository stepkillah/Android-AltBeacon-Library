using System.Linq;
using Xunit;

namespace AndroidAltBeaconLibrary.UnitTests
{
    public static class AssertEx
    {
        public static void AreEqual(string message, int expected, int actual)
        {
            Assert.True(expected == actual, message);
        }
        public static void AreEqual(int expected, int actual, string message)
        {
            Assert.True(expected == actual, message);
        }

        public static void AreEqual(string message, long expected, long actual)
        {
            Assert.True(expected == actual, message);
        }
        public static void AreEqual(long expected, long actual, string message)
        {
            Assert.True(expected == actual, message);
        }

        public static void AreEqual(string message, byte[] expected, byte[] actual)
        {
            Assert.True(actual.SequenceEqual(expected), message);
        }

        public static void AreEqual(string message, double expected, double actual, double delta)
        {
            Assert.True(Math.Abs(expected - actual) <= delta, message);
        }
        public static void AreEqual(double expected, double actual, double delta, string message)
        {
            Assert.True(Math.Abs(expected - actual) <= delta, message);
        }

        public static void AreEqual(string message, object expected, object actual)
        {
            Assert.True(Equals(expected, actual), message);
        }

        public static void AreNotEqual(string message, int expected, int actual)
        {
            Assert.True(expected != actual, message);
        }

        public static void AreNotEqual(string message, object expected, object actual)
        {
            Assert.True(!Equals(expected, actual), message);
        }

        public static void Null(string message, object anObject)
        {
            Assert.True(anObject == null, message);
        }

        public static void NotNull(string message, object anObject)
        {
            Assert.True(anObject != null, message);
        }

        public static void True(string message, bool condition)
        {
            Assert.True(condition, message);
        }

        public static void True(bool condition)
        {
            Assert.True(condition);
        }

        public static void False(string message, bool condition)
        {
            Assert.True(!condition, message);
        }

        public static void AreNotSame(string message, object expected, object actual)
        {
            Assert.True(!ReferenceEquals(expected, actual), message);
        }
    }
}