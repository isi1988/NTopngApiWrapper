using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.HostStats;

public class Receiver
{
    [JsonPropertyName("rate")]
    public Rate Rate { get; set; }

    [JsonPropertyName("query")]
    public Query Query { get; set; }

    [JsonPropertyName("response")]
    public Response Response { get; set; }
}