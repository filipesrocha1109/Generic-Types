using AutoMapper;
using genericTypes.domain.Common.HttpHandle.Request;
using genericTypes.domain.Interfaces.Payment;
using genericTypes.domain.Interfaces.UnitOfWork;

namespace genericTypes.services.Payment
{
    public class PaymentService : IPaymentService
    {
        #region FIELDS
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion

        #region CTOR
        public PaymentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        #endregion

        #region PUBLIC FUNCTIONS  
        public async Task<object> AddOrder<T>(T model) where T : PaymentModel
        {
            try
            {
                return await Task.Run(() => new object());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<decimal> CalculateTotalOrder<T>(T model) where T : PaymentModel
        {
            try
            {
                return await Task.Run(() => 0);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        #endregion

        #region PRIVATE FUNCTION
        #endregion
    }
}
