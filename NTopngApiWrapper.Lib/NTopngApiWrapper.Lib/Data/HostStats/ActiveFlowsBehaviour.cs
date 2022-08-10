using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.HostStats;

public class ActiveFlowsBehaviour
{
    [JsonPropertyName("as_server")]
    public AsServer AsServer { get; set; }

    [JsonPropertyName("tot_num_anomalies")]
    public int TotNumAnomalies { get; set; }

    [JsonPropertyName("as_client")]
    public AsClient AsClient { get; set; }
}