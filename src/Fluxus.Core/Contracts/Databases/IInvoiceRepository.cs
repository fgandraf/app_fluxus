using Fluxus.Core.Models;
using System.Collections.Generic;

namespace Fluxus.Core.Contracts.Databases;

public interface IInvoiceRepository
{
    public int Insert(Invoice body);

    public bool Update(Invoice body);

    public bool Delete(int id);

    public string GetDescription(int id);

    public List<Invoice> GetAll();
}
