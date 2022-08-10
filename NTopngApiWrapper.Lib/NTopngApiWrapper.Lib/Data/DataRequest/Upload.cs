using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.DataRequest;

public class Upload
{
    [JsonPropertyName("bps")]
    public double Bps { get; set; }

    [JsonPropertyName("pps")]
    public double Pps { get; set; }
}