namespace Tests
{
    using Xunit;

    public class ReverseStringTests
    {
        [Fact]
        public void TestReverseString()
        {
            Assert.Equal("olleh", StringReverser.ReverseString("hello"));
            Assert.Equal("cba", StringReverser.ReverseString("abc"));
            Assert.Equal("", StringReverser.ReverseString(""));
        }
    }
}

