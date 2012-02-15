using Newtonsoft.Json;

namespace AMEE.Model
{
    public class Note
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

    }
}