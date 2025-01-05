using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain
{


    public class Attachment
    {
        [JsonProperty("author")]
        private User Author { get; set; }

        [JsonProperty("content")]
        private string Content { get; set; }

        [JsonProperty("created")]
        private string Created { get; set; }

        [JsonProperty("filename")]
        private string Filename { get; set; }

        [JsonProperty("id")]
        private string Id { get; set; }

        [JsonProperty("self")]
        private string Self { get; set; }

        [JsonProperty("size")]
        private string Size { get; set; }

        [JsonProperty("thumbmail")]
        private string Thumbnail { get; set; }
    }

}