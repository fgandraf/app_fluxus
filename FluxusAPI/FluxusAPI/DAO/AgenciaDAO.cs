using System;
using MySql.Data.MySqlClient;
using FluxusAPI.Model;
using System.Collections;

namespace FluxusAPI.DAO
{


    public class AgenciaDAO
    {



        MySqlCommand sql;
        Connection con = new Connection();





        public ArrayList GetAll()
        {
            try
            {
                ArrayList agenciaArray = new ArrayList();
                con.OpenConnection();
                sql = new MySqlCommand("SELECT id, agencia, nome, cidade, telefone1, email FROM tb_agencias ORDER BY agencia", con.Conn);

                MySqlDataReader dr = sql.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        AgenciaENT agencia = new AgenciaENT();

                        agencia.Id = Convert.ToInt64(dr["id"]);
                        agencia.Agencia = Convert.ToString(dr["agencia"]);
                        agencia.Nome = Convert.ToString(dr["nome"]);
                        agencia.Cidade = Convert.ToString(dr["cidade"]);
                        agencia.Telefone1 = Convert.ToString(dr["telefone1"]);
                        agencia.Email = Convert.ToString(dr["email"]);

                        agenciaArray.Add(agencia);
                    }

                    return agenciaArray;
                }
                else
                    return null;
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





        public AgenciaENT GetBy(long id)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("SELECT * FROM tb_agencias WHERE id = @id", con.Conn);
                sql.Parameters.AddWithValue("@id", id);
                MySqlDataReader dr = sql.ExecuteReader();

                if (dr.HasRows)
                {
                    AgenciaENT agencia = new AgenciaENT();
                    if (dr.Read())
                    {
                        agencia.Id = Convert.ToInt64(dr["id"]);
                        agencia.Agencia = Convert.ToString(dr["agencia"]);
                        agencia.Nome = Convert.ToString(dr["nome"]);
                        agencia.Endereco = Convert.ToString(dr["endereco"]);
                        agencia.Complemento = Convert.ToString(dr["complemento"]);
                        agencia.Bairro = Convert.ToString(dr["bairro"]);
                        agencia.Cidade = Convert.ToString(dr["cidade"]);
                        agencia.CEP = Convert.ToString(dr["cep"]);
                        agencia.UF = Convert.ToString(dr["uf"]);
                        agencia.Contato = Convert.ToString(dr["contato"]);
                        agencia.Telefone1 = Convert.ToString(dr["telefone1"]);
                        agencia.Telefone2 = Convert.ToString(dr["telefone2"]);
                        agencia.Email = Convert.ToString(dr["email"]);
                    }
                    return agencia;
                }
                else
                    return null;
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





        public ArrayList GetNomeTelefone1EmailBy(string agenciaCodigo)
        {
            try
            {
                ArrayList agenciaArray = new ArrayList();

                con.OpenConnection();
                sql = new MySqlCommand("SELECT agencia, nome, telefone1, email FROM tb_agencias WHERE agencia = @agencia", con.Conn);
                sql.Parameters.AddWithValue("@agencia", agenciaCodigo);
                MySqlDataReader dr = sql.ExecuteReader();

                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        dynamic agencia = new
                        {
                            Agencia = Convert.ToString(dr["agencia"]),
                            Nome = Convert.ToString(dr["nome"]),
                            Telefone1 = Convert.ToString(dr["telefone1"]),
                            Email = Convert.ToString(dr["email"])
                        };

                        agenciaArray.Add(agencia);
                    }
                    return agenciaArray;
                }
                else
                    return null;
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





        public long Insert(AgenciaENT dado)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("INSERT INTO  tb_agencias(agencia, nome, endereco, complemento, bairro, cidade, CEP, UF, contato, telefone1, telefone2, email) VALUES (@agencia, @nome, @endereco, @complemento, @bairro, @cidade, @CEP, @UF, @contato, @telefone1, @telefone2, @email)", con.Conn);
                sql.Parameters.AddWithValue("@agencia", dado.Agencia);
                sql.Parameters.AddWithValue("@nome", dado.Nome);
                sql.Parameters.AddWithValue("@endereco", dado.Endereco);
                sql.Parameters.AddWithValue("@complemento", dado.Complemento);
                sql.Parameters.AddWithValue("@bairro", dado.Bairro);
                sql.Parameters.AddWithValue("@cidade", dado.Cidade);
                sql.Parameters.AddWithValue("@CEP", dado.CEP);
                sql.Parameters.AddWithValue("@UF", dado.UF);
                sql.Parameters.AddWithValue("@contato", dado.Contato);
                sql.Parameters.AddWithValue("@telefone1", dado.Telefone1);
                sql.Parameters.AddWithValue("@telefone2", dado.Telefone2);
                sql.Parameters.AddWithValue("@email", dado.Email);
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





        public void Update(long id, AgenciaENT dado)
        {
            try
            {
                con.OpenConnection();

                sql = new MySqlCommand("UPDATE tb_agencias SET agencia = @agencia, nome = @nome, endereco = @endereco, complemento = @complemento, bairro = @bairro, cidade = @cidade, CEP = @CEP, UF = @UF, contato = @contato, telefone1 = @telefone1, telefone2 = @telefone2, email = @email WHERE id = @id", con.Conn);
                sql.Parameters.AddWithValue("@agencia", dado.Agencia);
                sql.Parameters.AddWithValue("@nome", dado.Nome);
                sql.Parameters.AddWithValue("@endereco", dado.Endereco);
                sql.Parameters.AddWithValue("@complemento", dado.Complemento);
                sql.Parameters.AddWithValue("@bairro", dado.Bairro);
                sql.Parameters.AddWithValue("@cidade", dado.Cidade);
                sql.Parameters.AddWithValue("@CEP", dado.CEP);
                sql.Parameters.AddWithValue("@UF", dado.UF);
                sql.Parameters.AddWithValue("@contato", dado.Contato);
                sql.Parameters.AddWithValue("@telefone1", dado.Telefone1);
                sql.Parameters.AddWithValue("@telefone2", dado.Telefone2);
                sql.Parameters.AddWithValue("@email", dado.Email);
                sql.Parameters.AddWithValue("@id", id);
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





        public void Delete(long id)
        {
            try
            {
                con.OpenConnection();

                sql = new MySqlCommand("DELETE FROM tb_agencias WHERE id = @id", con.Conn);
                sql.Parameters.AddWithValue("@id", id);
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





    }


}
