using System.Xml.Serialization;

namespace WSGYG63.Models.AssignBP
{
    public class AssignBPResponse
    {
        [XmlElement(ElementName = "MSGTY")]
        public string Msgty { get; set; }

        [XmlElement(ElementName = "MSGNO")]
        public string Msgno { get; set; }

        [XmlElement(ElementName = "MSGV1")]
        public string Msgv1 { get; set; }

        [XmlElement(ElementName = "MSGV2")]
        public string Msgv2 { get; set; }

        [XmlElement(ElementName = "MSGV3")]
        public string Msgv3 { get; set; }

        [XmlElement(ElementName = "MSGV4")]
        public string Msgv4 { get; set; }

        [XmlElement(ElementName = "MESSAGE")]
        public string Message { get; set; }
    }
}
