using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Snap.Net.Afdian
{
    public class AfdianRequestInfo
    {
        public AfdianRequestInfo(string method, string url, Func<Task<HttpResponseMessage>> httpResponseMessage)
        {
            this.Method = method;
            this.Url = url;
            this.RequestAsyncFunc = httpResponseMessage;
        }

        public string Method { get; set; }
        public string Url { get; set; }
        public Func<Task<HttpResponseMessage>> RequestAsyncFunc { get; set; }
    }
}