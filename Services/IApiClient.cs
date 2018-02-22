using ConceptaApi.Models.Result;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConceptaApi.Services
{
    /// <summary>
    /// IApiClient
    /// </summary>
    public interface IApiClient : IDisposable
    {
        /// <summary>
        /// GetAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="apiRoute"></param>
        /// <param name="access_token"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        Task<BaseApiResult<T>> GetAsync<T>(string apiRoute, string access_token = "", Action<BaseApiResult<T>> callback = null);

        /// <summary>
        /// PostAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="apiRoute"></param>
        /// <param name="content"></param>
        /// <param name="access_token"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        Task<BaseApiResult<T>> PostAsync<T>(string apiRoute, HttpContent content, string access_token = "", Action<BaseApiResult<T>> callback = null);

        /// <summary>
        /// UseSufix
        /// </summary>
        /// <param name="urlSufix"></param>
        /// <returns></returns>
        IApiClient UseSufix(string urlSufix);
    }
}