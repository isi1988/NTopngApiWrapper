using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.HostStats;

public class ServerContacts
{
    [JsonPropertyName("dns")]
    public int Dns { get; set; }

    [JsonPropertyName("domain_names")]
    public int DomainNames { get; set; }

    [JsonPropertyName("smtp")]
    public int Smtp { get; set; }

    [JsonPropertyName("ntp")]
    public int Ntp { get; set; }
}