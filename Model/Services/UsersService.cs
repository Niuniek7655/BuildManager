using Constans;
using IModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Encryption;
using static Constans.ConstansValues;

namespace Model.Services
{
    public class UsersService
    {
        public LogInStatus AutoriseUser(IEnumerable<IUser> users, string encryptionLogIn, string encryptionPassword)
        {
            foreach(var user in users)
            {
                user.UserName = EncryptionService.Decrypt(user.UserName, EncryptionPassword);
                user.Password = EncryptionService.Decrypt(user.Password, EncryptionPassword);
            }

            var logIn = EncryptionService.Decrypt(encryptionLogIn, EncryptionPassword);
            var similarUsersLogIn = users.Where(x => x.UserName.Equals(logIn));
            if(similarUsersLogIn.Count() == 0)
            {
                return LogInStatus.UserNotExist;
            }

            var password = EncryptionService.Decrypt(encryptionPassword, EncryptionPassword);
            var searchUser = similarUsersLogIn.Where(x => x.Password.Equals(password)).SingleOrDefault();
            if(searchUser != null)
            {
                return LogInStatus.CorrectAuthorization;
            }
            else
            {
                return LogInStatus.IncorrectPassword;
            }
        }
    }
}
