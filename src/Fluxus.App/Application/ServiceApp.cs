using Fluxus.Domain.Entities;
using Fluxus.Domain.Enums;
using Fluxus.Infra.Repositories;
using System.Collections.Generic;

namespace Fluxus.App
{
    public class ServiceApp
    {
        public string Message { get; private set; }

        public bool InsertOrUpdate (Service service, EnumMethod method)
        {
            if (service.Tag == "")
            {
                Message = "Campos com * são obrigatório";
                return false;
            }

            if (method == EnumMethod.Insert)
                new ServiceRepository().Insert(service);
            else
                new ServiceRepository().Update(service);

            return true;
        }

        public bool Delete(int id)
        {
            var success = new ServiceRepository().Delete(id);
            if (success)
            {
                return true;
            }
            else
            {
                Message = "Ñão foi possível excluir a atividade.";
                return false;
            }
        }


        public List<Service> GetAll(bool addHeader)
        {
            var services = new ServiceRepository().GetAll();

            if (addHeader)
                services.Insert(0, new Service { Tag = "--TODAS--"});

            return services;
        }

        public Service GetBy(int id)
            => new ServiceRepository().GetById(id);

    }

}
