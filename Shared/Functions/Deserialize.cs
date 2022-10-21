using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace WSGYG.Shared.Functions
{
    public static class Deserialize
    {
        public static string Serialize<T>(this T value, string? openTags = null, string? closeTags = null)
        {
            if (value == null)
                return string.Empty;

            XmlSerializer xmlserializer = new XmlSerializer(typeof(T));
            Utf8StringWriter stringWriter = new Utf8StringWriter();

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;

            using XmlWriter writer = XmlWriter.Create(stringWriter, settings);

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            xmlserializer.Serialize(writer, value, namespaces);

            string xml = stringWriter.ToString();

            if (!string.IsNullOrEmpty(openTags))
                xml = $"{openTags}{xml}";

            if (!string.IsNullOrEmpty(closeTags))
                xml += closeTags;

            return xml;
        }

        public static T Xml<T>(string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            TextReader reader = new StringReader(xml);
            return (T) serializer.Deserialize(reader);
        }
    }

    public class Utf8StringWriter : StringWriter
    {
        public override Encoding Encoding => Encoding.UTF8;
    }
}
