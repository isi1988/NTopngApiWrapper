using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.HostStats;

public class Cs0
{
    [JsonPropertyName("bytes.rcvd")]
    public int BytesRcvd { get; set; }

    [JsonPropertyName("packets.sent")]
    public int PacketsSent { get; set; }

    [JsonPropertyName("packets.rcvd")]
    public int PacketsRcvd { get; set; }

    [JsonPropertyName("bytes.sent")]
    public int BytesSent { get; set; }
}