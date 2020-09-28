using System;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
using FluxusAPI.Model;
using FluxusAPI.DAO;
using Microsoft.AspNetCore.Http;

namespace FluxusAPI.Controllers
{


    [Route("api/[controller]")]


    public class OsController : ControllerBase
    {

        Autentication AutenticacaoServico;



        public OsController(IHttpContextAccessor context)
        {
            AutenticacaoServico = new Autentication(context);
        }




        // GET: api/os/getordensdofluxo
        [HttpGet]
        [Route("getordensdofluxo")]
        public ArrayList GetOrdensDoFluxo()
        {
            try
            {
                AutenticacaoServico.Autenticar();
                return new OsDAO().GetOrdensDoFluxo();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }





        // GET: api/os/getcidadesdasordens
        [HttpGet]
        [Route("getcidadesdasordens")]
        public ArrayList GetCidadesDasOrdens()
        {
            try
            {
                AutenticacaoServico.Autenticar();
                return new OsDAO().GetCidadesDasOrdens();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }




        // GET: api/os/getordensconcluidasafaturar
        [HttpGet]
        [Route("getordensconcluidasafaturar")]
        public ArrayList GetOrdensConcluidasAFaturar()
        {
            try
            {
                AutenticacaoServico.Autenticar();
                return new OsDAO().GetOrdensConcluidasAFaturar();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }





        // GET: api/os/getfiltered/<filtro>
        [HttpGet]
        [Route("getfiltered/{filtro}")]
        public ArrayList GetFiltered(string filtro)
        {
            try
            {
                AutenticacaoServico.Autenticar();
                return new OsDAO().GetFiltered(filtro);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }




        // GET api/os/getordensfaturadas/<fatura_cod>
        [HttpGet]
        [Route("getordensfaturadas/{fatura_cod}")]
        public ArrayList GetOrdensFaturadas(int fatura_cod)
        {
            try
            {
                AutenticacaoServico.Autenticar();
                return new OsDAO().GetOrdensFaturadasBy(fatura_cod);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }





        // GET api/os/getprofissionaisdafatura/<fatura_cod>
        [HttpGet]
        [Route("getprofissionaisdafatura/{fatura_cod}")]
        public ArrayList GetProfissionaisDaFatura(int fatura_cod)
        {
            try
            {
                AutenticacaoServico.Autenticar();
                return new OsDAO().GetProfissionaisDaFatura(fatura_cod);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }





        // GET api/os/getby/<id>
        [HttpGet]
        [Route("getby/{id}")]
        public OsENT GetBy(long id)
        {
            try
            {
                AutenticacaoServico.Autenticar();
                return new OsDAO().GetBy(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }





        // POST api/os/post
        [HttpPost]
        [Route("post")]
        public ReturnAllServices Post([FromBody] OsENT os)
        {
            ReturnAllServices retorno = new ReturnAllServices();
            try
            {
                AutenticacaoServico.Autenticar();

                new OsDAO().Insert(os);

                retorno.Result = true;
                retorno.ErrorMessage = "O.S. Cadastrada!";
            }
            catch (Exception ex)
            {
                retorno.Result = false;
                retorno.ErrorMessage = ex.Message;
            }

            return retorno;
        }





        // PUT api/os/put/<id>
        [HttpPut]
        [Route("put/{id}")]
        public ReturnAllServices Put(long id, [FromBody] OsENT os)
        {
            ReturnAllServices retorno = new ReturnAllServices();
            try
            {
                AutenticacaoServico.Autenticar();

                new OsDAO().Update(id, os);

                retorno.Result = true;
                retorno.ErrorMessage = "O.S. Alterada!";
            }
            catch (Exception ex)
            {
                retorno.Result = false;
                retorno.ErrorMessage = ex.Message;
            }

            return retorno;
        }





        // PUT api/os/updatefaturacod/<id>,<fatura_cod>
        [HttpPut]
        [Route("updatefaturacod/{id},{fatura_cod}")]
        public ReturnAllServices UpdateFaturaCod(long id, long fatura_cod)
        {
            ReturnAllServices retorno = new ReturnAllServices();
            try
            {
                AutenticacaoServico.Autenticar();

                new OsDAO().UpdateFaturaCod(id, fatura_cod);

                retorno.Result = true;
                retorno.ErrorMessage = "O.S. Alterada!";
            }
            catch (Exception ex)
            {
                retorno.Result = false;
                retorno.ErrorMessage = ex.Message;
            }

            return retorno;
        }




        // PUT api/os/updatestatus/<id>,<status>
        [HttpPut]
        [Route("updatestatus/{id},{status}")]
        public ReturnAllServices UpdateStatus(long id, string status)
        {
            ReturnAllServices retorno = new ReturnAllServices();
            try
            {
                AutenticacaoServico.Autenticar();

                new OsDAO().UpdateStatus(id, status);

                retorno.Result = true;
                retorno.ErrorMessage = "O.S. Alterada!";
            }
            catch (Exception ex)
            {
                retorno.Result = false;
                retorno.ErrorMessage = ex.Message;
            }

            return retorno;
        }





        // DELETE api/os/delete/<referencia>
        [HttpDelete]
        [Route("delete/{referencia}")]
        public ReturnAllServices Delete(long id)
        {
            ReturnAllServices retorno = new ReturnAllServices();
            try
            {
                AutenticacaoServico.Autenticar();

                new OsDAO().Delete(id);

                retorno.Result = true;
                retorno.ErrorMessage = "O.S. Excluída!";
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
