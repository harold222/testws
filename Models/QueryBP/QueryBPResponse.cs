using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace WSGYG63.Models.QueryBP
{

    [Serializable, XmlRoot(ElementName = "properties")]
    public class QueryBPResponse
    {
        [XmlElement(ElementName = "Type")]
        public string Type { get; set; }

        [XmlElement(ElementName = "NumberId")]
        public string NumberId { get; set; }

        [XmlElement(ElementName = "Bpartner")]
        public string Bpartner { get; set; }

        [XmlElement(ElementName = "NameFirst")]
        public string NameFirst { get; set; }

        [XmlElement(ElementName = "NameSecond")]
        public string NameSecond { get; set; }

        [XmlElement(ElementName = "FirstLastname")]
        public string FirstLastname { get; set; }

        [XmlElement(ElementName = "SecondLastname")]
        public string SecondLastname { get; set; }

        [XmlElement(ElementName = "PostalCode")]
        public string PostalCode { get; set; }

        [XmlElement(ElementName = "Country")]
        public string Country { get; set; }

        [XmlElement(ElementName = "Region")]
        public string Region { get; set; }

        [XmlElement(ElementName = "City")]
        public string City { get; set; }

        [XmlElement(ElementName = "District")]
        public string District { get; set; }

        [XmlElement(ElementName = "Street")]
        public string Street { get; set; }

        [JsonPropertyName("Genero")]
        [XmlElement(ElementName = "Genero")]
        public string Gender { get; set; }

        [XmlElement(ElementName = "Birthdate")]
        public string Birthdate { get; set; }

        [XmlElement(ElementName = "CivilSt")]
        public string CivilSt { get; set; }

        [XmlElement(ElementName = "Email")]
        public string Email { get; set; }

        [XmlElement(ElementName = "TelNumber")]
        public string TelNumber { get; set; }

        [XmlElement(ElementName = "MobilePhone")]
        public string MobilePhone { get; set; }

        [JsonPropertyName("MENSAJE")]
        [XmlElement(ElementName = "MENSAJE")]
        public string Message { get; set; }
    }
}
