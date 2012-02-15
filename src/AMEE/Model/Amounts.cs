using Newtonsoft.Json;

namespace AMEE.Model
{
    public class Amounts
    {
        [JsonProperty("amount")]
        public Amount[] Amount { get; set; }
        [JsonProperty("note")]
        public Note[] note { get; set; }
    }
}