using System.Text.Json.Serialization;

namespace SiliconPower.ResponseModels
{
    public class DataModel
    {
        [JsonPropertyName("status")]
        public StatusModel Status { get; set; }
        [JsonPropertyName("data")]
        public object Data { get; set; }
    }
}
