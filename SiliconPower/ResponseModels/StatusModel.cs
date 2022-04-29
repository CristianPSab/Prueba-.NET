using System.Text.Json.Serialization;

namespace SiliconPower.ResponseModels
{
    public class StatusModel
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
