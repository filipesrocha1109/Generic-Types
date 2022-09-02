
using System.ComponentModel.DataAnnotations;

namespace genericTypes.domain.Common.HttpHandle.Request
{
    public class HttpClientParams
    {
        public string? param { get; set; }
        public string? value { get; set; }
    }

    public class PaymentModel
    {
        [Required(ErrorMessage = "Items is required")]
        public List<PaymentItemsModel>? Items { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "PhoneNumber is required")]
        public string? PhoneNumber { get; set; }

        public string? Ref { get; set; }

        public string? RefId { get; set; }

        public string? Cpf { get; set; }
    }

    public class PaymentItemsModel
    {
        public int? Id { get; set; }

        [Range(1, 10, ErrorMessage = "Amount must be greater than 1")]
        public int? Amount { get; set; }

        public string? Origin { get; set; }

        public DateTime? FullDate { get; set; }
    }

    public class PixModel : PaymentModel
    {
        public string? Cnpj { get; set; }
    }

    public class PaypalModel : PaymentModel
    {
        [Required(ErrorMessage = "CpfCnpj is required")]
        public string? CpfCnpj { get; set; }

        [Required(ErrorMessage = "CodSeg is required")]
        public string? CodSeg { get; set; }
    }

    public class CreditcardModel : PaymentModel
    {

        [Required(ErrorMessage = "CpfCnpj is required")]
        public string? CpfCnpj { get; set; }

        [Required(ErrorMessage = "Birth is required")]
        public DateTime? Birth { get; set; }

        [Required(ErrorMessage = "NumberCreditCard is required")]
        public string? NumberCreditCard { get; set; }

        [Required(ErrorMessage = "ExpirationCreditCard is required")]
        public string? ExpirationCreditCard { get; set; }

        [Required(ErrorMessage = "CodeCreditCard is required")]
        public string? CodeCreditCard { get; set; }

        [Required(ErrorMessage = "Installments is required")]
        public int? Installments { get; set; }

    }

    public class CreditcardScore
    {
        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "CpfCnpj is required")]
        public string? CpfCnpj { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Birth is required")]
        public DateTime? Birth { get; set; }

        [Required(ErrorMessage = "Price is required")]
        public decimal? Price { get; set; }

        [Required(ErrorMessage = "FirstSixNumbersCreditCard is required")]
        public string? FirstSixNumbersCreditCard { get; set; }

        [Required(ErrorMessage = "LastFourNumbersCreditCard is required")]
        public string? LastFourNumbersCreditCard { get; set; }

        [Required(ErrorMessage = "ExpirationCreditCard is required")]
        public string? ExpirationCreditCard { get; set; }

        public string? OrderId { get; set; }
    }
}

