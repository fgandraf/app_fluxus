using System;
using System.Windows.Forms;
using Arqueng.MODEL;
using Arqueng.ENTIDADES;
using System.Text.RegularExpressions;
using System.IO;

namespace Arqueng.VIEW
{


    public partial class frmDadosCadastrais : Form
    {

        frmPrincipal _frmPrincipal;

        CadastraisMODEL model = new CadastraisMODEL();
        CadastraisENT dado = new CadastraisENT();
        private string NFantasia = null;
        private string LogoNome = null;
        private string Locallogo = null;


        public frmDadosCadastrais(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }


        private  void BuscarDadosCadastrais()
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
                    txtTelefone.Text = dado.Telefone;
                    txtTelefone2.Text = dado.Telefone2;
                    txtEmail.Text = dado.Email;
                    txtBanco.Text = dado.Db_banco;
                    cboTipoDeConta.Text = dado.Db_tipo;
                    txtAgencia.Text = dado.Db_agencia;
                    txtOperador.Text = dado.Db_operador;
                    txtConta.Text = dado.Db_conta;
                    cboTomador.Text = dado.Ct_tomador;
                    txtEdital.Text = dado.Ct_edital;
                    txtContrato.Text = dado.Ct_contrato;
                    if (dado.Ct_celebrado.ToString() != "01/01/0001 00:00:00")
                        txtCelebrado.Text = dado.Ct_celebrado.ToString("dd/MM/yyy");
                    if (dado.Ct_inicio.ToString() != "01/01/0001 00:00:00")
                        txtInicio.Text = dado.Ct_inicio.ToString("dd/MM/yyyy");
                    if (dado.Ct_termino.ToString() != "01/01/0001 00:00:00")
                        txtTermino.Text = dado.Ct_termino.ToString("dd/MM/yyyy");
                    picLogotipo.ImageLocation = dado.Logotipo;
                    Locallogo = dado.Logotipo;
                    
                    
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
            if (Globais.Rl == false)
            {
                pnlBotton.Hide();
            }
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

            if (Globais.Razao != txtRazaoSocial.Text)
                Globais.Razao = txtRazaoSocial.Text;

            if (Globais.Cnpj != txtCNPJ.Text)
                Globais.Cnpj = txtCNPJ.Text;

            if (Globais.Edital != txtEdital.Text)
                Globais.Edital = txtEdital.Text;

            if (Globais.Contrato != txtContrato.Text)
                Globais.Contrato = txtContrato.Text;

            
            

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
            dado.Telefone = txtTelefone.Text;
            dado.Telefone2 = txtTelefone2.Text;
            dado.Email = txtEmail.Text;
            dado.Db_banco = txtBanco.Text;
            dado.Db_tipo = cboTipoDeConta.Text;
            dado.Db_agencia = txtAgencia.Text;
            dado.Db_operador = txtOperador.Text;
            dado.Db_conta = txtConta.Text;
            dado.Ct_tomador = cboTomador.Text;
            dado.Ct_edital = txtEdital.Text;
            dado.Ct_contrato = txtContrato.Text;
            if (txtCelebrado.Text != "")
                dado.Ct_celebrado = Convert.ToDateTime(txtCelebrado.Text);
            if (txtInicio.Text != "")
                dado.Ct_inicio = Convert.ToDateTime(txtInicio.Text);
            if (txtTermino.Text != "")
                dado.Ct_termino = Convert.ToDateTime(txtTermino.Text);


            if (picLogotipo.ImageLocation != Locallogo && picLogotipo.ImageLocation != "")
            {
                if (File.Exists(Globais.Logotipo))
                    File.Delete(Globais.Logotipo);



                System.IO.File.Copy(picLogotipo.ImageLocation, System.Environment.CurrentDirectory + @"\" + LogoNome, true);
                dado.Logotipo = System.Environment.CurrentDirectory + @"\" + LogoNome;
                
                picLogotipo.ImageLocation = System.Environment.CurrentDirectory + @"\" + LogoNome;
            }












            if (Globais.Logotipo != picLogotipo.ImageLocation)
                Globais.Logotipo = picLogotipo.ImageLocation;




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

        private void txtCelebrado_Enter(object sender, EventArgs e)
        {
            txtCelebrado.Mask = "00/00/0000";
        }

        private void txtCelebrado_Validated(object sender, EventArgs e)
        {
            if (txtCelebrado.Text == "  /  /")
                txtCelebrado.Mask = "";
        }

        private void txtInicio_Enter(object sender, EventArgs e)
        {
            txtInicio.Mask = "00/00/0000";
        }

        private void txtInicio_Validated(object sender, EventArgs e)
        {
            if (txtInicio.Text == "  /  /")
                txtInicio.Mask = "";
        }

        private void txtTermino_Enter(object sender, EventArgs e)
        {
            txtTermino.Mask = "00/00/0000";
        }

        private void txtTermino_Validated(object sender, EventArgs e)
        {
            if (txtTermino.Text == "  /  /")
                txtTermino.Mask = "";
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                picLogotipo.ImageLocation = openDialog.FileName;
                LogoNome = openDialog.SafeFileName;
            }
        }

    }


}
