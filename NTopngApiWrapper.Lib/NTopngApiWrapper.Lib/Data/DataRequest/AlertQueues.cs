using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.DataRequest;

public class AlertQueues
{
    [JsonPropertyName("internal_alerts_queue")]
    public InternalAlertsQueue InternalAlertsQueue { get; set; }
}