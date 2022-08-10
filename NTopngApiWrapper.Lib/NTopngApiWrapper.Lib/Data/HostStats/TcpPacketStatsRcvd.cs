using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.HostStats;

public class TcpPacketStatsRcvd
{
    [JsonPropertyName("keep_alive")]
    public int KeepAlive { get; set; }

    [JsonPropertyName("out_of_order")]
    public int OutOfOrder { get; set; }

    [JsonPropertyName("lost")]
    public int Lost { get; set; }

    [JsonPropertyName("retransmissions")]
    public int Retransmissions { get; set; }
}