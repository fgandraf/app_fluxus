using Fluxus.DAO;
using Fluxus.Model.ENT;
using Newtonsoft.Json;
using System;
using System.Data;

namespace Fluxus.Model
{
    class AtividadeModel
    {
        
        
        bool localDataBase = Util.LocalDB;



        public void Insert(AtividadeENT dado)
        {
            if (localDataBase)
                InsertLocal(dado);
            else
                PostAPI(dado);
        }
        public void Update(long id, AtividadeENT dado)
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
        public DataTable ListarAtividades(bool adicionaTitulo)
        {
            if (localDataBase)
                return ListarAtividadesLocal(adicionaTitulo);
            else
                return ListarAtividadesAPI(adicionaTitulo);
        }
        public AtividadeENT GetBy(long id)
        {
            if (localDataBase)
                return GetByLocal(id);
            else
                return GetByAPI(id);
        }





        //----------
        private void InsertLocal(AtividadeENT dado)
        {
            try
            {
                new AtividadeDAO().Insert(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void PostAPI(AtividadeENT dado)
        {
            // POST: api/atividade/post
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = WebAPI.RequestPOST("atividade/post", jsonData);
        }
        //----------
        private void UpdateLocal(long id, AtividadeENT dado)
        {
            try
            {
                new AtividadeDAO().Update(id, dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void PutAPI(long id, AtividadeENT dado)
        {
            // PUT: api/atividade/put/<id>
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = WebAPI.RequestPUT("atividade/put/" + id, jsonData);
        }
        //----------
        private void DeleteLocal(long id)
        {
            try
            {
                new AtividadeDAO().Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void DeleteAPI(long id)
        {
            // DELETE: api/atividade/delete/<id>
            string retorno = WebAPI.RequestDELETE("atividade/delete/", id.ToString());
        }
        //----------
        private DataTable ListarAtividadesLocal(bool adicionaTitulo)
        {
            DataTable dtAtividades = new DataTable();
            try
            {
                DataView dvAtividades = new DataView(new AtividadeDAO().GetAll());
                dtAtividades = dvAtividades.ToTable("Selected", false, "id", "codigo", "descricao", "valor_atividade", "valor_deslocamento");

                if (adicionaTitulo)
                {
                    DataRow linha = dtAtividades.NewRow();
                    linha[1] = "--TODAS--";
                    dtAtividades.Rows.InsertAt(linha, 0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtAtividades;
        }
        private DataTable ListarAtividadesAPI(bool adicionaTitulo)
        {
            // GET: api/atividade
            DataTable dtAtividades = new DataTable();
            try
            {
                string json = WebAPI.RequestGET("atividade", string.Empty);
                dtAtividades = JsonConvert.DeserializeObject<DataTable>(json);

                if (adicionaTitulo)
                {
                    DataRow linha = dtAtividades.NewRow();
                    linha[1] = "--TODAS--";
                    dtAtividades.Rows.InsertAt(linha, 0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtAtividades;
        }
        //----------
        private AtividadeENT GetByLocal(long id)
        {
            try
            {
                return new AtividadeDAO().GetBy(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private AtividadeENT GetByAPI(long id)
        {
            // GET: api/atividade/getby/<id>
            AtividadeENT retorno = new AtividadeENT();
            string json = WebAPI.RequestGET("atividade/getby/", id.ToString());
            retorno = JsonConvert.DeserializeObject<AtividadeENT>(json);
            return retorno;
        }
 
    }
}
