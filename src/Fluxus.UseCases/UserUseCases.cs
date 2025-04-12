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
