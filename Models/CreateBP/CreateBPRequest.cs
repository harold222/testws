namespace WSGYG.Models.CreateBP
{
    public class CreateBPrequest
    {
        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? BPARTNER { get; set; }

        [MaxLength(1, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? CATEGORY { get; set; }

        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? PARTNER { get; set; }

        [MaxLength(4, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? PARTNERTYPE { get; set; }

        [MaxLength(4, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? GROUPBP { get; set; }

        [MaxLength(4, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? TITLE_KEY { get; set; } = "0001";

        [MaxLength(40, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? FIRSTNAME { get; set; }

        [MaxLength(40, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? MIDDLENAME { get; set; }

        [MaxLength(40, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? LASTNAME { get; set; }

        [MaxLength(40, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? SECONDNAME { get; set; }

        [Required, MaxLength(20, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string SEARCHTERM1 { get; set; }

        [MaxLength(20, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? SEARCHTERM2 { get; set; }

        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? POSTL_COD1 { get; set; }

        [MaxLength(60, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? STREET { get; set; }

        [MaxLength(40, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? CITY1 { get; set; }

        [MaxLength(40, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? DISTRICT { get; set; }

        [MaxLength(3, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? LAND1 { get; set; }

        [MaxLength(3, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? REGIO { get; set; }

        [MaxLength(2, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? LANGU { get; set; }

        [MaxLength(30, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? TELEPHONETEL { get; set; }

        [MaxLength(30, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? TELEPHONEMOB { get; set; }

        [MaxLength(30, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? FAX { get; set; }

        [MaxLength(241, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? E_MAIL { get; set; }

        [MaxLength(1, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? SEX { get; set; }

        [MaxLength(1, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? MARITALSTATUS { get; set; }

        [MaxLength(4, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? OCCUPATION { get; set; }

        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? BIRTHDATE { get; set; }

        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? DEATHDATE { get; set; }

        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? FOUNDATIONDATE { get; set; }

        [MaxLength(2, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? LEGALFORM { get; set; }

        [MaxLength(2, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? LEGALORG { get; set; }

        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? INDUSTRYSECTOR { get; set; }

        [MaxLength(20, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? TAXNUMBER { get; set; }

        [MaxLength(4, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? TAXTYPE { get; set; }

        [MaxLength(1, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? NAT_PERSON { get; set; }

        [MaxLength(4, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? BPKIND { get; set; }

        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? DATE_FROM { get; set; }

        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? DATE_TO { get; set; }

        [MaxLength(1, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? AREA_VENTAS { get; set; }

        [MaxLength(3, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? GRP { get; set; }

        [MaxLength(6, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? BU_PARTNERROLE { get; set; }

        [MaxLength(14, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? SALES_ORGANIZATION { get; set; }

        [MaxLength(2, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? DISTRIBUTION_CHANNEL { get; set; }

        [MaxLength(2, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? DIVISION { get; set; }

        [MaxLength(2, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? CUSTOMER_GROUP { get; set; }

        [MaxLength(1, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? CUST_PRIC_PROC { get; set; }

        [MaxLength(5, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? CURRENCY { get; set; }

        [MaxLength(2, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? SHIPPING_COND { get; set; }

        [MaxLength(4, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? PAYMENT_TERMS { get; set; }

        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? ID { get; set; }

        [MaxLength(20, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? MSGID { get; set; }

        [MaxLength(1, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? MSGTY { get; set; }

        [MaxLength(3, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? MSGNO { get; set; }

        [MaxLength(50, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? MSGV1 { get; set; }

        [MaxLength(50, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? MSGV2 { get; set; }

        [MaxLength(50, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? MSGV3 { get; set; }

        [MaxLength(50, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? MSGV4 { get; set; }

        [MaxLength(220, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? MESSAGE { get; set; }

    }
}
