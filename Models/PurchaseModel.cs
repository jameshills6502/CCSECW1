using System.ComponentModel.DataAnnotations;

namespace BlazorServer.Models
{
    public class PurchaseModel
    { 
        [Required][StringLength(16, ErrorMessage = "Card Number is invalid")]public string CardNumber { get; set; }

        [Required][StringLength(3, ErrorMessage = "CVV is invalid")] public string CardCVV { get; set; }

        [Required] public string CardName { get; set; }
        [Required] public string CardType { get; set; }

        [Required] public string ExpiryDate { get; set; }

        [Required] public string BillingAddress { get; set; }
    }
}
