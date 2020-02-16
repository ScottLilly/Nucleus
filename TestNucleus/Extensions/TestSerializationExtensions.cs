using System;
using Nucleus.Extensions;
using TestNucleus.Models;
using Xunit;

namespace TestNucleus.Extensions
{
    public class TestSerializationExtensions
    {
        [Fact]
        public void Test_PersonObjectToXml()
        {
            Person person =
                new Person
                {
                    FirstName = "John",
                    LastName = "Smith",
                    BirthDate = new DateTime(1950, 6, 15)
                };

            string serializedPerson = person.ToSerializedXmlString();

            string expectedResult =
                "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine +
                "<Person xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine +
                "  <FirstName>John</FirstName>" + Environment.NewLine +
                "  <LastName>Smith</LastName>" + Environment.NewLine +
                "  <BirthDate>1950-06-15T00:00:00</BirthDate>" + Environment.NewLine +
                "</Person>";

            Assert.True(serializedPerson == expectedResult);
        }
    }
}