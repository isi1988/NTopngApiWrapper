using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.HostStats;

public class Response
{
    [JsonPropertyName("2xx")]
    public int _2xx { get; set; }

    [JsonPropertyName("1xx")]
    public int _1xx { get; set; }

    [JsonPropertyName("5xx")]
    public int _5xx { get; set; }

    [JsonPropertyName("4xx")]
    public int _4xx { get; set; }

    [JsonPropertyName("3xx")]
    public int _3xx { get; set; }

    [JsonPropertyName("num_3xx")]
    public int Num3xx { get; set; }

    [JsonPropertyName("num_1xx")]
    public int Num1xx { get; set; }

    [JsonPropertyName("num_2xx")]
    public int Num2xx { get; set; }

    [JsonPropertyName("num_5xx")]
    public int Num5xx { get; set; }

    [JsonPropertyName("num_4xx")]
    public int Num4xx { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }
}