using System.Text.Json.Serialization;
using System.Xml.Serialization;
using WSGYG.Models.AssignBP.AssignItem;

namespace WSGYG.Models.AssignBP
{
    [XmlRoot(ElementName = "ImData")]
    public class AssignBPRequest
    {
        [XmlElement(ElementName = "item")]
        public List<AssingItem> item { get; set; }
    }
}
