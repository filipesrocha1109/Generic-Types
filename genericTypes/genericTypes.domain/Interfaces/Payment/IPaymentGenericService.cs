using genericTypes.domain.Common;

namespace genericTypes.domain.Interfaces.Payment
{
    public interface IPaymentGenericService<T>
    {
        Task<Response> GetAll();
        Task<Response> Get(int id);
        Task<Response> Insert(T item);
        Task<Response> Delete(int id);
    }
}
