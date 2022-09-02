using Microsoft.AspNetCore.Mvc;
using genericTypes.domain.Common.HttpHandle.Request;
using genericTypes.domain.Interfaces.Payment;

namespace genericTypes.api.Controllers.Payment
{
    [Route("payments/[controller]")]
    [ApiController]
    public class PixController : PaymentGenericController<PixModel>
    {
        #region FIELDS
        private IConfiguration _configuration;
        #endregion

        #region CTOR
        public PixController(IPaymentGenericService<PixModel> paymentService, IConfiguration configuration) : base(paymentService)
        {
            _configuration = configuration;
        }
        #endregion
    }
}
