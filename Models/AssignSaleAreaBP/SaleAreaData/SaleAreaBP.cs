using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace WSGYG63.Models.AssignSaleAreaBP.SaleAreaData
{
    public class SaleAreaBP
    {
        [JsonPropertyName("item")]
        [XmlElement(ElementName = "item")]
        public List<SaleItem> ItemSale { get; set; }
    }
}
