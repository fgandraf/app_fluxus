using System;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
using FluxusAPI.Model;
using FluxusAPI.DAO;
using Microsoft.AspNetCore.Http;

namespace FluxusAPI.Controllers
{


    [Route("api/[controller]")]


    public class CadastraisController : ControllerBase
    {

        Autentication AutenticacaoServico;



        public CadastraisController(IHttpContextAccessor context)
        {

            AutenticacaoServico = new Autentication(context);
        }



        // GET: api/cadastrais
        [HttpGet]
        public ArrayList GetAll()
        {
            try
            {
                AutenticacaoServico.Autenticar();
                return new CadastraisDAO().GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }





        // GET api/cadastrais/gettoprint
        [HttpGet]
        [Route("gettoprint")]
        public ArrayList GetToPrint()
        {
            try
            {
                AutenticacaoServico.Autenticar();
                return new CadastraisDAO().GetToPrint();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }






        // GET api/cadastrais/getfantasia
        [HttpGet]
        [Route("getfantasia")]
        public string GetFantasia()
        {
            try
            {
                AutenticacaoServico.Autenticar();
                return new CadastraisDAO().GetFantasia();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }





        // POST api/cadastrais/post
        [HttpPost]
        [Route("post")]
        public ReturnAllServices Post([FromBody] CadastraisENT cadastrais)
        {
            ReturnAllServices retorno = new ReturnAllServices();
            try
            {
                AutenticacaoServico.Autenticar();

                new CadastraisDAO().Insert(cadastrais);

                retorno.Result = true;
                retorno.ErrorMessage = "Dados Cadastrais Cadastrados!";

            }
            catch (Exception ex)
            {
                retorno.Result = false;
                retorno.ErrorMessage = ex.Message;
            }

            return retorno;
        }




        // PUT api/cadastrais/put
        [HttpPut]
        [Route("put")]
        public ReturnAllServices Put([FromBody] CadastraisENT cadastrais)
        {
            ReturnAllServices retorno = new ReturnAllServices();
            try
            {
                AutenticacaoServico.Autenticar();

                new CadastraisDAO().Update(cadastrais);

                retorno.Result = true;
                retorno.ErrorMessage = "Dados Cadastrais Alterados!";
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
