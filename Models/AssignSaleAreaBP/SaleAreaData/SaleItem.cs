using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace WSGYG63.Models.AssignSaleAreaBP.SaleAreaData
{
    public class SaleItem
    {
        /// <summary>
        /// ID de organizacion de ventas
        /// </summary>
        /// <example></example>
        [JsonPropertyName("SALES_ORGANIZATION")]
        [XmlElement(ElementName = "SALES_ORGANIZATION")]
        [MaxLength(14, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? SALES_ORGANIZATION { get; set; }

        /// <summary>
        /// Canal de distribucion
        /// </summary>
        /// <example></example>
        [JsonPropertyName("DISTRIBUTION_CHANNEL")]
        [XmlElement(ElementName = "DISTRIBUTION_CHANNEL")]
        [MaxLength(2, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? DISTRIBUTION_CHANNEL { get; set; }

        /// <summary>
        /// Sector
        /// </summary>
        /// <example></example>
        [JsonPropertyName("DIVISION")]
        [XmlElement(ElementName = "DIVISION")]
        [MaxLength(2, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? DIVISION { get; set; }

        /// <summary>
        /// Oficina de ventas
        /// </summary>
        /// <example></example>
        [JsonPropertyName("SALES_OFFICE")]
        [XmlElement(ElementName = "SALES_OFFICE")]
        [MaxLength(14, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? SALES_OFFICE { get; set; }

        /// <summary>
        /// Grupo de vendedores
        /// </summary>
        /// <example></example>
        [JsonPropertyName("SALES_GROUP")]
        [XmlElement(ElementName = "SALES_GROUP")]
        [MaxLength(14, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? SALES_GROUP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <example></example>
        [JsonPropertyName("CUSTOMER_GROUP")]
        [XmlElement(ElementName = "CUSTOMER_GROUP")]
        [MaxLength(10, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? CUSTOMER_GROUP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <example></example>
        [JsonPropertyName("CUST_PRIC_PROC")]
        [XmlElement(ElementName = "CUST_PRIC_PROC")]
        [MaxLength(10, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? CUST_PRIC_PROC { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <example></example>
        [JsonPropertyName("CURRENCY")]
        [XmlElement(ElementName = "CURRENCY")]
        [MaxLength(10, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? CURRENCY { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <example></example>
        [JsonPropertyName("PRICE_GROUP")]
        [XmlElement(ElementName = "PRICE_GROUP")]
        [MaxLength(10, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? PRICE_GROUP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <example></example>
        [JsonPropertyName("DLV_PRIORITY")]
        [XmlElement(ElementName = "DLV_PRIORITY")]
        [MaxLength(10, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? DLV_PRIORITY { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <example></example>
        [JsonPropertyName("SHIPPING_COND")]
        [XmlElement(ElementName = "SHIPPING_COND")]
        [MaxLength(10, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? SHIPPING_COND { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <example></example>
        [JsonPropertyName("ACCOUNT_ASGNGRP")]
        [XmlElement(ElementName = "ACCOUNT_ASGNGRP")]
        [MaxLength(10, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? ACCOUNT_ASGNGRP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <example></example>
        [JsonPropertyName("PAYMENT_TERMS")]
        [XmlElement(ElementName = "PAYMENT_TERMS")]
        [MaxLength(10, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? PAYMENT_TERMS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <example></example>
        [JsonPropertyName("CUSTOMER_GROUP1")]
        [XmlElement(ElementName = "CUSTOMER_GROUP1")]
        [MaxLength(10, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? CUSTOMER_GROUP1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <example></example>
        [JsonPropertyName("CUSTOMER_GROUP2")]
        [XmlElement(ElementName = "CUSTOMER_GROUP2")]
        [MaxLength(10, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? CUSTOMER_GROUP2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <example></example>
        [JsonPropertyName("PART_DLV_ITM")]
        [XmlElement(ElementName = "PART_DLV_ITM")]
        [MaxLength(10, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? PART_DLV_ITM { get; set; }
    }
}
