using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Model.HttpComunication
{
    public class HeaderFilter
    {
        public string GetHeader(HttpRequestHeaders headers, string headerName)
        {
            var headerValue = headers.FirstOrDefault(x => x.Key == headerName).Value?.First();
            return headerValue;
        }
    }
}
