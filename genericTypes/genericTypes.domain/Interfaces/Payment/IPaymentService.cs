using genericTypes.domain.Common.HttpHandle.Request;

namespace genericTypes.domain.Interfaces.Payment
{
    public interface IPaymentService
    {
        Task<object> AddOrder<T>(T model) where T : PaymentModel;
        Task<decimal> CalculateTotalOrder<T>(T model) where T : PaymentModel;
    }
}
