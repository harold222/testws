using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace WSGYG.Models.CreateBP
{
    [XmlRoot(ElementName = "I_ES_DATA_BP")]
    public class CreateBPrequest
    {
        /// <summary>
        /// Numero del BP (Business Parther)
        /// </summary>
        /// <example></example>
        [JsonPropertyName("BPARTNER")]
        [XmlElement(ElementName = "BPARTNER")]
        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Bpartner { get; set; }

        /// <example></example>
        [JsonPropertyName("CATEGORY")]
        [XmlElement(ElementName = "CATEGORY")]
        [MaxLength(1, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Category { get; set; }

        /// <example></example>
        [JsonPropertyName("PARTNER")]
        [XmlElement(ElementName = "PARTNER")]
        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Partner { get; set; }

        /// <example></example>
        [JsonPropertyName("PARTNERTYPE")]
        [MaxLength(4, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? PartnerType { get; set; }

        /// <example></example>
        [JsonPropertyName("GROUPBP")]
        [MaxLength(4, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? GroupBP { get; set; }

        /// <example></example>
        [JsonPropertyName("TITLE_KEY")]
        [MaxLength(4, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? TitleKey { get; set; }

        /// <example></example>
        [JsonPropertyName("FIRSTNAME")]
        [MaxLength(40, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? FirstName { get; set; }

        /// <example></example>
        [JsonPropertyName("MIDDLENAME")]
        [MaxLength(40, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? MiddleName { get; set; }

        /// <example></example>
        [JsonPropertyName("LASTNAME")]
        [MaxLength(40, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? LastName { get; set; }

        /// <example></example>
        [JsonPropertyName("SECONDNAME")]
        [MaxLength(40, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? SecondName { get; set; }

        /// <example></example>
        [JsonPropertyName("SEARCHTERM1")]
        [Required, MaxLength(20, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string SearchTerm1 { get; set; }

        /// <example></example>
        [JsonPropertyName("SEARCHTERM2")]
        [MaxLength(20, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? SearchTerm2 { get; set; }

        /// <example></example>
        [JsonPropertyName("POSTL_COD1")]
        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? PostlCod1 { get; set; }

        /// <example></example>
        [JsonPropertyName("STREET")]
        [MaxLength(60, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Street { get; set; }

        /// <example></example>
        [JsonPropertyName("CITY1")]
        [MaxLength(40, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? City1 { get; set; }

        /// <example></example>
        [JsonPropertyName("DISTRICT")]
        [MaxLength(40, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? District { get; set; }

        /// <example></example>
        [JsonPropertyName("LAND1")]
        [MaxLength(3, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Land1 { get; set; }

        /// <example></example>
        [JsonPropertyName("REGIO")]
        [MaxLength(3, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Regio { get; set; }

        /// <example></example>
        [JsonPropertyName("LANGU")]
        [MaxLength(2, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Langu { get; set; }

        /// <example></example>
        [JsonPropertyName("TELEPHONETEL")]
        [MaxLength(30, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Telephonetel { get; set; }

        /// <example></example>
        [JsonPropertyName("TELEPHONEMOB")]
        [MaxLength(30, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? TelephoneMob { get; set; }

        /// <example></example>
        [JsonPropertyName("FAX")]
        [MaxLength(30, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Fax { get; set; }

        /// <example></example>
        [JsonPropertyName("E_MAIL")]
        [MaxLength(241, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Email { get; set; }

        /// <example></example>
        [JsonPropertyName("SEX")]
        [MaxLength(1, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Sex { get; set; }

        /// <example></example>
        [JsonPropertyName("MARITALSTATUS")]
        [MaxLength(1, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? MaritalStatus { get; set; }

        /// <example></example>
        [JsonPropertyName("OCCUPATION")]
        [MaxLength(4, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Occupation { get; set; }

        /// <example></example>
        [JsonPropertyName("BIRTHDATE")]
        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? BirthDate { get; set; }

        /// <example></example>
        [JsonPropertyName("DEATHDATE")]
        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? DeathDate { get; set; }

        /// <example></example>
        [JsonPropertyName("FOUNDATIONDATE")]
        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? FoundationDate { get; set; }

        /// <example></example>
        [JsonPropertyName("LEGALFORM")]
        [MaxLength(2, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? LegalForm { get; set; }

        /// <example></example>
        [JsonPropertyName("LEGALORG")]
        [MaxLength(2, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? LegalOrg { get; set; }

        /// <example></example>
        [JsonPropertyName("INDUSTRYSECTOR")]
        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? IndustrySector { get; set; }

        /// <example></example>
        [JsonPropertyName("TAXNUMBER")]
        [MaxLength(20, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? TaxNumber { get; set; }

        /// <example></example>
        [JsonPropertyName("TAXTYPE")]
        [MaxLength(4, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? TaxType { get; set; }

        /// <example></example>
        [JsonPropertyName("NAT_PERSON")]
        [MaxLength(1, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? NatPerson { get; set; }

        /// <example></example>
        [JsonPropertyName("BPKIND")]
        [MaxLength(4, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Bpkind { get; set; }

        /// <example></example>
        [JsonPropertyName("DATE_FROM")]
        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? DateFrom { get; set; }

        /// <example></example>
        [JsonPropertyName("DATE_TO")]
        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? DateTo { get; set; }

        /// <example></example>
        [JsonPropertyName("AREA_VENTAS")]
        [MaxLength(1, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? AreaVentas { get; set; }

        /// <example></example>
        [JsonPropertyName("GRP")]
        [MaxLength(3, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Grp { get; set; }

        /// <example>CRM000</example>
        [JsonPropertyName("BU_PARTNERROLE")]
        [MaxLength(6, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? BuPartnerRole { get; set; } = "CRM000";

        /// <example>O 50000026</example>
        [JsonPropertyName("SALES_ORGANIZATION")]
        [MaxLength(14, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? SalesOrganization { get; set; } = "O 50000026";

        /// <example>AP</example>
        [JsonPropertyName("DISTRIBUTION_CHANNEL")]
        [MaxLength(2, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? DistributionChannel { get; set; } = "AP";

        /// <example>SF</example>
        [JsonPropertyName("DIVISION")]
        [MaxLength(2, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Division { get; set; } = "SF";

        /// <example>Z1</example>
        [JsonPropertyName("CUSTOMER_GROUP")]
        [MaxLength(2, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? CustomerGroup { get; set; } = "Z1";

        /// <example>1</example>
        [JsonPropertyName("CUST_PRIC_PROC")]
        [MaxLength(1, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? CustPricProc { get; set; } = "1";

        /// <example>COP</example>
        [JsonPropertyName("CURRENCY")]
        [MaxLength(5, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Currency { get; set; } = "COP";

        /// <example>01</example>
        [JsonPropertyName("SHIPPING_COND")]
        [MaxLength(2, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? ShippingCond { get; set; } = "01";

        /// <example>0001</example>
        [JsonPropertyName("PAYMENT_TERMS")]
        [MaxLength(4, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? PaymentTerms { get; set; } = "0001";

        /// <example>String 50</example>
        [JsonPropertyName("ID")]
        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Id { get; set; } = "String 50";

        /// <example>String 51</example>
        [JsonPropertyName("MSGID")]
        [MaxLength(20, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? MsgId { get; set; } = "String 51";

        /// <example>S</example>
        [JsonPropertyName("MSGTY")]
        [MaxLength(1, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Msgty { get; set; } = "S";

        /// <example>53</example>
        [JsonPropertyName("MSGNO")]
        [MaxLength(3, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Msgno { get; set; } = "53";

        /// <example>String 54</example>
        [JsonPropertyName("MSGV1")]
        [MaxLength(50, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Msgv1 { get; set; } = "String 54";

        /// <example>String 55</example>
        [JsonPropertyName("MSGV2")]
        [MaxLength(50, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Msgv2 { get; set; } = "String 55";

        /// <example>String 56</example>
        [JsonPropertyName("MSGV3")]
        [MaxLength(50, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Msgv3 { get; set; } = "String 56";

        /// <example>String 57</example>
        [JsonPropertyName("MSGV4")]
        [MaxLength(50, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Msgv4 { get; set; } = "String 57";

        /// <example>String 58</example>
        [JsonPropertyName("MESSAGE")]
        [MaxLength(220, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Message { get; set; } = "String 58";
    }
}
