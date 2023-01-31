using System;
using Newtonsoft.Json;
namespace SlotsAutomationTesting.Core.Responses
{
    public class ResultReport
    {
        [JsonProperty("data")] public Data Data { get; set; }
    }
    public class Data
    {
        [JsonProperty("roundId")] public long RoundId { get; set; }

        [JsonProperty("gameTypeId")] public long GameTypeId { get; set; }

        [JsonProperty("isCrash")] public bool IsCrash { get; set; }

        [JsonProperty("resultReportData")] public ResultReportData ResultReportData { get; set; }

        [JsonProperty("id")] public Guid Id { get; set; }

        [JsonProperty("time")] public DateTime Time { get; set; }
    }

    public class ResultReportData
    {
        [JsonProperty("second")] public double Second { get; set; }

        [JsonProperty("odd")] public decimal Odd { get; set; }

        [JsonProperty("bets")] public object[] Bets { get; set; }
    }

}