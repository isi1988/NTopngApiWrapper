using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.DataRequest;

public class AlertsStats
{
    [JsonPropertyName("alert_queues")]
    public AlertQueues AlertQueues { get; set; }
}