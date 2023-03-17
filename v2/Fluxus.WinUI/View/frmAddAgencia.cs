using System;
using System.Windows.Forms;
using Fluxus.Domain.Entities;
using Fluxus.Services;

namespace Fluxus.WinUI.View
{
    public partial class frmAddAgencia : Form
    {

        frmPrincipal _frmPrincipal;
        private int _id;



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


        public frmAddAgencia(frmPrincipal frm1, BankBranch dado) //Editar agencia
        {
            InitializeComponent();
            _frmPrincipal = frm1;

            _id = dado.Id;
            txtAgencia.Text = dado.BranchNumber;
            txtNome.Text = dado.Name;
            txtEndereco.Text = dado.Address;
            txtComplemento.Text = dado.Complement;
            txtBairro.Text = dado.District;
            txtCidade.Text = dado.City;
            txtCEP.Text = dado.Zip;
            cboUF.Text = dado.State;
            txtContato.Text = dado.ContactName;
            txtTelefone1.Text = dado.Phone1;
            txtTelefone2.Text = dado.Phone2;
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


            BankBranch agency = new BankBranch
            {
                Id = _id,
                BranchNumber = txtAgencia.Text,
                Name = txtNome.Text,
                Address = txtEndereco.Text,
                Complement = txtComplemento.Text,
                District = txtBairro.Text,
                City = txtCidade.Text,
                Zip = txtCEP.Text,
                State = cboUF.Text,
                ContactName = txtContato.Text,
                Phone1 = txtTelefone1.Text,
                Phone2 = txtTelefone2.Text,
                Email = txtEmail.Text
            };


            if (this.Text == "Alterar")
                new BankBranchService().Update(agency);
            else
                new BankBranchService().Insert(agency);


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
                _frmPrincipal.AbrirFormInPanel(formFilho);
            }
        }

    }


}
