using Fluxus.Domain;
using Fluxus.Domain.Entities;
using Fluxus.Domain.Interfaces;

namespace Fluxus.App.Services
{
    public class BankBranchService
    {

        private IBankBranchRepository _repository;


        public BankBranchService(IBankBranchRepository repository)
            => _repository = repository;


        public OperationResult Insert(BankBranch bankBranch)
        {
            if (bankBranch == null || bankBranch.BranchNumber == null)
                return OperationResult.FailureResult("Não foi possível incluir a agência bancária!");

            var branchInRepo = _repository.GetByCode(bankBranch.BranchNumber);
            if (branchInRepo != null)
                return OperationResult.FailureResult("Agência já cadastrada!");
           
            int id = _repository.Insert(bankBranch);
            return OperationResult.SuccessResult(id);
        }

        public OperationResult Update(BankBranch bankBranch)
        {
            if (bankBranch == null || bankBranch.BranchNumber == null)
                return OperationResult.FailureResult("Não foi possível alterar a agência bancária!");

            var branchInRepo = _repository.GetByCode(bankBranch.BranchNumber);
            if (branchInRepo == null)
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

        public OperationResult GetById(int id)
        {
            var branch = _repository.GetById(id);

            if (branch == null)
                return OperationResult.FailureResult("Não foi possível encontrar a agência bancária!");

            return OperationResult.SuccessResult(branch);
        }
            
        public OperationResult GetIndex()
        {
            var branches = _repository.GetIndex();

            if (branches == null)
                return OperationResult.FailureResult("Não foi possível encontrar agências bancárias na base de dados!");

            return OperationResult.SuccessResult(branches);
        }

        public OperationResult GetByCode(string branchCode)
        {
            var branch = _repository.GetByCode(branchCode);

            if (branch == null)
                return OperationResult.FailureResult("Não foi possível encontrar agências bancárias na base de dados!");

            return OperationResult.SuccessResult(branch);
        }
    }

}
