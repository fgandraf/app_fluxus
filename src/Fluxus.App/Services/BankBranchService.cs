using Fluxus.Domain.Entities;
using Fluxus.Infra.Interfaces;
using Fluxus.Infra.Records;
using System.Collections.Generic;

namespace Fluxus.App.Services
{
    public class BankBranchService
    {

        private IBankBranchRepository _repository;


        public BankBranchService(IBankBranchRepository repository)
            => _repository = repository;


        public OperationResult<int> Insert(BankBranch bankBranch)
        {
            if (bankBranch == null)
                return OperationResult<int>.FailureResult("Não foi possível incluir a agência bancária!");

            if (bankBranch.Id == null)
                return OperationResult<int>.FailureResult("Campos com * são obrigatório");

            if (_repository.GetContacts(bankBranch.Id) != null)
                return OperationResult<int>.FailureResult("Agência já cadastrada!");
           
            int id = _repository.Insert(bankBranch);
            if (id == 0)
                return OperationResult<int>.FailureResult("Não foi possível inserir a agência bancária na base de dados!");

            return OperationResult<int>.SuccessResult(id);
        }

        public OperationResult Update(BankBranch bankBranch)
        {
            if (bankBranch == null || bankBranch.Id == null)
                return OperationResult.FailureResult("Não foi possível alterar a agência bancária!");

            if (_repository.GetContacts(bankBranch.Id) == null)
                return OperationResult.FailureResult("Agência não encontrada!");

            if (!_repository.Update(bankBranch))
                return OperationResult.FailureResult("Não foi possível alterar a agência bancária!");

            return OperationResult.SuccessResult();
        }
        
        public OperationResult Delete(string id)
        {
            if (!_repository.Delete(id))
                return OperationResult.FailureResult("Não foi possível excluir a agência bancária!");

            return OperationResult.SuccessResult();
        }

        public OperationResult<BankBranch> GetById(string id)
        {
            var branch = _repository.GetById(id);

            if (branch == null)
                return OperationResult<BankBranch>.FailureResult("Não foi possível encontrar a agência bancária!");

            return OperationResult<BankBranch>.SuccessResult(branch);
        }
            
        public OperationResult<List<BankBranchIndex>> GetIndex()
        {
            var branches = _repository.GetIndex();

            if (branches == null)
                return OperationResult<List<BankBranchIndex>>.FailureResult("Não foi possível encontrar agências bancárias na base de dados!");

            return OperationResult<List<BankBranchIndex>>.SuccessResult(branches);
        }


    }

}
