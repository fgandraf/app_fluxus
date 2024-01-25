using Fluxus.Core.Models;
using System.Drawing.Imaging;
using Fluxus.Infra.Services;
using System.Text.RegularExpressions;
using Fluxus.Core.Enums;
using Microsoft.Extensions.DependencyInjection;
using Org.BouncyCastle.Utilities.Collections;
using Fluxus.Core.ViewModels;
using Fluxus.UseCases;

namespace Fluxus.WinUI.View
{
    public partial class uctProfile : UserControl
    {
        private readonly IServiceProvider _serviceProvider;
        private ProfileUseCases _profileService;
        private frmMain _frmPrincipal;
        private Image _actualLogo;
        private EMethod _method;

        public uctProfile(frmMain frm, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            _profileService = _serviceProvider.GetService<ProfileUseCases>();
            _frmPrincipal = frm;

            InitializeComponent();

            var profile = _profileService.GetById(1);
            if (profile.Success)
            {
                PopulateFields(profile.Value);
                btnAddSave.Text = "&Salvar";
                _method = EMethod.Update;
            }
            else
            {
                _method = EMethod.Insert;
            }

            if (Logged.Rl)
                pnlBotton.Show();
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            var profile = PopulateObject();
            var logo = PopulateLogo();

            dynamic resultProfile = _method == EMethod.Insert ? _profileService.Insert(profile) : _profileService.Update(profile);
            var resulLogo = _profileService.UpdateLogo(logo);

            if (resultProfile.Success && resulLogo.Success)
                MessageBox.Show("Dados alterados com sucesso!", "Dados Cadastrais", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(resultProfile.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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



            var logo = _profileService.GetLogo();
            if (logo.Value != null)
            {
                using (var stream = new MemoryStream(logo.Value))
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

            return profile;
        }

        private Object PopulateLogo()
        {
            byte[] logo;
            using (var stream = new MemoryStream())
            {
                picLogotipo.Image.Save(stream, ImageFormat.Png);
                logo = stream.ToArray();
            }

            return new
            {
                Base64Image = Convert.ToBase64String(logo)
            };
        }


    }
}
