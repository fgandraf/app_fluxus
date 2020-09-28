using System;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
using FluxusAPI.Model;
using FluxusAPI.DAO;
using Microsoft.AspNetCore.Http;

namespace FluxusAPI.Controllers
{


    [Route("api/[controller]")]


    public class ProfissionalController : ControllerBase
    {


        Autentication AutenticacaoServico;



        public ProfissionalController(IHttpContextAccessor context)
        {
            AutenticacaoServico = new Autentication(context);
        }




        // GET: api/profissional
        [HttpGet]
        public ArrayList GetAll()
        {
            try
            {
                AutenticacaoServico.Autenticar();
                return new ProfissionalDAO().GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }





        // GET api/profissional/getcodigoenomeid
        [HttpGet]
        [Route("getcodigoenomeid")]
        public ArrayList GetCodigoENomeid()
        {
            try
            {
                AutenticacaoServico.Autenticar();
                return new ProfissionalDAO().GetCodigoENomeid();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }






        // GET api/profissional/getuserinfo/<userName>
        [HttpGet]
        [Route("getuserinfo/{userName}")]
        public ArrayList GetUserInfo(string userName)
        {
            try
            {
                AutenticacaoServico.Autenticar();
                return new ProfissionalDAO().GetUserInfoBy(userName);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }







        // POST api/profissional/post
        [HttpPost]
        [Route("post")]
        public ReturnAllServices Post([FromBody] ProfissionalENT profissional)
        {
            ReturnAllServices retorno = new ReturnAllServices();
            try
            {
                AutenticacaoServico.Autenticar();

                new ProfissionalDAO().Insert(profissional);

                retorno.Result = true;
                retorno.ErrorMessage = "Profissional Cadastrado!";
            }
            catch (Exception ex)
            {
                retorno.Result = false;
                retorno.ErrorMessage = ex.Message;
            }

            return retorno;
        }





        // PUT api/profissional/put/<id>
        [HttpPut]
        [Route("put/{id}")]
        public ReturnAllServices Put(long id, [FromBody] ProfissionalENT profissional)
        {
            ReturnAllServices retorno = new ReturnAllServices();
            try
            {
                AutenticacaoServico.Autenticar();

                new ProfissionalDAO().Update(id, profissional);

                retorno.Result = true;
                retorno.ErrorMessage = "Profissional Alterado!";
            }
            catch (Exception ex)
            {
                retorno.Result = false;
                retorno.ErrorMessage = ex.Message;
            }

            return retorno;
        }





        // DELETE api/profissional/delete/<id>
        [HttpDelete]
        [Route("delete/{id}")]
        public ReturnAllServices Delete(long id)
        {
            ReturnAllServices retorno = new ReturnAllServices();
            try
            {
                AutenticacaoServico.Autenticar();

                new ProfissionalDAO().Delete(id);

                retorno.Result = true;
                retorno.ErrorMessage = "Profissional Excluído!";
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
