using System.Text.Json.Serialization;

namespace Fluxus.Core.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum EStatus
{
    RECEBIDA = 1,
    PENDENTE = 2,
    VISTORIADA = 3,
    CONCLUIDA = 4
}