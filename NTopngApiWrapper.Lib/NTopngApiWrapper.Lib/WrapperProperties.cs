using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib;

public class WrapperProperties
{
    [JsonPropertyName("ntopnghost")]
    public string NTopngHost { get; set; } = String.Empty;
    
    [JsonPropertyName("ntopnglogin")]
    public string NTopngLogin { get; set; } = String.Empty;
    
    [JsonPropertyName("ntopngpassword")]
    public string NTopngPassword { get; set; } = String.Empty;
}