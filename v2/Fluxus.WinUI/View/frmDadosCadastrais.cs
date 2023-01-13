using System;
using System.Windows.Forms;
using Fluxus.Domain.Entities;
using System.Drawing;
using Fluxus.Services;


namespace Fluxus.WinUI.View
{
    public partial class frmDadosCadastrais : Form
    {


        frmPrincipal _frmPrincipal;
        private Image _logoAtual = null;





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


        private void PopulateFields()
        {
            try
            {

                Profile dados = new ProfileService().ListarCadastrais();

                if (dados == null)
                    txtCNPJ.Focus();
                else
                {
                    btnCadastrarSalvar.Text = "&Salvar";
                    txtCNPJ.Text = dados.Cnpj;
                    txtNomeFantasia.Text = dados.TradingName;
                    txtRazaoSocial.Text = dados.CompanyName;
                    txtInscricaoEstadual.Text = dados.StateId;
                    txtInscricaoMunicipal.Text = dados.CityId;
                    txtEndereco.Text = dados.Address;
                    txtComplemento.Text = dados.Complement;
                    txtBairro.Text = dados.District;
                    txtCidade.Text = dados.City;
                    txtCEP.Text = dados.Zip;
                    cboUF.Text = dados.State;
                    DateTime constituicao = Convert.ToDateTime(dados.EstablishmentDate);
                    if (constituicao.ToString() != "01/01/0001 00:00:00")
                        txtConstituicao.Text = constituicao.ToString("dd/MM/yyyy");
                    txtTelefone.Text = dados.Phone1;
                    txtTelefone2.Text = dados.Phone2;
                    txtEmail.Text = dados.Email;
                    txtBanco.Text = dados.BankAccountName;
                    cboTipoDeConta.Text = dados.BankAccountType;
                    txtAgencia.Text = dados.BankAccountBranch;
                    txtOperador.Text = dados.BankAccountDigit;
                    txtConta.Text = dados.BankAccountNumber;
                    cboTomador.Text = dados.ContractorName;
                    txtEdital.Text = dados.ContractNotice;
                    txtContrato.Text = dados.ContractNumber;

                    DateTime ct_celebrado = Convert.ToDateTime(dados.ContractEstablished);
                    if (ct_celebrado.ToString() != "01/01/0001 00:00:00")
                        txtCelebrado.Text = ct_celebrado.ToString("dd/MM/yyy");

                    DateTime ct_inicio = Convert.ToDateTime(dados.ContractStart);
                    if (ct_inicio.ToString() != "01/01/0001 00:00:00")
                        txtInicio.Text = ct_inicio.ToString("dd/MM/yyyy");

                    DateTime ct_termino = Convert.ToDateTime(dados.ContractEnd);
                    if (ct_termino.ToString() != "01/01/0001 00:00:00")
                        txtTermino.Text = ct_termino.ToString("dd/MM/yyyy");




                    byte[] logo = Convert.FromBase64String(dados.Logo);

                    if (logo.ToString() != "")
                    {
                        _logoAtual = Util.ByteToImage(logo);
                        picLogotipo.Image = Util.ByteToImage(logo);
                    }

                    txtCNPJ.Focus();
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
                EstablishmentDate = Util.ValidateDateString(txtConstituicao.Text),
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
                ContractEstablished = Util.ValidateDateString(txtCelebrado.Text),
                ContractStart = Util.ValidateDateString(txtInicio.Text),
                ContractEnd = Util.ValidateDateString(txtTermino.Text),
                Logo = Convert.ToBase64String(Util.ImageToByte(picLogotipo.Image))
            };

            return dado;
        }





        //:EVENTS
        public frmDadosCadastrais(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }


        private void frmDadosCadastrais_Load(object sender, EventArgs e)
        {
            PopulateFields();
            if (Logged.Rl)
            {
                pnlBotton.Show();
            }
        }


        private void btnCadastrarSalvar_Click(object sender, EventArgs e)
        {
            if (txtCNPJ.Text == "" || txtNomeFantasia.Text == "" || txtRazaoSocial.Text == "")
            {
                MessageBox.Show("Campos com * são obrigatório", "Chave Primária", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



            if (_frmPrincipal.btnDadosCadastrais.Text != txtNomeFantasia.Text)
            {
                _frmPrincipal.btnDadosCadastrais.Text = txtNomeFantasia.Text;
                _frmPrincipal.btnDadosCadastrais.Refresh();
            }



            Profile dado = PopulateObject();



            if (btnCadastrarSalvar.Text == "&Cadastrar")
            {
                try
                {
                    new ProfileService().Insert(dado);
                    MessageBox.Show("Dados cadastrados com sucesso!", "Dados Cadastrais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    new ProfileService().Update(dado);
                    MessageBox.Show("Dados cadastrais alterados com sucesso!", "Dados Cadastrais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.OK)
                picLogotipo.ImageLocation = openDialog.FileName;
        }


    }


}
