using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.HostStats;

public class NumBlacklistedFlows
{
    [JsonPropertyName("as_server")]
    public int AsServer { get; set; }

    [JsonPropertyName("tot_as_server")]
    public int TotAsServer { get; set; }

    [JsonPropertyName("tot_as_client")]
    public int TotAsClient { get; set; }

    [JsonPropertyName("as_client")]
    public int AsClient { get; set; }
}