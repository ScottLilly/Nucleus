using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Nucleus.Extensions
{
    public static class SerializationExtensions
    {
        public static string ToSerializedXmlString<T>(this T obj, Formatting format = Formatting.Indented)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            using(StringWriter stringWriter = new StringWriter())
            {
                using(XmlWriter xmlWriter = new XmlTextWriter(stringWriter) {Formatting = format})
                {
                    xmlSerializer.Serialize(xmlWriter, obj);

                    return stringWriter.ToString();
                }
            }
        }
    }
}