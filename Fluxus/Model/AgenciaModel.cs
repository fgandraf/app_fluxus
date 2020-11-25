using Fluxus.Model.ENT;
using System.Data;
using Newtonsoft.Json;
using System;
using Fluxus.DAO;

namespace Fluxus.Model
{
    class AgenciaModel
    {
        bool localDataBase = Util.LocalDB;



        public void Insert(AgenciaENT dado)
        {
            if (localDataBase)
                InsertLocal(dado);
            else
                PostAPI(dado);
        }
        public void Update(long id, AgenciaENT dado)
        {
            if (localDataBase)
                UpdateLocal(id, dado);
            else
                PutAPI(id, dado);
        }
        public void Delete(long id)
        {
            if (localDataBase)
                DeleteLocal(id);
            else
                DeleteAPI(id);
        }
        public DataTable GetAll()
        {
            if (localDataBase)
                return GetAllLocal();
            else
                return GetAllAPI();
        }
        public DataTable BuscarAgencia(string agenciaCodigo)
        {
            if (localDataBase)
                return BuscarAgenciaLocal(agenciaCodigo);
            else
                return BuscarAgenciaAPI(agenciaCodigo);
        }
        public AgenciaENT GetBy(long id)
        {
            if (localDataBase)
                return GetByLocal(id);
            else
                return GetByAPI(id);
           
        }





        //----------
        private void InsertLocal(AgenciaENT dado)
        {
            try
            {
                new AgenciaDAO().Insert(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void PostAPI(AgenciaENT dado)
        {
            // POST: api/agencia/post
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = WebAPI.RequestPOST("agencia/post", jsonData);
        }
        //----------
        private void UpdateLocal(long id, AgenciaENT dado)
        {
            try
            {
                new AgenciaDAO().Update(id, dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void PutAPI(long id, AgenciaENT dado)
        {
            // PUT: api/agencia/put/<id>
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = WebAPI.RequestPUT("agencia/put/" + id, jsonData);
        }
        //----------
        private void DeleteLocal(long id)
        {
            try
            {
                new AgenciaDAO().Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void DeleteAPI(long id)
        {
            // DELETE: api/agencia/delete/<id>
            string retorno = WebAPI.RequestDELETE("agencia/delete/", id.ToString());
        }
        //----------
        private DataTable GetAllLocal()
        {
            try
            {
                return new AgenciaDAO().GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private DataTable GetAllAPI()
        {
            // GET: api/agencia
            DataTable retorno = new DataTable();
            string json = WebAPI.RequestGET("agencia", string.Empty);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }
        //----------
        private DataTable BuscarAgenciaLocal(string agenciaCodigo)
        {
            try
            {
                return new AgenciaDAO().GetNomeTelefone1EmailBy(agenciaCodigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private DataTable BuscarAgenciaAPI(string agenciaCodigo)
        {
            // GET: api/agencia/getsomeby/<agenciaCodigo>
            DataTable retorno = new DataTable();
            string json = WebAPI.RequestGET("agencia/getsomeby/", agenciaCodigo);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }
        //----------
        private AgenciaENT GetByLocal(long id)
        {
            try
            {
                return new AgenciaDAO().GetBy(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private AgenciaENT GetByAPI(long id)
        {
            // GET: api/agencia/getby/<id>
            AgenciaENT retorno = new AgenciaENT();
            string json = WebAPI.RequestGET("agencia/getby/", id.ToString());
            retorno = JsonConvert.DeserializeObject<AgenciaENT>(json);
            return retorno;
        }
        //----------

    }
}
