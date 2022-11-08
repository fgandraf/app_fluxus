using System;
using System.Windows.Forms;
using Fluxus.Domain.Models;
using Fluxus.Presentation.Controller;

namespace Fluxus.Presentation.View
{
    public partial class frmAddAgencia : Form
    {


        frmPrincipal _frmPrincipal;
        private long _id;





        //:METHODS
        private void OnValidated_MaskedTextBox(object sender, EventArgs e)
        {
            MaskedTextBox box = (MaskedTextBox)sender;
            box.Mask = Util.MaskValidated(sender);
        }


        private void OnEnter_MaskedTextBox(object sender, EventArgs e)
        {
            MaskedTextBox box = (MaskedTextBox)sender;
            box.Mask = Util.MaskEnter(sender);
        }


        private Agencia PopulateObject()
        {
            Agencia dado = new Agencia
            {
                Digito = txtAgencia.Text,
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
            return dado;
        }


        private void Back()
        {
            this.Close();
            if (this.FormBorderStyle != System.Windows.Forms.FormBorderStyle.FixedSingle)
            {
                frmAgencias formFilho = new frmAgencias(_frmPrincipal);
                _frmPrincipal.AbrirFormInPanel(formFilho, _frmPrincipal.pnlMain);
            }
        }





        //:EVENTS
        public frmAddAgencia(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }


        public frmAddAgencia(string agencia)
        {
            InitializeComponent();
           
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Size = new System.Drawing.Size(650, 600);
            this.Text = "Adicionar";

            txtAgencia.Text = agencia;

        }


        public frmAddAgencia(frmPrincipal frm1, Agencia dado)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
            
            _id = dado.Id;
            txtAgencia.Text = dado.Digito;
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


        private void btnAddSave_Click(object sender, EventArgs e)
        {
            if (txtAgencia.Text == "")
            {
                MessageBox.Show("Campos com * são obrigatório", "Chave Primária", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            Agencia dado = PopulateObject();

            if (btnAddSave.Text == "&Adicionar")
            {
                try
                {
                    new AgenciaController().Insert(dado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                try
                {
                    new AgenciaController().Update(_id, dado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Back();

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Back();
        }


    }


}
