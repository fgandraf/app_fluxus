using System;
using MySql.Data.MySqlClient;
using Arqueng.ENTIDADES;

namespace Arqueng.DAO
{


    public class CadastraisDAO
    {
        MySqlCommand sql;
        CONEXAO con = new CONEXAO();


        public void BuscarCadastraisDAO(CadastraisENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM tb_dadoscadastrais WHERE codigo = @codigo", con.con);
                sql.Parameters.AddWithValue("@codigo", "1");
                MySqlDataReader dr = sql.ExecuteReader();

                if (dr.HasRows == false)
                {
                    dado.Cnpj = null;
                    return;
                }
                else
                {
                    while (dr.Read())
                    {
                        dado.Cnpj = Convert.ToString(dr["cnpj"]);
                        dado.Fantasia = Convert.ToString(dr["fantasia"]);
                        dado.Razao = Convert.ToString(dr["razao"]);
                        dado.Ie = Convert.ToString(dr["ie"]);
                        dado.Im = Convert.ToString(dr["im"]);
                        dado.Endereco = Convert.ToString(dr["endereco"]);
                        dado.Complemento = Convert.ToString(dr["complemento"]);
                        dado.Bairro = Convert.ToString(dr["bairro"]);
                        dado.Cidade = Convert.ToString(dr["cidade"]);
                        dado.Cep = Convert.ToString(dr["cep"]);
                        dado.Uf = Convert.ToString(dr["uf"]);
                       
                        dado.Constituicao = Convert.ToDateTime(dr["constituicao"]);
                        
                        dado.Representante = Convert.ToString(dr["representante"]);
                        dado.Telefone = Convert.ToString(dr["telefone"]);
                        dado.Telefone2 = Convert.ToString(dr["telefone2"]);
                        dado.Email = Convert.ToString(dr["email"]);
                        dado.Db_banco = Convert.ToString(dr["db_banco"]);
                        dado.Db_tipo = Convert.ToString(dr["db_tipo"]);
                        dado.Db_agencia = Convert.ToString(dr["db_agencia"]);
                        dado.Db_operador = Convert.ToString(dr["db_operador"]);
                        dado.Db_conta = Convert.ToString(dr["db_conta"]);
                    }
                }

                con.FecharConexao();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void BuscarFantasiaDAO(CadastraisENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT fantasia FROM tb_dadoscadastrais", con.con);
                MySqlDataReader dr = sql.ExecuteReader();

                if (dr.HasRows == false)
                {
                    dado.Fantasia = null;
                    return;
                }                    
                else
                {
                    while (dr.Read())
                    {
                        dado.Fantasia =Convert.ToString(dr["fantasia"]);
                    }
                }
                con.FecharConexao();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void InsertCadastraisDAO(CadastraisENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO tb_dadoscadastrais(codigo, cnpj, fantasia, razao, ie, im, endereco, complemento, bairro, cidade, cep, uf, constituicao, representante, telefone, telefone2, email, db_banco, db_tipo, db_agencia, db_operador, db_conta) VALUES (@codigo, @cnpj, @fantasia, @razao, @ie, @im, @endereco, @complemento, @bairro, @cidade, @cep, @uf, @constituicao, @representante, @telefone, @telefone2 @email, @db_banco, @db_tipo, @db_agencia, @db_operador, @db_conta)", con.con);
                sql.Parameters.AddWithValue("@codigo", "1");
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
                sql.Parameters.AddWithValue("@representante", dado.Representante);
                sql.Parameters.AddWithValue("@telefone", dado.Telefone);
                sql.Parameters.AddWithValue("@telefone2", dado.Telefone);
                sql.Parameters.AddWithValue("@email", dado.Email);
                sql.Parameters.AddWithValue("@db_banco", dado.Db_banco);
                sql.Parameters.AddWithValue("@db_tipo", dado.Db_tipo);
                sql.Parameters.AddWithValue("@db_agencia", dado.Db_agencia);
                sql.Parameters.AddWithValue("@db_operador", dado.Db_operador);
                sql.Parameters.AddWithValue("@db_conta", dado.Db_conta);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception)
            {
                con.FecharConexao();
                throw;
            }
        }


        public void UpdateCadastraisDAO(CadastraisENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE tb_dadoscadastrais SET cnpj = @cnpj, fantasia = @fantasia, razao = @razao, ie = @ie, im = @im, endereco = @endereco, complemento = @complemento, bairro = @bairro, cidade = @cidade, cep = @cep, uf = @uf, constituicao = @constituicao, representante = @representante, telefone = @telefone, telefone2 = @telefone2, email = @email, db_banco = @db_banco, db_tipo = @db_tipo, db_agencia = @db_agencia, db_operador = @db_operador, db_conta = @db_conta WHERE codigo = @codigo", con.con);
                sql.Parameters.AddWithValue("@codigo", "1");
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
                sql.Parameters.AddWithValue("@representante", dado.Representante);
                sql.Parameters.AddWithValue("@telefone", dado.Telefone);
                sql.Parameters.AddWithValue("@telefone2", dado.Telefone2);
                sql.Parameters.AddWithValue("@email", dado.Email);
                sql.Parameters.AddWithValue("@db_banco", dado.Db_banco);
                sql.Parameters.AddWithValue("@db_tipo", dado.Db_tipo);
                sql.Parameters.AddWithValue("@db_agencia", dado.Db_agencia);
                sql.Parameters.AddWithValue("@db_operador", dado.Db_operador);
                sql.Parameters.AddWithValue("@db_conta", dado.Db_conta);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception)
            {
                con.FecharConexao();
                throw;
            }
        }


    }


}
