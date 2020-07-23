using System;
using System.Windows.Forms;
using Arqueng.MODEL;
using Arqueng.ENTIDADES;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Arqueng.VIEW
{


    public partial class frmDadosCadastrais : Form
    {

        frmPrincipal _frmPrincipal;

        CadastraisMODEL model = new CadastraisMODEL();
        CadastraisENT dado = new CadastraisENT();
        string NFantasia = null;


        public frmDadosCadastrais(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }


        public void BuscarDadosCadastrais()
        {
            try
            {
                ENTIDADES.CadastraisENT dado = new ENTIDADES.CadastraisENT();
                model.BuscarCadastraisModel(dado);

                if (dado.Cnpj == null)
                    txtCNPJ.Focus();
                else
                {
                    txtCNPJ.Text = dado.Cnpj;
                    txtNomeFantasia.Text = dado.Fantasia;
                    txtRazaoSocial.Text = dado.Razao;
                    txtInscricaoEstadual.Text = dado.Ie;
                    txtInscricaoMunicipal.Text = dado.Im;
                    txtEndereco.Text = dado.Endereco;
                    txtComplemento.Text = dado.Complemento;
                    txtBairro.Text = dado.Bairro;
                    txtCidade.Text = dado.Cidade;
                    txtCEP.Text = dado.Cep;
                    cboUF.Text = dado.Uf;

                    if (dado.Constituicao.ToString() != "01/01/0001 00:00:00")
                        txtConstituicao.Text = dado.Constituicao.ToString("dd/MM/yyyy");
                    
                    txtRepresentanteLegal.Text = dado.Representante;
                    txtTelefone.Text = dado.Telefone;
                    txtTelefone2.Text = dado.Telefone2;
                    txtEmail.Text = dado.Email;
                    txtBanco.Text = dado.Db_banco;
                    cboTipoDeConta.Text = dado.Db_tipo;
                    txtAgencia.Text = dado.Db_agencia;
                    txtOperador.Text = dado.Db_operador;
                    txtConta.Text = dado.Db_conta;

                    btnCadastrarSalvar.Text = "&Salvar";
                    txtCNPJ.Focus();
                    NFantasia = dado.Fantasia;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void frmDadosCadastrais_Load(object sender, EventArgs e)
        {
            BuscarDadosCadastrais();
        }


        private void btnCadastrarSalvar_Click(object sender, EventArgs e)
        {
            if (txtCNPJ.Text == "" || txtNomeFantasia.Text == "" || txtRazaoSocial.Text == "")
            {
                MessageBox.Show("Campos com * são obrigatório", "Chave Primária", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            
            
            if (NFantasia != txtNomeFantasia.Text)
            {
                _frmPrincipal.btnDadosCadastrais.Text = txtNomeFantasia.Text.ToString();
                _frmPrincipal.btnDadosCadastrais.Refresh();
                NFantasia = txtNomeFantasia.Text;
            }


            //POPULATE
            dado.Cnpj = txtCNPJ.Text;
            dado.Cnpj = txtCNPJ.Text;
            dado.Fantasia = txtNomeFantasia.Text;
            dado.Razao = txtRazaoSocial.Text;
            dado.Ie = txtInscricaoEstadual.Text;
            dado.Im = txtInscricaoMunicipal.Text;
            dado.Endereco = txtEndereco.Text;
            dado.Complemento = txtComplemento.Text;
            dado.Bairro = txtBairro.Text;
            dado.Cidade = txtCidade.Text;
            dado.Cep = txtCEP.Text;
            dado.Uf = cboUF.Text;
            if (txtConstituicao.Text != "")
                dado.Constituicao = Convert.ToDateTime(txtConstituicao.Text);
            dado.Representante = txtRepresentanteLegal.Text;
            dado.Telefone = txtTelefone.Text;
            dado.Telefone2 = txtTelefone2.Text;
            dado.Email = txtEmail.Text;
            dado.Db_banco = txtBanco.Text;
            dado.Db_tipo = cboTipoDeConta.Text;
            dado.Db_agencia = txtAgencia.Text;
            dado.Db_operador = txtOperador.Text;
            dado.Db_conta = txtConta.Text;
            

            if (btnCadastrarSalvar.Text == "&Cadastrar")
            {
                try
                {
                    model.InsertCadastraisModel(dado);
                    MessageBox.Show("Dados cadastrados com sucesso!", "Dados Cadastrais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    model.UpdateCadastraisModel(dado);
                    MessageBox.Show("Dados cadastrais alterados com sucesso!", "Dados Cadastrais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCNPJ_Enter(object sender, EventArgs e)
        {
            txtCNPJ.Mask = "00,000,000/0000-00";
        }

        private void txtCNPJ_Validated(object sender, EventArgs e)
        {
            if (txtCNPJ.Text == "  .   .   /    -")
                txtCNPJ.Mask = "";
        }

        private void txtTelefone_Enter(object sender, EventArgs e)
        {
            txtTelefone.Mask = "(99) ##########";
        }

        private void txtTelefone2_Enter(object sender, EventArgs e)
        {
            txtTelefone2.Mask = "(99) ##########";
        }

        private void txtTelefone_Validated(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "(  ) ")
            {
                txtTelefone.Mask = "";
                return;
            }

            var apenasDigitos = new Regex(@"[^\d]");
            if (apenasDigitos.Replace(txtTelefone.Text, "").Length == 10)
                txtTelefone.Mask = "(99) #########";
        }

        private void txtTelefone2_Validated(object sender, EventArgs e)
        {
            if (txtTelefone2.Text == "(  ) ")
            {
                txtTelefone2.Mask = "";
                return;
            }

            var apenasDigitos = new Regex(@"[^\d]");
            if (apenasDigitos.Replace(txtTelefone2.Text, "").Length == 10)
                txtTelefone2.Mask = "(99) #########";
        }

        private void txtCEP_Enter(object sender, EventArgs e)
        {
            txtCEP.Mask = "#####-###";
        }

        private void txtCEP_Validated(object sender, EventArgs e)
        {
            if (txtCEP.Text == "     -")
                txtCEP.Mask = "";
        }

        private void txtConstituicao_Enter(object sender, EventArgs e)
        {
            txtConstituicao.Mask = "00/00/0000";
        }

        private void txtConstituicao_Validated(object sender, EventArgs e)
        {
            if (txtConstituicao.Text == "  /  /")
                txtConstituicao.Mask = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblOperador_Click(object sender, EventArgs e)
        {

        }
    }


}
