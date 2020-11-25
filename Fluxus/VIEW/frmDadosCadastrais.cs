using System;
using System.Windows.Forms;
using Fluxus.Model.ENT;
using System.Drawing;
using System.Data;
using Fluxus.Model;


namespace Fluxus.View
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
                //DataTable dtDados = new CadastraisModel().ListarCadastrais();

                //if (dtDados.Rows.Count == 0)
                //    txtCNPJ.Focus();
                //else
                //{
                //    btnCadastrarSalvar.Text = "&Salvar";
                //    txtCNPJ.Text = dtDados.Rows[0]["cnpj"].ToString();
                //    txtNomeFantasia.Text = dtDados.Rows[0]["fantasia"].ToString();
                //    txtRazaoSocial.Text = dtDados.Rows[0]["razao"].ToString();
                //    txtInscricaoEstadual.Text = dtDados.Rows[0]["ie"].ToString();
                //    txtInscricaoMunicipal.Text = dtDados.Rows[0]["im"].ToString();
                //    txtEndereco.Text = dtDados.Rows[0]["endereco"].ToString();
                //    txtComplemento.Text = dtDados.Rows[0]["complemento"].ToString();
                //    txtBairro.Text = dtDados.Rows[0]["bairro"].ToString();
                //    txtCidade.Text = dtDados.Rows[0]["cidade"].ToString();
                //    txtCEP.Text = dtDados.Rows[0]["cep"].ToString();
                //    cboUF.Text = dtDados.Rows[0]["uf"].ToString();
                //    DateTime constituicao = Convert.ToDateTime(dtDados.Rows[0]["constituicao"]);
                //    if (constituicao.ToString() != "01/01/0001 00:00:00")
                //        txtConstituicao.Text = constituicao.ToString("dd/MM/yyyy");
                //    txtTelefone.Text = dtDados.Rows[0]["telefone"].ToString();
                //    txtTelefone2.Text = dtDados.Rows[0]["telefone2"].ToString();
                //    txtEmail.Text = dtDados.Rows[0]["email"].ToString();
                //    txtBanco.Text = dtDados.Rows[0]["db_banco"].ToString();
                //    cboTipoDeConta.Text = dtDados.Rows[0]["db_tipo"].ToString();
                //    txtAgencia.Text = dtDados.Rows[0]["db_agencia"].ToString();
                //    txtOperador.Text = dtDados.Rows[0]["db_operador"].ToString();
                //    txtConta.Text = dtDados.Rows[0]["db_conta"].ToString();
                //    cboTomador.Text = dtDados.Rows[0]["ct_tomador"].ToString();
                //    txtEdital.Text = dtDados.Rows[0]["ct_edital"].ToString();
                //    txtContrato.Text = dtDados.Rows[0]["ct_contrato"].ToString();

                //    DateTime ct_celebrado = Convert.ToDateTime(dtDados.Rows[0]["ct_celebrado"]);
                //    if (ct_celebrado.ToString() != "01/01/0001 00:00:00")
                //        txtCelebrado.Text = ct_celebrado.ToString("dd/MM/yyy");

                //    DateTime ct_inicio = Convert.ToDateTime(dtDados.Rows[0]["ct_inicio"]);
                //    if (ct_inicio.ToString() != "01/01/0001 00:00:00")
                //        txtInicio.Text = ct_inicio.ToString("dd/MM/yyyy");

                //    DateTime ct_termino = Convert.ToDateTime(dtDados.Rows[0]["ct_termino"]);
                //    if (ct_termino.ToString() != "01/01/0001 00:00:00")
                //        txtTermino.Text = ct_termino.ToString("dd/MM/yyyy");




                //    byte[] logo = Convert.FromBase64String(dtDados.Rows[0]["logo"].ToString());

                //    if (logo.ToString() != "")
                //    {
                //        _logoAtual = Util.ByteToImage(logo);
                //        picLogotipo.Image = Util.ByteToImage(logo);
                //    }

                //    txtCNPJ.Focus();
                //}
                CadastraisENT dados = new CadastraisModel().ListarCadastrais();

                if (dados == null)
                    txtCNPJ.Focus();
                else
                {
                    btnCadastrarSalvar.Text = "&Salvar";
                    txtCNPJ.Text = dados.Cnpj;
                    txtNomeFantasia.Text = dados.Fantasia;
                    txtRazaoSocial.Text = dados.Razao;
                    txtInscricaoEstadual.Text = dados.Ie;
                    txtInscricaoMunicipal.Text = dados.Im;
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
                    txtBanco.Text = dados.Db_banco;
                    cboTipoDeConta.Text = dados.Db_tipo;
                    txtAgencia.Text = dados.Db_agencia;
                    txtOperador.Text = dados.Db_operador;
                    txtConta.Text = dados.Db_conta;
                    cboTomador.Text = dados.Ct_tomador;
                    txtEdital.Text = dados.Ct_edital;
                    txtContrato.Text = dados.Ct_contrato;

                    DateTime ct_celebrado = Convert.ToDateTime(dados.Ct_celebrado);
                    if (ct_celebrado.ToString() != "01/01/0001 00:00:00")
                        txtCelebrado.Text = ct_celebrado.ToString("dd/MM/yyy");

                    DateTime ct_inicio = Convert.ToDateTime(dados.Ct_inicio);
                    if (ct_inicio.ToString() != "01/01/0001 00:00:00")
                        txtInicio.Text = ct_inicio.ToString("dd/MM/yyyy");

                    DateTime ct_termino = Convert.ToDateTime(dados.Ct_termino);
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


        private CadastraisENT PopulateObject()
        {
            CadastraisENT dado = new CadastraisENT
            {
                Cnpj = txtCNPJ.Text,
                Fantasia = txtNomeFantasia.Text,
                Razao = txtRazaoSocial.Text,
                Ie = txtInscricaoEstadual.Text,
                Im = txtInscricaoMunicipal.Text,
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
                Db_banco = txtBanco.Text,
                Db_tipo = cboTipoDeConta.Text,
                Db_agencia = txtAgencia.Text,
                Db_operador = txtOperador.Text,
                Db_conta = txtConta.Text,
                Ct_tomador = cboTomador.Text,
                Ct_edital = txtEdital.Text,
                Ct_contrato = txtContrato.Text,
                Ct_celebrado = Util.ValidateDateString(txtCelebrado.Text),
                Ct_inicio = Util.ValidateDateString(txtInicio.Text),
                Ct_termino = Util.ValidateDateString(txtTermino.Text),
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



            CadastraisENT dado = PopulateObject();



            if (btnCadastrarSalvar.Text == "&Cadastrar")
            {
                try
                {
                    new CadastraisModel().Insert(dado);
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
                    new CadastraisModel().Update(dado);
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
