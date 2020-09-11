//using



using Arqueng.MODEL;
using System;
using System.Data;

namespace Arqueng.ENTIDADES
{
    public class Globais
    {
        //USER LOGGED
        public static string Codpro = null;
        public static bool Rt = false;
        public static bool Rl = false;
        public static bool Usr_ativo = false;
        public static string Usr_nome = null;
        //GENERAL INFO
        public static string Versao = "1.0b";
        //COMPANY INFO
        public static string Razao = null;
        public static string Fantasia = null;
        public static string Cnpj = null;
        public static byte[] Logo = null;
        //CONTRACT INFO
        public static string Edital = null;
        public static string Contrato = null;



        //public static DataTable Cidades()
        //{
        //    DataTable distinctCidades = new DataTable();
        //    try
        //    {
        //        DataView dvCidades = new DataView(DT.OS);
        //        dvCidades.Sort = "cidade ASC";
        //        distinctCidades = dvCidades.ToTable(true, "cidade");
        //        DataRow linha = distinctCidades.NewRow();
        //        linha[0] = "--TODAS--";
        //        distinctCidades.Rows.InsertAt(linha, 0);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return distinctCidades;
        //}

        public static DataTable Cidades(bool adicionaTitulo)
        {
            DataTable distinctCidades = new DataTable();
            OsMODEL model = new OsMODEL();
            try
            {
                distinctCidades = model.DistinctCidadesModel();

                if (adicionaTitulo)
                {
                    DataRow linha = distinctCidades.NewRow();
                    linha[0] = "--TODAS--";
                    distinctCidades.Rows.InsertAt(linha, 0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return distinctCidades;
        }

        //public static DataTable Profissionais(bool adicionaTitulo)
        //{
        //    //DataTable dtPro = new DataTable();
        //    //try
        //    //{
        //    //    ProfissionaisMODEL model = new ProfissionaisMODEL();
        //    //    dtPro = model.ListarCodigoENomeidModel();
                
        //    //    if (adicionaTitulo)
        //    //    {
        //    //        DataRow linha = dtPro.NewRow();
        //    //        linha[1] = "--TODOS--";
        //    //        dtPro.Rows.InsertAt(linha, 0);
        //    //    }
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    throw ex;
        //    //}
        //    //return dtPro;
        //}

        public static DataTable Atividades(bool adicionaTitulo)
        {
            DataTable dtAtividades = new DataTable();
            AtividadesMODEL model = new AtividadesMODEL();
            try
            {
                DataView dvAtividades = new DataView(model.ListarAtividadesModel());
                dtAtividades = dvAtividades.ToTable("Selected", false, "codigo", "descricao", "valor_atividade", "valor_deslocamento");
                if (adicionaTitulo)
                {
                    DataRow linha = dtAtividades.NewRow();
                    linha[0] = "--TODAS--";
                    dtAtividades.Rows.InsertAt(linha, 0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtAtividades;
        }
    }
}
