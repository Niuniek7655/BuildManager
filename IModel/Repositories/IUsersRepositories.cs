using Constans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IModel.Repositories
{
    public interface IUsersRepositories
    {
        Task<LogInStatus> TryLogIn(string logIn, string password);
    }
}
