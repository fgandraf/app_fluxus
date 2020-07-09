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
                    txtEmail.Text = dado.Email;
                    txtBanco.Text = dado.Db_banco;
                    cboTipoDeConta.Text = dado.Db_tipo;
                    txtAgencia.Text = dado.Db_agencia;
                    txtOperador.Text = dado.Db_operador;
                    txtConta.Text = dado.Db_conta;
                    txtECCNPJ.Text = dado.Ec_cnpj;
                    txtECFantasia.Text = dado.Ec_fantasia;
                    txtECRazao.Text = dado.Ec_razao;
                    txtECEndereco.Text = dado.Ec_endereco;
                    txtECComplemento.Text = dado.Ec_complemento;
                    txtECBairro.Text = dado.Ec_bairro;
                    txtECCidade.Text = dado.Ec_cidade;
                    txtECCEP.Text = dado.Ec_cep;
                    cboECUF.Text = dado.Ec_uf;
                    txtECContato1.Text = dado.Ec_contato1;
                    txtECCargo1.Text = dado.Ec_cargo1;
                    txtECTelefone1.Text = dado.Ec_telefone1;
                    txtECEmail1.Text = dado.Ec_email1;
                    txtECContato2.Text = dado.Ec_contato2;
                    txtECCargo2.Text = dado.Ec_cargo2;
                    txtECTelefone2.Text = dado.Ec_telefone2;
                    txtECEmail2.Text = dado.Ec_email2;

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
            dado.Email = txtEmail.Text;
            dado.Db_banco = txtBanco.Text;
            dado.Db_tipo = cboTipoDeConta.Text;
            dado.Db_agencia = txtAgencia.Text;
            dado.Db_operador = txtOperador.Text;
            dado.Db_conta = txtConta.Text;
            dado.Ec_cnpj = txtECCNPJ.Text;
            dado.Ec_fantasia = txtECFantasia.Text;
            dado.Ec_razao = txtECRazao.Text;
            dado.Ec_endereco = txtECEndereco.Text;
            dado.Ec_complemento = txtECComplemento.Text;
            dado.Ec_bairro = txtECBairro.Text;
            dado.Ec_cidade = txtECCidade.Text;
            dado.Ec_cep = txtECCEP.Text;
            dado.Ec_uf = cboECUF.Text;
            dado.Ec_contato1 = txtECContato1.Text;
            dado.Ec_cargo1 = txtECCargo1.Text;
            dado.Ec_telefone1 = txtECTelefone1.Text;
            dado.Ec_email1 = txtECEmail1.Text;
            dado.Ec_contato2 = txtECContato2.Text;
            dado.Ec_cargo2 = txtECCargo2.Text;
            dado.Ec_telefone2 = txtECTelefone2.Text;
            dado.Ec_email2 = txtECEmail2.Text;

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
