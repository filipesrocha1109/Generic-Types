using genericTypes.crosscutting.Utils;
using genericTypes.domain.Common;
using genericTypes.domain.Common.HttpHandle.Request;
using genericTypes.domain.Enums;
using genericTypes.domain.Interfaces.Payment;
using genericTypes.domain.Interfaces.UnitOfWork;

namespace genericTypes.services.Payment
{
    public class PaypalService : IPaymentGenericService<PaypalModel>, IPaypalService
    {
        #region FIELDS
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPaymentService _paymentService;
        #endregion

        #region CTOR
        public PaypalService(IUnitOfWork unitOfWork, IPaymentService paymentService)
        {
            _unitOfWork = unitOfWork;
            _paymentService = paymentService;
        }
        #endregion

        #region GENERIC FUNCTIONS   
        public async Task<Response> Insert(PaypalModel item)
        {
            return await Task.Run(() => new Response
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
        public async Task<Response> PaypalMethod(PaypalModel request)
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
