using System.Collections.Generic;
using Nucleus.Extensions;
using Xunit;

namespace TestNucleus.Extensions
{
    public class TestLINQExtensions
    {
        [Fact]
        public void Test_NoneExtension()
        {
            List<string> values = new List<string>();
            values.Add("asd");
            values.Add("qwe");
            values.Add("xcv");

            Assert.True(values.None(s => s.Contains("t")));
            Assert.False(values.None(s => s.Contains("a")));
        }
    }
}