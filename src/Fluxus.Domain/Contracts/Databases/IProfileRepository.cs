using Fluxus.Domain.Models;
using System;

namespace Fluxus.Domain.Contracts.Databases;

public interface IProfileRepository
{
    public int Insert(Profile profile);

    public bool Update(Profile profile);
    public bool UpdateLogo(Object model);

    public Profile GetById(int id);

    public Profile GetToPrint();

    public byte[] GetLogo();

    public string GetTradingName();
}
