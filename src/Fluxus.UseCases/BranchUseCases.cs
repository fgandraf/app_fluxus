﻿using Fluxus.Core.Models;
using Fluxus.Core;
using Fluxus.Core.ViewModels;
using Fluxus.Core.Contracts.Databases;
using System.Collections.Generic;

namespace Fluxus.UseCases
{
    public class BranchUseCases
    {

        private readonly IBranchRepository _repository;


        public BranchUseCases(IBranchRepository repository)
            => _repository = repository;

        public OperationResult<int> Insert(Branch bankBranch)
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

        public OperationResult Update(Branch bankBranch)
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

        public OperationResult<Branch> GetById(string id)
        {
            var branch = _repository.GetById(id);

            if (branch == null)
                return OperationResult<Branch>.FailureResult("Não foi possível encontrar a agência bancária!");

            return OperationResult<Branch>.SuccessResult(branch);
        }

        public OperationResult<List<BranchesIndexViewModel>> GetIndex()
        {
            var branches = _repository.GetIndex();

            if (branches == null)
                return OperationResult<List<BranchesIndexViewModel>>.FailureResult("Não foi possível encontrar agências bancárias na base de dados!");

            return OperationResult<List<BranchesIndexViewModel>>.SuccessResult(branches);
        }


    }

}
