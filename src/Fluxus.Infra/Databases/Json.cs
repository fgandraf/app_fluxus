using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.Globalization;

namespace Fluxus.Infra.Databases;

public static class Json
{
    public static JsonSerializerSettings Settings = new JsonSerializerSettings
    {
        DateFormatString = "yyyy-MM-ddTHH:mm:ss",
        ContractResolver = new CamelCasePropertyNamesContractResolver(),
        Culture = CultureInfo.InvariantCulture
    };
}
