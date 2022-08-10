using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.HostStats;

public class Root
{
     [JsonPropertyName("os_detail")]
        public string OsDetail { get; set; }

        [JsonPropertyName("ICMPv4")]
        public List<object> ICMPv4 { get; set; }

        [JsonPropertyName("udp.packets.sent")]
        public int UdpPacketsSent { get; set; }

        [JsonPropertyName("contacts.as_client")]
        public int ContactsAsClient { get; set; }

        [JsonPropertyName("ja3_fingerprint")]
        public List<object> Ja3Fingerprint { get; set; }

        [JsonPropertyName("asname")]
        public string Asname { get; set; }

        [JsonPropertyName("continent")]
        public string Continent { get; set; }

        [JsonPropertyName("broadcast_domain_host")]
        public bool BroadcastDomainHost { get; set; }

        [JsonPropertyName("tskey")]
        public string Tskey { get; set; }

        [JsonPropertyName("host_unreachable_flows.as_server")]
        public int HostUnreachableFlowsAsServer { get; set; }

        [JsonPropertyName("packets.rcvd")]
        public int PacketsRcvd { get; set; }

        [JsonPropertyName("total_alerts")]
        public int TotalAlerts { get; set; }

        [JsonPropertyName("total_flows.as_server")]
        public int TotalFlowsAsServer { get; set; }

        [JsonPropertyName("bytes.ndpi.unknown")]
        public int BytesNdpiUnknown { get; set; }

