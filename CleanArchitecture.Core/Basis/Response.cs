using System.Net;

namespace CleanArchitecture.Core.Basis
{
    public class Response<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public object Meta { get; set; }
        public bool Succeded { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
        public T Data { get; set; }
        public Response()
        {
        }
        public Response(string? message)
        {
            Succeded = false;
            Message = message;
        }
        public Response(string message, bool success)
        {
            Succeded = success;
            Message = message;
        }
        public Response(string message, T respose)
        {
            Succeded = true;
            Message = message;
            Data = respose;
        }
    }
}
