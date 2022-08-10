using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.HostStats;

public class ContactedHostsBehaviour
{
    [JsonPropertyName("upper_bound")]
    public int UpperBound { get; set; }

    [JsonPropertyName("lower_bound")]
    public int LowerBound { get; set; }

    [JsonPropertyName("anomaly")]
    public bool Anomaly { get; set; }

    [JsonPropertyName("value")]
    public double Value { get; set; }
}