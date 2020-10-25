using RestSharp;
using System;

namespace ClientService
{
    public class Client : IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="service"></param>
        /// <returns></returns>
        public T GetServiceData<T>(string service)
        {
            IRestClient client = new RestClient($"{service}");
            IRestRequest request = new RestRequest(Method.GET)
            {
                RequestFormat = DataFormat.Json
            };
            IRestResponse<T> resp = client.Execute<T>(request);
            return resp.Data;
        }
    }
}
