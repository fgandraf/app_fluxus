using System;
using System.Data;
using Arqueng.DAO;
using Arqueng.ENTIDADES;

namespace Arqueng.MODEL
{


    public class CadastraisMODEL
    {


        CadastraisDAO dao = new CadastraisDAO();



        public void BuscarCadastraisModel(CadastraisENT dado)
        {
            try
            {
                dao.BuscarCadastraisDAO(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void BuscarDadosEmpModel(CadastraisENT dado)
        {
            try
            {
                dao.BuscarDadosEmpDAO(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void InsertCadastraisModel(CadastraisENT dado)
        {
            try
            {
                dao.InsertCadastraisDAO(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void UpdateCadastraisModel(CadastraisENT dado)
        {
            try
            {
                dao.UpdateCadastraisDAO(dado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }


}
