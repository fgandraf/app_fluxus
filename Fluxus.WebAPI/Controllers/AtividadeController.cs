using System;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
using FluxusAPI.Model;
using FluxusAPI.DAO;
using Microsoft.AspNetCore.Http;

namespace FluxusAPI.Controllers
{
   
    
    [Route("api/[controller]")]


    public class AtividadeController : ControllerBase
    {


        Autentication AutenticacaoServico;



        public AtividadeController(IHttpContextAccessor context)
        {
            AutenticacaoServico = new Autentication(context);
        }



        // GET: api/atividade
        [HttpGet]
        public ArrayList GetAll()
        {
            try
            {
                AutenticacaoServico.Autenticar();
                return new AtividadeDAO().GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            
        }


        // GET api/atividade/getby/<id>
        [HttpGet]
        [Route("getby/{id}")]
        public AtividadeENT GetBy(long id)
        {
            try
            {
                AutenticacaoServico.Autenticar();
                return new AtividadeDAO().GetBy(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        // POST api/atividade/post
        [HttpPost]
        [Route("post")]
        public ReturnAllServices Post([FromBody] AtividadeENT atividade)
        {
            ReturnAllServices retorno = new ReturnAllServices();
            AtividadeDAO atividadeDAO = new AtividadeDAO();
            try
            {
                AutenticacaoServico.Autenticar();

                new AtividadeDAO().Insert(atividade);

                retorno.Result = true;
                retorno.ErrorMessage = "Atividade Cadastrada!";
            }
            catch (Exception ex)
            {
                retorno.Result = false;
                retorno.ErrorMessage = ex.Message;
            }

            return retorno;
        }





        // PUT api/atividade/put/<id>
        [HttpPut]
        [Route("put/{id}")]
        public ReturnAllServices Put(long id, [FromBody] AtividadeENT atividade)
        {
            ReturnAllServices retorno = new ReturnAllServices();
            try
            {
                AutenticacaoServico.Autenticar();

                new AtividadeDAO().Update(id, atividade);

                retorno.Result = true;
                retorno.ErrorMessage = "Atividade Alterada!";
            }
            catch (Exception ex)
            {
                retorno.Result = false;
                retorno.ErrorMessage = ex.Message;
            }

            return retorno;
                
        }





        // DELETE api/atividade/delete/<id>
        [HttpDelete]
        [Route("delete/{id}")]
        public ReturnAllServices Delete(long id)
        {
            ReturnAllServices retorno = new ReturnAllServices();
            try
            {
                AutenticacaoServico.Autenticar();

                new AtividadeDAO().Delete(id);

                retorno.Result = true;
                retorno.ErrorMessage = "Atividade Excluída!";
            }
            catch (Exception ex)
            {
                retorno.Result = false;
                retorno.ErrorMessage = ex.Message;
            }

            return retorno;

        }


    }


}
