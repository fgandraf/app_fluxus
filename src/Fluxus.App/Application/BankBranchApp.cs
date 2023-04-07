using System.Collections.Generic;
using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;

namespace Fluxus.App
{
    public class BankBranchApp
    {
        public string Message { get; private set; }

        public bool InsertOrUpdate(BankBranch bankBranch, string method)
        {
            if (bankBranch.BranchNumber == "")
            {
                Message = "Campos com * são obrigatório";
                return false;
            }
            else
            {
                if (method == "Alterar")
                    new BankBranchRepository().Update(bankBranch);
                else
                    new BankBranchRepository().Insert(bankBranch);
                
                return true;
            }
        }


        public void Insert(BankBranch body) 
            => new BankBranchRepository().Insert(body);


        public void Update(BankBranch body)
            => new BankBranchRepository().Update(body);


        public bool Delete(int id)
        {
            var success = new BankBranchRepository().Delete(id);
            
            if (success)
                return true;
            else
            {
                Message = "Não foi possível excluir a agência";
                return false;
            }
        }


        public List<dynamic> GetIndex() 
            => new BankBranchRepository().GetIndex();


        public BankBranch BuscarAgencia(string agenciaCodigo)
            => new BankBranchRepository().GetByCode(agenciaCodigo);


        public BankBranch GetBy(int id) 
            => new BankBranchRepository().GetById(id);

    }

}
