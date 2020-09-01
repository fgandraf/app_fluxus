//using



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
        //public static string Usr_senha = null;
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



        public static DataTable Cidades()
        {
            DataTable distinctCidades = new DataTable();
            try
            {
                DataView dvCidades = new DataView(DT.OS);
                dvCidades.Sort = "cidade ASC";
                distinctCidades = dvCidades.ToTable(true, "cidade");
                DataRow linha = distinctCidades.NewRow();
                linha[0] = "--TODAS--";
                distinctCidades.Rows.InsertAt(linha, 0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return distinctCidades;
        }

        public static DataTable Profissionais(bool adicionaTitulo)
        {
            DataTable dtPro = new DataTable();
            try
            {
                DataView dvPro = new DataView(DT.Profissionais);
                dtPro = dvPro.ToTable("Selected", false, "codigo", "nomeid");
                if (adicionaTitulo)
                {
                    DataRow linha = dtPro.NewRow();
                    linha[1] = "--TODOS--";
                    dtPro.Rows.InsertAt(linha, 0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtPro;
        }

        public static DataTable Atividades(bool adicionaTitulo)
        {
            DataTable dtAtividades = new DataTable();
            try
            {
                DataView dvAtividades = new DataView(DT.Atividades);
                dtAtividades = dvAtividades.ToTable("Selected", false, "codigo");
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
