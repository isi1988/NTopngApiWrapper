using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.HostStats;

public class NdpiCategories
{
    [JsonPropertyName("Unspecified")]
    public Unspecified Unspecified { get; set; }

    [JsonPropertyName("Web")]
    public Web Web { get; set; }

    [JsonPropertyName("System")]
    public System System { get; set; }
}