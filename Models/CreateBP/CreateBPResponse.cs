using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace WSGYG63.Models.CreateBP
{
    [XmlRoot(ElementName = "E_S_DATA")]
    public class CreateBPResponse
    {
        [JsonPropertyName("BPARTNER")]
        [XmlElement(ElementName = "BPARTNER")]
        public string Bpartner { get; set; }

        [JsonPropertyName("CATEGORY")]
        [XmlElement(ElementName = "CATEGORY")]
        public string Category { get; set; }

        [JsonPropertyName("PARTNER")]
        [XmlElement(ElementName = "PARTNER")]
        public string Partner { get; set; }

        [JsonPropertyName("PARTNERTYPE")]
        [XmlElement(ElementName = "PARTNERTYPE")]
        public string PartnerType { get; set; }

        [JsonPropertyName("GROUPBP")]
        [XmlElement(ElementName = "GROUPBP")]
        public string GroupBP { get; set; }

        [JsonPropertyName("TITLE_KEY")]
        [XmlElement(ElementName = "TITLE_KEY")]
        public string TitleKey { get; set; }

        [JsonPropertyName("FIRSTNAME")]
        [XmlElement(ElementName = "FIRSTNAME")]
        public string FirstName { get; set; }

        [JsonPropertyName("MIDDLENAME")]
        [XmlElement(ElementName = "MIDDLENAME")]
        public string MiddleName { get; set; }

        [JsonPropertyName("LASTNAME")]
        [XmlElement(ElementName = "LASTNAME")]
        public string LastName { get; set; }

        [JsonPropertyName("SECONDNAME")]
        [XmlElement(ElementName = "SECONDNAME")]
        public string SecondName { get; set; }

        [JsonPropertyName("SEARCHTERM1")]
        [XmlElement(ElementName = "SEARCHTERM1")]
        public string SearchTerm1 { get; set; }

        [JsonPropertyName("SEARCHTERM2")]
        [XmlElement(ElementName = "SEARCHTERM2")]
        public string SearchTerm2 { get; set; }

        [JsonPropertyName("POSTL_COD1")]
        [XmlElement(ElementName = "POSTL_COD1")]
        public string PostlCod1 { get; set; }

        [JsonPropertyName("STREET")]
        [XmlElement(ElementName = "STREET")]
        public string Street { get; set; }

        [JsonPropertyName("CITY1")]
        [XmlElement(ElementName = "CITY1")]
        public string City1 { get; set; }

        [JsonPropertyName("DISTRICT")]
        [XmlElement(ElementName = "DISTRICT")]
        public string District { get; set; }

        [JsonPropertyName("LAND1")]
        [XmlElement(ElementName = "LAND1")]
        public string Land1 { get; set; }

        [JsonPropertyName("REGIO")]
        [XmlElement(ElementName = "REGIO")]
        public string Regio { get; set; }

        [JsonPropertyName("LANGU")]
        [XmlElement(ElementName = "LANGU")]
        public string Langu { get; set; }

        [JsonPropertyName("TELEPHONETEL")]
        [XmlElement(ElementName = "TELEPHONETEL")]
        public string Telephonetel { get; set; }

        [JsonPropertyName("TELEPHONEMOB")]
        [XmlElement(ElementName = "TELEPHONEMOB")]
        public string TelephoneMob { get; set; }

        [JsonPropertyName("FAX")]
        [XmlElement(ElementName = "FAX")]
        public string Fax { get; set; }

        [JsonPropertyName("E_MAIL")]
        [XmlElement(ElementName = "E_MAIL")]
        public string Email { get; set; }

        [JsonPropertyName("SEX")]
        [XmlElement(ElementName = "SEX")]
        public string Sex { get; set; }

        [JsonPropertyName("MARITALSTATUS")]
        [XmlElement(ElementName = "MARITALSTATUS")]
        public string MaritalStatus { get; set; }

        [JsonPropertyName("OCCUPATION")]
        [XmlElement(ElementName = "OCCUPATION")]
        public string Occupation { get; set; }

        [JsonPropertyName("BIRTHDATE")]
        [XmlElement(ElementName = "BIRTHDATE")]
        public string BirthDate { get; set; }

        [JsonPropertyName("DEATHDATE")]
        [XmlElement(ElementName = "DEATHDATE")]
        public string DeathDate { get; set; }

        [JsonPropertyName("FOUNDATIONDATE")]
        [XmlElement(ElementName = "FOUNDATIONDATE")]
        public string FoundationDate { get; set; }

        [JsonPropertyName("LEGALFORM")]
        [XmlElement(ElementName = "LEGALFORM")]
        public string LegalForm { get; set; }

        [JsonPropertyName("LEGALORG")]
        [XmlElement(ElementName = "LEGALORG")]
        public string LegalOrg { get; set; }

        [JsonPropertyName("INDUSTRYSECTOR")]
        [XmlElement(ElementName = "INDUSTRYSECTOR")]
        public string IndustrySector { get; set; }

        [JsonPropertyName("TAXNUMBER")]
        [XmlElement(ElementName = "TAXNUMBER")]
        public string TaxNumber { get; set; }

        [JsonPropertyName("TAXTYPE")]
        [XmlElement(ElementName = "TAXTYPE")]
        public string TaxType { get; set; }

        [JsonPropertyName("NAT_PERSON")]
        [XmlElement(ElementName = "NAT_PERSON")]
        public string NatPerson { get; set; }

        [JsonPropertyName("BPKIND")]
        [XmlElement(ElementName = "BPKIND")]
        public string Bpkind { get; set; }

        [JsonPropertyName("DATE_FROM")]
        [XmlElement(ElementName = "DATE_FROM")]
        public string DateFrom { get; set; }

        [JsonPropertyName("DATE_TO")]
        [XmlElement(ElementName = "DATE_TO")]
        public string DateTo { get; set; }

        [JsonPropertyName("AREA_VENTAS")]
        [XmlElement(ElementName = "AREA_VENTAS")]
        public string AreaVentas { get; set; }

        [JsonPropertyName("GRP")]
        [XmlElement(ElementName = "GRP")]
        public string Grp { get; set; }

        [JsonPropertyName("BU_PARTNERROLE")]
        [XmlElement(ElementName = "BU_PARTNERROLE")]
        public string BuPartnerRole { get; set; }

        [JsonPropertyName("SALES_ORGANIZATION")]
        [XmlElement(ElementName = "SALES_ORGANIZATION")]
        public string SalesOrganization { get; set; }

        [JsonPropertyName("DISTRIBUTION_CHANNEL")]
        [XmlElement(ElementName = "DISTRIBUTION_CHANNEL")]
        public string DistributionChannel { get; set; }

        [JsonPropertyName("DIVISION")]
        [XmlElement(ElementName = "DIVISION")]
        public string Division { get; set; }

        [JsonPropertyName("CUSTOMER_GROUP")]
        [XmlElement(ElementName = "CUSTOMER_GROUP")]
        public string CustomerGroup { get; set; }

        [JsonPropertyName("CUST_PRIC_PROC")]
        [XmlElement(ElementName = "CUST_PRIC_PROC")]
        public string CustPricProc { get; set; }

        [JsonPropertyName("CURRENCY")]
        [XmlElement(ElementName = "CURRENCY")]
        public string Currency { get; set; }

        [JsonPropertyName("SHIPPING_COND")]
        [XmlElement(ElementName = "SHIPPING_COND")]
        public string ShippingCond { get; set; }

        [JsonPropertyName("PAYMENT_TERMS")]
        [XmlElement(ElementName = "PAYMENT_TERMS")]
        public string PaymentTerms { get; set; }

        [JsonPropertyName("ID")]
        [XmlElement(ElementName = "ID")]
        public string Id { get; set; }

        [JsonPropertyName("MSGID")]
        [XmlElement(ElementName = "MSGID")]
        public string MsgId { get; set; }

        [JsonPropertyName("MSGTY")]
        [XmlElement(ElementName = "MSGTY")]
        public string Msgty { get; set; }

        [JsonPropertyName("MSGNO")]
        [XmlElement(ElementName = "MSGNO")]
        public string Msgno { get; set; }

        [JsonPropertyName("MSGV1")]
        [XmlElement(ElementName = "MSGV1")]
        public string Msgv1 { get; set; }

        [JsonPropertyName("MSGV2")]
        [XmlElement(ElementName = "MSGV2")]
        public string Msgv2 { get; set; }

        [JsonPropertyName("MSGV3")]
        [XmlElement(ElementName = "MSGV3")]
        public string Msgv3 { get; set; }

        [JsonPropertyName("MSGV4")]
        [XmlElement(ElementName = "MSGV4")]
        public string Msgv4 { get; set; }

        [JsonPropertyName("MESSAGE")]
        [XmlElement(ElementName = "MESSAGE")]
        public string Message { get; set; }
    }
}
