using Fluxus.Domain;
using Fluxus.Domain.Entities;
using Fluxus.Domain.Interfaces;
using Fluxus.Domain.Records;
using iTextSharp.text;
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
            if (bankBranch == null || bankBranch.BranchNumber == null)
                return OperationResult<int>.FailureResult("Não foi possível incluir a agência bancária!");

            
            if (_repository.GetByCode(bankBranch.BranchNumber) != null)
                return OperationResult<int>.FailureResult("Agência já cadastrada!");
           
            int id = _repository.Insert(bankBranch);
            return OperationResult<int>.SuccessResult(id);
        }

        public OperationResult Update(BankBranch bankBranch)
        {
            if (bankBranch == null || bankBranch.BranchNumber == null)
                return OperationResult.FailureResult("Não foi possível alterar a agência bancária!");

            if (_repository.GetByCode(bankBranch.BranchNumber) == null)
                return OperationResult.FailureResult("Agência não encontrada!");

            if (!_repository.Update(bankBranch))
                return OperationResult.FailureResult("Não foi possível alterar a agência bancária!");

            return OperationResult.SuccessResult();
        }
        
        public OperationResult Delete(int id)
        {
            if (!_repository.Delete(id))
                return OperationResult.FailureResult("Não foi possível excluir a agência bancária!");

            return OperationResult.SuccessResult();
        }

        public OperationResult<BankBranch> GetById(int id)
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

        public OperationResult<BankBranch> GetByCode(string branchCode)
        {
            var branch = _repository.GetByCode(branchCode);

            if (branch == null)
                return OperationResult<BankBranch>.FailureResult("Não foi possível encontrar agências bancárias na base de dados!");

            return OperationResult<BankBranch>.SuccessResult(branch);
        }
    }

}
