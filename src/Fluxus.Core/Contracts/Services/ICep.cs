

using Fluxus.Core.ViewModels;

namespace Fluxus.Core.Contracts.Services;

public interface ICep
{
    AddressViewModel GetCep(string cep);
}
