using genericTypes.domain.Common.HttpHandle.Request;
using genericTypes.domain.Enums;
using System.ComponentModel;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace genericTypes.crosscutting.Utils
{
    public static class Utils
    {
        public static string GetEnumDescription(Enum value)
        {
            // https://codereview.stackexchange.com/questions/157871/method-that-returns-description-attribute-of-enum-value
            return value.GetType().GetMember(value.ToString()).FirstOrDefault()?.GetCustomAttribute<DescriptionAttribute>()?.Description ?? value.ToString();
        }
        public static string GetTypePayment(object value)
        {
            try
            {
  
                var credito = new CreditcardModel().GetType();
                var pix = new PixModel().GetType();
                var paypal = new PaypalModel().GetType();

                if (credito.Equals(value.GetType()))
                    return GetEnumDescription(ReturnPaymentsType.CREDITO);

                if (pix.Equals(value.GetType()))
                    return GetEnumDescription(ReturnPaymentsType.PIX);

                if (paypal.Equals(value.GetType()))
                    return GetEnumDescription(ReturnPaymentsType.PAYPAL);

                return GetEnumDescription(ReturnPaymentsType.OTHER);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
