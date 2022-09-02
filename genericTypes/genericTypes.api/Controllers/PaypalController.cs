using Microsoft.AspNetCore.Mvc;
using genericTypes.domain.Common.HttpHandle.Request;
using genericTypes.domain.Interfaces.Payment;

namespace genericTypes.api.Controllers.Payment
{
    [Route("payments/[controller]")]
    [ApiController]
    public class PaypalController : PaymentGenericController<PaypalModel>
    {
        #region FIELDS
        private IConfiguration _configuration;
        #endregion

        #region CTOR
        public PaypalController(IPaymentGenericService<PaypalModel> paymentService, IConfiguration configuration) : base(paymentService)
        {
            _configuration = configuration;
        }
        #endregion
    }
}
