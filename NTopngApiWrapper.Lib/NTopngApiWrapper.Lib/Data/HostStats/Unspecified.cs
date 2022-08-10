using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.HostStats;

public class Unspecified
{
    [JsonPropertyName("duration")]
    public int Duration { get; set; }

    [JsonPropertyName("category")]
    public int Category { get; set; }

    [JsonPropertyName("bytes")]
    public int Bytes { get; set; }

    [JsonPropertyName("bytes.rcvd")]
    public int BytesRcvd { get; set; }

    [JsonPropertyName("bytes.sent")]
    public int BytesSent { get; set; }
}