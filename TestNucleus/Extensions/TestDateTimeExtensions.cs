using System;
using Nucleus.Extensions;
using Xunit;

namespace TestNucleus.Extensions
{
    public class TestDateTimeExtensions
    {
        [Fact]
        public void Test_StartOfDay()
        {
            DateTime test = new DateTime(2019, 03, 18, 19, 12, 34);
            DateTime startOfDay = test.StartOfDay();

            Assert.True(startOfDay.Year == 2019);
            Assert.True(startOfDay.Month == 3);
            Assert.True(startOfDay.Day == 18);
            Assert.True(startOfDay.Hour == 0);
            Assert.True(startOfDay.Minute == 0);
            Assert.True(startOfDay.Second == 0);
        }

        [Fact]
        public void Test_EndOfDay()
        {
            DateTime test = new DateTime(2019, 03, 18, 19, 12, 34);
            DateTime startOfDay = test.EndOfDay();

            Assert.True(startOfDay.Year == 2019);
            Assert.True(startOfDay.Month == 3);
            Assert.True(startOfDay.Day == 18);
            Assert.True(startOfDay.Hour == 23);
            Assert.True(startOfDay.Minute == 59);
            Assert.True(startOfDay.Second == 59);
        }

        [Fact]
        public void Test_StartOfMonth()
        {
            DateTime test = new DateTime(2019, 03, 18, 19, 12, 34);
            DateTime startOfDay = test.StartOfMonth();

            Assert.True(startOfDay.Year == 2019);
            Assert.True(startOfDay.Month == 3);
            Assert.True(startOfDay.Day == 1);
            Assert.True(startOfDay.Hour == 0);
            Assert.True(startOfDay.Minute == 0);
            Assert.True(startOfDay.Second == 0);
        }

        [Fact]
        public void Test_EndOfMonth()
        {
            DateTime test = new DateTime(2019, 03, 18, 19, 12, 34);
            DateTime startOfDay = test.EndOfMonth();

            Assert.True(startOfDay.Year == 2019);
            Assert.True(startOfDay.Month == 3);
            Assert.True(startOfDay.Day == 31);
            Assert.True(startOfDay.Hour == 23);
            Assert.True(startOfDay.Minute == 59);
            Assert.True(startOfDay.Second == 59);
        }
    }
}