using System;
using MySql.Data.MySqlClient;
using Fluxus.Api.Entities;
using System.Collections;

namespace Fluxus.Api.Repositories
{


    public class CadastraisRepository
    {
        public ArrayList GetAll()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(ConnectionString.Conn);
                conexao.Open();
                MySqlCommand sql = new MySqlCommand("SELECT * FROM tb_dadoscadastrais", conexao);
                MySqlDataReader dr = sql.ExecuteReader();

                ArrayList cadastraisArray = new ArrayList();

                if (dr.HasRows)
                {
                    Cadastrais cadastrais = new Cadastrais();
                    if (dr.Read())
                    {
                        cadastrais.Cnpj = Convert.ToString(dr["cnpj"]);
                        cadastrais.Fantasia = Convert.ToString(dr["fantasia"]);
                        cadastrais.Razao = Convert.ToString(dr["razao"]);
                        cadastrais.Ie = Convert.ToString(dr["ie"]);
                        cadastrais.Im = Convert.ToString(dr["im"]);
                        cadastrais.Endereco = Convert.ToString(dr["endereco"]);
                        cadastrais.Complemento = Convert.ToString(dr["complemento"]);
                        cadastrais.Bairro = Convert.ToString(dr["bairro"]);
                        cadastrais.Cidade = Convert.ToString(dr["cidade"]);
                        cadastrais.Cep = Convert.ToString(dr["cep"]);
                        cadastrais.Uf = Convert.ToString(dr["uf"]);
                        cadastrais.Constituicao = Convert.ToString(dr["constituicao"]);
                        cadastrais.Telefone = Convert.ToString(dr["telefone"]);
                        cadastrais.Telefone2 = Convert.ToString(dr["telefone2"]);
                        cadastrais.Email = Convert.ToString(dr["email"]);
                        cadastrais.Db_banco = Convert.ToString(dr["db_banco"]);
                        cadastrais.Db_tipo = Convert.ToString(dr["db_tipo"]);
                        cadastrais.Db_agencia = Convert.ToString(dr["db_agencia"]);
                        cadastrais.Db_operador = Convert.ToString(dr["db_operador"]);
                        cadastrais.Db_conta = Convert.ToString(dr["db_conta"]);
                        cadastrais.Ct_tomador = Convert.ToString(dr["ct_tomador"]);
                        cadastrais.Ct_edital = Convert.ToString(dr["ct_edital"]);
                        cadastrais.Ct_contrato = Convert.ToString(dr["ct_contrato"]);
                        cadastrais.Ct_celebrado = Convert.ToString(dr["ct_celebrado"]);
                        cadastrais.Ct_inicio = Convert.ToString(dr["ct_inicio"]);
                        cadastrais.Ct_termino = Convert.ToString(dr["ct_termino"]);
                        cadastrais.Logo = Convert.ToBase64String((byte[])(dr["logo"]));

                        cadastraisArray.Add(cadastrais);
                    }
                    conexao.Close();
                    return cadastraisArray;
                }
                else
                {
                    conexao.Close();
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public byte[] GetLogo()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(ConnectionString.Conn);
                conexao.Open();
                MySqlCommand sql = new MySqlCommand("SELECT logo FROM tb_dadoscadastrais WHERE id = 1", conexao);
                MySqlDataReader dr = sql.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    conexao.Close();
                    return (byte[])(dr["logo"]);
                }
                else
                {
                    conexao.Close();
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }



        public ArrayList GetToPrint()
        {
            try
            {
                ArrayList cadastraisArray = new ArrayList();
                MySqlConnection conexao = new MySqlConnection(ConnectionString.Conn);
                conexao.Open();
                MySqlCommand sql = new MySqlCommand("SELECT cnpj, razao, ct_edital, ct_contrato, logo FROM tb_dadoscadastrais WHERE id = 1", conexao);
                MySqlDataReader dr = sql.ExecuteReader();

                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        dynamic cadastrais = new
                        {
                            Cnpj = Convert.ToString(dr["cnpj"]),
                            Razao = Convert.ToString(dr["razao"]),
                            Ct_edital = Convert.ToString(dr["ct_edital"]),
                            Ct_contrato = Convert.ToString(dr["ct_contrato"]),
                            Logo = (byte[])(dr["logo"])
                        };

                        cadastraisArray.Add(cadastrais);
                    }
                    conexao.Close();
                    return cadastraisArray;
                }
                else
                {
                    conexao.Close();
                    return null;
                }
            }

