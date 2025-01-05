using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain.Issue
{

    public class Transition : KeyBase
    {

        [JsonProperty("fields")] public TransitionFields Fields { get; set; }

        [JsonProperty("to")] public Status To { get; set; }
    }
}