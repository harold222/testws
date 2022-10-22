using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace WSGYG.Models.AssignBP.AssignItem
{
    public class AssingItem
    {
        /// <summary>
        /// Numero de interlocutor comercial
        /// </summary>
        /// <example></example>
        [JsonPropertyName("Partner")]
        [XmlElement(ElementName = "Partner")]
        [MaxLength(10, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? Partner { get; set; }

        public List<AssignPartnerRole> PartnerRole { get; set; }
    }
}
