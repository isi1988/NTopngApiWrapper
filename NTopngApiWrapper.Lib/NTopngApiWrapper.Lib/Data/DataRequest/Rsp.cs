using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.DataRequest;

public class Rsp
{
    [JsonPropertyName("num_local_hosts")]
        public int NumLocalHosts { get; set; }

        [JsonPropertyName("macs_pctg")]
        public int MacsPctg { get; set; }

        [JsonPropertyName("alerted_flows_warning")]
        public int AlertedFlowsWarning { get; set; }

        [JsonPropertyName("packets")]
        public int Packets { get; set; }

        [JsonPropertyName("bytes_upload")]
        public int BytesUpload { get; set; }

        [JsonPropertyName("throughput")]
        public Throughput Throughput { get; set; }

        [JsonPropertyName("hosts_pctg")]
        public int HostsPctg { get; set; }

        [JsonPropertyName("num_flows")]
        public int NumFlows { get; set; }

        [JsonPropertyName("flow_dropped_alerts")]
        public int FlowDroppedAlerts { get; set; }

        [JsonPropertyName("alerted_flows_notice")]
        public int AlertedFlowsNotice { get; set; }

        [JsonPropertyName("throughput_bps")]
        public double ThroughputBps { get; set; }

        [JsonPropertyName("engaged_alerts_warning")]
        public int EngagedAlertsWarning { get; set; }

        [JsonPropertyName("is_view")]
        public bool IsView { get; set; }

        [JsonPropertyName("drops")]
        public int Drops { get; set; }

        [JsonPropertyName("remote_bps")]
        public int RemoteBps { get; set; }

        [JsonPropertyName("packets_upload")]
        public int PacketsUpload { get; set; }

        [JsonPropertyName("download_upload_chart")]
        public DownloadUploadChart DownloadUploadChart { get; set; }

        [JsonPropertyName("localtime")]
        public string Localtime { get; set; }

        [JsonPropertyName("active_discovery_active")]
        public bool ActiveDiscoveryActive { get; set; }

        [JsonPropertyName("system_host_stats")]
        public SystemHostStats SystemHostStats { get; set; }

        [JsonPropertyName("remote2local")]
        public int Remote2local { get; set; }

        [JsonPropertyName("epoch")]
        public int Epoch { get; set; }

        [JsonPropertyName("num_remote_hosts_anomalies")]
        public int NumRemoteHostsAnomalies { get; set; }

        [JsonPropertyName("num_local_hosts_anomalies")]
        public int NumLocalHostsAnomalies { get; set; }

        [JsonPropertyName("packets_download")]
        public int PacketsDownload { get; set; }

        [JsonPropertyName("bytes_download")]
        public int BytesDownload { get; set; }

        [JsonPropertyName("engaged_alerts_notice")]
        public int EngagedAlertsNotice { get; set; }

        [JsonPropertyName("alerted_flows_error")]
        public int AlertedFlowsError { get; set; }

        [JsonPropertyName("tcpPacketStats")]
        public TcpPacketStats TcpPacketStats { get; set; }

        [JsonPropertyName("local2remote")]
        public int Local2remote { get; set; }

        [JsonPropertyName("num_live_captures")]
        public int NumLiveCaptures { get; set; }

        [JsonPropertyName("alerted_flows")]
        public int AlertedFlows { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("engaged_alerts")]
        public int EngagedAlerts { get; set; }

        [JsonPropertyName("num_hosts")]
        public int NumHosts { get; set; }

        [JsonPropertyName("remote_pps")]
        public int RemotePps { get; set; }

        [JsonPropertyName("periodic_stats_update_frequency_secs")]
        public int PeriodicStatsUpdateFrequencySecs { get; set; }

        [JsonPropertyName("flows_pctg")]
        public int FlowsPctg { get; set; }

        [JsonPropertyName("throughput_pps")]
        public double ThroughputPps { get; set; }

        [JsonPropertyName("dropped_alerts")]
        public int DroppedAlerts { get; set; }

        [JsonPropertyName("ifid")]
        public string Ifid { get; set; }

        [JsonPropertyName("uptime")]
        public string Uptime { get; set; }

        [JsonPropertyName("num_devices")]
        public int NumDevices { get; set; }

        [JsonPropertyName("bytes")]
        public int Bytes { get; set; }

        [JsonPropertyName("host_dropped_alerts")]
        public int HostDroppedAlerts { get; set; }

        [JsonPropertyName("other_dropped_alerts")]
        public int OtherDroppedAlerts { get; set; }

        [JsonPropertyName("engaged_alerts_error")]
        public int EngagedAlertsError { get; set; }

        [JsonPropertyName("ifname")]
        public string Ifname { get; set; }
}