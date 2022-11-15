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
                
                Cadastrais dados = new CadastraisService().ListarCadastrais();

                if (dados == null)
                    txtCNPJ.Focus();
                else
                {
                    btnCadastrarSalvar.Text = "&Salvar";
                    txtCNPJ.Text = dados.Cnpj;
                    txtNomeFantasia.Text = dados.Nome;
                    txtRazaoSocial.Text = dados.RazaoSocial;
                    txtInscricaoEstadual.Text = dados.InscricaoEstadual;
                    txtInscricaoMunicipal.Text = dados.InscricaoMunicipal;
                    txtEndereco.Text = dados.Endereco;
                    txtComplemento.Text = dados.Complemento;
                    txtBairro.Text = dados.Bairro;
                    txtCidade.Text = dados.Cidade;
                    txtCEP.Text = dados.Cep;
                    cboUF.Text = dados.Uf;
                    DateTime constituicao = Convert.ToDateTime(dados.Constituicao);
                    if (constituicao.ToString() != "01/01/0001 00:00:00")
                        txtConstituicao.Text = constituicao.ToString("dd/MM/yyyy");
                    txtTelefone.Text = dados.Telefone;
                    txtTelefone2.Text = dados.Telefone2;
                    txtEmail.Text = dados.Email;
                    txtBanco.Text = dados.BancoNome;
                    cboTipoDeConta.Text = dados.BancoTipo;
                    txtAgencia.Text = dados.BancoAgencia;
                    txtOperador.Text = dados.BancoOperador;
                    txtConta.Text = dados.BancoConta;
                    cboTomador.Text = dados.ContratoTomador;
                    txtEdital.Text = dados.ContratoEdital;
                    txtContrato.Text = dados.ContratoNumero;

                    DateTime ct_celebrado = Convert.ToDateTime(dados.ContratoCelebrado);
                    if (ct_celebrado.ToString() != "01/01/0001 00:00:00")
                        txtCelebrado.Text = ct_celebrado.ToString("dd/MM/yyy");

                    DateTime ct_inicio = Convert.ToDateTime(dados.ContratoInicio);
                    if (ct_inicio.ToString() != "01/01/0001 00:00:00")
                        txtInicio.Text = ct_inicio.ToString("dd/MM/yyyy");

                    DateTime ct_termino = Convert.ToDateTime(dados.ContratoTermino);
                    if (ct_termino.ToString() != "01/01/0001 00:00:00")
                        txtTermino.Text = ct_termino.ToString("dd/MM/yyyy");




                    byte[] logo = Convert.FromBase64String(dados.Logotipo);

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


        private Cadastrais PopulateObject()
        {
            Cadastrais dado = new Cadastrais
            {
                Cnpj = txtCNPJ.Text,
                Nome = txtNomeFantasia.Text,
                RazaoSocial = txtRazaoSocial.Text,
                InscricaoEstadual = txtInscricaoEstadual.Text,
                InscricaoMunicipal = txtInscricaoMunicipal.Text,
                Endereco = txtEndereco.Text,
                Complemento = txtComplemento.Text,
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                Cep = txtCEP.Text,
                Uf = cboUF.Text,
                Constituicao = Util.ValidateDateString(txtConstituicao.Text),
                Telefone = txtTelefone.Text,
                Telefone2 = txtTelefone2.Text,
                Email = txtEmail.Text,
                BancoNome = txtBanco.Text,
                BancoTipo = cboTipoDeConta.Text,
                BancoAgencia = txtAgencia.Text,
                BancoOperador = txtOperador.Text,
                BancoConta = txtConta.Text,
                ContratoTomador = cboTomador.Text,
                ContratoEdital = txtEdital.Text,
                ContratoNumero = txtContrato.Text,
                ContratoCelebrado = Util.ValidateDateString(txtCelebrado.Text),
                ContratoInicio = Util.ValidateDateString(txtInicio.Text),
                ContratoTermino = Util.ValidateDateString(txtTermino.Text),
                Logotipo = Convert.ToBase64String(Util.ImageToByte(picLogotipo.Image))
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



            Cadastrais dado = PopulateObject();



            if (btnCadastrarSalvar.Text == "&Cadastrar")
            {
                try
                {
                    new CadastraisService().Insert(dado);
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
                    new CadastraisService().Update(dado);
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
