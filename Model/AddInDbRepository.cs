//using DPS.ConstantValues;
//using DPS.Tools.API;
//using DPS.Tools.Encryption;
//using DPS.Tools.SessionTool;
//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;
//using static DPS.ConstantValues.Constans;

//namespace DPS.EdytorBom.Helpers.Repositories.AddInDb
//{
//    public class AddInDbRepository : IAddInDbRepository
//    {
//        public async Task<bool> CheckConnection()
//        {
//            return await CheckConnectionAsync();
//        }

//        async public Task<bool> CheckConnectionAsync()
//        {
//            var addInConnectionString = Session.Instance.AddinConnectionString;
//            var webApiAdress = Session.Instance.WebApiAdress;

//            var requestbBuilder = new HttpRequestMessageBuilder(HttpMethod.Post, $"api/configuration/checkconnection");
//            var request = requestbBuilder
//                               .AddHeader("connectionString", EncryptionService.Encrypt(addInConnectionString, EncryptionPassword))
//                               .AddHeader("database", ((int)Enum_DatabaseType.SQL_Server).ToString())
//                               .Make();

//            using (var api = new BetterApiService(webApiAdress))
//            {
//                var response = await api.SendAsync(request);
//                var content = await response.Content.ReadAsStringAsync();

//                if (response.StatusCode == System.Net.HttpStatusCode.OK)
//                {
//                    return JsonConvert.DeserializeObject<bool>(content);
//                }
//                else
//                {
//                    return false;
//                }
//            }
//        }
//    }
//}
