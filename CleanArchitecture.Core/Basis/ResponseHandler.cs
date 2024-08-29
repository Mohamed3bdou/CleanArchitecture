namespace CleanArchitecture.Core.Basis
{
    public class ResponseHandler
    {
        public ResponseHandler()
        {
        }
        public Response<T> Deleted<T>(string? message)
        {
            return new Response<T>
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Succeded = true,
                Message = string.IsNullOrEmpty(message) ? "Item Deleted Successfully!" : message
            };
        }
        public Response<T> Success<T>(T response, object meta = null)
        {
            return new Response<T>
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Data = response,
                Succeded = true,
                Message = "Operation done successfully!",
                Meta = meta
            };
        }
        public Response<T> UnAuthorized<T>()
        {
            return new Response<T>
            {
                StatusCode = System.Net.HttpStatusCode.Unauthorized,
                Succeded = true,
                Message = "Unauthorized!"
            };
        }
        public Response<T> BadRequest<T>(string message = null)
        {
            return new Response<T>
            {
                StatusCode = System.Net.HttpStatusCode.BadRequest,
                Succeded = false,
                Message = string.IsNullOrEmpty(message) ? "Bad Request!" : message
            };
        }
        public Response<T> Found<T>(T entity)
        {
            return new Response<T>()
            {
                Data = entity,
                StatusCode = System.Net.HttpStatusCode.Found,
                Succeded = true,
                Message = "Found!"
            };
        }
        public Response<T> NotFound<T>(string message = null)
        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.NotFound,
                Succeded = false,
                Message = message == null ? "Not Found" : message
            };
        }
        public Response<T> Creaetd<T>(T entity, object meta = null)
        {
            return new Response<T>()
            {
                Data = entity,
                StatusCode = System.Net.HttpStatusCode.Created,
                Succeded = true,
                Message = "Created!",
                Meta = meta
            };
        }
    }
}
