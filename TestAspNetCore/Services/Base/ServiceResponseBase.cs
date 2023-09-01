using System.Net;

namespace TestAspNetCore.Services.Base
{
    /// <summary>
    /// Service 回傳 Controller 使用
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ServiceResponseBase<T>
    {

        public bool HasError { get; set; }

        public HttpStatusCode StatusCode { get; set; }

        public string Message { get; set; }

        public T ReturnData { get; set; }

        public int? MessageCode { get; set; }

        public ServiceResponseBase()
        {
            this.StatusCode = HttpStatusCode.OK;
            this.HasError = false;
            ReturnData = default;
        }
    }
}
