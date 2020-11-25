using Fluxus.DAO;
using Fluxus.Model.ENT;
using Newtonsoft.Json;
using System;
using System.Data;

namespace Fluxus.Model
{
    class ProfissionalModel
    {


        bool localDataBase = Util.LocalDB;



        public void Insert(ProfissionalENT dado)
        {
            if (localDataBase)
                InsertLocal(dado);
            else
                PostAPI(dado);
        }
        public void Update(long id, ProfissionalENT dado)
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
        public DataTable ListarProfissionais()
        {
            if (localDataBase)
                return GetAllLocal();
            else
                return GetAllAPI();
        }
        public DataTable BuscarUsuario(string nomeDeUsuario)
        {
            if (localDataBase)
                return BuscarUsuarioLocal(nomeDeUsuario);
            else
                return BuscarUsuarioAPI(nomeDeUsuario);
        }
        public DataTable ListarCodigoENomeid(bool adicionaTitulo)
        {
            if (localDataBase)
                return ListarCodigoENomeidLocal(adicionaTitulo);
            else
                return ListarCodigoENomeidAPI(adicionaTitulo);
        }
        public ProfissionalENT GetBy(long id)
        {
            if (localDataBase)
                return GetByLocal(id);
            else
                return GetByAPI(id);
        }





        //----------
        private void InsertLocal(ProfissionalENT dado)
        {
            try
            {
                new ProfissionalDAO().Insert(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void PostAPI(ProfissionalENT dado)
        {
            // POST: api/profissional/post
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = WebAPI.RequestPOST("profissional/post", jsonData);
        }
        //----------
        private void UpdateLocal(long id, ProfissionalENT profissional)
        {
            try
            {
                new ProfissionalDAO().Update(id, profissional);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void PutAPI(long id, ProfissionalENT dado)
        {
            // PUT: api/profissional/put/<id>
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = WebAPI.RequestPUT("profissional/put/" + id, jsonData);
        }
        //----------
        private void DeleteLocal(long id)
        {
            try
            {
                new ProfissionalDAO().Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void DeleteAPI(long id)
        {
            // DELETE: api/profissional/delete/<id>
            string retorno = WebAPI.RequestDELETE("profissional/delete/", id.ToString());
        }
        //----------
        private DataTable GetAllLocal()
        {
            try
            {
                return new ProfissionalDAO().GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private DataTable GetAllAPI()
        {
            // GET: api/profissional
            DataTable retorno = new DataTable();
            string json = WebAPI.RequestGET("profissional", string.Empty);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }
        //----------
        private DataTable BuscarUsuarioLocal(string nomeDeUsuario)
        {
            try
            {
                return new ProfissionalDAO().GetUserInfoBy(nomeDeUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private DataTable BuscarUsuarioAPI(string nomeDeUsuario)
        {
            // GET: api/profissional/getuserinfo/<userName>
            DataTable retorno = new DataTable();
            string json = WebAPI.RequestGET("profissional/getuserinfo/", nomeDeUsuario);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }
        //----------
        private DataTable ListarCodigoENomeidLocal(bool adicionaTitulo)
        {
            DataTable dtPro = new DataTable();
            try
            {
               
                dtPro = new ProfissionalDAO().GetCodigoENomeid();

                if (adicionaTitulo)
                {
                    DataRow linha = dtPro.NewRow();
                    linha[1] = "--TODOS--";
                    dtPro.Rows.InsertAt(linha, 0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtPro;
        }
        private DataTable ListarCodigoENomeidAPI(bool adicionaTitulo)
        {
            // GET: api/profissional/getcodigoenomeid
            DataTable dtProfissionais = new DataTable();
            try
            {
                string json = WebAPI.RequestGET("profissional/getcodigoenomeid", string.Empty);
                dtProfissionais = JsonConvert.DeserializeObject<DataTable>(json);

                if (adicionaTitulo)
                {
                    DataRow linha = dtProfissionais.NewRow();
                    linha[1] = "--TODAS--";
                    dtProfissionais.Rows.InsertAt(linha, 0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtProfissionais;
        }
        //----------
        private ProfissionalENT GetByLocal(long id)
        {
            try
            {
                return new ProfissionalDAO().GetBy(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private ProfissionalENT GetByAPI(long id)
        {
            // GET: api/profissional/getby/<id>
            ProfissionalENT retorno = new ProfissionalENT();
            string json = WebAPI.RequestGET("profissional/getby/", id.ToString());
            retorno = JsonConvert.DeserializeObject<ProfissionalENT>(json);
            return retorno;
        }
        //----------


    }
}
