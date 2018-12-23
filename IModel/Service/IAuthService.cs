using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IModel.Service
{
    public interface IAuthService
    {
        bool Authorize(HttpRequestMessage request);
    }
}
