using System;
using Fluxus.Core.Enums;

namespace Fluxus.Core.Models;


public class Order
{

    public long Id { get; private set; }
    public string ReferenceCode { get; private set; }
    public string Branch { get; private set; }
    public long ProfessionalId { get; private set; }
    public long ServiceId { get; private set; }
    public double ServiceAmount { get; private set; }
    public double MileageAllowance { get; private set; }
    public string CustomerName { get; private set; }
    public string City { get; private set; }
    public string ContactName { get; private set; }
    public string ContactPhone { get; private set; }
    public string Coordinates { get; private set; }
    public EStatus Status { get; private set; }
    public bool Invoiced { get; private set; }
    public long InvoiceId { get; private set; }
    public DateTime OrderDate { get; private set; }
    public DateTime Deadline { get; private set; }
    public DateTime? PendingDate { get; private set; }
    public DateTime? SurveyDate { get; private set; }
    public DateTime? DoneDate { get; private set; }
    public bool Siopi { get; private set; }

    public Order(long id, string referenceCode, string branch, long professionalId, long serviceId, double serviceAmount, double mileageAllowance, string customerName, string city, string contactName, string contactPhone, string coordinates, EStatus status, bool invoiced, long invoiceId, DateTime orderDate, DateTime deadline, DateTime? pendingDate, DateTime? surveyDate, DateTime? doneDate, bool siopi)
    {
        Id = id;
        ReferenceCode = referenceCode;
        Branch = branch;
        ProfessionalId = professionalId;
        ServiceId = serviceId;
        ServiceAmount = serviceAmount;
        MileageAllowance = mileageAllowance;
        CustomerName = customerName;
        City = city;
        ContactName = contactName;
        ContactPhone = contactPhone;
        Coordinates = coordinates;
        Status = status;
        Invoiced = invoiced;
        InvoiceId = invoiceId;
        OrderDate = orderDate;
        Deadline = deadline;
        PendingDate = pendingDate;
        SurveyDate = surveyDate;
        DoneDate = doneDate;
        Siopi = siopi;
    }

}
