using System.Text.Json.Serialization;

namespace Fluxus.Core.Dtos.Profiles;

public record ProfileTradingNameResponse
(
    [property: JsonPropertyName("tradingName")]
    string TradingName
);