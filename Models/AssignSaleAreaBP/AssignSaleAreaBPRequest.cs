using System.Xml.Serialization;
using WSGYG63.Models.AssignSaleAreaBP.SaleAreaData;

namespace WSGYG63.Models.AssignSaleAreaBP
{
    [XmlRoot(ElementName = "I_DATA")]
    public class AssignSaleAreaBPRequest
    {
        [XmlElement(ElementName = "item")]
        public List<AreaItem> item { get; set; }
    }
}
