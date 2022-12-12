using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace WSGYG63.Models.AssignBP
{

    [XmlRoot(ElementName = "ExTreturn")]
    public class AssignBPResponse
    {
        [XmlElement(ElementName = "item")]
        public List<ItemResponseRole> Item { get; set; }
    }

    public class ItemResponseRole
    {
        [JsonPropertyName("MSGTY")]
        [XmlElement(ElementName = "Type")]
        public string Msgty { get; set; }

        [JsonPropertyName("MSGNO")]
        [XmlElement(ElementName = "LogMsgNo")]
        public string Msgno { get; set; }

        [JsonPropertyName("MSGV1")]
        [XmlElement(ElementName = "MessageV1")]
        public string Msgv1 { get; set; }

        [JsonPropertyName("MSGV2")]
        [XmlElement(ElementName = "MessageV2")]
        public string Msgv2 { get; set; }

        [JsonPropertyName("MSGV3")]
        [XmlElement(ElementName = "MessageV3")]
        public string Msgv3 { get; set; }

        [JsonPropertyName("MSGV4")]
        [XmlElement(ElementName = "MessageV4")]
        public string Msgv4 { get; set; }

        [JsonPropertyName("MESSAGE")]
        [XmlElement(ElementName = "Message")]
        public string Message { get; set; }
    }
}
