using System;
using System.Windows.Forms;
using Arqueng.MODEL;
using Arqueng.ENTIDADES;

namespace Arqueng.VIEW
{


    public partial class frmDadosCadastrais : Form
    {


        CadastraisMODEL model = new CadastraisMODEL();
        CadastraisENT dado = new CadastraisENT();
        public bool alterado = false;


        public frmDadosCadastrais()
        {
            InitializeComponent();
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
                    dtpConstituicao.Value = dado.Constituicao;
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
            dado.Constituicao = dtpConstituicao.Value;
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
                    alterado = true;
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
                    alterado = true;
                    MessageBox.Show("Dados cadastrais alterados com sucesso!", "Dados Cadastrais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }


}
