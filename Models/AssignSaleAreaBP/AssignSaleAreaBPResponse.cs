using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace WSGYG63.Models.AssignSaleAreaBP
{
    [XmlRoot(ElementName = "E_RETURN")]
    public class AssignSaleAreaBPResponse
    {
        [XmlElement(ElementName = "item")]
        public List<ResponseSaleArea> Item { get; set; }
    }

    public class ResponseSaleArea
    {
        [JsonPropertyName("MSGTY")]
        [XmlElement(ElementName = "TYPE")]
        public string Msgty { get; set; }

        [JsonPropertyName("MSGNO")]
        [XmlElement(ElementName = "LOG_MSG_NO")]
        public string Msgno { get; set; }

        [JsonPropertyName("MSGV1")]
        [XmlElement(ElementName = "MESSAGE_V1")]
        public string Msgv1 { get; set; }

        [JsonPropertyName("MSGV2")]
        [XmlElement(ElementName = "MESSAGE_V2")]
        public string Msgv2 { get; set; }

        [JsonPropertyName("MSGV3")]
        [XmlElement(ElementName = "MESSAGE_V3")]
        public string Msgv3 { get; set; }

        [JsonPropertyName("MSGV4")]
        [XmlElement(ElementName = "MESSAGE_V4")]
        public string Msgv4 { get; set; }

        [JsonPropertyName("MESSAGE")]
        [XmlElement(ElementName = "MESSAGE")]
        public string Message { get; set; }
    }
}
