using Fluxus.Domain.Entities;
using Fluxus.Infra.Services;
using Fluxus.App;
using System.Text.RegularExpressions;

namespace Fluxus.WinUI.View
{
    public partial class uctAddBankBranch : UserControl
    {
        private readonly frmMain _frmPrincipal;
        private readonly int _id;

        public uctAddBankBranch(frmMain frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }

        public uctAddBankBranch(string agencia)
        {
            InitializeComponent();

            this.Size = new System.Drawing.Size(650, 600);
            this.Text = "Adicionar";

            txtAgencia.Text = agencia;
        }

        public uctAddBankBranch(frmMain frm1, BankBranch branch)
        {
            InitializeComponent();
            _frmPrincipal = frm1;

            _id = branch.Id;
            txtAgencia.Text = branch.BranchNumber;
            txtNome.Text = branch.Name;
            txtEndereco.Text = branch.Address;
            txtComplemento.Text = branch.Complement;
            txtBairro.Text = branch.District;
            txtCidade.Text = branch.City;
            txtCEP.Text = branch.Zip;
            cboUF.Text = branch.State;
            txtContato.Text = branch.ContactName;
            txtTelefone1.Text = branch.Phone1;
            txtTelefone2.Text = branch.Phone2;
            txtEmail.Text = branch.Email;

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
            BankBranch branch = PopulateObject();
            var result = new BankBranchApp().InsertOrUpdate(branch, btnAddSave.Text);

            MessageBox.Show(result, "Atividades", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            uctBankBranch formFilho = new uctBankBranch(_frmPrincipal);
            _frmPrincipal.OpenUserControl(formFilho);
        }

        private void OnValidated_MaskedTextBox(object sender, EventArgs e)
            => ((MaskedTextBox)sender).Mask = Util.MaskValidated(sender);

        private void OnEnter_MaskedTextBox(object sender, EventArgs e)
            => ((MaskedTextBox)sender).Mask = Util.MaskEnter(sender);

        private BankBranch PopulateObject()
        {
            BankBranch branch = new BankBranch
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
            return branch;
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            if (txtCEP.Text != "     -")
            {
                string cep = Regex.Replace(txtCEP.Text, "[^0-9]", "");
                var result = new ViaCep().GetViaCep(cep);
                if (!result.Erro)
                {
                    txtEndereco.Text = result.Logradouro;
                    txtComplemento.Text = result.Complemento;
                    txtBairro.Text = result.Bairro;
                    txtCidade.Text = result.Localidade;
                    cboUF.Text = result.Uf;
                }
            }

        }
    }
}
