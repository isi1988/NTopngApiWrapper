using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.FlowSankeyRequest;

public class Link
{
    [JsonPropertyName("source")]
    public int Source { get; set; }

    [JsonPropertyName("target")]
    public int Target { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }

    [JsonPropertyName("sent")]
    public int Sent { get; set; }

    [JsonPropertyName("rcvd")]
    public int Rcvd { get; set; }
}