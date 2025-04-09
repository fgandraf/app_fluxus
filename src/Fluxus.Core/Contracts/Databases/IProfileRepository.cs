using Fluxus.Core.Dtos.Profiles;
using Fluxus.Core.Models;
using System;

namespace Fluxus.Core.Contracts.Databases;

public interface IProfileRepository
{
    public long Insert(Profile profile);

    public bool Update(Profile profile);
    public bool UpdateLogo(Object model);

    public Profile GetById(long id);

    public Profile GetToPrint();

    public ProfileLogoResponse GetLogo();

    public ProfileTradingNameResponse GetTradingName();
}
