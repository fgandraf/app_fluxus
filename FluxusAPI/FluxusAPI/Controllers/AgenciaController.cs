﻿using System;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
using FluxusAPI.Model;
using FluxusAPI.DAO;
using Microsoft.AspNetCore.Http;

namespace FluxusAPI.Controllers
{


    [Route("api/[controller]")]


    public class AgenciaController : ControllerBase
    {



        Autentication AutenticacaoServico;



        public AgenciaController(IHttpContextAccessor context)
        {
            AutenticacaoServico = new Autentication(context);
        }



        // GET: api/agencia
        [HttpGet]
        public ArrayList GetAll()
        {
            try
            {
                AutenticacaoServico.Autenticar();
                return new AgenciaDAO().GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }



        // GET api/agencia/getby/<id>
        [HttpGet]
        [Route("getby/{id}")]
        public AgenciaENT GetBy(long id)
        {
            try
            {
                AutenticacaoServico.Autenticar();
                return new AgenciaDAO().GetBy(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }




        // GET api/agencia/getsomeby/<agenciaCodigo>
        [HttpGet]
        [Route("getsomeby/{agenciaCodigo}")]
        public ArrayList GetSomeBy(string agenciaCodigo)
        {
            try
            {
                AutenticacaoServico.Autenticar();
                return new AgenciaDAO().GetNomeTelefone1EmailBy(agenciaCodigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }





        // POST api/agencia/post
        [HttpPost]
        [Route("post")]
        public ReturnAllServices Post([FromBody] AgenciaENT agencia)
        {
            ReturnAllServices retorno = new ReturnAllServices();
            try
            {
                AutenticacaoServico.Autenticar();

                new AgenciaDAO().Insert(agencia);

                retorno.Result = true;
                retorno.ErrorMessage = "Agencia Cadastrada!";
            }
            catch (Exception ex)
            {
                retorno.Result = false;
                retorno.ErrorMessage = ex.Message;
            }

            return retorno;
        }





        // PUT api/agencia/put/<id>
        [HttpPut]
        [Route("put/{id}")]
        public ReturnAllServices Put(long id, [FromBody] AgenciaENT agencia)
        {
            ReturnAllServices retorno = new ReturnAllServices();
            try
            {
                AutenticacaoServico.Autenticar();

                new AgenciaDAO().Update(id, agencia);

                retorno.Result = true;
                retorno.ErrorMessage = "Agencia Alterada!";
            }
            catch (Exception ex)
            {
                retorno.Result = false;
                retorno.ErrorMessage = ex.Message;
            }

            return retorno;
        }





        // DELETE api/agencia/delete/<id>
        [HttpDelete]
        [Route("delete/{id}")]
        public ReturnAllServices Delete(long id)
        {

            ReturnAllServices retorno = new ReturnAllServices();
            try
            {
                AutenticacaoServico.Autenticar();

                new AgenciaDAO().Delete(id);

                retorno.Result = true;
                retorno.ErrorMessage = "Agencia Excluída!";
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