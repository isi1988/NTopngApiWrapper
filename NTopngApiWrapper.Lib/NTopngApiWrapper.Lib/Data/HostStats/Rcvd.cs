using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.HostStats;

public class Rcvd
{
    [JsonPropertyName("num_replies_ok")]
    public int NumRepliesOk { get; set; }

    [JsonPropertyName("queries")]
    public Queries Queries { get; set; }

    [JsonPropertyName("num_queries")]
    public int NumQueries { get; set; }

    [JsonPropertyName("num_replies_error")]
    public int NumRepliesError { get; set; }
}