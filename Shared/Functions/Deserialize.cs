using System.Xml.Serialization;

namespace WSGYG.Shared.Functions
{
    public class Deserialize
    {
        public static T Xml<T>(string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            TextReader reader = new StringReader(xml);
            return (T) serializer.Deserialize(reader);
        }
    }
}
