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
        public string? SalesOrganization { get; set; }

        /// <summary>
        /// Canal de distribucion
        /// </summary>
        /// <example></example>
        [JsonPropertyName("DISTRIBUTION_CHANNEL")]
        [XmlElement(ElementName = "DISTRIBUTION_CHANNEL")]
        [MaxLength(2, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? DistributionChannel { get; set; }

        /// <summary>
        /// Sector
        /// </summary>
        /// <example></example>
        [JsonPropertyName("DIVISION")]
        [XmlElement(ElementName = "DIVISION")]
        [MaxLength(2, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? Division { get; set; }

        /// <summary>
        /// Oficina de ventas
        /// </summary>
        /// <example></example>
        [JsonPropertyName("SALES_OFFICE")]
        [XmlElement(ElementName = "SALES_OFFICE")]
        [MaxLength(14, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? SalesOffice { get; set; }

        /// <summary>
        /// Grupo de vendedores
        /// </summary>
        /// <example></example>
        [JsonPropertyName("SALES_GROUP")]
        [XmlElement(ElementName = "SALES_GROUP")]
        [MaxLength(14, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? SalesGroup { get; set; }

        /// <summary>
        /// Grupo de clientes
        /// </summary>
        /// <example></example>
        [JsonPropertyName("CUSTOMER_GROUP")]
        [XmlElement(ElementName = "CUSTOMER_GROUP")]
        [MaxLength(2, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? CustomerGroup { get; set; }

        /// <summary>
        /// Esquema de cliente
        /// </summary>
        /// <example></example>
        [JsonPropertyName("CUST_PRIC_PROC")]
        [XmlElement(ElementName = "CUST_PRIC_PROC")]
        [MaxLength(1, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? CustPricProc { get; set; }

        /// <summary>
        /// Codigo moneda
        /// </summary>
        /// <example></example>
        [JsonPropertyName("CURRENCY")]
        [XmlElement(ElementName = "CURRENCY")]
        [MaxLength(5, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? Currenccy { get; set; }

        /// <summary>
        /// Grupo precios del cliente
        /// </summary>
        /// <example></example>
        [JsonPropertyName("PRICE_GROUP")]
        [XmlElement(ElementName = "PRICE_GROUP")]
        [MaxLength(2, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? PriceGroup { get; set; }

        /// <summary>
        /// Prioridad de entrega
        /// </summary>
        /// <example></example>
        [JsonPropertyName("DLV_PRIORITY")]
        [XmlElement(ElementName = "DLV_PRIORITY")]
        [MaxLength(2, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? DlvPriority { get; set; }

        /// <summary>
        /// Condiciones de expedicion
        /// </summary>
        /// <example></example>
        [JsonPropertyName("SHIPPING_COND")]
        [XmlElement(ElementName = "SHIPPING_COND")]
        [MaxLength(2, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? ShippingCond { get; set; }

        /// <summary>
        /// Grupo de imputacion interlocutor comercial
        /// </summary>
        /// <example></example>
        [JsonPropertyName("ACCOUNT_ASGNGRP")]
        [XmlElement(ElementName = "ACCOUNT_ASGNGRP")]
        [MaxLength(2, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? AccountAsgngrp { get; set; }

        /// <summary>
        /// Condiciones de pago
        /// </summary>
        /// <example></example>
        [JsonPropertyName("PAYMENT_TERMS")]
        [XmlElement(ElementName = "PAYMENT_TERMS")]
        [MaxLength(4, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? PaymentTerms { get; set; }

        /// <summary>
        /// Grupo de clientes 1
        /// </summary>
        /// <example></example>
        [JsonPropertyName("CUSTOMER_GROUP1")]
        [XmlElement(ElementName = "CUSTOMER_GROUP1")]
        [MaxLength(3, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? CustomerGroup1 { get; set; }

        /// <summary>
        /// Grupo de clientes 2
        /// </summary>
        /// <example></example>
        [JsonPropertyName("CUSTOMER_GROUP2")]
        [XmlElement(ElementName = "CUSTOMER_GROUP2")]
        [MaxLength(3, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? CustomerGroup2 { get; set; }

        /// <summary>
        /// Control de entrega (posicion)
        /// </summary>
        /// <example></example>
        [JsonPropertyName("PART_DLV_ITM")]
        [XmlElement(ElementName = "PART_DLV_ITM")]
        [MaxLength(1, ErrorMessage = "El maximo de caracteres permitidos para el campo {0} es {1}")]
        public string? PartDlvItm { get; set; }
    }
}
