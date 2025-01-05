using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain.Issue
{

    public class Attachment
    {
        [JsonProperty("self")] public string Self { get; set; }
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("filename")] public string Filename { get; set; }
        [JsonProperty("author")] public User Author { get; set; }
        [JsonProperty("created")] public string Created { get; set; }
        [JsonProperty("size")] public int? Size { get; set; }
        [JsonProperty("mimetype")] public string MimeType { get; set; }
        [JsonProperty("content")] public string Content { get; set; }
        [JsonProperty("thumbnail")] public string Thumbnail { get; set; }
    }
}