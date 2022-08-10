using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.DataRequest;

public class InternalAlertsQueue
{
    [JsonPropertyName("pct_not_enqueued")]
    public int PctNotEnqueued { get; set; }
}