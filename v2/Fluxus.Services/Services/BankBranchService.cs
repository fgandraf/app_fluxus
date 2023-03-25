using System.Data;
using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;


namespace Fluxus.Services
{
    public class BankBranchService
    {

        public void Insert(BankBranch body) 
            => new BankBranchRepository().Insert(body);


        public void Update(BankBranch body)
            => new BankBranchRepository().Update(body);


        public void Delete(int id) 
            => new BankBranchRepository().Delete(id);


        public DataTable GetAll() 
            => new BankBranchRepository().GetAll();


        public DataTable BuscarAgencia(string agenciaCodigo)
            => new BankBranchRepository().GetByCode(agenciaCodigo);


        public BankBranch GetBy(int id) 
            => new BankBranchRepository().GetById(id);

    }

}
