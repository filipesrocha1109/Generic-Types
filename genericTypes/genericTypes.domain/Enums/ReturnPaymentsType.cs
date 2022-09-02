using System.ComponentModel;

namespace genericTypes.domain.Enums
{
    public enum ReturnPaymentsType
    {
        [Description("CREDITO")]
        CREDITO = 1,

        [Description("DEBITO")]
        DEBITO = 2,

        [Description("DINHEIRO")]
        DINHEIRO = 3,

        [Description("PIX")]
        PIX = 4,

        [Description("VALE")]
        VALE = 5,

        [Description("PAYPAL")]
        PAYPAL = 6,

        [Description("OTHER")]
        OTHER = 0
    }
}
