using System;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
using FluxusAPI.Model;
using FluxusAPI.DAO;
using Microsoft.AspNetCore.Http;

namespace FluxusAPI.Controllers
{


    [Route("api/[controller]")]


    public class FaturaController : ControllerBase
    {

        Autentication AutenticacaoServico;



        public FaturaController(IHttpContextAccessor context)
        {
            AutenticacaoServico = new Autentication(context);
        }



        // GET: api/fatura
        [HttpGet]
        public ArrayList GetAll()
        {
            try
            {
                AutenticacaoServico.Autenticar();
                return new FaturaDAO().GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }





        // GET api/fatura/getdescricao/<id>
        [HttpGet]
        [Route("getdescricao/{id}")]
        public string GetDescricao(string id)
        {
            try
            {
                AutenticacaoServico.Autenticar();
                return new FaturaDAO().GetDescricaoBy(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }





        // POST api/fatura/post
        [HttpPost]
        [Route("post")]
        public ReturnAllServices Post([FromBody] FaturaENT fatura)
        {
            ReturnAllServices retorno = new ReturnAllServices();
            try
            {
                AutenticacaoServico.Autenticar();

                new FaturaDAO().Insert(fatura);

                retorno.Result = true;
                retorno.ErrorMessage = "Fatura Cadastrada!";
            }
            catch (Exception ex)
            {
                retorno.Result = false;
                retorno.ErrorMessage = ex.Message;
            }

            return retorno;
        }





        // PUT api/fatura/put/<id>
        [HttpPut]
        [Route("puttotals/{id}")]
        public ReturnAllServices PutTotals(long id, [FromBody] FaturaENT fatura)
        {
            ReturnAllServices retorno = new ReturnAllServices();
            try
            {
                AutenticacaoServico.Autenticar();

                new FaturaDAO().UpdateTotals(id, fatura);

                retorno.Result = true;
                retorno.ErrorMessage = "Fatura Alterada!";
            }
            catch (Exception ex)
            {
                retorno.Result = false;
                retorno.ErrorMessage = ex.Message;
            }

            return retorno;
        }





        // DELETE api/fatura/delete/<id>
        [HttpDelete]
        [Route("delete/{id}")]
        public ReturnAllServices Delete(string id)
        {
            ReturnAllServices retorno = new ReturnAllServices();
            try
            {
                AutenticacaoServico.Autenticar();

                new FaturaDAO().Delete(id);

                retorno.Result = true;
                retorno.ErrorMessage = "Fatura Excluída!";
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
