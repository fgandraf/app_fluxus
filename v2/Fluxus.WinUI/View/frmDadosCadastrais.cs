using Fluxus.Domain.Entities;
using Fluxus.Services;

namespace Fluxus.WinUI.View
{
    public partial class frmDadosCadastrais : Form
    {
        frmPrincipal _frmPrincipal;
        private Image _logoAtual;

        public frmDadosCadastrais(frmPrincipal frm1)
        {
            InitializeComponent();

            _frmPrincipal = frm1;

            PopulateFields();

            if (Logged.Rl)
                pnlBotton.Show();
        }

        private void btnCadastrarSalvar_Click(object sender, EventArgs e)
        {
            if (RequiredFieldsIsInvalid())
                return;

            var profile = PopulateObject();

            if (((Button)sender).Text == "&Cadastrar")
                new ProfileService().Insert(profile);
            else
                new ProfileService().Update(profile);

            UpdateTradingNameButton();

            MessageBox.Show("Dados alterados com sucesso!", "Dados Cadastrais", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCarregar_Click(object sender, EventArgs e)
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













        private void PopulateFields()
        {
            try
            {
                var profile = new ProfileService().ListarCadastrais();

                if (profile == null)
                    txtCNPJ.Focus();
                else
                {
                    btnCadastrarSalvar.Text = "&Salvar";
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
                    DateTime constituicao = Convert.ToDateTime(profile.EstablishmentDate);
                    if (constituicao.ToString() != "01/01/0001 00:00:00")
                        txtConstituicao.Text = constituicao.ToString("dd/MM/yyyy");
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

                    DateTime ct_celebrado = Convert.ToDateTime(profile.ContractEstablished);
                    if (ct_celebrado.ToString() != "01/01/0001 00:00:00")
                        txtCelebrado.Text = ct_celebrado.ToString("dd/MM/yyy");

                    DateTime ct_inicio = Convert.ToDateTime(profile.ContractStart);
                    if (ct_inicio.ToString() != "01/01/0001 00:00:00")
                        txtInicio.Text = ct_inicio.ToString("dd/MM/yyyy");

                    DateTime ct_termino = Convert.ToDateTime(profile.ContractEnd);
                    if (ct_termino.ToString() != "01/01/0001 00:00:00")
                        txtTermino.Text = ct_termino.ToString("dd/MM/yyyy");




                    //byte[] logo = Convert.FromBase64String(profile.Logo);

                    //if (logo.ToString() != "")
                    //{
                    //    using (var stream = new MemoryStream(logo))
                    //    {
                    //        _logoAtual = Image.FromStream(stream);
                    //    }
                    //    picLogotipo.Image = _logoAtual;
                    //}

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private Profile PopulateObject()
        {
            Profile dado = new Profile
            {
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
                EstablishmentDate = Util.ValidateDate(txtConstituicao.Text),
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
                ContractEstablished = Util.ValidateDate(txtCelebrado.Text),
                ContractStart = Util.ValidateDate(txtInicio.Text),
                ContractEnd = Util.ValidateDate(txtTermino.Text),
            };

            //using (var stream = new MemoryStream())
            //{
            //    picLogotipo.Image.Save(stream, ImageFormat.Png);
            //    dado.Logo = Convert.ToBase64String(stream.ToArray());
            //}

            return dado;
        }
    }
}
