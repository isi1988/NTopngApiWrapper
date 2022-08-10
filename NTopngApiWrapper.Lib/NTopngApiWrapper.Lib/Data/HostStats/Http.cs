using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.HostStats;

public class Http
{
    [JsonPropertyName("virtual_hosts")]
    public List<object> VirtualHosts { get; set; }

    [JsonPropertyName("sender")]
    public Sender Sender { get; set; }

    [JsonPropertyName("receiver")]
    public Receiver Receiver { get; set; }
}