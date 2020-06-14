using System;
using System.Data;
using MySql.Data.MySqlClient;
using Arqueng.ENTIDADES;

namespace Arqueng.DAO
{
    public class CadastraisDAO
    {
        MySqlCommand sql;
        CONEXAO con = new CONEXAO();

        public DataTable ListarCadastraisDAO()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM tb_dadoscadastrais", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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
                sql = new MySqlCommand("INSERT INTO tb_dadoscadastrais(codigo, cnpj, fantasia, razao, ie, im, endereco, complemento, bairro, cidade, cep, uf, constituicao, representante, telefone, email, db_banco, db_tipo, db_agencia, db_operador, db_conta, ec_cnpj, ec_fantasia, ec_razao, ec_endereco, ec_complemento, ec_bairro, ec_cidade, ec_cep, ec_uf, ec_contato1, ec_cargo1, ec_telefone1, ec_email1, ec_contato2, ec_cargo2, ec_telefone2, ec_email2) VALUES (@codigo, @cnpj, @fantasia, @razao, @ie, @im, @endereco, @complemento, @bairro, @cidade, @cep, @uf, @constituicao, @representante, @telefone, @email, @db_banco, @db_tipo, @db_agencia, @db_operador, @db_conta, @ec_cnpj, @ec_fantasia, @ec_razao, @ec_endereco, @ec_complemento, @ec_bairro, @ec_cidade, @ec_cep, @ec_uf, @ec_contato1, @ec_cargo1, @ec_telefone1, @ec_email1, @ec_contato2, @ec_cargo2, @ec_telefone2, @ec_email2)", con.con);
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
                sql.Parameters.AddWithValue("@email", dado.Email);
                sql.Parameters.AddWithValue("@db_banco", dado.Db_banco);
                sql.Parameters.AddWithValue("@db_tipo", dado.Db_tipo);
                sql.Parameters.AddWithValue("@db_agencia", dado.Db_agencia);
                sql.Parameters.AddWithValue("@db_operador", dado.Db_operador);
                sql.Parameters.AddWithValue("@db_conta", dado.Db_conta);
                sql.Parameters.AddWithValue("@ec_cnpj", dado.Ec_cnpj);
                sql.Parameters.AddWithValue("@ec_fantasia", dado.Ec_fantasia);
                sql.Parameters.AddWithValue("@ec_razao", dado.Ec_razao);
                sql.Parameters.AddWithValue("@ec_endereco", dado.Ec_endereco);
                sql.Parameters.AddWithValue("@ec_complemento", dado.Ec_complemento);
                sql.Parameters.AddWithValue("@ec_bairro", dado.Ec_bairro);
                sql.Parameters.AddWithValue("@ec_cidade", dado.Ec_cidade);
                sql.Parameters.AddWithValue("@ec_cep", dado.Ec_cep);
                sql.Parameters.AddWithValue("@ec_uf", dado.Ec_uf);
                sql.Parameters.AddWithValue("@ec_contato1", dado.Ec_contato1);
                sql.Parameters.AddWithValue("@ec_cargo1", dado.Ec_cargo1);
                sql.Parameters.AddWithValue("@ec_telefone1", dado.Ec_telefone1);
                sql.Parameters.AddWithValue("@ec_email1", dado.Ec_email1);
                sql.Parameters.AddWithValue("@ec_contato2", dado.Ec_contato2);
                sql.Parameters.AddWithValue("@ec_cargo2", dado.Ec_cargo2);
                sql.Parameters.AddWithValue("@ec_telefone2", dado.Ec_telefone2);
                sql.Parameters.AddWithValue("@ec_email2", dado.Ec_email2);
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
                sql = new MySqlCommand("UPDATE tb_dadoscadastrais SET cnpj = @cnpj, fantasia = @fantasia, razao = @razao, ie = @ie, im = @im, endereco = @endereco, complemento = @complemento, bairro = @bairro, cidade = @cidade, cep = @cep, uf = @uf, constituicao = @constituicao, representante = @representante, telefone = @telefone, email = @email, db_banco = @db_banco, db_tipo = @db_tipo, db_agencia = @db_agencia, db_operador = @db_operador, db_conta = @db_conta, ec_cnpj = @ec_cnpj, ec_fantasia = @ec_fantasia, ec_razao = @ec_razao, ec_endereco = @ec_endereco, ec_complemento = @ec_complemento, ec_bairro = @ec_bairro, ec_cidade = @ec_cidade, ec_cep = @ec_cep, ec_uf = @ec_uf, ec_contato1 = @ec_contato1, ec_cargo1 = @ec_cargo1, ec_telefone1 = @ec_telefone1, ec_email1 = @ec_email1, ec_contato2 = @ec_contato2, ec_cargo2 = @ec_cargo2, ec_telefone2 = @ec_telefone2, ec_email2 = @ec_email2 WHERE codigo = @codigo", con.con);
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
                sql.Parameters.AddWithValue("@email", dado.Email);
                sql.Parameters.AddWithValue("@db_banco", dado.Db_banco);
                sql.Parameters.AddWithValue("@db_tipo", dado.Db_tipo);
                sql.Parameters.AddWithValue("@db_agencia", dado.Db_agencia);
                sql.Parameters.AddWithValue("@db_operador", dado.Db_operador);
                sql.Parameters.AddWithValue("@db_conta", dado.Db_conta);
                sql.Parameters.AddWithValue("@ec_cnpj", dado.Ec_cnpj);
                sql.Parameters.AddWithValue("@ec_fantasia", dado.Ec_fantasia);
                sql.Parameters.AddWithValue("@ec_razao", dado.Ec_razao);
                sql.Parameters.AddWithValue("@ec_endereco", dado.Ec_endereco);
                sql.Parameters.AddWithValue("@ec_complemento", dado.Ec_complemento);
                sql.Parameters.AddWithValue("@ec_bairro", dado.Ec_bairro);
                sql.Parameters.AddWithValue("@ec_cidade", dado.Ec_cidade);
                sql.Parameters.AddWithValue("@ec_cep", dado.Ec_cep);
                sql.Parameters.AddWithValue("@ec_uf", dado.Ec_uf);
                sql.Parameters.AddWithValue("@ec_contato1", dado.Ec_contato1);
                sql.Parameters.AddWithValue("@ec_cargo1", dado.Ec_cargo1);
                sql.Parameters.AddWithValue("@ec_telefone1", dado.Ec_telefone1);
                sql.Parameters.AddWithValue("@ec_email1", dado.Ec_email1);
                sql.Parameters.AddWithValue("@ec_contato2", dado.Ec_contato2);
                sql.Parameters.AddWithValue("@ec_cargo2", dado.Ec_cargo2);
                sql.Parameters.AddWithValue("@ec_telefone2", dado.Ec_telefone2);
                sql.Parameters.AddWithValue("@ec_email2", dado.Ec_email2);
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
