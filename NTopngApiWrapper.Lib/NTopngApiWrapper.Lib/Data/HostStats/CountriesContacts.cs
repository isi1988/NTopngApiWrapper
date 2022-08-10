using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.HostStats;

public class CountriesContacts
{
    [JsonPropertyName("value")]
    public double Value { get; set; }
}