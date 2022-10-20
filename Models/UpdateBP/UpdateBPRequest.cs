using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace WSGYG.Models.UpdateBP
{
    [XmlRoot(ElementName = "I_ES_DATA_BP")]
    public class UpdateBPRequest

    {
        /// <summary>
        /// Número del BP
        /// </summary>
        [JsonPropertyName("BPARTNER")]
        [XmlElement(ElementName = "BPARTNER")]
        [Required, MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Bpartner { get; set; }

        /// <summary><summary>
        [JsonPropertyName("FIRSTNAME")]
        [XmlElement(ElementName = "FIRSTNAME")]
        [MaxLength(1, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? FirstName { get; set; }

        /// <summary><summary>
        [JsonPropertyName("MIDDLENAME")]
        [XmlElement(ElementName = "MIDDLENAME")]
        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? MiddleName { get; set; }

        /// <summary><summary>
        [JsonPropertyName("LASTNAME")]
        [XmlElement(ElementName = "LASTNAME")]
        [MaxLength(4, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? LastName { get; set; }

        /// <summary><summary>
        [JsonPropertyName("SECONDNAME")]
        [XmlElement(ElementName = "SECONDNAME")]
        [MaxLength(4, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? SecondName { get; set; }

        /// <summary><summary>
        [JsonPropertyName("SEARCHTERM1")]
        [XmlElement(ElementName = "SEARCHTERM1")]
        [Required, MaxLength(4, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? SearchTerm1 { get; set; }

        /// <summary><summary>
        [JsonPropertyName("POSTL_COD1")]
        [XmlElement(ElementName = "POSTL_COD1")]
        [MaxLength(40, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Postl_Cod1 { get; set; }

        /// <summary><summary>
        [JsonPropertyName("STREET")]
        [XmlElement(ElementName = "STREET")]
        [MaxLength(40, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Street { get; set; }

        /// <summary><summary>
        [JsonPropertyName("CITY")]
        [XmlElement(ElementName = "CITY")]
        [MaxLength(40, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? City { get; set; }

        /// <summary><summary>
        [JsonPropertyName("COUNTRY")]
        [XmlElement(ElementName = "COUNTRY")]
        [MaxLength(40, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Country { get; set; }

        /// <summary><summary>
        [JsonPropertyName("REGION")]
        [XmlElement(ElementName = "REGION")]
        [MaxLength(20, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Region { get; set; }

        /// <summary><summary>
        [JsonPropertyName("LANGU")]
        [XmlElement(ElementName = "LANGU")]
        [MaxLength(20, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Langu { get; set; }

        /// <summary><summary>
        [JsonPropertyName("TELEPHONE")]
        [XmlElement(ElementName = "TELEPHONE")]
        [MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Telephone { get; set; }

        /// <summary><summary>
        [JsonPropertyName("MOVIL")]
        [XmlElement(ElementName = "MOVIL")]
        [MaxLength(60, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Movil { get; set; }

        /// <summary><summary>
        [JsonPropertyName("FAX")]
        [XmlElement(ElementName = "FAX")]
        [MaxLength(40, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Fax { get; set; }

        /// <summary><summary>
        [JsonPropertyName("EMAIL")]
        [XmlElement(ElementName = "EMAIL")]
        [MaxLength(40, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Email { get; set; }

        /// <summary><summary>
        [JsonPropertyName("SEX")]
        [XmlElement(ElementName = "SEX")]
        [MaxLength(3, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Sex { get; set; }

        /// <summary><summary>
        [JsonPropertyName("ESTADO")]
        [XmlElement(ElementName = "ESTADO")]
        [MaxLength(3, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Estado { get; set; }

        /// <summary><summary>
        [JsonPropertyName("FECHA_NAC")]
        [XmlElement(ElementName = "FECHA_NAC")]
        [MaxLength(1, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Fecha_Nac { get; set; }

        /// <summary><summary>
        [JsonPropertyName("NIF")]
        [XmlElement(ElementName = "NIF")]
        [Required, MaxLength(30, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Nif { get; set; }

        /// <summary><summary>
        [JsonPropertyName("TIPOID")]
        [XmlElement(ElementName = "TIPOID")]
        [MaxLength(30, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Tipoid { get; set; }

        /// <summary><summary>
        [JsonPropertyName("PET_BORRADO")]
        [XmlElement(ElementName = "PET_BORRADO")]
        [MaxLength(30, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Pet_Borrado { get; set; }

        /// <summary><summary>
        [JsonPropertyName("CLAVE_GRPO")]
        [XmlElement(ElementName = "CLAVE_GRPO")]
        public string? Clave_Grpo { get; set; }

        /// <summary><summary>
        [JsonPropertyName("LONGITUD")]
        [XmlElement(ElementName = "LONGITUD")]
        public string? Longitud { get; set; }

        /// <summary><summary>
        [JsonPropertyName("LATITUD")]
        [XmlElement(ElementName = "LATITUD")]
        public string? Latitud { get; set; }
    }
}
