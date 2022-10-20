using Fluxus.Application.Model;
using Newtonsoft.Json;
using System.Data;


namespace Fluxus.Application.Controller
{
    class AtividadeController
    {



        public void Insert(Atividade dado)
        {
            // POST: api/atividade/post
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = Connection.RequestPOST("atividade/post", jsonData);
        }



        public void Update(long id, Atividade dado)
        {
            // PUT: api/atividade/put/<id>
            string jsonData = JsonConvert.SerializeObject(dado);
            string json = string.Empty;

            json = Connection.RequestPUT("atividade/put/" + id, jsonData);
        }



        public void Delete(long id)
        {
            // DELETE: api/atividade/delete/<id>
            string retorno = Connection.RequestDELETE("atividade/delete/", id.ToString());
        }



        public DataTable ListarAtividades(bool adicionaTitulo)
        {
            DataView dvAtividades = new DataView();

            // GET: api/atividade
            DataTable tabela = new DataTable();
            string json = Connection.RequestGET("atividade", string.Empty);
            tabela = JsonConvert.DeserializeObject<DataTable>(json);

            dvAtividades = new DataView(tabela);

            DataTable dtAtividades = dvAtividades.ToTable("Selected", false, "id", "codigo", "descricao", "valor_atividade", "valor_deslocamento");
            if (adicionaTitulo)
            {
                DataRow linha = dtAtividades.NewRow();
                linha[1] = "--TODAS--";
                dtAtividades.Rows.InsertAt(linha, 0);
            }

            return dtAtividades;
        }



        public Atividade GetBy(long id)
        {
            // GET: api/atividade/getby/<id>
            Atividade retorno = new Atividade();
            string json = Connection.RequestGET("atividade/getby/", id.ToString());
            retorno = JsonConvert.DeserializeObject<Atividade>(json);
            return retorno;
        }



    }



}
