using Fluxus.Domain.Models;
using Fluxus.App.Services;
using System.Text.RegularExpressions;
using Fluxus.Domain.Enums;
using Microsoft.Extensions.DependencyInjection;
using Fluxus.Infra.Services;

namespace Fluxus.WinUI.View
{
    public partial class uctAddBankBranch : UserControl
    {
        private readonly frmMain _frmPrincipal;
        private EMethod _method;
        private IServiceProvider _serviceProvider;

        public uctAddBankBranch(frmMain frm1, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            InitializeComponent();
            _frmPrincipal = frm1;
            _method = EMethod.Insert;
        }

        public uctAddBankBranch(string agencia, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            InitializeComponent();
            _method = EMethod.Insert;

            this.Size = new System.Drawing.Size(650, 600);
            txtAgencia.Text = agencia;
        }

        public uctAddBankBranch(frmMain frm1, Branch branch, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            InitializeComponent();
            _frmPrincipal = frm1;
            _method = EMethod.Update;

            txtAgencia.Text = branch.Id;
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
            if (_method == EMethod.Insert)
            {
                btnAddSave.Text = "&Adicionar";
                txtAgencia.Focus();
            }
            else
                txtNome.Focus();
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            var service = _serviceProvider.GetService<BankBranchService>();
            var bankBranch = PopulateObject();

            dynamic result = _method == EMethod.Insert ? service.Insert(bankBranch) : service.Update(bankBranch);

            if (result.Success)
                btnCancelar_Click(sender, e);
            else
                MessageBox.Show(result.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            uctBankBranch formFilho = new uctBankBranch(_frmPrincipal, _serviceProvider);
            _frmPrincipal.OpenUserControl(formFilho);
        }

        private void OnValidated_MaskedTextBox(object sender, EventArgs e)
            => ((MaskedTextBox)sender).Mask = Util.MaskValidated(sender);

        private void OnEnter_MaskedTextBox(object sender, EventArgs e)
            => ((MaskedTextBox)sender).Mask = Util.MaskEnter(sender);

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            string cep = Regex.Replace(txtCEP.Text, "[^0-9]", "");

            if (!String.IsNullOrEmpty(cep) && cep.Length == 8)
            {
                var result = new ViaCep().GetCep(cep);
                if (result != null || !result.Erro)
                {
                    txtEndereco.Text = result.Logradouro;
                    txtComplemento.Text = result.Complemento;
                    txtBairro.Text = result.Bairro;
                    txtCidade.Text = result.Localidade;
                    cboUF.Text = result.Uf;
                }
            }
        }

        private Branch PopulateObject()
        {
            Branch branch = new Branch
            (
                id : txtAgencia.Text,
                name : txtNome.Text,
                address: txtEndereco.Text,
                complement : txtComplemento.Text,
                district : txtBairro.Text,
                city: txtCidade.Text,
                zip: txtCEP.Text,
                state : cboUF.Text,
                contactName: txtContato.Text,
                phone1: txtTelefone1.Text,
                phone2: txtTelefone2.Text,
                email: txtEmail.Text
            );
            return branch;
        }

    }

}
