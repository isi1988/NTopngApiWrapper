using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.DataRequest;

public class Throughput
{
    [JsonPropertyName("download")]
    public Download Download { get; set; }

    [JsonPropertyName("upload")]
    public Upload Upload { get; set; }
}