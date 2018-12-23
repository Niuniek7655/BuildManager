using Constans;
using IModel.Repositories;
using Model.Encryption;
using Model.HttpComunication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static Constans.URLApiAdress;
using static Constans.ConstansValues;
using Model.RegisterKey;
using System.Net;
using Newtonsoft.Json;

namespace Model.Repositories
{
    public class UsersRepositories : IUsersRepositories
    {
        async public Task<LogInStatus> TryLogIn(string logIn, string password)
        {
            var encryptionLogIn = EncryptionService.Encrypt(logIn, EncryptionPassword);
            var encryptionPassword = EncryptionService.Encrypt(password, EncryptionPassword);
            var encryptionApiPassword = EncryptionService.Encrypt(ApiPassword, EncryptionPassword);

            var requestbBuilder = new HttpRequestMessageBuilder(HttpMethod.Get, $"{LogInEndpoint}/{LogInToSystem}");
            var request = requestbBuilder
                               .AddHeader(LogInHeader, encryptionLogIn)
                               .AddHeader(PasswordHeader, encryptionPassword)
                               .AddHeader(ApiHeader, encryptionApiPassword)
                               .Make();

            var webApiAdress = RegisterKeyReader.GetValueFromLocalMachineRegistry(BuildManagerKeys, WebApiKey);
            using (var api = new ApiService(webApiAdress))
            {
                var response = await api.SendAsync(request).ConfigureAwait(false);
                if(response.StatusCode == HttpStatusCode.OK)
                {
                    var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    var result = JsonConvert.DeserializeObject<LogInStatus>(content);
                    return result;
                }
                else
                {
                    return LogInStatus.AnotherNotAuthorizationStatus;
                }
            }
        }
    }
}
