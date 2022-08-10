using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.HostStats;

public class ScoreBreakdownServer
{
    [JsonPropertyName("1")]
    public double _1 { get; set; }

    [JsonPropertyName("0")]
    public double _0 { get; set; }
}