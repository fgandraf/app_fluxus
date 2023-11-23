using Fluxus.Domain.Entities;
using Fluxus.App.Services;
using System.Drawing.Imaging;
using Fluxus.Infra.Services;
using System.Text.RegularExpressions;
using Fluxus.Domain.Enums;
using Microsoft.Extensions.DependencyInjection;

namespace Fluxus.WinUI.View
{
    public partial class uctProfile : UserControl
    {
        private readonly IServiceProvider _serviceProvider;
        private ProfileService _profileService;
        private frmMain _frmPrincipal;
        private Image _actualLogo;
        private EnumMethod _method;

        public uctProfile(frmMain frm, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            _profileService = _serviceProvider.GetService<ProfileService>();
            _frmPrincipal = frm;

            InitializeComponent();

            var profile = _profileService.GetAll();
            if (profile != null)
            {
                PopulateFields(profile);
                btnAddSave.Text = "&Salvar";
                _method = EnumMethod.Update;
            }
            else
            {
                _method = EnumMethod.Insert;
            }

            if (Logged.Rl)
                pnlBotton.Show();
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {

            _profileService.Profile = PopulateObject();

            var result = _method == EnumMethod.Insert ? _profileService.Insert() : _profileService.Update();

            if (result.Success)
                MessageBox.Show("Dados alterados com sucesso!", "Dados Cadastrais", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(_profileService.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            UpdateTradingNameButton();
            UpdateMainLogo();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.OK)
                picLogotipo.ImageLocation = openDialog.FileName;
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            string cep = Regex.Replace(txtCEP.Text, "[^0-9]", "");

            if (!String.IsNullOrEmpty(cep) && cep.Length == 8)
            {
                var result = new ViaCep().GetViaCep(cep);
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

        private bool RequiredFieldsIsInvalid()
        {
            if (txtCNPJ.Text == "" || txtNomeFantasia.Text == "" || txtRazaoSocial.Text == "")
            {
                MessageBox.Show("Campos com * são obrigatório", "Chave Primária", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            else
                return false;
        }

        private void UpdateTradingNameButton()
        {
            if (_frmPrincipal.btnDadosCadastrais.Text != txtNomeFantasia.Text)
            {
                _frmPrincipal.btnDadosCadastrais.Text = txtNomeFantasia.Text;
                _frmPrincipal.btnDadosCadastrais.Refresh();
            }
        }

        private void UpdateMainLogo()
        {
            if (picLogotipo.Image != _actualLogo)
            {
                _frmPrincipal.imgLogo.Image = picLogotipo.Image;
                _frmPrincipal.imgLogo.Refresh();
            }
        }

        private void PopulateFields(Profile profile)
        {
            txtCNPJ.Text = profile.Cnpj;
            txtNomeFantasia.Text = profile.TradingName;
            txtRazaoSocial.Text = profile.CompanyName;
            txtInscricaoEstadual.Text = profile.StateId;
            txtInscricaoMunicipal.Text = profile.CityId;
            txtEndereco.Text = profile.Address;
            txtComplemento.Text = profile.Complement;
            txtBairro.Text = profile.District;
            txtCidade.Text = profile.City;
            txtCEP.Text = profile.Zip;
            cboUF.Text = profile.State;
            dtpConstituicao.Value = profile.EstablishmentDate;
            txtTelefone.Text = profile.Phone1;
            txtTelefone2.Text = profile.Phone2;
            txtEmail.Text = profile.Email;
            txtBanco.Text = profile.BankAccountName;
            cboTipoDeConta.Text = profile.BankAccountType;
            txtAgencia.Text = profile.BankAccountBranch;
            txtOperador.Text = profile.BankAccountDigit;
            txtConta.Text = profile.BankAccountNumber;
            cboTomador.Text = profile.ContractorName;
            txtEdital.Text = profile.ContractNotice;
            txtContrato.Text = profile.ContractNumber;
            dtpCelebrado.Value = profile.ContractEstablished;
            dtpInicio.Value = profile.ContractStart;
            dtpTermino.Value = profile.ContractEnd;

            if (profile.Logo != null)
            {
                using (var stream = new MemoryStream(profile.Logo))
                    _actualLogo = Image.FromStream(stream);
            }
            picLogotipo.Image = _actualLogo;
        }

        private Profile PopulateObject()
        {
            var profile = new Profile
            (
                id : 1,
                cnpj : txtCNPJ.Text,
                tradingName : txtNomeFantasia.Text,
                companyName : txtRazaoSocial.Text,
                stateId : txtInscricaoEstadual.Text,
                cityId : txtInscricaoMunicipal.Text,
                address : txtEndereco.Text,
                complement : txtComplemento.Text,
                district : txtBairro.Text,
                city : txtCidade.Text,
                zip : txtCEP.Text,
                state : cboUF.Text,
                establishmentDate : dtpConstituicao.Value,
                phone1 : txtTelefone.Text,
                phone2 : txtTelefone2.Text,
                email : txtEmail.Text,
                bankAccountName : txtBanco.Text,
                bankAccountType : cboTipoDeConta.Text,
                bankAccountBranch : txtAgencia.Text,
                bankAccountDigit : txtOperador.Text,
                bankAccountNumber : txtConta.Text,
                contractorName : cboTomador.Text,
                contractNotice : txtEdital.Text,
                contractNumber : txtContrato.Text,
                contractEstablished : dtpCelebrado.Value,
                contractStart : dtpInicio.Value,
                contractEnd : dtpTermino.Value
            );

            using (var stream = new MemoryStream())
            {
                picLogotipo.Image.Save(stream, ImageFormat.Png);
                profile.Logo = stream.ToArray();
            }

            return profile;
        }


    }
}
