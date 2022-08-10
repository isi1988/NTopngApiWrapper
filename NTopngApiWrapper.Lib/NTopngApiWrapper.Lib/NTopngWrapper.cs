namespace NTopngApiWrapper.Lib;

/// <summary>
/// Main wrapper
/// </summary>
public class NTopngWrapper
{
    /// <summary>
    /// Ntopng host (ip or domain name with protocol)
    /// </summary>
    private string _ntopHost = string.Empty;

    /// <summary>
    /// Ntopng login
    /// </summary>
    private string _ntopLogin = string.Empty;

    /// <summary>
    /// Ntopng password
    /// </summary>
    private string _ntopPassword = string.Empty;


    private HttpClient _httpClient = new HttpClient();

    /// <summary>
    /// Default constructor
    /// </summary>
    public NTopngWrapper()
    {
        
    }

    /// <summary>
    /// Constructor for injection
    /// </summary>
    /// <param name="httpClient">Http client</param>
    public NTopngWrapper(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
}