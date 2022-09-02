using genericTypes.domain.Common.HttpHandle.Request;
using genericTypes.domain.Interfaces.Payment;
using Microsoft.AspNetCore.Mvc;

namespace genericTypes.api.Controllers.Payment
{
    [ApiController]
    [Route("payments/[controller]")]
    public class CreditCardController : PaymentGenericController<CreditcardModel>
    {
        #region FIELDS
        private IConfiguration _configuration;
        #endregion

        #region CTOR
        public CreditCardController(IPaymentGenericService<CreditcardModel> paymentService, IConfiguration configuration) : base(paymentService)
        {
            _configuration = configuration;
        }
        #endregion
    }
}
