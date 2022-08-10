using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.DataRequest;

public class TcpPacketStats
{
    [JsonPropertyName("retransmissions")]
    public int Retransmissions { get; set; }

    [JsonPropertyName("lost")]
    public int Lost { get; set; }

    [JsonPropertyName("out_of_order")]
    public int OutOfOrder { get; set; }
}