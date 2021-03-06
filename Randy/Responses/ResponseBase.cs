using System;
using System.Text.Json.Serialization;
using Randy.Responses.Abstractions;

namespace Randy.Responses
{
    public class ResponseBase : IResponse
    {
        [JsonPropertyName("result")]
        public ResultInfo ResultInfo { get; set; } = new ResultInfo();
        public string JsonResponse { get; set; }
        public int Id { get; set; }
        public DateTime CompletionTime { get; set; }
    }
}