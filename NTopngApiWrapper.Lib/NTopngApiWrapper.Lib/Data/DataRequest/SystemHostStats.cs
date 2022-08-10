using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.DataRequest;

public class SystemHostStats
{
    [JsonPropertyName("alerts_stats")]
    public AlertsStats AlertsStats { get; set; }

    [JsonPropertyName("mem_used")]
    public int MemUsed { get; set; }

    [JsonPropertyName("mem_ntopng_resident")]
    public int MemNtopngResident { get; set; }

    [JsonPropertyName("written_alerts")]
    public int WrittenAlerts { get; set; }

    [JsonPropertyName("mem_total")]
    public int MemTotal { get; set; }

    [JsonPropertyName("dropped_alerts")]
    public int DroppedAlerts { get; set; }

    [JsonPropertyName("mem_ntopng_virtual")]
    public int MemNtopngVirtual { get; set; }

    [JsonPropertyName("alerts_queries")]
    public int AlertsQueries { get; set; }

    [JsonPropertyName("mem_buffers")]
    public int MemBuffers { get; set; }

    [JsonPropertyName("mem_sreclaimable")]
    public int MemSreclaimable { get; set; }

    [JsonPropertyName("mem_cached")]
    public int MemCached { get; set; }

    [JsonPropertyName("mem_free")]
    public int MemFree { get; set; }

    [JsonPropertyName("mem_shmem")]
    public int MemShmem { get; set; }

    [JsonPropertyName("cpu_load")]
    public double CpuLoad { get; set; }
}