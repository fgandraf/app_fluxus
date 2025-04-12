using Fluxus.Core.Dtos.Invoices;
using Fluxus.Core.Models;
using System.Collections.Generic;

namespace Fluxus.Core.Contracts.Databases;

public interface IInvoiceRepository
{
    public InvoiceResponse Insert(InvoiceCreateRequest body);

    public bool Update(InvoiceUpdateRequest body);

    public bool Delete(long id);

    public string GetDescription(long id);

    public List<Invoice> GetAll();
}
