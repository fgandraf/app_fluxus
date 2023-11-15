using Fluxus.Domain.Entities;
using Fluxus.Domain.Enums;
using Fluxus.Domain.Interfaces;
using System.Collections.Generic;

namespace Fluxus.App
{
    public class ServiceService
    {

        private IServiceRepository _repository;
        public Service Service { get; set; }


        public string Message { get; private set; }



        public ServiceService(IServiceRepository repository)
            => _repository = repository;




        public int Execute(EnumMethod method)
        {
            if (Service == null || !IsValid())
                return 0;

            if (method == EnumMethod.Update)
                return Update();
            else
                return Insert();
        }

        private int Insert()
        {
            if (Service != null)
                return _repository.Insert(Service);

            Message = "Não foi possível incluir a atividade!";
            return 0;
        }

        private int Update()
        {
            if (Service != null && _repository.Update(Service))
                return 1;

            Message = "Não foi possível alterar a atividade!";
            return 0;
        }

        private bool IsValid()
        {
            if (string.IsNullOrEmpty(Service.Tag))
            {
                Message = "Campos com * são obrigatório";
                return false;
            }

            return true;
        }

        public bool Delete(int id)
        {
            if (_repository.Delete(id))
                return true;

            Message = "Não foi possível excluir a atividade!";
            return false;
        }

        public Service GetBy(int id)
        {
            var service = _repository.GetById(id);

            if (service != null)
                return service;

            Message = "Não foi possível encontrar a atividade!";
            return null;
        }

        public List<Service> GetAll(bool addHeader)
        {
            var services = _repository.GetAll();

            if (services != null)
            {
                if (addHeader)
                    services.Insert(0, new Service { Tag = "--TODAS--" });
                return services;
            }

            Message = "Não foi possível encontrar atividades na base de dados!";
            return null;
        }

    }
}