            catch (Exception)
            {
                throw;
            }
            
        }





        public string GetFantasia()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(ConnectionString.Conn);
                conexao.Open();
                MySqlCommand sql = new MySqlCommand("SELECT fantasia FROM tb_dadoscadastrais WHERE id = 1", conexao);
                MySqlDataReader dr = sql.ExecuteReader();


                if (dr.HasRows)
                {
                    string fantasia = null;

                    if (dr.Read())
                    {
                        fantasia = Convert.ToString(dr["fantasia"]);
                    }
                    conexao.Close();
                    return fantasia;
                }
                else
                {
                    conexao.Close();
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }





        public long Insert(Cadastrais dado)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(ConnectionString.Conn);
                conexao.Open();
                MySqlCommand sql = new MySqlCommand("INSERT INTO tb_dadoscadastrais(id, cnpj, fantasia, razao, ie, im, endereco, complemento, bairro, cidade, cep, uf, constituicao, telefone, telefone2, email, db_banco, db_tipo, db_agencia, db_operador, db_conta, ct_tomador, ct_edital, ct_contrato, ct_celebrado, ct_inicio, ct_termino, logo) VALUES (@id, @cnpj, @fantasia, @razao, @ie, @im, @endereco, @complemento, @bairro, @cidade, @cep, @uf, @constituicao, @telefone, @telefone2, @email, @db_banco, @db_tipo, @db_agencia, @db_operador, @db_conta, @ct_tomador, @ct_edital, @ct_contrato, @ct_celebrado, @ct_inicio, @ct_termino, @logo)", conexao);
                sql.Parameters.AddWithValue("@id", "1");
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
                sql.Parameters.AddWithValue("@constituicao", Util.DateOrNull(dado.Constituicao));
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
                sql.Parameters.AddWithValue("@ct_celebrado", Util.DateOrNull(dado.Ct_celebrado));
                sql.Parameters.AddWithValue("@ct_inicio", Util.DateOrNull(dado.Ct_inicio));
                sql.Parameters.AddWithValue("@ct_termino", Util.DateOrNull(dado.Ct_termino));
                sql.Parameters.AddWithValue("@logo", (byte[])Convert.FromBase64String(dado.Logo));

                sql.ExecuteNonQuery();
                conexao.Close();
                return sql.LastInsertedId;
            }
            catch (Exception)
            {
                throw;
            }
            
        }





        public void Update(Cadastrais dado)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(ConnectionString.Conn);
                conexao.Open();

                MySqlCommand sql = new MySqlCommand("UPDATE tb_dadoscadastrais SET cnpj = @cnpj, fantasia = @fantasia, razao = @razao, ie = @ie, im = @im, endereco = @endereco, complemento = @complemento, bairro = @bairro, cidade = @cidade, cep = @cep, uf = @uf, constituicao = @constituicao, telefone = @telefone, telefone2 = @telefone2, email = @email, db_banco = @db_banco, db_tipo = @db_tipo, db_agencia = @db_agencia, db_operador = @db_operador, db_conta = @db_conta, ct_tomador = @ct_tomador, ct_edital = @ct_edital, ct_contrato = @ct_contrato, ct_celebrado = @ct_celebrado, ct_inicio = @ct_inicio, ct_termino = @ct_termino, logo = @logo WHERE id = @id", conexao);
                sql.Parameters.AddWithValue("@id", "1");
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
                sql.Parameters.AddWithValue("@constituicao", Util.DateOrNull(dado.Constituicao));
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
                sql.Parameters.AddWithValue("@ct_celebrado", Util.DateOrNull(dado.Ct_celebrado));
                sql.Parameters.AddWithValue("@ct_inicio", Util.DateOrNull(dado.Ct_inicio));
                sql.Parameters.AddWithValue("@ct_termino", Util.DateOrNull(dado.Ct_termino));
                sql.Parameters.AddWithValue("@logo", (byte[])Convert.FromBase64String(dado.Logo));

                sql.ExecuteNonQuery();
                conexao.Close();

            }
            catch (Exception)
            {
                throw;
            }
            
        }


    }


}
