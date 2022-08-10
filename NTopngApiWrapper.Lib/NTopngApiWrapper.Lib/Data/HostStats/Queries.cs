using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.HostStats;

public class Queries
{
    [JsonPropertyName("num_txt")]
    public int NumTxt { get; set; }

    [JsonPropertyName("num_ns")]
    public int NumNs { get; set; }

    [JsonPropertyName("num_any")]
    public int NumAny { get; set; }

    [JsonPropertyName("num_ptr")]
    public int NumPtr { get; set; }

    [JsonPropertyName("num_aaaa")]
    public int NumAaaa { get; set; }

    [JsonPropertyName("num_soa")]
    public int NumSoa { get; set; }

    [JsonPropertyName("num_a")]
    public int NumA { get; set; }

    [JsonPropertyName("num_mx")]
    public int NumMx { get; set; }

    [JsonPropertyName("num_cname")]
    public int NumCname { get; set; }

    [JsonPropertyName("num_other")]
    public int NumOther { get; set; }
}