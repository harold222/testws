namespace WSGYG63.Models.QueryBP
{
    public class QueryBPRequest
    {
        /// <summary>
        /// Tipo de identificacion del cliente
        /// </summary>
        /// <example>CO1C</example>
        [Required, MaxLength(4, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        [RegularExpression(@"^[a-zA-Z0-9 ]+$", ErrorMessage = "No son permitidos los caracteres especiales en el campo {0}.")]
        public string Type { get; set; }

        /// <summary>
        /// Numero de identificacion del cliente
        /// </summary>
        /// <example>1094907957</example>
        [Required, MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        [RegularExpression(@"^[a-zA-Z0-9 ]+$", ErrorMessage = "No son permitidos los caracteres especiales en el campo {0}.")]
        public string NumberId { get; set; }
    }
}
