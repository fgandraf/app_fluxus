using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;
using iTextSharp.text;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Fluxus.App
{
    public class ServiceApp
    {
        public string InsertOrUpdate (Service service, string method)
        {
            if (service.Tag == "")
                return "Campos com * são obrigatório";

            if (method == "&Adicionar")
                new ServiceRepository().Insert(service);
            else
                new ServiceRepository().Update(service);

            return "Dados cadastrados com sucesso!";
        }

        public void Delete(int id)
            => new ServiceRepository().Delete(id);


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
