using Fluxus.DAO;
using Fluxus.Model.ENT;
using Newtonsoft.Json;
using System;
using System.Data;

namespace Fluxus.Model
{
    class FaturaModel
    {

        bool localDataBase = Util.LocalDB;


        public long Insert(FaturaENT dado)
        {
            if (localDataBase)
                return InsertLocal(dado);
            else
                return PostAPI(dado);
        }
        public void Update(long id, FaturaENT dado)
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
        public string DescricaoFatura(long id)
        {
            if (localDataBase)
                return DescricaoFaturaLocal(id);
            else
                return DescricaoFaturaAPI(id);
        }
        public DataTable ListarFatura()
        {
            if (localDataBase)
                return ListarFaturaLocal();
            else
                return ListarFaturaAPI();
        }





        //----------
        private long InsertLocal(FaturaENT dado)
        {
            try
            {
                return new FaturaDAO().Insert(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private long PostAPI(FaturaENT dado)
        {
            // POST: api/fatura/post
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = WebAPI.RequestPOST("fatura/post", jsonData);

            return Convert.ToInt64(json);
        }
        //----------
        private void UpdateLocal(long id, FaturaENT dado)
        {
            try
            {
                new FaturaDAO().UpdateTotals(id, dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void PutAPI(long id, FaturaENT dado)
        {
            // PUT: api/fatura/puttotals/<id>
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = WebAPI.RequestPUT("fatura/puttotals/" + id, jsonData);

        }
        //----------
        private void DeleteLocal(long id)
        {
            try
            {
                new FaturaDAO().Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void DeleteAPI(long id)
        {
            // DELETE: api/fatura/delete/<id>
            string retorno = WebAPI.RequestDELETE("fatura/delete/", id.ToString());
        }
        //----------
        private DataTable ListarFaturaLocal()
        {
            try
            {
                return new FaturaDAO().GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private DataTable ListarFaturaAPI()
        {
            // GET: api/fatura
            DataTable retorno = new DataTable();
            string json = WebAPI.RequestGET("fatura", string.Empty);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }
        //----------
        private string DescricaoFaturaLocal(long id)
        {
            try
            {
                return new FaturaDAO().GetDescricaoById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private string DescricaoFaturaAPI(long id)
        {
            // GET: api/fatura/getdescricao/<id>
            string json = WebAPI.RequestGET("fatura/getdescricao/", id.ToString());
            return json;
        }


    }
}