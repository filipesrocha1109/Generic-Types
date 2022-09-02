using genericTypes.crosscutting.Utils;
using genericTypes.domain.Common;
using genericTypes.domain.Common.HttpHandle.Request;
using genericTypes.domain.Enums;
using genericTypes.domain.Interfaces.Payment;

namespace genericTypes.services.Payment
{ 
    public class CreditCardService : IPaymentGenericService<CreditcardModel>, ICreditCardService
    {
        #region FIELDS
        private readonly IPaymentService _paymentService;
        #endregion

        #region CTOR
        public CreditCardService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        #endregion

        #region GENERIC FUNCTIONS  
        public async Task<Response> Insert(CreditcardModel item)
        {

            return await Task.Run(() =>  new Response
            {
                Message = Utils.GetEnumDescription(ReturnCodes.Ok),
                Code = (int)ReturnCodes.Ok,
                Status = (int)ReturnStatus.Ok,
                Success = true,
            });
        }
        public async Task<Response> Delete(int id)
        {
            return await Task.Run(() => new Response
            {
                Message = Utils.GetEnumDescription(ReturnCodes.Ok),
                Code = (int)ReturnCodes.Ok,
                Status = (int)ReturnStatus.Ok,
                Success = true,
            });
        }
        public async Task<Response> Get(int id)
        {
            return await Task.Run(() => new Response
            {
                Message = Utils.GetEnumDescription(ReturnCodes.Ok),
                Code = (int)ReturnCodes.Ok,
                Status = (int)ReturnStatus.Ok,
                Success = true,
            });
        }
        public async Task<Response> GetAll()
        {
            return await Task.Run(() => new Response
            {
                Message = Utils.GetEnumDescription(ReturnCodes.Ok),
                Code = (int)ReturnCodes.Ok,
                Status = (int)ReturnStatus.Ok,
                Success = true,
            });
        }
        #endregion

        #region PUBLIC FUNCTIONS  
        public async Task<Response> CreditcardMethod(CreditcardModel request)
        {
            return await Task.Run(() => new Response
            {
                Message = Utils.GetEnumDescription(ReturnCodes.Ok),
                Code = (int)ReturnCodes.Ok,
                Status = (int)ReturnStatus.Ok,
                Success = true,
            });
        }
        #endregion

        #region PRIVATE FUNCTION
        #endregion
    }
}
