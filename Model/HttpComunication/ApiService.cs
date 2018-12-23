using Model.Encryption;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using static Constans.ConstansValues;

namespace Model.HttpComunication
{
    public class ApiService : IDisposable
    {
        private HttpClient _http;
        private readonly JsonSerializerSettings _jsonSettings;

        public ApiService(string baseAdress)
        {
            _http = new HttpClient();
            _http.BaseAddress = new Uri(baseAdress);
            var encryptionApiPassword = EncryptionService.Encrypt(ApiPassword, EncryptionPassword);
            _http.DefaultRequestHeaders.Add(PasswordHeader, encryptionApiPassword);

            _jsonSettings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.Auto,
                ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                ObjectCreationHandling = ObjectCreationHandling.Auto
            };
        }

        async public Task<T> GetSingle<T>(HttpRequestMessage request)
        {
            _http.Timeout = Timeout.InfiniteTimeSpan;
            var response = await _http.SendAsync(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var data = await response.Content.ReadAsStringAsync();
                var deserializeObject = JsonConvert.DeserializeObject<T>(data, _jsonSettings);
                return deserializeObject;
            }
            return default(T);
        }

        async public Task<IEnumerable<T>> GetMany<T>(HttpRequestMessage request)
        {
            _http.Timeout = Timeout.InfiniteTimeSpan;
            var response = await _http.SendAsync(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var data = await response.Content.ReadAsStringAsync();
                var deserializeObject = JsonConvert.DeserializeObject<IEnumerable<T>>(data, _jsonSettings);
                return deserializeObject;
            }
            return new List<T>();
        }

        async public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
        {
            var response = await _http.SendAsync(request);
            return response;
        }

        public void Dispose()
        {
            _http.Dispose();
        }
    }
}
