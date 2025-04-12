using Fluxus.Core.Models;
using Fluxus.Core;
using Fluxus.Core.Contracts.Databases;
using System.Collections.Generic;
using Fluxus.Core.Dtos.Branches;

namespace Fluxus.UseCases
{
    public class BranchUseCases
    {

        private readonly IBranchRepository _repository;


        public BranchUseCases(IBranchRepository repository)
            => _repository = repository;

        public OperationResult<long> Insert(Branch bankBranch)
        {
            if (bankBranch == null)
                return OperationResult<long>.FailureResult("Não foi possível incluir a agência bancária!");

            if (bankBranch.Id == null)
                return OperationResult<long>.FailureResult("Campos com * são obrigatório");

            if (_repository.GetContacts(bankBranch.Id) != null)
                return OperationResult<long>.FailureResult("Agência já cadastrada!");

            var branchRequest = new BranchCreateRequest(bankBranch);

            var id = _repository.Insert(branchRequest);
            if (id == 0)
                return OperationResult<long>.FailureResult("Não foi possível inserir a agência bancária na base de dados!");

            return OperationResult<long>.SuccessResult(id);
        }

        public OperationResult Update(Branch bankBranch)
        {
            if (bankBranch == null || bankBranch.Id == null)
                return OperationResult.FailureResult("Não foi possível alterar a agência bancária!");

            if (_repository.GetContacts(bankBranch.Id) == null)
                return OperationResult.FailureResult("Agência não encontrada!");


            var branchRequest = new BranchUpdateRequest(bankBranch);

            if (!_repository.Update(branchRequest))
                return OperationResult.FailureResult("Não foi possível alterar a agência bancária!");

            return OperationResult.SuccessResult();
        }

        public OperationResult Delete(string id)
        {
            if (!_repository.Delete(id))
                return OperationResult.FailureResult("Não foi possível excluir a agência bancária!");

            return OperationResult.SuccessResult();
        }

        public OperationResult<Branch> GetById(string id)
        {
            var branch = _repository.GetById(id);

            if (branch == null)
                return OperationResult<Branch>.FailureResult("Não foi possível encontrar a agência bancária!");

            return OperationResult<Branch>.SuccessResult(branch);
        }

        public OperationResult<List<BranchIndexResponse>> GetIndex()
        {
            var branches = _repository.GetIndex();

            if (branches == null)
                return OperationResult<List<BranchIndexResponse>>.FailureResult("Não foi possível encontrar agências bancárias na base de dados!");

            return OperationResult<List<BranchIndexResponse>>.SuccessResult(branches);
        }


    }

}
