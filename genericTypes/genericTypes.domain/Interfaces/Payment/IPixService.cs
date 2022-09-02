using genericTypes.domain.Common;
using genericTypes.domain.Common.HttpHandle.Request;

namespace genericTypes.domain.Interfaces.Payment
{
    public interface IPixService
    {
        Task<Response> PixMethod(PixModel request);
    }
}
