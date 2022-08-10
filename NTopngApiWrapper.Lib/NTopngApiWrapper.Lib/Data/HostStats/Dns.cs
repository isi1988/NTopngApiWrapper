using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.HostStats;

public class Dns
{
    [JsonPropertyName("rcvd")]
    public Rcvd Rcvd { get; set; }

    [JsonPropertyName("sent")]
    public Sent Sent { get; set; }
}