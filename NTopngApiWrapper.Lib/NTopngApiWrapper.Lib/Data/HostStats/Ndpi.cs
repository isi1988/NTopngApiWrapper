using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.HostStats;

public class Ndpi
{
    [JsonPropertyName("HTTP")]
    public Http HTTP { get; set; }

    [JsonPropertyName("Unknown")]
    public Unknown Unknown { get; set; }

    [JsonPropertyName("SMBv1")]
    public SMBv1 SMBv1 { get; set; }

    [JsonPropertyName("ntop")]
    public Ntop Ntop { get; set; }
}