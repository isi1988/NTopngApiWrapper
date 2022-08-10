using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.FlowSankeyRequest;

public class Root
{
    [JsonPropertyName("nodes")]
    public List<Node> Nodes { get; set; }

    [JsonPropertyName("links")]
    public List<Link> Links { get; set; }
}