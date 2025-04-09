

using Fluxus.Core.Dtos;

namespace Fluxus.Core.Contracts.Services;

public interface ICep
{
    AddressViewModel GetCep(string cep);
}
