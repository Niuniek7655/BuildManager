using Model.Encryption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using static Constans.ConstansValues;

namespace DALForEF.Models
{
    public class AuthService
    {
        public bool Authorize(HttpRequestMessage request)
        {
            var encryptedPassword = request.Headers.FirstOrDefault(h => h.Key == ApiHeader).Value?.First();
            if (string.IsNullOrEmpty(encryptedPassword))
            {
                return false;
            }
            else
            {
                var password = EncryptionService.Decrypt(encryptedPassword, EncryptionPassword);
                var authorizationResult = password.Equals(ApiPassword);
                return authorizationResult;
            }
        }
    }
}