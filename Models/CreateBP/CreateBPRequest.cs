using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace WSGYG63.Models.CreateBP
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

        /// <summary>
        /// 1 persona natural y 2 persona juridica
        /// </summary>
        /// <example>1</example>
        [JsonPropertyName("CATEGORY")]
        [XmlElement(ElementName = "CATEGORY")]
        [MaxLength(1, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Category { get; set; } = "1";

        /// <summary>
        /// Numero del cliente
        /// </summary>
        /// <example></example>
        [JsonPropertyName("PARTNER")]
        [XmlElement(ElementName = "PARTNER")]
        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Partner { get; set; }

        /// <summary>
        /// Clase del cliente
        /// </summary>
        /// <example></example>
        [JsonPropertyName("PARTNERTYPE")]
        [XmlElement(ElementName = "PARTNERTYPE")]
        [MaxLength(4, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? PartnerType { get; set; }

        /// <summary>
        /// Enviar ZPAN para persona natural y ZEEN para persona juridica
        /// </summary>
        /// <example>ZPAN</example>
        [JsonPropertyName("GROUPBP")]
        [XmlElement(ElementName = "GROUPBP")]
        [MaxLength(4, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? GroupBP { get; set; } = "ZPAN";

        /// <summary>
        /// 0001 Señor, 0002 Señora
        /// </summary>
        /// <example>0001</example>
        [JsonPropertyName("TITLE_KEY")]
        [XmlElement(ElementName = "TITLE_KEY")]
        [MaxLength(4, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? TitleKey { get; set; } = "0001";

        /// <summary>
        /// Primer Nombre
        /// </summary>
        /// <example></example>
        [JsonPropertyName("FIRSTNAME")]
        [XmlElement(ElementName = "FIRSTNAME")]
        [MaxLength(40, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Segundo Nombre
        /// </summary>
        /// <example></example>
        [JsonPropertyName("MIDDLENAME")]
        [XmlElement(ElementName = "MIDDLENAME")]
        [MaxLength(40, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? MiddleName { get; set; }

        /// <summary>
        /// Primer apellido
        /// </summary>
        /// <example></example>
        [JsonPropertyName("LASTNAME")]
        [XmlElement(ElementName = "LASTNAME")]
        [MaxLength(40, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? LastName { get; set; }

        /// <summary>
        /// Segundo Apellido
        /// </summary>
        /// <example></example>
        [JsonPropertyName("SECONDNAME")]
        [XmlElement(ElementName = "SECONDNAME")]
        [MaxLength(40, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? SecondName { get; set; }

        /// <summary>
        /// Numero de documento de identidad debe ser igual a la etiqueta TAXNUMBER
        /// </summary>
        /// <example></example>
        [JsonPropertyName("SEARCHTERM1")]
        [XmlElement(ElementName = "SEARCHTERM1")]
        [Required, MaxLength(20, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string SearchTerm1 { get; set; }

        /// <example></example>
        [JsonPropertyName("SEARCHTERM2")]
        [XmlElement(ElementName = "SEARCHTERM2")]
        [MaxLength(20, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? SearchTerm2 { get; set; }

        /// <summary>
        /// Codigo postal de la poblacion
        /// </summary>
        /// <example></example>
        [JsonPropertyName("POSTL_COD1")]
        [XmlElement(ElementName = "POSTL_COD1")]
        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? PostlCod1 { get; set; }

        /// <summary>
        /// Dirección vivienda cliente
        /// </summary>
        /// <example></example>
        [JsonPropertyName("STREET")]
        [XmlElement(ElementName = "STREET")]
        [MaxLength(60, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Street { get; set; }

        /// <summary>
        /// Ciudad
        /// </summary>
        /// <example></example>
        [JsonPropertyName("CITY1")]
        [XmlElement(ElementName = "CITY1")]
        [MaxLength(40, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? City1 { get; set; }

        /// <summary>
        /// Distrito
        /// </summary>
        /// <example></example>
        [JsonPropertyName("DISTRICT")]
        [XmlElement(ElementName = "DISTRICT")]
        [MaxLength(40, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? District { get; set; }

        /// <summary>
        /// Clave del pais
        /// </summary>
        /// <example></example>
        [JsonPropertyName("LAND1")]
        [XmlElement(ElementName = "LAND1")]
        [MaxLength(3, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Land1 { get; set; }

        /// <summary>
        /// Region (Estado federal, "land", provincia, condado)
        /// </summary>
        /// <example></example>
        [JsonPropertyName("REGIO")]
        [XmlElement(ElementName = "REGIO")]
        [MaxLength(3, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Regio { get; set; }

        /// <summary>
        /// Lenguaje clave del idioma
        /// </summary>
        /// <example></example>
        [JsonPropertyName("LANGU")]
        [XmlElement(ElementName = "LANGU")]
        [MaxLength(2, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Langu { get; set; }

        /// <summary>
        /// Telefono fijo = prefijo + numero
        /// </summary>
        /// <example></example>
        [JsonPropertyName("TELEPHONETEL")]
        [XmlElement(ElementName = "TELEPHONETEL")]
        [MaxLength(30, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Telephonetel { get; set; }

        /// <summary>
        /// Telefono movil = prefijo + numero
        /// </summary>
        /// <example></example>
        [JsonPropertyName("TELEPHONEMOB")]
        [XmlElement(ElementName = "TELEPHONEMOB")]
        [MaxLength(30, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? TelephoneMob { get; set; }

        /// <summary>
        /// Fax = prefijo + numero
        /// </summary>
        /// <example></example>
        [JsonPropertyName("FAX")]
        [XmlElement(ElementName = "FAX")]
        [MaxLength(30, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Fax { get; set; }

        /// <summary>
        /// Correo Electronico
        /// </summary>
        /// <example></example>
        [JsonPropertyName("E_MAIL")]
        [XmlElement(ElementName = "E_MAIL")]
        [MaxLength(241, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Email { get; set; }

        /// <summary>
        /// 1 Femenino o 2 Masculino
        /// </summary>
        /// <example></example>
        [JsonPropertyName("SEX")]
        [XmlElement(ElementName = "SEX")]
        [MaxLength(1, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Sex { get; set; }

        /// <summary>
        /// Estado Civil cliente 1 Soltero,  2 Casado, 3 Separado, 4 Viudo, 5 Unión libre
        /// </summary>
        /// <example></example>
        [JsonPropertyName("MARITALSTATUS")]
        [XmlElement(ElementName = "MARITALSTATUS")]
        [MaxLength(1, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? MaritalStatus { get; set; }

        /// <summary>
        /// Profesion del cliente
        /// </summary>
        /// <example></example>
        [JsonPropertyName("OCCUPATION")]
        [XmlElement(ElementName = "OCCUPATION")]
        [MaxLength(4, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Occupation { get; set; }

        /// <summary>
        /// Fecha de nacimiento formato aaaa-mm-dd
        /// </summary>
        /// <example></example>
        [JsonPropertyName("BIRTHDATE")]
        [XmlElement(ElementName = "BIRTHDATE")]
        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? BirthDate { get; set; }

        /// <summary>
        /// Fecha fallecimiento formato aaaa-mm-dd
        /// </summary>
        /// <example></example>
        [JsonPropertyName("DEATHDATE")]
        [XmlElement(ElementName = "DEATHDATE")]
        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? DeathDate { get; set; }

        /// <summary>
        /// Fecha de fundacion organizacion formato aaaa-mm-dd
        /// </summary>
        /// <example></example>
        [JsonPropertyName("FOUNDATIONDATE")]
        [XmlElement(ElementName = "FOUNDATIONDATE")]
        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? FoundationDate { get; set; }

        /// <summary>
        /// IC: Forma jurídica de organización
        /// </summary>
        /// <example></example>
        [JsonPropertyName("LEGALFORM")]
        [XmlElement(ElementName = "LEGALFORM")]
        [MaxLength(2, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? LegalForm { get; set; }

        /// <summary>
        /// Sujeto de derecho de la organización
        /// </summary>
        /// <example></example>
        [JsonPropertyName("LEGALORG")]
        [XmlElement(ElementName = "LEGALORG")]
        [MaxLength(2, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? LegalOrg { get; set; }

        /// <example></example>
        [JsonPropertyName("INDUSTRYSECTOR")]
        [XmlElement(ElementName = "INDUSTRYSECTOR")]
        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? IndustrySector { get; set; }

        /// <summary>
        /// Numero de identificación del cliente
        /// </summary>
        /// <example></example>
        [JsonPropertyName("TAXNUMBER")]
        [XmlElement(ElementName = "TAXNUMBER")]
        [MaxLength(20, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? TaxNumber { get; set; }

        /// <summary>
        /// Tipo de número identificacion del cliente
        /// </summary>
        /// <example></example>
        [JsonPropertyName("TAXTYPE")]
        [XmlElement(ElementName = "TAXTYPE")]
        [MaxLength(4, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? TaxType { get; set; }

        /// <summary>
        /// Indicador de una posición
        /// </summary>
        /// <example>X</example>
        [JsonPropertyName("NAT_PERSON")]
        [XmlElement(ElementName = "NAT_PERSON")]
        [MaxLength(1, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? NatPerson { get; set; } = "X";

        /// <summary>
        /// Niveles de patch
        /// </summary>
        /// <example></example>
        [JsonPropertyName("BPKIND")]
        [XmlElement(ElementName = "BPKIND")]
        [MaxLength(4, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Bpkind { get; set; }

        /// <summary>
        /// Inicio de la validez del numero de identificacion formato aaaa-mm-dd
        /// </summary>
        /// <example></example>
        [JsonPropertyName("DATE_FROM")]
        [XmlElement(ElementName = "DATE_FROM")]
        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? DateFrom { get; set; }

        /// <summary>
        /// Fin de la validez del numero de identificacion formato aaaa-mm-dd
        /// </summary>
        /// <example></example>
        [JsonPropertyName("DATE_TO")]
        [XmlElement(ElementName = "DATE_TO")]
        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? DateTo { get; set; }

        /// <summary>
        /// Area de venta
        /// </summary>
        /// <example></example>
        [JsonPropertyName("AREA_VENTAS")]
        [XmlElement(ElementName = "AREA_VENTAS")]
        [MaxLength(1, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? AreaVentas { get; set; }

        /// <summary>
        /// Clave de grupo
        /// </summary>
        /// <example></example>
        [JsonPropertyName("GRP")]
        [XmlElement(ElementName = "GRP")]
        [MaxLength(3, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Grp { get; set; }

        /// <summary>
        /// Funcion IC
        /// </summary>
        /// <example>CRM000</example>
        [JsonPropertyName("BU_PARTNERROLE")]
        [XmlElement(ElementName = "BU_PARTNERROLE")]
        [MaxLength(6, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? BuPartnerRole { get; set; } = "CRM000";

        /// <summary>
        /// ID de organización de ventas
        /// </summary>
        /// <example>O 50000026</example>
        [JsonPropertyName("SALES_ORGANIZATION")]
        [XmlElement(ElementName = "SALES_ORGANIZATION")]
        [MaxLength(14, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? SalesOrganization { get; set; } = "O 50000026";

        /// <summary>
        /// Canal de distribucion
        /// </summary>
        /// <example>AP</example>
        [JsonPropertyName("DISTRIBUTION_CHANNEL")]
        [XmlElement(ElementName = "DISTRIBUTION_CHANNEL")]
        [MaxLength(2, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? DistributionChannel { get; set; } = "AP";

        /// <example>SF</example>
        [JsonPropertyName("DIVISION")]
        [XmlElement(ElementName = "DIVISION")]
        [MaxLength(2, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Division { get; set; } = "SF";

        /// <summary>
        /// Grupo de clientes
        /// </summary>
        /// <example>Z1</example>
        [JsonPropertyName("CUSTOMER_GROUP")]
        [XmlElement(ElementName = "CUSTOMER_GROUP")]
        [MaxLength(2, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? CustomerGroup { get; set; } = "Z1";

        /// <summary>
        /// Esquema del cliente
        /// </summary>
        /// <example>1</example>
        [JsonPropertyName("CUST_PRIC_PROC")]
        [XmlElement(ElementName = "CUST_PRIC_PROC")]
        [MaxLength(1, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? CustPricProc { get; set; } = "1";

        /// <summary>
        /// Moneda
        /// </summary>
        /// <example>COP</example>
        [JsonPropertyName("CURRENCY")]
        [XmlElement(ElementName = "CURRENCY")]
        [MaxLength(5, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Currency { get; set; } = "COP";

        /// <summary>
        /// Condiciones de expedicion
        /// </summary>
        /// <example>01</example>
        [JsonPropertyName("SHIPPING_COND")]
        [XmlElement(ElementName = "SHIPPING_COND")]
        [MaxLength(2, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? ShippingCond { get; set; } = "01";

        /// <summary>
        /// Condiciones de pago
        /// </summary>
        /// <example>0001</example>
        [JsonPropertyName("PAYMENT_TERMS")]
        [XmlElement(ElementName = "PAYMENT_TERMS")]
        [MaxLength(4, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? PaymentTerms { get; set; } = "0001";

        /// <summary>
        /// Codigo de mensaje
        /// </summary>
        /// <example>String 50</example>
        [JsonPropertyName("ID")]
        [XmlElement(ElementName = "ID")]
        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Id { get; set; } = "String 50";

        /// <summary>
        /// Clase de mensaje
        /// </summary>
        /// <example>String 51</example>
        [JsonPropertyName("MSGID")]
        [XmlElement(ElementName = "MSGID")]
        [MaxLength(20, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? MsgId { get; set; } = "String 51";

        /// <summary>
        /// Tipo de mensaje
        /// </summary>
        /// <example>S</example>
        [JsonPropertyName("MSGTY")]
        [XmlElement(ElementName = "MSGTY")]
        [MaxLength(1, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Msgty { get; set; } = "S";

        /// <summary>
        /// Numero de mensaje
        /// </summary>
        /// <example>53</example>
        [JsonPropertyName("MSGNO")]
        [XmlElement(ElementName = "MSGNO")]
        [MaxLength(3, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Msgno { get; set; } = "53";

        /// <summary>
        /// Variable de mensaje
        /// </summary>
        /// <example>String 54</example>
        [JsonPropertyName("MSGV1")]
        [XmlElement(ElementName = "MSGV1")]
        [MaxLength(50, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Msgv1 { get; set; } = "String 54";

        /// <summary>
        /// Variable de mensaje
        /// </summary>
        /// <example>String 55</example>
        [JsonPropertyName("MSGV2")]
        [XmlElement(ElementName = "MSGV2")]
        [MaxLength(50, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Msgv2 { get; set; } = "String 55";

        /// <summary>
        /// Variable de mensaje
        /// </summary>
        /// <example>String 56</example>
        [JsonPropertyName("MSGV3")]
        [XmlElement(ElementName = "MSGV3")]
        [MaxLength(50, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Msgv3 { get; set; } = "String 56";

        /// <summary>
        /// Variable de mensaje
        /// </summary>
        /// <example>String 57</example>
        [JsonPropertyName("MSGV4")]
        [XmlElement(ElementName = "MSGV4")]
        [MaxLength(50, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Msgv4 { get; set; } = "String 57";

        /// <summary>
        /// Texto de mensaje
        /// </summary>
        /// <example>String 58</example>
        [JsonPropertyName("MESSAGE")]
        [XmlElement(ElementName = "MESSAGE")]
        [MaxLength(220, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Message { get; set; } = "String 58";
    }
}
