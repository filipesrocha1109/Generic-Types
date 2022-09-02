using genericTypes.api.Filters;
using genericTypes.domain.Common;
using genericTypes.domain.Enums;
using genericTypes.domain.Interfaces.Payment;
using Microsoft.AspNetCore.Mvc;

namespace genericTypes.api.Controllers.Payment
{
    [ApiController]
    [Route("[controller]")]
    [ServiceFilter(typeof(ValidationFilterAttribute))]
    public class PaymentGenericController<T> : Controller where T : class
    {
        #region FIELDS
        private IPaymentGenericService<T> _paymentService;
        #endregion

        #region CTOR
        public PaymentGenericController(IPaymentGenericService<T> paymentService)
        {
            _paymentService = paymentService;
        }
        #endregion

        #region PUBLIC METHODS
        [HttpGet]
        public async Task<ActionResult<Response>> GetAllAsync()
        {
            #region VARIABLES
            var response = new Response();
            #endregion

            #region LOGIC
            try
            {
                response = await _paymentService.GetAll();

                return StatusCode(response.Status, response);
            }
            catch (Exception e)
            {
                return StatusCode((int)ReturnStatus.InternalServerError, response = new()
                {
                    Message = $"MESSAGE => {e.Message} || INNER EXCEPTION => {e.InnerException}",
                    Code = (int)ReturnCodes.ExceptionEx,
                    Success = false
                });
            }
            #endregion
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Response>> GetAsync(int id)
        {
            #region VARIABLES
            var response = new Response();
            #endregion

            #region LOGIC
            try
            {
                response = await _paymentService.Get(id);

                return StatusCode(response.Status, response);
            }
            catch (Exception e)
            {
                return StatusCode((int)ReturnStatus.InternalServerError, response = new()
                {
                    Message = $"MESSAGE => {e.Message} || INNER EXCEPTION => {e.InnerException}",
                    Code = (int)ReturnCodes.ExceptionEx,
                    Success = false
                });
            }
            #endregion
        }

        [HttpPost]
        public async Task<ActionResult<Response>> InsertAsync([FromBody] T value)
        {
            #region VARIABLES
            var response = new Response();
            #endregion

            #region LOGIC
            try
            {
                response = await _paymentService.Insert(value);

                return StatusCode(response.Status, response);
            }
            catch (Exception e)
            {
                return StatusCode((int)ReturnStatus.InternalServerError, response = new()
                {
                    Message = $"MESSAGE => {e.Message} || INNER EXCEPTION => {e.InnerException}",
                    Code = (int)ReturnCodes.ExceptionEx,
                    Success = false
                });
            }
            #endregion
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Response>> DeleteAsync(int id)
        {
            #region VARIABLES
            var response = new Response();
            #endregion

            #region LOGIC
            try
            {
                response = await _paymentService.Delete(id);

                return StatusCode(response.Status, response);
            }
            catch (Exception e)
            {
                return StatusCode((int)ReturnStatus.InternalServerError, response = new()
                {
                    Message = $"MESSAGE => {e.Message} || INNER EXCEPTION => {e.InnerException}",
                    Code = (int)ReturnCodes.ExceptionEx,
                    Success = false
                });
            }
            #endregion
        }
        #endregion

        #region PRIVATE METHODS
        #endregion
    }
}
