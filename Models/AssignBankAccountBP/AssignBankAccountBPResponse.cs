using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace WSGYG63.Models.AssignBankAccountBP
{
    [XmlRoot(ElementName = "properties")]
    public class AssignBankAccountBPResponse
    {
        [XmlElement(ElementName = "BU_ROLE")]
        [JsonPropertyName("BU_ROLE")]
        public string BuRole { get; set; }

        [XmlElement(ElementName = "BPTAXTYPE")]
        [JsonPropertyName("BPTAXTYPE")]
        public string BpTaxType { get; set; }

        [XmlElement(ElementName = "BPTAXNUM")]
        [JsonPropertyName("BPTAXNUM")]
        public string BpTaxNum { get; set; }

        [XmlElement(ElementName = "NOMBRE")]
        [JsonPropertyName("NOMBRE")]
        public string Nombre { get; set; }

        [XmlElement(ElementName = "BKVID")]
        [JsonPropertyName("BKVID")]
        public string Bkvid { get; set; }

        [XmlElement(ElementName = "BANKN")]
        [JsonPropertyName("BANKN")]
        public string Bankn { get; set; }

        [XmlElement(ElementName = "BKONT")]
        [JsonPropertyName("BKONT")]
        public string Bkont { get; set; }

        [XmlElement(ElementName = "BANKS")]
        [JsonPropertyName("BANKS")]
        public string Banks { get; set; }

        [XmlElement(ElementName = "BANKK")]
        [JsonPropertyName("BANKK")]
        public string Bankk { get; set; }

        [XmlElement(ElementName = "bcol")]
        [JsonPropertyName("bcol")]
        public string Bcol { get; set; }

        [XmlElement(ElementName = "INDICADOR")]
        [JsonPropertyName("INDICADOR")]
        public string Indicador { get; set; }
    }

    public class ResponseAssignBank
    {
        public AssignBankAccountBPResponse Response { get; set; }
    }
}
