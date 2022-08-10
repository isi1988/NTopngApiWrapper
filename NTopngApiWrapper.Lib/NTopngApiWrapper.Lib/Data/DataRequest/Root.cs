using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.DataRequest;

public class Root
{
    [JsonPropertyName("rc_str_hr")]
    public string RcStrHr { get; set; }

    [JsonPropertyName("rsp")]
    public Rsp Rsp { get; set; }

    [JsonPropertyName("rc")]
    public int Rc { get; set; }

    [JsonPropertyName("rc_str")]
    public string RcStr { get; set; }
}