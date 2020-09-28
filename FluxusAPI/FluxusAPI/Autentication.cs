using Microsoft.AspNetCore.Http;
using System;

namespace FluxusAPI
{
    public class Autentication
    {
        public static string TOKEN = "345HDRgffg2#hjd!246@Úhdfjb02";
        public static string FALHA_AUTENTICACAO = "Falha na autenticação... O token informado é inválido!";
        IHttpContextAccessor contextAcessor;

        public Autentication(IHttpContextAccessor context)
        {
            contextAcessor = context;
        }


        public void Autenticar()
        {
            try
            {
                string TokenRecebido = contextAcessor.HttpContext.Request.Headers["Token"].ToString();

                if (String.Equals(TOKEN, TokenRecebido) == false)
                {
                    throw new Exception(FALHA_AUTENTICACAO);
                }
            }
            catch
            {
                throw new Exception(FALHA_AUTENTICACAO);
            }

        }






    }
}
