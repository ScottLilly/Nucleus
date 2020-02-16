using Nucleus.Extensions;
using Xunit;

namespace TestNucleus.Extensions
{
    public class TestStringExtensions
    {
        [Fact]
        public void Test_IsNotNullEmptyOrWhitespace()
        {
            Assert.False("".IsNotNullEmptyOrWhiteSpace());
            Assert.False(" ".IsNotNullEmptyOrWhiteSpace());
            Assert.False("   ".IsNotNullEmptyOrWhiteSpace());
            Assert.True("A".IsNotNullEmptyOrWhiteSpace());
        }

        [Fact]
        public void Test_StartingCharacters()
        {
            Assert.Equal("", "asdfgh".StartingCharacters(0));
            Assert.Equal("asd", "asdfgh".StartingCharacters(3));
            Assert.Equal("asdfgh", "asdfgh".StartingCharacters(10));
        }
    }
}