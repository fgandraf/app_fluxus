using System;
using System.Collections;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API.Model.DB;
using API.Model.Entities;

namespace API.Controllers
{
    public class AtividadeController : ApiController
    {


        // GET: api/Atividade
        public ArrayList Get()
        {
            AtividadeDB dao = new AtividadeDB();
            return dao.GetAll();
        }




        // GET: api/Atividade/5
        public AtividadeENT Get(long id)
        {
            AtividadeDB dao = new AtividadeDB();
            AtividadeENT atividade = dao.GetAtividade(id);

            return atividade;
        }




        // POST: api/Atividade
        public HttpResponseMessage Post([FromBody]AtividadeENT dado)
        {
            AtividadeDB atividade = new AtividadeDB();
            long id = atividade.Insert(dado);

            dado.Id = id;

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Request.RequestUri, String.Format("Atividade/{0}", id));

            return response;
        }




        // PUT: api/Atividade/5
        public HttpResponseMessage Put(int id, [FromBody]AtividadeENT dado)
        {
            AtividadeDB atividade = new AtividadeDB();
            bool recordExists = atividade.Update(id, dado);
            HttpResponseMessage response;

            if (recordExists)
            {
                response = Request.CreateResponse(HttpStatusCode.NoContent);
            }
            else
            {
                response = Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return response;
        }




        // DELETE: api/Atividade/5
        public HttpResponseMessage Delete(long id)
        {
            AtividadeDB dao = new AtividadeDB();
            bool recordExists = dao.Delete(id);

            HttpResponseMessage response;

            if (recordExists)
            {
                response = Request.CreateResponse(HttpStatusCode.NoContent);
            }
            else
            {
                response = Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return response;
        }




    }



}
