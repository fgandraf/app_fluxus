using System.Collections.Generic;
using Fluxus.Domain.Entities;
using Fluxus.Domain.Interfaces;
using Fluxus.Domain.Structs;

namespace Fluxus.App
{
    public class BankBranchService
    {

        private IBankBranchRepository _repository;
        public BankBranch BankBranch { get; set; }


        public string Message { get; private set; }



        public BankBranchService(IBankBranchRepository repository)
            => _repository = repository;



        public int Execute(string method)
        {
            if (BankBranch == null || !IsValid())
                return 0;

            if (method == "Alterar")
                return Update();
            else
                return Insert();
        }

        private int Insert()
        {
            if (BankBranch != null)
                return _repository.Insert(BankBranch);

            Message = "Não foi possível incluir a agência bancária!";
            return 0;
        }

        private int Update()
        {
            if (BankBranch != null && _repository.Update(BankBranch))
                return 1;

            Message = "Não foi possível alterar a agência bancária!";
            return 0;
        }

        private bool IsValid()
        {
            if (string.IsNullOrEmpty(BankBranch.BranchNumber))
            {
                Message = "Campos com * são obrigatório";
                return false;
            }

            var branch = _repository.GetByCode(BankBranch.BranchNumber);
            var branchExists = !string.IsNullOrWhiteSpace(branch.BranchNumber);
            
            if (BankBranch.Id == 0 && branchExists)
            {
                Message = "Agência já cadastrada.";
                return false;
            }

            return true;
        }

        public bool Delete(int id)
        {
            if (_repository.Delete(id))
                return true;

            Message = "Não foi possível excluir a agência bancrária!";
            return false;
        }

        public BankBranch GetById(int id)
        {
            var branch = _repository.GetById(id);

            if (branch != null)
                return branch;

            Message = "Não foi possível encontrar o profissional!";
            return null;
        }
            
        public List<BankBranchIndex> GetIndex()
        {
            var branches = _repository.GetIndex();

            if (branches != null)
                return branches;

            Message = "Não foi possível encontrar agências bancrárias na base de dados!";
            return null;
        }

        public BankBranch GetByCode(string agenciaCodigo)
        {
            var branch = _repository.GetByCode(agenciaCodigo);

            if (branch != null)
                return branch;

            Message = "Não foi possível encontrar profissionais na base de dados!";
            return null;
        }
    }

}
