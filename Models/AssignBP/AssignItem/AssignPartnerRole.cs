using System.Xml.Serialization;

namespace WSGYG63.Models.AssignBP.AssignItem
{
    public class AssignPartnerRole
    {
        [XmlElement(ElementName = "item")]
        public List<AssignPartnerRoleTwo> item { get; set; }
    }
}
