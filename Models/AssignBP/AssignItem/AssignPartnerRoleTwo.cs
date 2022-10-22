using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace WSGYG.Models.AssignBP.AssignItem
{
    public class AssignPartnerRoleTwo
    {
        /// <summary>
        /// Numero de interlocutor comercial
        /// </summary>
        /// <example></example>
        [JsonPropertyName("PartnerRole")]
        [XmlElement(ElementName = "PartnerRole")]
        [MaxLength(6, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string PartnerRole { get; set; }
    }
}
