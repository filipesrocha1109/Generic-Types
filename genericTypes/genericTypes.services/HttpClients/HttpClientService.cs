using genericTypes.domain.Common.HttpHandle.Request;
using genericTypes.domain.Interfaces.HttpClient;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace genericTypes.services.HttpClients
{
    public class HttpClientService : IHttpClientService
    {
        #region FIELDS
        private readonly HttpClient _httpClient;
        private StringContent requestJson;
        #endregion

        #region CTOR
        public HttpClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        #endregion

        #region PUBLIC FUNCTIONS
        public async Task<HttpResponseMessage> GetWithoutParametersAsync(string url)
        {
            try
            {
                var httpClient = new HttpClient();

                var request = new HttpRequestMessage();

                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                return await httpClient.GetAsync(new Uri(url));

            }
            catch (Exception ex)
            {
                throw new Exception("HttpClientGetAsync: " + ex.Message + " || " + ex.InnerException);
            }
        }
        public async Task<HttpResponseMessage> GetAsync(string url, List<HttpClientParams> paramsUrl)
        {
            try
            {
                var httpClient = new HttpClient();

                var request = new HttpRequestMessage();

                var paramsUrlStr = string.Empty;

                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                if (paramsUrl.Count > 0)
                {
                    foreach (var param in paramsUrl)
                        paramsUrlStr += $"{param.param}={param.value}&";

                    if (!String.IsNullOrEmpty(paramsUrlStr))
                        url += $"?{paramsUrlStr.Remove(paramsUrlStr.Length - 1)}";
                }

                return await httpClient.GetAsync(new Uri(url));

            }
            catch (Exception ex)
            {
                throw new Exception("HttpClientGetAsync: " + ex.Message + " || " + ex.InnerException);
            }
        }
        public async Task<HttpResponseMessage> PostAsync(string url, object value)
        {
            try
            {
                var httpClient = new HttpClient();

                var request = new HttpRequestMessage();

                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                StringContent requestJson = new StringContent(JsonConvert.SerializeObject(value), Encoding.UTF8, "application/json");

                return await httpClient.PostAsync(new Uri(url), requestJson);

            }
            catch (Exception ex)
            {
                throw new Exception("HttpClientPostAsync: " + ex.Message + " || " + ex.InnerException);
            }
        }
        #endregion
    }
}
