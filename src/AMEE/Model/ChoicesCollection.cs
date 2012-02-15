using System.Collections.Generic;
using Newtonsoft.Json;

namespace AMEE.Model
{
    public class ChoicesCollection
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("choices")]
        public List<ValueItem> Choices { get; set; }
    }
}