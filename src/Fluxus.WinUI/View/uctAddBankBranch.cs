using Fluxus.Core.Models;
using System.Text.RegularExpressions;
using Fluxus.Core.Enums;
using Microsoft.Extensions.DependencyInjection;
using Fluxus.Infra.Services;
using Fluxus.UseCases;
using Fluxus.Core.Dtos;

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

            if (!string.IsNullOrEmpty(branch.Zip))
                txtCEP.Text = string.Format("{0}-{1}", branch.Zip.Substring(0, 5), branch.Zip.Substring(5, 3));
            

            cboUF.Text = branch.State;
            txtContato.Text = branch.ContactName;

            if (branch.Phone1.Length == 11)
            {
                txtTelefone1.Text = string.Format("({0}) {1}-{2}",
                branch.Phone1.Substring(0, 2),
                branch.Phone1.Substring(2, 5),
                branch.Phone1.Substring(7, 4));
            }
            if (branch.Phone1.Length == 10)
            {
                txtTelefone1.Text = string.Format("({0}) {1}-{2}",
                branch.Phone1.Substring(0, 2),
                branch.Phone1.Substring(2, 4),
                branch.Phone1.Substring(6, 4));
            }

            if (branch.Phone2.Length == 11)
            {
                txtTelefone2.Text = string.Format("({0}) {1}-{2}",
                branch.Phone2.Substring(0, 2),
                branch.Phone2.Substring(2, 5),
                branch.Phone2.Substring(7, 4));
            }
            if (branch.Phone2.Length == 10)
            {
                txtTelefone2.Text = string.Format("({0}) {1}-{2}",
                branch.Phone2.Substring(0, 2),
                branch.Phone2.Substring(2, 4),
                branch.Phone2.Substring(6, 4));
            }
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
            var service = _serviceProvider.GetService<BranchUseCases>();
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
                if (!result.Equals(new AddressViewModel()))
                {
                    txtEndereco.Text = result.Logradouro;
                    txtComplemento.Text = result.Complemento;
                    txtBairro.Text = result.Bairro;
                    txtCidade.Text = result.Cidade;
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
                zip: Regex.Replace(txtCEP.Text, @"[^\d]", ""),
                state : cboUF.Text,
                contactName: txtContato.Text,
                phone1: Regex.Replace(txtTelefone1.Text, @"[^\d]", ""),
                phone2: Regex.Replace(txtTelefone2.Text, @"[^\d]", ""),
                email: txtEmail.Text
            );
            return branch;
        }

    }

}
