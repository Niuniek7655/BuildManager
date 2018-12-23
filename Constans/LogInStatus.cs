using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constans
{
    public enum LogInStatus
    {
        UserNotExist = 0,
        IncorrectPassword = 1,
        CorrectAuthorization = 2,
        AnotherNotAuthorizationStatus = 3
    }
}
