using Fluxus.Model.ENT;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Text;

namespace Fluxus.Model
{
    class OsModel
    {





        // POST api/os/post
        public void Insert(OsENT dado)
        {
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = WebAPI.RequestPOST("os/post", jsonData);
        }





        // PUT api/os/put/<id>
        public void Update(long id, OsENT dado)
        {
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = WebAPI.RequestPUT("os/put/" + id, jsonData);
        }





        // PUT api/os/updatefaturacod/<id>,<fatura_cod>
        public void UpdateFaturaCod(long id, long fatura_cod)
        {
            string json = WebAPI.RequestPUT("os/updatefaturacod/" + id + "," + fatura_cod, string.Empty);
        }





        // PUT api/os/updatestatus/<id>,<status>
        public void UpdateStatus(long id, string status)
        {
            string json = WebAPI.RequestPUT("os/updatestatus/" + id + "," + status, string.Empty);
        }





        // DELETE api/os/delete/<id>
        public void Delete(long id)
        {
            string retorno = WebAPI.RequestDELETE("os/delete/", id.ToString());
        }





        // GET: api/os/getordensdofluxo
        public DataTable GetOrdensDoFluxo()
        {
            DataTable retorno = new DataTable();
            string json = WebAPI.RequestGET("os/getordensdofluxo", string.Empty);            
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }





        // GET: api/os/getordensconcluidasafaturar
        public DataTable GetOrdensConcluidasNaoFaturadas()
        {
            DataTable retorno = new DataTable();
            string json = WebAPI.RequestGET("os/getordensconcluidasafaturar", string.Empty);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }





        // GET api/os/getordensfaturadas/<fatura_cod>
        public DataTable GetOrdensFaturadasDoCodigo(long fatura_cod)
        {
            DataTable retorno = new DataTable();
            string json = WebAPI.RequestGET("os/getordensfaturadas/", fatura_cod.ToString());
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }





        // GET: api/os/getfiltered/<filtro>
        public DataTable GetOrdensComFiltro(string filtro)
        {
            DataTable retorno = new DataTable();
            string json = WebAPI.RequestGET("os/getfiltered/",  filtro);
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }





        // GET api/os/getprofissionaisdafatura/<fatura_cod>
        public DataTable GetProfissionaisDaFatura(long fatura_cod)
        {
            DataTable retorno = new DataTable();
            string json = WebAPI.RequestGET("os/getprofissionaisdafatura/", fatura_cod.ToString());
            retorno = JsonConvert.DeserializeObject<DataTable>(json);
            return retorno;
        }





        // GET: api/os/getcidadesdasordens
        public DataTable GetCidadesDasOrdens(bool adicionaTitulo)
        {
            DataTable dtCidades = new DataTable();
            try
            {
                string json = WebAPI.RequestGET("os/getcidadesdasordens", string.Empty);
                dtCidades = JsonConvert.DeserializeObject<DataTable>(json);

                if (adicionaTitulo)
                {
                    DataRow linha = dtCidades.NewRow();
                    linha[0] = "--TODAS--";
                    dtCidades.Rows.InsertAt(linha, 0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtCidades;
        }





        // GET api/os/getby/<id>
        public OsENT GetBy(long id)
        {
            OsENT retorno = new OsENT();
            string json = WebAPI.RequestGET("os/getby/", id.ToString());
            retorno = JsonConvert.DeserializeObject<OsENT>(json);
            return retorno;
        }





    }
}
