using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.FlowSankeyRequest;

public class Node
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("host")]
    public string Host { get; set; }

    [JsonPropertyName("vlan")]
    public string Vlan { get; set; }
}