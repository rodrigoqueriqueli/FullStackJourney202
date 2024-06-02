using System.Text.Json.Serialization;

namespace SmartFinancial.Core.Responses
{
    //Response<Category>
    //Response<Transaction>
    public class Response<TData>
    {
        private int _statusCode = Configuration.DefaultStatusCode;

        //Annotation to inform Asp which constructor should be used to convert to json
        [JsonConstructor]
        public Response()
               => _statusCode = Configuration.DefaultStatusCode;

        public Response(TData? data,
            int code = Configuration.DefaultStatusCode,
            string? message = null)
        {
            Data = data;
            _statusCode = code;
            Message = message;
        }

        public TData? Data { get; set; }
        public string? Message { get; set; }

        [JsonIgnore]
        public bool IsSuccess
            => _statusCode is >= 200 and <= 299;
    }
}
