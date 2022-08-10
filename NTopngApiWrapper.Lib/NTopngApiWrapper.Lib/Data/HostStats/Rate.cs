using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.HostStats;

public class Rate
{
    [JsonPropertyName("query")]
    public Query Query { get; set; }

    [JsonPropertyName("response")]
    public Response Response { get; set; }
}