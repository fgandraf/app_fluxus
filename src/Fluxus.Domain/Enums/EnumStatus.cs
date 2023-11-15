﻿using System;
using System.Text.Json.Serialization;

namespace Fluxus.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EnumStatus
    {
        RECEBIDA = 1,
        PENDENTE = 2,
        VISTORIADA = 3,
        CONCLUIDA = 4
    }
}