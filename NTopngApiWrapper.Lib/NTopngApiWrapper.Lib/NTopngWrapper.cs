using System.Net.Http.Headers;
using System.Text.Json;
using NTopngApiWrapper.Lib.Data.DataRequest;

namespace NTopngApiWrapper.Lib;

/// <summary>
/// Main wrapper
/// </summary>
public class NTopngWrapper
{
    /// <summary>
    /// Ntopng properties
    /// </summary>
    private WrapperProperties? _properties;


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

    public void InitFromFile(string fileName = "config.secret.json")
    {
        if (!File.Exists(fileName))
            throw new Exception($"Config file {fileName} not found!");
      
        try
        {
            _properties = JsonSerializer.Deserialize<WrapperProperties>(File.ReadAllText(fileName));
        }
        catch (Exception e)
        {
            throw new Exception($"Config file {fileName} not valid!");
        }

        if (_properties != null && !_properties.NTopngHost.EndsWith("/"))
            _properties.NTopngHost += "/";
        
    }

    private async Task<string?> GetJSONData(string url)
    {
        var authenticationString = $"{_properties.NTopngLogin}:{_properties.NTopngPassword}";
        var base64EncodedAuthenticationString = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(authenticationString));

        var request = new HttpRequestMessage(HttpMethod.Get, url);
        request.Headers.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);

        var result = await _httpClient.SendAsync(request);
        if (result.IsSuccessStatusCode)
            return await result.Content.ReadAsStringAsync();
        return null;
    }

    public async Task<Root?> GetInterfaceData()
    {
        if (_properties == null)
            throw new Exception($"Properties is null!");
        
        try
        {
            
            var json = await GetJSONData($"{_properties.NTopngHost}lua/rest/v2/get/interface/data.lua?ifid=1");
            if (!string.IsNullOrEmpty(json))
                return JsonSerializer.Deserialize<Root>(json);
            else
                throw new Exception($"Json from request lua/rest/v2/get/interface/data.lua?ifid=1 null or empty");
        }
        catch (Exception e)
        {
            //TODO error event
            return null;
        }
    }
}