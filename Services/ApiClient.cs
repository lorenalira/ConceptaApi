using ConceptaApi.Models.Result;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ConceptaApi.Services
{
    /// <summary>
    /// ApiClient
    /// </summary>
    public class ApiClient : IApiClient
    {
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="apiUrlBase"></param>
        public ApiClient(string apiUrlBase)
        {
            if (string.IsNullOrEmpty(apiUrlBase))
            {
                throw new ArgumentNullException(nameof(apiUrlBase), "Uma url base de API deve ser informada");
            }

            _apiUrlBase = apiUrlBase;
        }

        private HttpClient _restClient;
        private string _apiUrlBase;

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="apiRoute"></param>
        /// <param name="access_token"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public async Task<BaseApiResult<TModel>> GetAsync<TModel>(string apiRoute, string access_token = "", Action<BaseApiResult<TModel>> callback = null)
        {
            try
            {
                var json = await GetAsync(apiRoute, access_token);
                var data = JsonConvert.DeserializeObject<TModel>(json, GetConverter());
                var result = new OkApiResult<TModel>(data);

                callback?.Invoke(result);

                return result;
            }
            catch (Exception ex)
            {
                return new InvalidApiResult<TModel>(ex);
            }
        }

        /// <summary>
        /// PostAsync
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="apiRoute"></param>
        /// <param name="content"></param>
        /// <param name="access_token"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public async Task<BaseApiResult<TModel>> PostAsync<TModel>(string apiRoute, HttpContent content, string access_token = "", Action<BaseApiResult<TModel>> callback = null)
        {
            try
            {
                var json = await PostAsync(apiRoute, content, access_token);
                var data = JsonConvert.DeserializeObject<TModel>(json, GetConverter());
                var result = new OkApiResult<TModel>(data);

                callback?.Invoke(result);

                return result;
            }
            catch (Exception ex)
            {
                return new InvalidApiResult<TModel>(ex);
            }
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <param name="apiRoute"></param>
        /// <param name="access_token"></param>
        /// <returns></returns>
        private async Task<string> GetAsync(string apiRoute, string access_token = "")
        {
            var url = _apiUrlBase + "/" + apiRoute;

            _restClient = _restClient ?? new HttpClient();
            _restClient.BaseAddress = new Uri(url);

            ClearReponseHeaders();
            AddReponseHeaders();

            if (!string.IsNullOrEmpty(access_token))
                _restClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", access_token);
            var response = await _restClient.GetAsync(_restClient.BaseAddress);
            response.EnsureSuccessStatusCode();
            var data = response.Content.ReadAsStringAsync().Result;

            return data;
        }

        /// <summary>
        /// PostAsync
        /// </summary>
        /// <param name="apiRoute"></param>
        /// <param name="content"></param>
        /// <param name="access_token"></param>
        /// <returns></returns>
        private async Task<string> PostAsync(string apiRoute, HttpContent content, string access_token)
        {
            var url = _apiUrlBase + "/" + apiRoute;

            using (_restClient = new HttpClient())
            {
                _restClient.BaseAddress = new Uri(url);

                ClearReponseHeaders();
                AddReponseHeaders();

                if (!string.IsNullOrEmpty(access_token))
                    _restClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", access_token);

                var response = await _restClient.PostAsync(_restClient.BaseAddress, content);

                response.EnsureSuccessStatusCode();
                var data = response.Content.ReadAsStringAsync().Result;

                return data;

            }
        }

        /// <summary>
        /// GetConverter
        /// </summary>
        /// <returns></returns>
        private IsoDateTimeConverter GetConverter()
        {
            return new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" };
        }

        /// <summary>
        /// UseSufix
        /// </summary>
        /// <param name="urlSufix"></param>
        /// <returns></returns>
        public IApiClient UseSufix(string urlSufix)
        {
            if (!_apiUrlBase.EndsWith(urlSufix))
            {
                _apiUrlBase = _apiUrlBase + "/" + urlSufix;
            }

            return this;
        }

        /// <summary>
        /// AddReponseHeaders
        /// </summary>
        private void AddReponseHeaders() { }

        private void ClearReponseHeaders()
        {
            _restClient.DefaultRequestHeaders.Clear();
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose() { }
    }
}