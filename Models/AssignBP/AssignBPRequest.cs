using System.Text.Json.Serialization;
using System.Xml.Serialization;


namespace WSGYG.Models.AssignBP
{
    /// 
    [XmlRoot(ElementName = "ImData")]
    public class AssignBPRequest
    {
        

        [XmlElement(ElementName = "item")]
        public List<AssingItem> item { get; set; }

    }

    public class AssingItem
    {
        [XmlElement(ElementName = "Partner")]
        public string Partner { get; set; }

        [XmlElement(ElementName = "PartnerRole")]
        public List<AssignPartnerRole>  PartnerRole { get; set; }
    }

    public class AssignPartnerRole
    {
        [XmlElement(ElementName = "item")]
        public List<AssignPartnerRoleTwo> item { get; set; }

    }

    public class AssignPartnerRoleTwo
    {
        [XmlElement(ElementName = "PartnerRole")]
        public string PartnerRole { get; set; }

    }
}