        [JsonPropertyName("hassh_fingerprint")]
        public List<object> HasshFingerprint { get; set; }

        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("udp.bytes.rcvd.anomaly_index")]
        public int UdpBytesRcvdAnomalyIndex { get; set; }

        [JsonPropertyName("observation_point_id")]
        public int ObservationPointId { get; set; }

        [JsonPropertyName("score.as_server")]
        public int ScoreAsServer { get; set; }

        [JsonPropertyName("local_network_name")]
        public string LocalNetworkName { get; set; }

        [JsonPropertyName("mac")]
        public string Mac { get; set; }

        [JsonPropertyName("throughput_trend_bps")]
        public int ThroughputTrendBps { get; set; }

        [JsonPropertyName("pktStats.sent")]
        public PktStatsSent PktStatsSent { get; set; }

        [JsonPropertyName("contacted_hosts_behaviour")]
        public ContactedHostsBehaviour ContactedHostsBehaviour { get; set; }

        [JsonPropertyName("local_network_id")]
        public int LocalNetworkId { get; set; }

        [JsonPropertyName("tcpPacketStats.sent")]
        public TcpPacketStatsSent TcpPacketStatsSent { get; set; }

        [JsonPropertyName("total_activity_time")]
        public int TotalActivityTime { get; set; }

        [JsonPropertyName("num_alerts")]
        public int NumAlerts { get; set; }

        [JsonPropertyName("systemhost")]
        public bool Systemhost { get; set; }

        [JsonPropertyName("udp.bytes.sent.anomaly_index")]
        public int UdpBytesSentAnomalyIndex { get; set; }

        [JsonPropertyName("pktStats.recv")]
        public PktStatsRecv PktStatsRecv { get; set; }

        [JsonPropertyName("flows.as_server")]
        public int FlowsAsServer { get; set; }

        [JsonPropertyName("score.as_client")]
        public int ScoreAsClient { get; set; }

        [JsonPropertyName("bytes.rcvd.anomaly_index")]
        public int BytesRcvdAnomalyIndex { get; set; }

        [JsonPropertyName("udp.bytes.rcvd")]
        public int UdpBytesRcvd { get; set; }

        [JsonPropertyName("icmp.bytes.sent")]
        public int IcmpBytesSent { get; set; }

        [JsonPropertyName("flows.as_client")]
        public int FlowsAsClient { get; set; }

        [JsonPropertyName("duration")]
        public int Duration { get; set; }

        [JsonPropertyName("throughput_bps")]
        public double ThroughputBps { get; set; }

        [JsonPropertyName("total_flows.as_client")]
        public int TotalFlowsAsClient { get; set; }

        [JsonPropertyName("num_flow_alerts")]
        public int NumFlowAlerts { get; set; }

        [JsonPropertyName("packets.sent")]
        public int PacketsSent { get; set; }

        [JsonPropertyName("other_ip.packets.rcvd")]
        public int OtherIpPacketsRcvd { get; set; }

        [JsonPropertyName("dhcpHost")]
        public bool DhcpHost { get; set; }

        [JsonPropertyName("contacts.as_server")]
        public int ContactsAsServer { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("packets.rcvd.anomaly_index")]
        public int PacketsRcvdAnomalyIndex { get; set; }

        [JsonPropertyName("seen.first")]
        public int SeenFirst { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("names")]
        public List<object> Names { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        [JsonPropertyName("http")]
        public Http Http { get; set; }

        [JsonPropertyName("privatehost")]
        public bool Privatehost { get; set; }

        [JsonPropertyName("bytes.sent.anomaly_index")]
        public int BytesSentAnomalyIndex { get; set; }

        [JsonPropertyName("score_pct")]
        public ScorePct ScorePct { get; set; }

        [JsonPropertyName("icmp.bytes.rcvd.anomaly_index")]
        public int IcmpBytesRcvdAnomalyIndex { get; set; }

        [JsonPropertyName("host_unreachable_flows.as_client")]
        public int HostUnreachableFlowsAsClient { get; set; }

        [JsonPropertyName("throughput_trend_pps")]
        public int ThroughputTrendPps { get; set; }

        [JsonPropertyName("bytes_ratio")]
        public double BytesRatio { get; set; }

        [JsonPropertyName("ip")]
        public string Ip { get; set; }

        [JsonPropertyName("active_http_hosts")]
        public int ActiveHttpHosts { get; set; }

        [JsonPropertyName("unreachable_flows.as_server")]
        public int UnreachableFlowsAsServer { get; set; }

        [JsonPropertyName("dscp")]
        public Dscp Dscp { get; set; }

        [JsonPropertyName("host_services_bitmap")]
        public int HostServicesBitmap { get; set; }

        [JsonPropertyName("num_blacklisted_flows")]
        public NumBlacklistedFlows NumBlacklistedFlows { get; set; }

        [JsonPropertyName("active_flows.as_server")]
        public int ActiveFlowsAsServer { get; set; }

        [JsonPropertyName("active_flows.as_client")]
        public int ActiveFlowsAsClient { get; set; }

        [JsonPropertyName("cardinality")]
        public Cardinality Cardinality { get; set; }

        [JsonPropertyName("tcp.bytes.sent.anomaly_index")]
        public int TcpBytesSentAnomalyIndex { get; set; }

        [JsonPropertyName("active_alerted_flows")]
        public int ActiveAlertedFlows { get; set; }

        [JsonPropertyName("bytes.rcvd")]
        public int BytesRcvd { get; set; }

        [JsonPropertyName("ifid")]
        public int Ifid { get; set; }

        [JsonPropertyName("ipkey")]
        public long Ipkey { get; set; }

        [JsonPropertyName("dns")]
        public Dns Dns { get; set; }

        [JsonPropertyName("tcp.packets.seq_problems")]
        public bool TcpPacketsSeqProblems { get; set; }

        [JsonPropertyName("icmp.bytes.sent.anomaly_index")]
        public int IcmpBytesSentAnomalyIndex { get; set; }

        [JsonPropertyName("is_broadcast")]
        public bool IsBroadcast { get; set; }

        [JsonPropertyName("countries_contacts")]
        public CountriesContacts CountriesContacts { get; set; }

        [JsonPropertyName("active_flows_behaviour")]
        public ActiveFlowsBehaviour ActiveFlowsBehaviour { get; set; }

        [JsonPropertyName("score_behaviour")]
        public ScoreBehaviour ScoreBehaviour { get; set; }

        [JsonPropertyName("unreachable_flows.as_client")]
        public int UnreachableFlowsAsClient { get; set; }

        [JsonPropertyName("udpBytesSent.unicast")]
        public int UdpBytesSentUnicast { get; set; }

        [JsonPropertyName("packets.sent.anomaly_index")]
        public int PacketsSentAnomalyIndex { get; set; }

        [JsonPropertyName("other_ip.bytes.rcvd")]
        public int OtherIpBytesRcvd { get; set; }

        [JsonPropertyName("seen.last")]
        public int SeenLast { get; set; }

        [JsonPropertyName("other_ip.bytes.sent")]
        public int OtherIpBytesSent { get; set; }

        [JsonPropertyName("other_ip.bytes.rcvd.anomaly_index")]
        public int OtherIpBytesRcvdAnomalyIndex { get; set; }

        [JsonPropertyName("alerted_flows.as_server")]
        public int AlertedFlowsAsServer { get; set; }

        [JsonPropertyName("icmp.bytes.rcvd")]
        public int IcmpBytesRcvd { get; set; }

        [JsonPropertyName("throughput_pps")]
        public double ThroughputPps { get; set; }

        [JsonPropertyName("icmp.packets.rcvd")]
        public int IcmpPacketsRcvd { get; set; }

        [JsonPropertyName("score")]
        public int Score { get; set; }

        [JsonPropertyName("localhost")]
        public bool Localhost { get; set; }

        [JsonPropertyName("icmp.packets.sent")]
        public int IcmpPacketsSent { get; set; }

        [JsonPropertyName("server_contacts")]
        public ServerContacts ServerContacts { get; set; }

        [JsonPropertyName("udp.packets.rcvd")]
        public int UdpPacketsRcvd { get; set; }

        [JsonPropertyName("is_multicast")]
        public bool IsMulticast { get; set; }

        [JsonPropertyName("udp.bytes.sent")]
        public int UdpBytesSent { get; set; }

        [JsonPropertyName("tcp.bytes.rcvd")]
        public int TcpBytesRcvd { get; set; }

        [JsonPropertyName("udpBytesSent.non_unicast")]
        public int UdpBytesSentNonUnicast { get; set; }

        [JsonPropertyName("tcp.packets.rcvd")]
        public int TcpPacketsRcvd { get; set; }

        [JsonPropertyName("is_blacklisted")]
        public bool IsBlacklisted { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("os")]
        public int Os { get; set; }

        [JsonPropertyName("tcp.packets.sent")]
        public int TcpPacketsSent { get; set; }

        [JsonPropertyName("pkts_ratio")]
        public double PktsRatio { get; set; }

        [JsonPropertyName("tcp.bytes.sent")]
        public int TcpBytesSent { get; set; }

        [JsonPropertyName("other_ip.packets.sent")]
        public int OtherIpPacketsSent { get; set; }

        [JsonPropertyName("alerted_flows.as_client")]
        public int AlertedFlowsAsClient { get; set; }

        [JsonPropertyName("ndpi_categories")]
        public NdpiCategories NdpiCategories { get; set; }

        [JsonPropertyName("ndpi")]
        public Ndpi Ndpi { get; set; }

        [JsonPropertyName("hiddenFromTop")]
        public bool HiddenFromTop { get; set; }

        [JsonPropertyName("vlan")]
        public int Vlan { get; set; }

        [JsonPropertyName("host_pool_id")]
        public int HostPoolId { get; set; }

        [JsonPropertyName("bytes.sent")]
        public int BytesSent { get; set; }

        [JsonPropertyName("tcpPacketStats.rcvd")]
        public TcpPacketStatsRcvd TcpPacketStatsRcvd { get; set; }

        [JsonPropertyName("other_ip.bytes.sent.anomaly_index")]
        public int OtherIpBytesSentAnomalyIndex { get; set; }

        [JsonPropertyName("devtype")]
        public int Devtype { get; set; }

        [JsonPropertyName("tcp.bytes.rcvd.anomaly_index")]
        public int TcpBytesRcvdAnomalyIndex { get; set; }

        [JsonPropertyName("asn")]
        public int Asn { get; set; }
}