using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.HostStats;

public class Size
{
    [JsonPropertyName("upTo9000")]
    public int UpTo9000 { get; set; }

    [JsonPropertyName("upTo1024")]
    public int UpTo1024 { get; set; }

    [JsonPropertyName("upTo64")]
    public int UpTo64 { get; set; }

    [JsonPropertyName("upTo128")]
    public int UpTo128 { get; set; }

    [JsonPropertyName("upTo2500")]
    public int UpTo2500 { get; set; }

    [JsonPropertyName("upTo512")]
    public int UpTo512 { get; set; }

    [JsonPropertyName("upTo1518")]
    public int UpTo1518 { get; set; }

    [JsonPropertyName("upTo256")]
    public int UpTo256 { get; set; }

    [JsonPropertyName("above9000")]
    public int Above9000 { get; set; }

    [JsonPropertyName("upTo6500")]
    public int UpTo6500 { get; set; }
}