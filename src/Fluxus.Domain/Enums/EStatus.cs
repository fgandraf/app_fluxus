using System.Text.Json.Serialization;

namespace Fluxus.Domain.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum EStatus
{
    RECEBIDA = 1,
    PENDENTE = 2,
    VISTORIADA = 3,
    CONCLUIDA = 4
}