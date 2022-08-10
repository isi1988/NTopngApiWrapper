using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.HostStats;

public class Cardinality
{
    [JsonPropertyName("num_contacted_services_as_client")]
    public int NumContactedServicesAsClient { get; set; }

    [JsonPropertyName("num_host_contacts_as_server")]
    public int NumHostContactsAsServer { get; set; }

    [JsonPropertyName("num_host_contacted_ports_as_server")]
    public int NumHostContactedPortsAsServer { get; set; }

    [JsonPropertyName("num_contacted_ports_as_client")]
    public int NumContactedPortsAsClient { get; set; }

    [JsonPropertyName("num_contacted_hosts_as_client")]
    public int NumContactedHostsAsClient { get; set; }
}