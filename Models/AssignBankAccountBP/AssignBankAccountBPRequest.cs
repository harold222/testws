using System.Text.Json.Serialization;

namespace WSGYG63.Models.AssignBankAccountBP
{
    public class AssignBankAccountBPRequest
    {
        /// <summary>
        /// Numero del BP (Business Parther)
        /// </summary>
        /// <example>1</example>
        [JsonPropertyName("BU_ROLE")]
        [MaxLength(1, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? BuRole { get; set; }

        /// <summary>
        /// NIF para interlocutor comercial 
        /// </summary>
        /// <example></example>
        [JsonPropertyName("BPTAXNUM")]
        [MaxLength(20, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? BpTaxNum { get; set; }

        /// <summary>
        /// ID datos bancarios, C002 (para Daviplata), C003 (Para Nequi) y C001 para todos los demas. 
        /// </summary>
        /// <example></example>
        [JsonPropertyName("BKVID")]
        [MaxLength(6, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Bkvid { get; set; }

        /// <summary>
        /// Numero cuenta bancaria
        /// </summary>
        /// <example></example>
        [JsonPropertyName("BANKN")]
        [MaxLength(18, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Bankn { get; set; }

        /// <summary>
        /// Clave de banco
        /// </summary>
        /// <example></example>
        [JsonPropertyName("BANKK")]
        [MaxLength(15, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Bankk { get; set; }

        /// <summary>
        /// Tipo de numero identificacion
        /// </summary>
        /// <example></example>
        [JsonPropertyName("BPTAXTYPE")]
        [MaxLength(4, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? BpTaxType { get; set; }

        /// <summary>
        /// Nombre del propietario de la cuenta
        /// </summary>
        /// <example></example>
        [JsonPropertyName("NOMBRE")]
        [MaxLength(60, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Nombre { get; set; }

        /// <summary>
        /// Clave de control de bancos, C1 (Cuenta corriente), C2 (Cuenta ahorros), DC (Daviplata), C2 (Nequi)
        /// </summary>
        /// <example></example>
        [JsonPropertyName("BKONT")]
        [MaxLength(2, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Bkont { get; set; }

        /// <summary>
        /// Clave de pais del banco
        /// </summary>
        /// <example>CO</example>
        [JsonPropertyName("BANKS")]
        [MaxLength(3, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        public string? Banks { get; set; }
    }
}
