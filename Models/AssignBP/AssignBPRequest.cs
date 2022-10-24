using System.Text.Json.Serialization;
using System.Xml.Serialization;
using WSGYG63.Models.AssignBP.AssignItem;

namespace WSGYG63.Models.AssignBP
{
    [XmlRoot(ElementName = "ImData")]
    public class AssignBPRequest
    {
        [XmlElement(ElementName = "item")]
        public List<AssingItem> item { get; set; }
    }
}
