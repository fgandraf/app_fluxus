using System;
using MySql.Data.MySqlClient;
using FluxusAPI.Model;
using System.Collections;

namespace FluxusAPI.DAO
{


    public class ProfissionalDAO
    {


        MySqlCommand sql;
        Connection con = new Connection();




        public ArrayList GetAll()
        {
            try
            {
                ArrayList profissionalArray = new ArrayList();
                con.OpenConnection();
                sql = new MySqlCommand("SELECT id, codigo, nome, profissao, telefone1, usr_ativo FROM tb_profissionais ORDER BY codigo", con.Conn);
                MySqlDataReader dr = sql.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ProfissionalENT profissional = new ProfissionalENT();

                        profissional.Id = Convert.ToInt64(dr["id"]);
                        profissional.Codigo = Convert.ToString(dr["codigo"]);
                        profissional.Nome = Convert.ToString(dr["nome"]);
                        profissional.Profissao = Convert.ToString(dr["profissao"]);
                        profissional.Telefone1 = Convert.ToString(dr["telefone1"]);
                        profissional.Usr_ativo = Convert.ToBoolean(dr["usr_ativo"]);

                        profissionalArray.Add(profissional);
                    }
                    return profissionalArray;
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





        public ArrayList GetCodigoENomeid()
        {
            try
            {
                ArrayList profissionalArray = new ArrayList();
                con.OpenConnection();
                sql = new MySqlCommand("SELECT codigo, nomeid FROM tb_profissionais ORDER BY codigo", con.Conn);
                MySqlDataReader dr = sql.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dynamic profissional = new
                        {
                            Codigo = Convert.ToString(dr["codigo"]),
                            Nomeid = Convert.ToString(dr["nomeid"])
                        };

                        profissionalArray.Add(profissional);
                    }
                    return profissionalArray;
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





        public ArrayList GetUserInfoBy(string nomeDeUsuario)
        {
            try
            {
                ArrayList userArray = new ArrayList();

                con.OpenConnection();
                sql = new MySqlCommand("SELECT codigo, rt, rl, usr_nome, usr_senha, usr_ativo FROM tb_profissionais WHERE usr_nome = @usr_nome", con.Conn);
                sql.Parameters.AddWithValue("@usr_nome", nomeDeUsuario);
                MySqlDataReader dr = sql.ExecuteReader();

                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        dynamic user = new
                        {
                            Codigo = Convert.ToString(dr["codigo"]),
                            Rt = Convert.ToBoolean(dr["rt"]),
                            Rl = Convert.ToBoolean(dr["rl"]),
                            Usr_ativo = Convert.ToBoolean(dr["usr_ativo"]),
                            Usr_nome = Convert.ToString(dr["usr_nome"]),
                            Usr_senha = Convert.ToString(dr["usr_senha"])
                        };
                        userArray.Add(user);
                    }

                    return userArray;
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




        public ProfissionalENT GetBy(long id)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("SELECT * FROM tb_profissionais WHERE id = @id", con.Conn);
                sql.Parameters.AddWithValue("@id", id);
                MySqlDataReader dr = sql.ExecuteReader();

                if (dr.HasRows)
                {
                    ProfissionalENT profissional = new ProfissionalENT();
                    if (dr.Read())
                    {
                        profissional.Id = Convert.ToInt64(dr["id"]);
                        profissional.Codigo = Convert.ToString(dr["codigo"]);
                        profissional.Nome = Convert.ToString(dr["nome"]);
                        profissional.Nomeid = Convert.ToString(dr["nomeid"]);
                        profissional.Cpf = Convert.ToString(dr["cpf"]);
                        profissional.Nascimento = Convert.ToDateTime(dr["nascimento"]);
                        profissional.Profissao = Convert.ToString(dr["profissao"]);
                        profissional.Carteira = Convert.ToString(dr["carteira"]);
                        profissional.Entidade = Convert.ToString(dr["entidade"]);
                        profissional.Telefone1 = Convert.ToString(dr["telefone1"]);
                        profissional.Telefone2 = Convert.ToString(dr["telefone2"]);
                        profissional.Email = Convert.ToString(dr["email"]);
                        profissional.Rt = Convert.ToBoolean(dr["rt"]);
                        profissional.Rl = Convert.ToBoolean(dr["rl"]);
                        profissional.Usr_ativo = Convert.ToBoolean(dr["usr_ativo"]);
                        profissional.Usr_nome = Convert.ToString(dr["usr_nome"]);
                        profissional.Usr_senha = Convert.ToString(dr["usr_senha"]);
                    }
                    return profissional;
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





        public long Insert(ProfissionalENT dado)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("INSERT INTO tb_profissionais(codigo, nome, nomeid, cpf, nascimento, profissao, carteira, entidade, telefone1, telefone2, email, rt, rl, usr_ativo, usr_nome, usr_senha) VALUES (@codigo, @nome, @nomeid, @cpf, @nascimento, @profissao, @carteira, @entidade, @telefone1, @telefone2, @email, @rt, @rl, @usr_ativo, @usr_nome, @usr_senha)", con.Conn);
                sql.Parameters.AddWithValue("@codigo", dado.Codigo);
                sql.Parameters.AddWithValue("@nome", dado.Nome);
                sql.Parameters.AddWithValue("@nomeid", dado.Nomeid);
                sql.Parameters.AddWithValue("@cpf", dado.Cpf);
                sql.Parameters.AddWithValue("@nascimento", dado.Nascimento);
                sql.Parameters.AddWithValue("@profissao", dado.Profissao);
                sql.Parameters.AddWithValue("@carteira", dado.Carteira);
                sql.Parameters.AddWithValue("@entidade", dado.Entidade);
                sql.Parameters.AddWithValue("@telefone1", dado.Telefone1);
                sql.Parameters.AddWithValue("@telefone2", dado.Telefone2);
                sql.Parameters.AddWithValue("@email", dado.Email);
                sql.Parameters.AddWithValue("@rt", dado.Rt);
                sql.Parameters.AddWithValue("@rl", dado.Rl);
                sql.Parameters.AddWithValue("@usr_ativo", dado.Usr_ativo);
                sql.Parameters.AddWithValue("@usr_nome", dado.Usr_nome);
                sql.Parameters.AddWithValue("@usr_senha", dado.Usr_senha);

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





        public void Update(long id, ProfissionalENT dado)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("UPDATE tb_profissionais SET nome = @nome, nomeid = @nomeid, cpf = @cpf, nascimento = @nascimento, profissao = @profissao, carteira = @carteira, entidade = @entidade, telefone1 = @telefone1, telefone2 = @telefone2, email = @email, rt = @rt, rl = @rl, usr_ativo = @usr_ativo, usr_nome = @usr_nome, usr_senha = @usr_senha WHERE id = @id", con.Conn);
                sql.Parameters.AddWithValue("@id", id);
                sql.Parameters.AddWithValue("@nome", dado.Nome);
                sql.Parameters.AddWithValue("@nomeid", dado.Nomeid);
                sql.Parameters.AddWithValue("@cpf", dado.Cpf);
                sql.Parameters.AddWithValue("@nascimento", dado.Nascimento);
                sql.Parameters.AddWithValue("@profissao", dado.Profissao);
                sql.Parameters.AddWithValue("@carteira", dado.Carteira);
                sql.Parameters.AddWithValue("@entidade", dado.Entidade);
                sql.Parameters.AddWithValue("@telefone1", dado.Telefone1);
                sql.Parameters.AddWithValue("@telefone2", dado.Telefone2);
                sql.Parameters.AddWithValue("@email", dado.Email);
                sql.Parameters.AddWithValue("@rt", dado.Rt);
                sql.Parameters.AddWithValue("@rl", dado.Rl);
                sql.Parameters.AddWithValue("@usr_ativo", dado.Usr_ativo);
                sql.Parameters.AddWithValue("@usr_nome", dado.Usr_nome);
                sql.Parameters.AddWithValue("@usr_senha", dado.Usr_senha);
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
                sql = new MySqlCommand("DELETE FROM tb_profissionais WHERE id = @id", con.Conn);
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
