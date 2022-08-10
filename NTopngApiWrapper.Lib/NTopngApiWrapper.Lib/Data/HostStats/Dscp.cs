using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.HostStats;

public class Dscp
{
    [JsonPropertyName("cs0")]
    public Cs0 Cs0 { get; set; }
    
}