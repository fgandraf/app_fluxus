﻿using Fluxus.Domain.Entities;
using Fluxus.Services;
using System.Drawing.Imaging;

namespace Fluxus.WinUI.View
{
    public partial class frmProfile : Form
    {
        frmPrincipal _frmPrincipal;
        private Image _actualLogo;
        private string _method;

        public frmProfile(frmPrincipal frm1)
        {
            InitializeComponent();
            
            _frmPrincipal = frm1;
            
            var profile = new ProfileService().GetAll();
            if (profile != null)
            {
                PopulateFields(profile);
                btnAddSave.Text = "&Salvar";
                _method = "Update";
            }
            
            if (Logged.Rl)
                pnlBotton.Show();
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            if (RequiredFieldsIsInvalid()) 
                return;

            var profile = PopulateObject();

            new ProfileService().InsertOrUpdate(_method, profile);

            UpdateTradingNameButton();

            MessageBox.Show("Dados alterados com sucesso!", "Dados Cadastrais", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.OK)
                picLogotipo.ImageLocation = openDialog.FileName;
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

            if (profile.Logo.ToString() != "")
            {
                using (var stream = new MemoryStream(profile.Logo))
                    _actualLogo = Image.FromStream(stream);

                picLogotipo.Image = _actualLogo;
            }
        }

        private Profile PopulateObject()
        {
            var profile = new Profile
            {
                Id = 1,
                Cnpj = txtCNPJ.Text,
                TradingName = txtNomeFantasia.Text,
                CompanyName = txtRazaoSocial.Text,
                StateId = txtInscricaoEstadual.Text,
                CityId = txtInscricaoMunicipal.Text,
                Address = txtEndereco.Text,
                Complement = txtComplemento.Text,
                District = txtBairro.Text,
                City = txtCidade.Text,
                Zip = txtCEP.Text,
                State = cboUF.Text,
                EstablishmentDate = dtpConstituicao.Value,
                Phone1 = txtTelefone.Text,
                Phone2 = txtTelefone2.Text,
                Email = txtEmail.Text,
                BankAccountName = txtBanco.Text,
                BankAccountType = cboTipoDeConta.Text,
                BankAccountBranch = txtAgencia.Text,
                BankAccountDigit = txtOperador.Text,
                BankAccountNumber = txtConta.Text,
                ContractorName = cboTomador.Text,
                ContractNotice = txtEdital.Text,
                ContractNumber = txtContrato.Text,
                ContractEstablished = dtpCelebrado.Value,
                ContractStart = dtpInicio.Value,
                ContractEnd = dtpTermino.Value,
            };

            using (var stream = new MemoryStream())
            {
                picLogotipo.Image.Save(stream, ImageFormat.Png);
                profile.Logo = stream.ToArray();
            }

            return profile;
        }
    }
}