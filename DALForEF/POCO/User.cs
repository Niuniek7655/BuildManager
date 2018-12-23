using IModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DALForEF.POCO
{
    public class User : IUser
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}