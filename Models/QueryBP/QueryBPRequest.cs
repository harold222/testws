namespace WSGYG63.Models.QueryBP
{
    public class QueryBPRequest
    {
        [Required, MaxLength(4, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        [RegularExpression(@"^[a-zA-Z0-9 ]+$", ErrorMessage = "No son permitidos los caracteres especiales en el campo {0}.")]
        public string Type { get; set; }

        [Required, MaxLength(10, ErrorMessage = "El máximo de carácteres permitidos para el campo {0} es {1}")]
        [RegularExpression(@"^[a-zA-Z0-9 ]+$", ErrorMessage = "No son permitidos los caracteres especiales en el campo {0}.")]
        public string NumberId { get; set; }
    }
}
