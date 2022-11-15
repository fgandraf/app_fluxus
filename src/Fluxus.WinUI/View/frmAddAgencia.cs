using System;
using System.Windows.Forms;
using Fluxus.Domain.Entities;
using Fluxus.Services;

namespace Fluxus.WinUI.View
{
    public partial class frmAddAgencia : Form
    {

        frmPrincipal _frmPrincipal;
        private long _id;



        public frmAddAgencia(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;


        }


        public frmAddAgencia(string agencia)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Size = new System.Drawing.Size(650, 600);
            this.Text = "Adicionar";

            txtAgencia.Text = agencia;

        }


        public frmAddAgencia(frmPrincipal frm1, Agencia dado) //Editar agencia
        {
            InitializeComponent();
            _frmPrincipal = frm1;

            _id = dado.Id;
            txtAgencia.Text = dado.Numero;
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

            txtAgencia.Enabled = false;

        }


        private void frmAddAgencia_Load(object sender, EventArgs e)
        {
            if (this.Text == "Adicionar")
                txtAgencia.Focus();
            else
                txtNome.Focus();
        }




        private void btnAddSave_Click(object sender, EventArgs e)
        {
            if (txtAgencia.Text == "")
            {
                MessageBox.Show("Campos com * são obrigatório", "Chave Primária", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            Agencia agency = new Agencia
            {
                Id = _id,
                Numero = txtAgencia.Text,
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


            if (this.Text == "Alterar")
                new AgenciaService().Update(agency);
            else
                new AgenciaService().Insert(agency);


            Back();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Back();
        }

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

        private void Back()
        {
            this.Close();
            if (this.FormBorderStyle != FormBorderStyle.FixedSingle)
            {
                frmAgencias formFilho = new frmAgencias(_frmPrincipal);
                _frmPrincipal.AbrirFormInPanel(formFilho, _frmPrincipal.pnlMain);
            }
        }

    }


}
