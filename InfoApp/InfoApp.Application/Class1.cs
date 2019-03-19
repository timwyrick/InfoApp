using System;
using System.Net;

namespace InfoApp.Application
{
    [Serializable]
    public class HttpResult
    {
        public  HttpStatusCode Status { get; set; }
        public string ErrorMessage { get; set; }
    }

    [Serializable]
    public class HttpResult<T> : HttpResult
    {
        public T Date { get; set; }
    }
}
