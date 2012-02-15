using Newtonsoft.Json;

namespace AMEE.Model
{
    public class Group
    {
        [JsonProperty("uid")]
        public string Uid;
        [JsonProperty("name")]
        public string Name;
    }
}