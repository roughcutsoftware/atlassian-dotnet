using System.Collections.Generic;
using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain.Issue
{

    public class History : Base
    {
        [JsonProperty("author")] public User Author { get; set; }

        [JsonProperty("created")] public string Created { get; set; }

        [JsonProperty("items")] public List<Item> Items { get; set; }
    }
}