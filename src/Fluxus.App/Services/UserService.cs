using Fluxus.Domain.Models;
using Fluxus.Domain.Contracts.Databases;
using System;

namespace Fluxus.App.Services
{
    public class UserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository userRepository)
            => _repository = userRepository;

        public (bool, string) Login(Object login)
            => _repository.Login(login);
        

        public OperationResult<int> Insert(User user)
        {
            if (user == null)
                return OperationResult<int>.FailureResult("Não foi possível incluir o usuário!");


            int id = _repository.Insert(user);
            if (id == 0)
                return OperationResult<int>.FailureResult("Não foi possível inserir o usuário na base de dados!");

            return OperationResult<int>.SuccessResult(id);
        }

        

        public OperationResult Update(User user)
        {
            if (user == null)
                return OperationResult.FailureResult("Não foi possível alterar o usuário!");

            if (!_repository.Update(user))
                return OperationResult.FailureResult("Não foi possível alterar o usuário na base de dados!");

            return OperationResult.SuccessResult();
        }

        public OperationResult Delete(int id)
        {
            if (!_repository.Delete(id))
                return OperationResult.FailureResult("Não foi possível excluir o usuário!");

            return OperationResult.SuccessResult();
        }

        public OperationResult<User> GetByProfessionalId(int id)
        {
            var user = _repository.GetByProfessionalId(id);

            if (user == null)
                return OperationResult<User>.FailureResult("Não foi possível encontrar o usuário!");

            return OperationResult<User>.SuccessResult(user);
        }

        public OperationResult<User> GetByUsername(string userName)
        {
            var user = _repository.GetByUserName(userName);

            if (user == null)
                return OperationResult<User>.FailureResult("Dados do usuário não encontrados");

            return OperationResult<User>.SuccessResult(user);
        }
    }
}
