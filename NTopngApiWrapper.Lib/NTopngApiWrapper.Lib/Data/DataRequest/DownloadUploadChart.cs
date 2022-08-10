using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.DataRequest;

public class DownloadUploadChart
{
    [JsonPropertyName("download")]
    public List<int> Download { get; set; }

    [JsonPropertyName("upload")]
    public List<int> Upload { get; set; }
}