using Fluxus.Core.Models;
using Fluxus.Core;
using Fluxus.Core.Contracts.Databases;
using Fluxus.Core.Dtos.Users;

namespace Fluxus.UseCases
{
    public class UserUseCases
    {
        private readonly IUserRepository _repository;

        public UserUseCases(IUserRepository userRepository)
            => _repository = userRepository;

        public (bool, string) Login(UserLoginRequest login)
            => _repository.Login(login);


        public OperationResult<long> Insert(User user)
        {
            if (user == null)
                return OperationResult<long>.FailureResult("Não foi possível incluir o usuário!");


            var id = _repository.Register(user);
            if (id == 0)
                return OperationResult<long>.FailureResult("Não foi possível inserir o usuário na base de dados!");

            return OperationResult<long>.SuccessResult(id);
        }



        public OperationResult Update(User user)
        {
            if (user == null)
                return OperationResult.FailureResult("Não foi possível alterar o usuário!");

            if (!_repository.UpdateInfo(user))
                return OperationResult.FailureResult("Não foi possível alterar o usuário na base de dados!");

            return OperationResult.SuccessResult();
        }

        public OperationResult Delete(long id)
        {
            if (!_repository.Delete(id))
                return OperationResult.FailureResult("Não foi possível excluir o usuário!");

            return OperationResult.SuccessResult();
        }

        public OperationResult<User> GetByProfessionalId(long id)
        {
            var user = _repository.GetByProfessionalId(id);

            if (user == null)
                return OperationResult<User>.FailureResult("Não foi possível encontrar o usuário!");

            return OperationResult<User>.SuccessResult(user);
        }

        public OperationResult<UserResponse> GetByUsername(string userName)
        {
            var user = _repository.GetByUserName(userName);

            if (user == null)
                return OperationResult<UserResponse>.FailureResult("Dados do usuário não encontrados");

            return OperationResult<UserResponse>.SuccessResult(user);
        }
    }
}
