using System.Text.Json.Serialization;

namespace NTopngApiWrapper.Lib.Data.HostStats;

public class ScorePct
{
    [JsonPropertyName("score_breakdown_client")]
    public ScoreBreakdownClient ScoreBreakdownClient { get; set; }

    [JsonPropertyName("score_breakdown_server")]
    public ScoreBreakdownServer ScoreBreakdownServer { get; set; }
}