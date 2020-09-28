using System;
using MySql.Data.MySqlClient;
using Fluxus.Model.ENT;
using System.Data;

namespace Fluxus.Model.DAO
{


    public class CadastraisDAO
    {
        
        
        MySqlCommand sql;
        Connection con = new Connection();





        public long Insert(CadastraisENT dado)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("INSERT INTO tb_dadoscadastrais(id, cnpj, fantasia, razao, ie, im, endereco, complemento, bairro, cidade, cep, uf, constituicao, telefone, telefone2, email, db_banco, db_tipo, db_agencia, db_operador, db_conta, ct_tomador, ct_edital, ct_contrato, ct_celebrado, ct_inicio, ct_termino, logo) VALUES (1, @cnpj, @fantasia, @razao, @ie, @im, @endereco, @complemento, @bairro, @cidade, @cep, @uf, @constituicao, @telefone, @telefone2, @email, @db_banco, @db_tipo, @db_agencia, @db_operador, @db_conta, @ct_tomador, @ct_edital, @ct_contrato, @ct_celebrado, @ct_inicio, @ct_termino, @logo)", con.Conn);
                sql.Parameters.AddWithValue("@cnpj", dado.Cnpj);
                sql.Parameters.AddWithValue("@fantasia", dado.Fantasia);
                sql.Parameters.AddWithValue("@razao", dado.Razao);
                sql.Parameters.AddWithValue("@ie", dado.Ie);
                sql.Parameters.AddWithValue("@im", dado.Im);
                sql.Parameters.AddWithValue("@endereco", dado.Endereco);
                sql.Parameters.AddWithValue("@complemento", dado.Complemento);
                sql.Parameters.AddWithValue("@bairro", dado.Bairro);
                sql.Parameters.AddWithValue("@cidade", dado.Cidade);
                sql.Parameters.AddWithValue("@cep", dado.Cep);
                sql.Parameters.AddWithValue("@uf", dado.Uf);
                sql.Parameters.AddWithValue("@constituicao", dado.Constituicao);
                sql.Parameters.AddWithValue("@telefone", dado.Telefone);
                sql.Parameters.AddWithValue("@telefone2", dado.Telefone);
                sql.Parameters.AddWithValue("@email", dado.Email);
                sql.Parameters.AddWithValue("@db_banco", dado.Db_banco);
                sql.Parameters.AddWithValue("@db_tipo", dado.Db_tipo);
                sql.Parameters.AddWithValue("@db_agencia", dado.Db_agencia);
                sql.Parameters.AddWithValue("@db_operador", dado.Db_operador);
                sql.Parameters.AddWithValue("@db_conta", dado.Db_conta);
                sql.Parameters.AddWithValue("@ct_tomador", dado.Ct_tomador);
                sql.Parameters.AddWithValue("@ct_edital", dado.Ct_edital);
                sql.Parameters.AddWithValue("@ct_contrato", dado.Ct_contrato);
                sql.Parameters.AddWithValue("@ct_celebrado", dado.Ct_celebrado);
                sql.Parameters.AddWithValue("@ct_inicio", dado.Ct_inicio);
                sql.Parameters.AddWithValue("@ct_termino", dado.Ct_termino);
                sql.Parameters.AddWithValue("@logo", dado.Logo);

                sql.ExecuteNonQuery();
                return sql.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }





        public void Update(CadastraisENT dado)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("UPDATE tb_dadoscadastrais SET cnpj = @cnpj, fantasia = @fantasia, razao = @razao, ie = @ie, im = @im, endereco = @endereco, complemento = @complemento, bairro = @bairro, cidade = @cidade, cep = @cep, uf = @uf, constituicao = @constituicao, telefone = @telefone, telefone2 = @telefone2, email = @email, db_banco = @db_banco, db_tipo = @db_tipo, db_agencia = @db_agencia, db_operador = @db_operador, db_conta = @db_conta, ct_tomador = @ct_tomador, ct_edital = @ct_edital, ct_contrato = @ct_contrato, ct_celebrado = @ct_celebrado, ct_inicio = @ct_inicio, ct_termino = @ct_termino, logo = @logo WHERE id = 1", con.Conn);

                sql.Parameters.AddWithValue("@cnpj", dado.Cnpj);
                sql.Parameters.AddWithValue("@fantasia", dado.Fantasia);
                sql.Parameters.AddWithValue("@razao", dado.Razao);
                sql.Parameters.AddWithValue("@ie", dado.Ie);
                sql.Parameters.AddWithValue("@im", dado.Im);
                sql.Parameters.AddWithValue("@endereco", dado.Endereco);
                sql.Parameters.AddWithValue("@complemento", dado.Complemento);
                sql.Parameters.AddWithValue("@bairro", dado.Bairro);
                sql.Parameters.AddWithValue("@cidade", dado.Cidade);
                sql.Parameters.AddWithValue("@cep", dado.Cep);
                sql.Parameters.AddWithValue("@uf", dado.Uf);
                sql.Parameters.AddWithValue("@constituicao", dado.Constituicao);
                sql.Parameters.AddWithValue("@telefone", dado.Telefone);
                sql.Parameters.AddWithValue("@telefone2", dado.Telefone2);
                sql.Parameters.AddWithValue("@email", dado.Email);
                sql.Parameters.AddWithValue("@db_banco", dado.Db_banco);
                sql.Parameters.AddWithValue("@db_tipo", dado.Db_tipo);
                sql.Parameters.AddWithValue("@db_agencia", dado.Db_agencia);
                sql.Parameters.AddWithValue("@db_operador", dado.Db_operador);
                sql.Parameters.AddWithValue("@db_conta", dado.Db_conta);
                sql.Parameters.AddWithValue("@ct_tomador", dado.Ct_tomador);
                sql.Parameters.AddWithValue("@ct_edital", dado.Ct_edital);
                sql.Parameters.AddWithValue("@ct_contrato", dado.Ct_contrato);
                sql.Parameters.AddWithValue("@ct_celebrado", dado.Ct_celebrado);
                sql.Parameters.AddWithValue("@ct_inicio", dado.Ct_inicio);
                sql.Parameters.AddWithValue("@ct_termino", dado.Ct_termino);
                sql.Parameters.AddWithValue("@logo", dado.Logo);

                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }





        public DataTable GetAll()
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("SELECT * FROM tb_dadoscadastrais WHERE id = 1", con.Conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }





        public DataTable GetToPrint()
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("SELECT cnpj, razao, ct_edital, ct_contrato, logo FROM tb_dadoscadastrais WHERE id = 1", con.Conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }





        public string GetFantasia()
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("SELECT fantasia FROM tb_dadoscadastrais WHERE id = 1", con.Conn);
                MySqlDataReader dr = sql.ExecuteReader();

                string fantasia = null;

                if (dr.Read())
                {
                    fantasia = Convert.ToString(dr["fantasia"]);

                }

                return fantasia;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }

    }


}
