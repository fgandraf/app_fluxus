using Microsoft.AspNetCore.Http;
using System;

namespace Fluxus.API
{
    public class Autentication
    {
        public const string TOKEN = "xz8wM6zr2RfF18GBM0B5yrkoo";
        
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
                    throw new Exception("Token inválido");

            }
            catch
            {
                throw new Exception("Não foi possível estabelecer a conexão!");
            }

        }


    }
}
