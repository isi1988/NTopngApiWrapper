using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.HostStats;

public class Query
{
    [JsonPropertyName("other")]
    public int Other { get; set; }

    [JsonPropertyName("get")]
    public int Get { get; set; }

    [JsonPropertyName("head")]
    public int Head { get; set; }

    [JsonPropertyName("put")]
    public int Put { get; set; }

    [JsonPropertyName("post")]
    public int Post { get; set; }

    [JsonPropertyName("num_post")]
    public int NumPost { get; set; }

    [JsonPropertyName("num_other")]
    public int NumOther { get; set; }

    [JsonPropertyName("num_put")]
    public int NumPut { get; set; }

    [JsonPropertyName("num_get")]
    public int NumGet { get; set; }

    [JsonPropertyName("num_head")]
    public int NumHead { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }
}