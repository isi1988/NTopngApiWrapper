using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.HostStats;

public class HTTP2
{
    [JsonPropertyName("duration")]
    public int Duration { get; set; }

    [JsonPropertyName("packets.sent")]
    public int PacketsSent { get; set; }

    [JsonPropertyName("breed")]
    public string Breed { get; set; }

    [JsonPropertyName("num_flows")]
    public int NumFlows { get; set; }

    [JsonPropertyName("bytes.rcvd")]
    public int BytesRcvd { get; set; }

    [JsonPropertyName("packets.rcvd")]
    public int PacketsRcvd { get; set; }

    [JsonPropertyName("bytes.sent")]
    public int BytesSent { get; set; }
}