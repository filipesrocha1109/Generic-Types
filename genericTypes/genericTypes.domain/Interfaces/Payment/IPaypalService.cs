using genericTypes.domain.Common;
using genericTypes.domain.Common.HttpHandle.Request;

namespace genericTypes.domain.Interfaces.Payment
{
    public interface IPaypalService
    {
        Task<Response> PaypalMethod(PaypalModel request);
    }
}
