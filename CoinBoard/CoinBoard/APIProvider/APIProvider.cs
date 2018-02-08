using CoinBoard.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using WebApiContrib.Formatting;

namespace CoinBoard.APIProvider
{
    public class APIProvider
    {
        private const string apiPrefix = @"v1/ticker/";

        public static async Task<T> Get<T>()
        {
            Uri _baseAddress = new Uri(ValuesConstant.API_URL);
            using (var httpClient = new HttpClient())
            {
                try
                {
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(ValuesConstant.ContentType));
                    httpClient.BaseAddress = _baseAddress;

                    var response = await httpClient.GetAsync(apiPrefix);

                    if (!response.IsSuccessStatusCode) return default(T); //Check status code

                    var data = response.Content.ReadAsAsync<T>(new[] { new ProtoBufFormatter() }).Result;

                    return (data == null ? default(T) : data);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}