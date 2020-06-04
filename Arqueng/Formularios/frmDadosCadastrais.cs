using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Arqueng.Entidades;

namespace Arqueng
{


    public partial class frmDadosCadastrais : Form
    {
        public frmDadosCadastrais()
        {
            InitializeComponent();
        }


        private void frmDadosCadastrais_Load(object sender, EventArgs e)
        {
            try
            {
                My.conexaoDB = new MySqlConnection(My.dadosdb);
                My.comando = new MySqlCommand("SELECT * FROM tb_dadoscadastrais", My.conexaoDB);
                My.conexaoDB.Open();
                My.dr = My.comando.ExecuteReader();
                if (My.dr.HasRows == false)
                {
                    txtCNPJ.Focus();
                }
                else
                {
                    while (My.dr.Read())
                    {
                        txtCNPJ.Text = Convert.ToString(My.dr["cnpj"]);
                        txtNomeFantasia.Text = Convert.ToString(My.dr["fantasia"]);
                        txtRazaoSocial.Text = Convert.ToString(My.dr["razao"]);
                        txtInscricaoEstadual.Text = Convert.ToString(My.dr["ie"]);
                        txtInscricaoMunicipal.Text = Convert.ToString(My.dr["im"]);
                        txtEndereco.Text = Convert.ToString(My.dr["endereco"]);
                        txtComplemento.Text = Convert.ToString(My.dr["complemento"]);
                        txtBairro.Text = Convert.ToString(My.dr["bairro"]);
                        txtCidade.Text = Convert.ToString(My.dr["cidade"]);
                        txtCEP.Text = Convert.ToString(My.dr["cep"]);
                        cboUF.Text = Convert.ToString(My.dr["uf"]);
                        dtpConstituicao.Value = Convert.ToDateTime(My.dr["constituicao"]);
                        txtRepresentanteLegal.Text = Convert.ToString(My.dr["representante"]);
                        txtTelefone.Text = Convert.ToString(My.dr["telefone"]);
                        txtEmail.Text = Convert.ToString(My.dr["email"]);
                        txtBanco.Text = Convert.ToString(My.dr["db_banco"]);
                        cboTipoDeConta.Text = Convert.ToString(My.dr["db_tipo"]);
                        txtAgencia.Text = Convert.ToString(My.dr["db_agencia"]);
                        txtOperador.Text = Convert.ToString(My.dr["db_operador"]);
                        txtConta.Text = Convert.ToString(My.dr["db_conta"]);
                        txtECCNPJ.Text = Convert.ToString(My.dr["ec_cnpj"]);
                        txtECFantasia.Text = Convert.ToString(My.dr["ec_fantasia"]);
                        txtECRazao.Text = Convert.ToString(My.dr["ec_razao"]);
                        txtECEndereco.Text = Convert.ToString(My.dr["ec_endereco"]);
                        txtECComplemento.Text = Convert.ToString(My.dr["ec_complemento"]);
                        txtECBairro.Text = Convert.ToString(My.dr["ec_bairro"]);
                        txtECCidade.Text = Convert.ToString(My.dr["ec_cidade"]);
                        txtECCEP.Text = Convert.ToString(My.dr["ec_cep"]);
                        cboECUF.Text = Convert.ToString(My.dr["ec_uf"]);
                        txtECContato1.Text = Convert.ToString(My.dr["ec_contato1"]);
                        txtECCargo1.Text = Convert.ToString(My.dr["ec_cargo1"]);
                        txtECTelefone1.Text = Convert.ToString(My.dr["ec_telefone1"]);
                        txtECEmail1.Text = Convert.ToString(My.dr["ec_email1"]);
                        txtECContato2.Text = Convert.ToString(My.dr["ec_contato2"]);
                        txtECCargo2.Text = Convert.ToString(My.dr["ec_cargo2"]);
                        txtECTelefone2.Text = Convert.ToString(My.dr["ec_telefone2"]);
                        txtECEmail2.Text = Convert.ToString(My.dr["ec_email2"]);
                        btnCadastrarSalvar.Text = "&Salvar";
                        txtCNPJ.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                My.conexaoDB.Close();
                My.conexaoDB = null;
            }
        }


        private void btnCadastrarSalvar_Click(object sender, EventArgs e)
        {
            if (btnCadastrarSalvar.Text == "&Cadastrar")
            { 
                try
                {
                    My.conexaoDB = new MySqlConnection(My.dadosdb);
                    My.comando = new MySqlCommand("INSERT INTO tb_dadoscadastrais(codigo, cnpj, fantasia, razao, ie, im, endereco, complemento, bairro, cidade, cep, uf, constituicao, representante, telefone, email, db_banco, db_tipo, db_agencia, db_operador, db_conta, ec_cnpj, ec_fantasia, ec_razao, ec_endereco, ec_complemento, ec_bairro, ec_cidade, ec_cep, ec_uf, ec_contato1, ec_cargo1, ec_telefone1, ec_email1, ec_contato2, ec_cargo2, ec_telefone2, ec_email2) VALUES (@codigo, @cnpj, @fantasia, @razao, @ie, @im, @endereco, @complemento, @bairro, @cidade, @cep, @uf, @constituicao, @representante, @telefone, @email, @db_banco, @db_tipo, @db_agencia, @db_operador, @db_conta, @ec_cnpj, @ec_fantasia, @ec_razao, @ec_endereco, @ec_complemento, @ec_bairro, @ec_cidade, @ec_cep, @ec_uf, @ec_contato1, @ec_cargo1, @ec_telefone1, @ec_email1, @ec_contato2, @ec_cargo2, @ec_telefone2, @ec_email2)", My.conexaoDB);
                    
                    My.comando.Parameters.AddWithValue("@codigo", "1");
                    My.comando.Parameters.AddWithValue("@cnpj", txtCNPJ.Text);
                    My.comando.Parameters.AddWithValue("@fantasia", txtNomeFantasia.Text);
                    My.comando.Parameters.AddWithValue("@razao", txtRazaoSocial.Text);
                    My.comando.Parameters.AddWithValue("@ie", txtInscricaoEstadual.Text);
                    My.comando.Parameters.AddWithValue("@im", txtInscricaoMunicipal.Text);
                    My.comando.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    My.comando.Parameters.AddWithValue("@complemento", txtComplemento.Text);
                    My.comando.Parameters.AddWithValue("@bairro", txtBairro.Text);
                    My.comando.Parameters.AddWithValue("@cidade", txtCidade.Text);
                    My.comando.Parameters.AddWithValue("@cep", txtCEP.Text);
                    My.comando.Parameters.AddWithValue("@uf", cboUF.Text);
                    My.comando.Parameters.AddWithValue("@constituicao", dtpConstituicao.Value);
                    My.comando.Parameters.AddWithValue("@representante", txtRepresentanteLegal.Text);
                    My.comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    My.comando.Parameters.AddWithValue("@email", txtEmail.Text);
                    My.comando.Parameters.AddWithValue("@db_banco", txtBanco.Text);
                    My.comando.Parameters.AddWithValue("@db_tipo", cboTipoDeConta.Text);
                    My.comando.Parameters.AddWithValue("@db_agencia", txtAgencia.Text);
                    My.comando.Parameters.AddWithValue("@db_operador", txtOperador.Text);
                    My.comando.Parameters.AddWithValue("@db_conta", txtConta.Text);
                    My.comando.Parameters.AddWithValue("@ec_cnpj", txtECCNPJ.Text);
                    My.comando.Parameters.AddWithValue("@ec_fantasia", txtECFantasia.Text);
                    My.comando.Parameters.AddWithValue("@ec_razao", txtECRazao.Text);
                    My.comando.Parameters.AddWithValue("@ec_endereco", txtECEndereco.Text);
                    My.comando.Parameters.AddWithValue("@ec_complemento", txtECComplemento.Text);
                    My.comando.Parameters.AddWithValue("@ec_bairro", txtECBairro.Text);
                    My.comando.Parameters.AddWithValue("@ec_cidade", txtECCidade.Text);
                    My.comando.Parameters.AddWithValue("@ec_cep", txtECCEP.Text);
                    My.comando.Parameters.AddWithValue("@ec_uf", cboECUF.Text);
                    My.comando.Parameters.AddWithValue("@ec_contato1", txtECContato1.Text);
                    My.comando.Parameters.AddWithValue("@ec_cargo1", txtECCargo1.Text);
                    My.comando.Parameters.AddWithValue("@ec_telefone1", txtECTelefone1.Text);
                    My.comando.Parameters.AddWithValue("@ec_email1", txtECEmail1.Text);
                    My.comando.Parameters.AddWithValue("@ec_contato2", txtECContato2.Text);
                    My.comando.Parameters.AddWithValue("@ec_cargo2", txtECCargo2.Text);
                    My.comando.Parameters.AddWithValue("@ec_telefone2", txtECTelefone2.Text);
                    My.comando.Parameters.AddWithValue("@ec_email2", txtECEmail2.Text);

                    My.conexaoDB.Open();
                    My.comando.ExecuteNonQuery();

                    MessageBox.Show("Dados cadastrados com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    My.conexaoDB.Close();
                    My.conexaoDB = null;
                    My.comando = null;
                }
            }
            else
            {
                try
                {
                    My.conexaoDB = new MySqlConnection(My.dadosdb);
                    My.comando = new MySqlCommand("UPDATE tb_dadoscadastrais SET cnpj = @cnpj, fantasia = @fantasia, razao = @razao, ie = @ie, im = @im, endereco = @endereco, complemento = @complemento, bairro = @bairro, cidade = @cidade, cep = @cep, uf = @uf, constituicao = @constituicao, representante = @representante, telefone = @telefone, email = @email, db_banco = @db_banco, db_tipo = @db_tipo, db_agencia = @db_agencia, db_operador = @db_operador, db_conta = @db_conta, ec_cnpj = @ec_cnpj, ec_fantasia = @ec_fantasia, ec_razao = @ec_razao, ec_endereco = @ec_endereco, ec_complemento = @ec_complemento, ec_bairro = @ec_bairro, ec_cidade = @ec_cidade, ec_cep = @ec_cep, ec_uf = @ec_uf, ec_contato1 = @ec_contato1, ec_cargo1 = @ec_cargo1, ec_telefone1 = @ec_telefone1, ec_email1 = @ec_email1, ec_contato2 = @ec_contato2, ec_cargo2 = @ec_cargo2, ec_telefone2 = @ec_telefone2, ec_email2 = @ec_email2 WHERE codigo = @codigo", My.conexaoDB);
                    My.comando.Parameters.AddWithValue("@codigo", "1");
                    My.comando.Parameters.AddWithValue("@cnpj", txtCNPJ.Text);
                    My.comando.Parameters.AddWithValue("@fantasia", txtNomeFantasia.Text);
                    My.comando.Parameters.AddWithValue("@razao", txtRazaoSocial.Text);
                    My.comando.Parameters.AddWithValue("@ie", txtInscricaoEstadual.Text);
                    My.comando.Parameters.AddWithValue("@im", txtInscricaoMunicipal.Text);
                    My.comando.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    My.comando.Parameters.AddWithValue("@complemento", txtComplemento.Text);
                    My.comando.Parameters.AddWithValue("@bairro", txtBairro.Text);
                    My.comando.Parameters.AddWithValue("@cidade", txtCidade.Text);
                    My.comando.Parameters.AddWithValue("@cep", txtCEP.Text);
                    My.comando.Parameters.AddWithValue("@uf", cboUF.Text);
                    My.comando.Parameters.AddWithValue("@constituicao", dtpConstituicao.Value);
                    My.comando.Parameters.AddWithValue("@representante", txtRepresentanteLegal.Text);
                    My.comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    My.comando.Parameters.AddWithValue("@email", txtEmail.Text);
                    My.comando.Parameters.AddWithValue("@db_banco", txtBanco.Text);
                    My.comando.Parameters.AddWithValue("@db_tipo", cboTipoDeConta.Text);
                    My.comando.Parameters.AddWithValue("@db_agencia", txtAgencia.Text);
                    My.comando.Parameters.AddWithValue("@db_operador", txtOperador.Text);
                    My.comando.Parameters.AddWithValue("@db_conta", txtConta.Text);
                    My.comando.Parameters.AddWithValue("@ec_cnpj", txtECCNPJ.Text);
                    My.comando.Parameters.AddWithValue("@ec_fantasia", txtECFantasia.Text);
                    My.comando.Parameters.AddWithValue("@ec_razao", txtECRazao.Text);
                    My.comando.Parameters.AddWithValue("@ec_endereco", txtECEndereco.Text);
                    My.comando.Parameters.AddWithValue("@ec_complemento", txtECComplemento.Text);
                    My.comando.Parameters.AddWithValue("@ec_bairro", txtECBairro.Text);
                    My.comando.Parameters.AddWithValue("@ec_cidade", txtECCidade.Text);
                    My.comando.Parameters.AddWithValue("@ec_cep", txtECCEP.Text);
                    My.comando.Parameters.AddWithValue("@ec_uf", cboECUF.Text);
                    My.comando.Parameters.AddWithValue("@ec_contato1", txtECContato1.Text);
                    My.comando.Parameters.AddWithValue("@ec_cargo1", txtECCargo1.Text);
                    My.comando.Parameters.AddWithValue("@ec_telefone1", txtECTelefone1.Text);
                    My.comando.Parameters.AddWithValue("@ec_email1", txtECEmail1.Text);
                    My.comando.Parameters.AddWithValue("@ec_contato2", txtECContato2.Text);
                    My.comando.Parameters.AddWithValue("@ec_cargo2", txtECCargo2.Text);
                    My.comando.Parameters.AddWithValue("@ec_telefone2", txtECTelefone2.Text);
                    My.comando.Parameters.AddWithValue("@ec_email2", txtECEmail2.Text);

                    My.conexaoDB.Open();
                    My.comando.ExecuteNonQuery();

                    MessageBox.Show("Dados atualizados com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    My.conexaoDB.Close();
                    My.conexaoDB = null;
                    My.comando = null;
                } 
            }
        }

    }
}
