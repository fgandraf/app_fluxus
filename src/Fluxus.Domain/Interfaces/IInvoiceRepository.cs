using Fluxus.Domain.Entities;
using System.Collections.Generic;

namespace Fluxus.Domain.Interfaces
{
    public interface IInvoiceRepository
    {
        public int Insert(Invoice body);

        public bool Update(Invoice body);

        public bool Delete(int id);

        public string GetDescription(int id);

        public List<Invoice> GetAll();
    }
}
