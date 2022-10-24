using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace WSGYG63.Models.AssignSaleAreaBP.SaleAreaData
{
    public class AreaItem
    {
        /// <summary>
        /// Numero de interlocutor comercial
        /// </summary>
        /// <example></example>
        [JsonPropertyName("PARTNER")]
        [XmlElement(ElementName = "PARTNER")]
        [MaxLength(10, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? Partner { get; set; }

        [JsonPropertyName("AREA_VENTAS_BP")]
        [XmlElement(ElementName = "AREA_VENTAS_BP")]
        public SaleAreaBP SaleAreaBP { get; set; }
    }
}
