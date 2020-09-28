using System;
using System.Windows.Forms;
using Fluxus.Controller;
using Fluxus.Model.ENT;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient.Authentication;

namespace Fluxus.View
{
    public partial class frmAddAgencia : Form
    {
       
        frmPrincipal _frmPrincipal;
        long _id;




        //:EVENTS
        ///_______Form
        public frmAddAgencia(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }

        public frmAddAgencia(string agencia)
        {
            InitializeComponent();
            txtAgencia.Text = agencia;
        }

        public frmAddAgencia(frmPrincipal frm1, AgenciaENT dado)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
            
            _id = dado.Id;
            txtAgencia.Text = dado.Agencia;
            txtNome.Text = dado.Nome;
            txtEndereco.Text = dado.Endereco;
            txtComplemento.Text = dado.Complemento;
            txtBairro.Text = dado.Bairro;
            txtCidade.Text = dado.Cidade;
            txtCEP.Text = dado.CEP;
            cboUF.Text = dado.UF;
            txtContato.Text = dado.Contato;
            txtTelefone1.Text = dado.Telefone1;
            txtTelefone2.Text = dado.Telefone2;
            txtEmail.Text = dado.Email;
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





        ///_______Button
        private void btnAddSave_Click(object sender, EventArgs e)
        {
            if (txtAgencia.Text == "")
            {
                MessageBox.Show("Campos com * são obrigatório", "Chave Primária", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //POPULATE
            AgenciaENT dado = new AgenciaENT
            {
                Agencia = txtAgencia.Text,
                Nome = txtNome.Text,
                Endereco = txtEndereco.Text,
                Complemento = txtComplemento.Text,
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                CEP = txtCEP.Text,
                UF = cboUF.Text,
                Contato = txtContato.Text,
                Telefone1 = txtTelefone1.Text,
                Telefone2 = txtTelefone2.Text,
                Email = txtEmail.Text
            };


            if (btnAddSave.Text == "&Adicionar")
            {
                try
                {
                    new AgenciaController().InsertAgencia(dado);
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
                    new AgenciaController().UpdateAgencia(_id, dado);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

            if (this.FormBorderStyle != System.Windows.Forms.FormBorderStyle.FixedSingle)
            {
                frmAgencias formFilho = new frmAgencias(_frmPrincipal);
                _frmPrincipal.AbrirFormInPanel(formFilho, _frmPrincipal.pnlMain);
            }
        }





        ///_______TextBox
        private void txtTelefone1_Enter(object sender, EventArgs e)
        {
            txtTelefone1.Mask = "(99) #########";
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
            else if (apenasDigitos.Replace(txtTelefone1.Text, "").Length == 11)
                txtTelefone1.Mask = "(99) ##########";

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
            else if (apenasDigitos.Replace(txtTelefone2.Text, "").Length == 11)
                txtTelefone2.Mask = "(99) ##########";
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

        

    }



}
