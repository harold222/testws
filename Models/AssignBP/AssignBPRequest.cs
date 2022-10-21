using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace WSGYG.Models.AssignBP
{
    [XmlRoot(ElementName = "urn:ZSdserviciosCargaRol")]
    public class AssignBPRequest
    {
        [XmlElement(ElementName = "ImData")]
        public AssignImData ImData { get; set; }

        [XmlElement(ElementName = "ImTest")]
        public AssignItemTest? ImTest { get; set; }
    }

    [XmlRoot(ElementName = "ImData")]
    public class AssignImData
    {
        [XmlElement(ElementName = "item")]
        public string Item { get; set; }
    }

    [XmlRoot(ElementName = "ImTest")]
    public class AssignItemTest{ }
}
