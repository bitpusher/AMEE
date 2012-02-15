using Newtonsoft.Json;

namespace AMEE.Model
{
    public class User
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}