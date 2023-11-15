﻿
using Fluxus.Domain.Entities;

namespace Fluxus.Domain.Interfaces
{
    public interface IProfileRepository
    {
        public int Insert(Profile profile);

        public bool Update(Profile profile);

        public Profile GetAll();

        public Profile GetToPrint();

        public byte[] GetLogo();

        public string GetTradingName();
    }
}