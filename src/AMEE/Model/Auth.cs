using Newtonsoft.Json;

namespace AMEE.Model
{
    public class Auth
    {
        [JsonProperty("uid")]
        public string Uid;
        [JsonProperty("username")]
        public string Username;  
    }
}