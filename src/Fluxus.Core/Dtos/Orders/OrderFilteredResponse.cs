using Fluxus.Core.Enums;
using System;

namespace Fluxus.Core.Dtos.Orders;

public record OrderFilteredResponse
(
    long Id,
    EStatus Status,
    string Professional,
    DateTime OrderDate,
    string ReferenceCode,
    string Service,
    string City,
    string CustomerName,
    DateTime SurveyDate,
    DateTime DoneDate,
    bool Invoiced
);