using System.Net.Http;
using System.Text;

namespace Model.HttpComunication
{
    public class HttpRequestMessageBuilder
    {
        private HttpRequestMessage req;
        public HttpRequestMessageBuilder(HttpMethod method, string uri)
        {
            req = new HttpRequestMessage(method, uri);
        }

        public HttpRequestMessageBuilder AddHeader(string name, string value)
        {
            req.Headers.Add(name, value);
            return this;
        }

        public HttpRequestMessageBuilder AddContent(string content, Encoding encoding, string mediaType)
        {
            var httpContent = new StringContent(content, encoding, mediaType);
            req.Content = httpContent;
            return this;
        }

        public HttpRequestMessage Make()
        {
            return req;
        }
    }
}
