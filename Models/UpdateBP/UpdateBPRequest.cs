using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace WSGYG63.Models.UpdateBP
{
    [XmlRoot(ElementName = "I_ES_DATA_BP")]
    public class UpdateBPRequest
    {
        /// <summary>
        /// Número del BP (Business Parther)
        /// </summary>
        /// <example></example>
        [JsonPropertyName("BPARTNER")]
        [XmlElement(ElementName = "BPARTNER")]
        [Required, MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string Bpartner { get; set; }

        /// <summary>
        /// Primer Nombre
        /// </summary>
        /// <example></example>
        [JsonPropertyName("FIRSTNAME")]
        [XmlElement(ElementName = "FIRSTNAME")]
        [MaxLength(40, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
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
        /// Primer Apellido
        /// </summary>
        /// <example></example>
        [JsonPropertyName("LASTNAME")]
        [XmlElement(ElementName = "LASTNAME")]
        [MaxLength(40, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? LastName { get; set; }

        /// <summary>
        /// Segundo Apellido
        /// </summary>
        /// <example></example>
        [JsonPropertyName("SECONDNAME")]
        [XmlElement(ElementName = "SECONDNAME")]
        [MaxLength(40, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? SecondName { get; set; }

        /// <summary>
        /// Numero de documento de identidad debe ser igual a la etiqueta TAXNUMBER
        /// </summary>
        /// <example></example>
        [JsonPropertyName("SEARCHTERM1")]
        [XmlElement(ElementName = "SEARCHTERM1")]
        [Required, MaxLength(20, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string SearchTerm1 { get; set; }

        /// <summary>
        /// Codigo Postal
        /// </summary>
        /// <example></example>
        [JsonPropertyName("POSTL_COD1")]
        [XmlElement(ElementName = "POSTL_COD1")]
        [MaxLength(10, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? Postl_Cod1 { get; set; }

        /// <summary>
        /// Dirección vivienda cliente
        /// </summary>
        /// <example></example>
        [JsonPropertyName("STREET")]
        [XmlElement(ElementName = "STREET")]
        [MaxLength(60, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? Street { get; set; }

        /// <summary>
        /// Ciudad
        /// </summary>
        /// <example></example>
        [JsonPropertyName("CITY")]
        [XmlElement(ElementName = "CITY")]
        [MaxLength(40, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? City { get; set; }

        /// <summary>
        /// Pais
        /// </summary>
        /// <example></example>
        [JsonPropertyName("COUNTRY")]
        [XmlElement(ElementName = "COUNTRY")]
        [MaxLength(40, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? Country { get; set; }

        /// <summary>
        /// Region (Estado federal, "land", provincia, condado)
        /// </summary>
        /// <example></example>
        [JsonPropertyName("REGION")]
        [XmlElement(ElementName = "REGION")]
        [MaxLength(3, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? Region { get; set; }

        /// <summary>
        /// Lenguaje clave del idioma
        /// </summary>
        /// <example></example>
        [JsonPropertyName("LANGU")]
        [XmlElement(ElementName = "LANGU")]
        [MaxLength(2, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? Langu { get; set; }

        /// <summary>
        /// Telefono fijo = prefijo + numero
        /// </summary>
        /// <example></example>
        [JsonPropertyName("TELEPHONE")]
        [XmlElement(ElementName = "TELEPHONE")]
        [MaxLength(30, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? Telephone { get; set; }

        /// <summary>
        /// Telefono movil = prefijo + numero
        /// </summary>
        /// <example></example>
        [JsonPropertyName("MOVIL")]
        [XmlElement(ElementName = "MOVIL")]
        [MaxLength(30, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? Movil { get; set; }

        /// <summary>
        /// Fax = prefijo + numero
        /// </summary>
        /// <example></example>
        [JsonPropertyName("FAX")]
        [XmlElement(ElementName = "FAX")]
        [MaxLength(30, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? Fax { get; set; }

        /// <summary>
        /// Direccion de correo electronico
        /// </summary>
        /// <example></example>
        [JsonPropertyName("EMAIL")]
        [XmlElement(ElementName = "EMAIL")]
        [MaxLength(241, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? Email { get; set; }

        /// <summary>
        /// "1" Femenino,"2" Masculino
        /// </summary>
        /// <example></example>
        [JsonPropertyName("SEX")]
        [XmlElement(ElementName = "SEX")]
        [MaxLength(1, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? Sex { get; set; }

        /// <summary>
        /// Estado Civil cliente 1 Soltero,  2 Casado, 3 Separado, 4 Viudo, 5 Unión libre
        /// </summary>
        /// <example></example>
        [JsonPropertyName("ESTADO")]
        [XmlElement(ElementName = "ESTADO")]
        [MaxLength(1, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? State { get; set; }

        /// <summary>
        /// Fecha de nacimiento en este formato aaaa-mm-dd
        /// </summary>
        /// <example></example>
        [JsonPropertyName("FECHA_NAC")]
        [XmlElement(ElementName = "FECHA_NAC")]
        [MaxLength(10, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? BirthDate { get; set; }

        /// <summary>
        /// Numero de documento de identidad debe ser igual a la etiqueta SEARCHTERM1
        /// </summary>
        /// <example></example>
        [JsonPropertyName("NIF")]
        [XmlElement(ElementName = "NIF")]
        [Required, MaxLength(20, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string Nif { get; set; }

        /// <summary>
        /// Tipo de número identificacion del cliente
        /// </summary>
        /// <example></example>
        [JsonPropertyName("TIPOID")]
        [XmlElement(ElementName = "TIPOID")]
        [MaxLength(4, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? TypeId { get; set; }

        /// <summary>
        /// Peticion de archivado para borrar, es cuando un BP no se va a seguir utilizando
        /// </summary>
        /// <example></example>
        [JsonPropertyName("PET_BORRADO")]
        [XmlElement(ElementName = "PET_BORRADO")]
        [MaxLength(30, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? DeletePet { get; set; }

        /// <summary>
        /// Clave de grupo
        /// </summary>
        /// <example></example>
        [JsonPropertyName("CLAVE_GRPO")]
        [XmlElement(ElementName = "CLAVE_GRPO")]
        public string? GrpKey { get; set; }

        /// <summary>
        /// LONGITUD
        /// </summary>
        /// <example></example>
        [JsonPropertyName("LONGITUD")]
        [XmlElement(ElementName = "LONGITUD")]
        public string? Length { get; set; }

        /// <summary>
        /// LATITUD
        /// </summary>
        /// <example></example>
        [JsonPropertyName("LATITUD")]
        [XmlElement(ElementName = "LATITUD")]
        public string? Latitude { get; set; }
    }
}
