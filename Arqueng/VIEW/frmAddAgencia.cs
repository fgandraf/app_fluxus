using System;
using System.Windows.Forms;
using Arqueng.MODEL;
using Arqueng.ENTIDADES;
using System.Text.RegularExpressions;

namespace Arqueng.VIEW
{


    public partial class frmAddAgencia : Form
    {

        frmPrincipal _frmPrincipal;
        AgenciasMODEL model = new AgenciasMODEL();
        AgenciasENT dado = new AgenciasENT();


        public frmAddAgencia(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }

        public frmAddAgencia()
        {
            InitializeComponent();
        }


        public frmAddAgencia (frmPrincipal frm1, string Agencia, string Nome, string Endereco, string Complemento, string Bairro, string Cidade, string CEP, string UF, string Contato, string Telefone1, string Telefone2, string Email)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
            txtAgencia.Text = Agencia;
            txtNome.Text = Nome;
            txtEndereco.Text = Endereco;
            txtComplemento.Text = Complemento;
            txtBairro.Text = Bairro;
            txtCidade.Text = Cidade;
            txtCEP.Text = CEP;
            cboUF.Text = UF;
            txtContato.Text = Contato;
            txtTelefone1.Text = Telefone1;
            txtTelefone2.Text = Telefone2;
            txtEmail.Text = Email;
        }


        private void frmAddAgencia_Load(object sender, EventArgs e)
        {
            if (this.Text == "Alterar")
            {
                btnAddSave.Text = "&Salvar";
                txtAgencia.Enabled = false;
                txtNome.Focus();
            }
            else
                txtAgencia.Focus();
        }


        private void btnAddSave_Click(object sender, EventArgs e)
        {
            if (txtAgencia.Text == "")
            {
                MessageBox.Show("Campos com * são obrigatório", "Chave Primária", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            //POPULATE
            dado.Agencia = txtAgencia.Text;
            dado.Nome = txtNome.Text;
            dado.Endereco = txtEndereco.Text;
            dado.Complemento = txtComplemento.Text;
            dado.Bairro = txtBairro.Text;
            dado.Cidade = txtCidade.Text;
            dado.CEP = txtCEP.Text;
            dado.UF = cboUF.Text;
            dado.Contato = txtContato.Text;
            dado.Telefone1 = txtTelefone1.Text;
            dado.Telefone2 = txtTelefone2.Text;
            dado.Email = txtEmail.Text;

            if (btnAddSave.Text == "&Adicionar")
            {
                try
                {
                    model.InsertAgenciaModel(dado);
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Duplicata du champ"))
                    {
                        MessageBox.Show($"Agência com o código '{txtAgencia.Text}' já cadastrada!", "Código existente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                try
                {
                    model.UpdateAgenciaModel(dado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();
            if (this.FormBorderStyle != System.Windows.Forms.FormBorderStyle.FixedSingle)
            {
                frmAgencias formFilho = new frmAgencias(_frmPrincipal);
                _frmPrincipal.AbrirFormInPanel(formFilho, _frmPrincipal.pnlMain);
            }
        }

        private void txtTelefone1_Enter(object sender, EventArgs e)
        {
            txtTelefone1.Mask = "(99) ##########";
        }

        private void txtTelefone1_Validated(object sender, EventArgs e)
        {
            if (txtTelefone1.Text == "(  ) ")
            {
                txtTelefone1.Mask = "";
                return;
            }

            var apenasDigitos = new Regex(@"[^\d]");
            if (apenasDigitos.Replace(txtTelefone1.Text, "").Length == 10)
                txtTelefone1.Mask = "(99) #########";
        }

        private void txtTelefone2_Enter(object sender, EventArgs e)
        {
            txtTelefone2.Mask = "(99) ##########";
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

            if (this.FormBorderStyle != System.Windows.Forms.FormBorderStyle.FixedSingle)
            {
                frmAgencias formFilho = new frmAgencias(_frmPrincipal);
                _frmPrincipal.AbrirFormInPanel(formFilho, _frmPrincipal.pnlMain);
            }
        }
    }


}
