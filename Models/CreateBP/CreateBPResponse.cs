using System.Xml.Serialization;

namespace WSGYG.Models.CreateBP
{
    [XmlRoot(ElementName = "I_ES_DATA_BP")]
    public class CreateBPResponse
    {
        [XmlElement(ElementName = "BPARTNER")]
        public string Bpartner { get; set; }

        [XmlElement(ElementName = "CATEGORY")]
        public string Category { get; set; }

        [XmlElement(ElementName = "PARTNER")]
        public string Partner { get; set; }

        [XmlElement(ElementName = "PARTNERTYPE")]
        public string PartnerType { get; set; }

        [XmlElement(ElementName = "GROUPBP")]
        public string GroupBP { get; set; }

        [XmlElement(ElementName = "TITLE_KEY")]
        public string TitleKey { get; set; }

        [XmlElement(ElementName = "FIRSTNAME")]
        public string FirstName { get; set; }

        [XmlElement(ElementName = "MIDDLENAME")]
        public string MiddleName { get; set; }

        [XmlElement(ElementName = "LASTNAME")]
        public string LastName { get; set; }

        [XmlElement(ElementName = "SECONDNAME")]
        public string SecondName { get; set; }

        [XmlElement(ElementName = "SEARCHTERM1")]
        public string SearchTerm1 { get; set; }

        [XmlElement(ElementName = "SEARCHTERM2")]
        public string SearchTerm2 { get; set; }

        [XmlElement(ElementName = "POSTL_COD1")]
        public string PostlCod1 { get; set; }

        [XmlElement(ElementName = "STREET")]
        public string Street { get; set; }

        [XmlElement(ElementName = "CITY1")]
        public string City1 { get; set; }

        [XmlElement(ElementName = "DISTRICT")]
        public string District { get; set; }

        [XmlElement(ElementName = "LAND1")]
        public string Land1 { get; set; }

        [XmlElement(ElementName = "REGIO")]
        public string Regio { get; set; }

        [XmlElement(ElementName = "LANGU")]
        public string Langu { get; set; }

        [XmlElement(ElementName = "TELEPHONETEL")]
        public string Telephonetel { get; set; }

        [XmlElement(ElementName = "TELEPHONEMOB")]
        public string TelephoneMob { get; set; }

        [XmlElement(ElementName = "FAX")]
        public string Fax { get; set; }

        [XmlElement(ElementName = "E_MAIL")]
        public string Email { get; set; }

        [XmlElement(ElementName = "SEX")]
        public string Sex { get; set; }

        [XmlElement(ElementName = "MARITALSTATUS")]
        public string MaritalStatus { get; set; }

        [XmlElement(ElementName = "OCCUPATION")]
        public string Occupation { get; set; }

        [XmlElement(ElementName = "BIRTHDATE")]
        public string BirthDate { get; set; }

        [XmlElement(ElementName = "DEATHDATE")]
        public string DeathDate { get; set; }

        [XmlElement(ElementName = "FOUNDATIONDATE")]
        public string FoundationDate { get; set; }

        [XmlElement(ElementName = "LEGALFORM")]
        public string LegalForm { get; set; }

        [XmlElement(ElementName = "LEGALORG")]
        public string LegalOrg { get; set; }

        [XmlElement(ElementName = "INDUSTRYSECTOR")]
        public string IndustrySector { get; set; }

        [XmlElement(ElementName = "TAXNUMBER")]
        public string TaxNumber { get; set; }

        [XmlElement(ElementName = "TAXTYPE")]
        public string TaxType { get; set; }

        [XmlElement(ElementName = "NAT_PERSON")]
        public string NatPerson { get; set; }

        [XmlElement(ElementName = "BPKIND")]
        public string Bpkind { get; set; }

        [XmlElement(ElementName = "DATE_FROM")]
        public string DateFrom { get; set; }
        
        [XmlElement(ElementName = "DATE_TO")]
        public string DateTo { get; set; }

        [XmlElement(ElementName = "AREA_VENTAS")]
        public string AreaVentas { get; set; }

        [XmlElement(ElementName = "GRP")]
        public string Grp { get; set; }

        [XmlElement(ElementName = "BU_PARTNERROLE")]
        public string BuPartnerRole { get; set; }

        [XmlElement(ElementName = "SALES_ORGANIZATION")]
        public string SalesOrganization { get; set; }

        [XmlElement(ElementName = "DISTRIBUTION_CHANNEL")]
        public string DistributionChannel { get; set; }

        [XmlElement(ElementName = "DIVISION")]
        public string Division { get; set; }

        [XmlElement(ElementName = "CUSTOMER_GROUP")]
        public string CustomerGroup { get; set; }

        [XmlElement(ElementName = "CUST_PRIC_PROC")]
        public string CustPricProc { get; set; }

        [XmlElement(ElementName = "CURRENCY")]
        public string Currency { get; set; }

        [XmlElement(ElementName = "SHIPPING_COND")]
        public string ShippingCond { get; set; }

        [XmlElement(ElementName = "PAYMENT_TERMS")]
        public string PaymentTerms { get; set; }

        [XmlElement(ElementName = "ID")]
        public string Id { get; set; }

        [XmlElement(ElementName = "MSGID")]
        public string MsgId { get; set; }

        [XmlElement(ElementName = "MSGTY")]
        public string Msgty { get; set; }

        [XmlElement(ElementName = "MSGNO")]
        public string Msgno { get; set; }

        [XmlElement(ElementName = "MSGV1")]
        public string Msgv1 { get; set; }

        [XmlElement(ElementName = "MSGV2")]
        public string Msgv2 { get; set; }

        [XmlElement(ElementName = "MSGV3")]
        public string Msgv3 { get; set; }

        [XmlElement(ElementName = "MSGV4")]
        public string Msgv4 { get; set; }

        [XmlElement(ElementName = "MESSAGE")]
        public string Message { get; set; }
    }
}
