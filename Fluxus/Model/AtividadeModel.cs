using Fluxus.Model.ENT;
using Newtonsoft.Json;
using System;
using System.Data;

namespace Fluxus.Model
{
    class AtividadeModel
    {





        // POST api/atividade/post
        public void Insert(AtividadeENT dado)
        {
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = WebAPI.RequestPOST("atividade/post", jsonData);
        }





        // PUT api/atividade/put/<id>
        public void Update(long id, AtividadeENT dado)
        {
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = WebAPI.RequestPUT("atividade/put/" + id, jsonData);
        }





        // DELETE api/atividade/delete/<id>
        public void Delete(long id)
        {
            string retorno = WebAPI.RequestDELETE("atividade/delete/", id.ToString());
        }





        // GET: api/atividade
        public DataTable ListarAtividades(bool adicionaTitulo)
        {
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





        // GET api/atividade/getby/<id>
        public AtividadeENT GetBy(long id)
        {
            AtividadeENT retorno = new AtividadeENT();
            string json = WebAPI.RequestGET("atividade/getby/",  id.ToString());
            retorno = JsonConvert.DeserializeObject<AtividadeENT>(json);
            return retorno;
        }
    
    
    
    
    
    }
}
