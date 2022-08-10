using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.HostStats;

public class TcpFlags
{
    [JsonPropertyName("finack")]
    public int Finack { get; set; }

    [JsonPropertyName("syn")]
    public int Syn { get; set; }

    [JsonPropertyName("rst")]
    public int Rst { get; set; }

    [JsonPropertyName("synack")]
    public int Synack { get; set; }   
}