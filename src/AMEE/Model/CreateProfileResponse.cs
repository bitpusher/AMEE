using Newtonsoft.Json;

namespace AMEE.Model
{
    public class CreateProfileResponse
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion { get; set; }

        [JsonProperty("profile")]
        public Profile Profile { get; set; }
    }
}