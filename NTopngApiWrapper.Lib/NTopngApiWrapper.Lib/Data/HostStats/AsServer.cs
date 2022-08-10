using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.HostStats;

public class AsServer
{
    [JsonPropertyName("upper_bound")]
    public int UpperBound { get; set; }

    [JsonPropertyName("lower_bound")]
    public int LowerBound { get; set; }

    [JsonPropertyName("anomaly")]
    public bool Anomaly { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }    
}