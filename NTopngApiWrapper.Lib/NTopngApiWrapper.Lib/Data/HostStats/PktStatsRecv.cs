using System.Drawing;
using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.HostStats;

public class PktStatsRecv
{
    [JsonPropertyName("tcp_flags")]
    public TcpFlags TcpFlags { get; set; }

    [JsonPropertyName("size")]
    public Size Size { get; set; }
}