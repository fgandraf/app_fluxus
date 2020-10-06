using System;
using System.Windows.Forms;
using Fluxus.Model.ENT;
using System.Text.RegularExpressions;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;
using Fluxus.Model;
using System.Text;

namespace Fluxus.View
{
    public partial class frmDadosCadastrais : Form
    {
        frmPrincipal _frmPrincipal;
        private Image _logoAtual = null;



        //:METHODS
        private void PopulateFields()
        {
            try
            {
                DataTable dtDados = new CadastraisModel().ListarCadastrais();

                if (dtDados.Rows.Count == 0)
                    txtCNPJ.Focus();
                else
                {
                    btnCadastrarSalvar.Text = "&Salvar";
                    txtCNPJ.Text = dtDados.Rows[0]["cnpj"].ToString();
                    txtNomeFantasia.Text = dtDados.Rows[0]["fantasia"].ToString();
                    txtRazaoSocial.Text = dtDados.Rows[0]["razao"].ToString();
                    txtInscricaoEstadual.Text = dtDados.Rows[0]["ie"].ToString();
                    txtInscricaoMunicipal.Text = dtDados.Rows[0]["im"].ToString();
                    txtEndereco.Text = dtDados.Rows[0]["endereco"].ToString();
                    txtComplemento.Text = dtDados.Rows[0]["complemento"].ToString();
                    txtBairro.Text = dtDados.Rows[0]["bairro"].ToString();
                    txtCidade.Text = dtDados.Rows[0]["cidade"].ToString();
                    txtCEP.Text = dtDados.Rows[0]["cep"].ToString();
                    cboUF.Text = dtDados.Rows[0]["uf"].ToString();
                    DateTime constituicao = Convert.ToDateTime(dtDados.Rows[0]["constituicao"]);
                    if (constituicao.ToString() != "01/01/0001 00:00:00")
                        txtConstituicao.Text = constituicao.ToString("dd/MM/yyyy");
                    txtTelefone.Text = dtDados.Rows[0]["telefone"].ToString();
                    txtTelefone2.Text = dtDados.Rows[0]["telefone2"].ToString();
                    txtEmail.Text = dtDados.Rows[0]["email"].ToString();
                    txtBanco.Text = dtDados.Rows[0]["db_banco"].ToString();
                    cboTipoDeConta.Text = dtDados.Rows[0]["db_tipo"].ToString();
                    txtAgencia.Text = dtDados.Rows[0]["db_agencia"].ToString();
                    txtOperador.Text = dtDados.Rows[0]["db_operador"].ToString();
                    txtConta.Text = dtDados.Rows[0]["db_conta"].ToString();
                    cboTomador.Text = dtDados.Rows[0]["ct_tomador"].ToString();
                    txtEdital.Text = dtDados.Rows[0]["ct_edital"].ToString();
                    txtContrato.Text = dtDados.Rows[0]["ct_contrato"].ToString();

                    DateTime ct_celebrado = Convert.ToDateTime(dtDados.Rows[0]["ct_celebrado"]);
                    if (ct_celebrado.ToString() != "01/01/0001 00:00:00")
                        txtCelebrado.Text = ct_celebrado.ToString("dd/MM/yyy");

                    DateTime ct_inicio = Convert.ToDateTime(dtDados.Rows[0]["ct_inicio"]);
                    if (ct_inicio.ToString() != "01/01/0001 00:00:00")
                        txtInicio.Text = ct_inicio.ToString("dd/MM/yyyy");

                    DateTime ct_termino = Convert.ToDateTime(dtDados.Rows[0]["ct_termino"]);
                    if (ct_termino.ToString() != "01/01/0001 00:00:00")
                        txtTermino.Text = ct_termino.ToString("dd/MM/yyyy");

                   


                    //Erro de conversao de String para byte[]
                    if (dtDados.Rows[0]["logo"].ToString() != "")
                    {
                        string str = dtDados.Rows[0]["logo"].ToString();
                        
                       

                        byte[] logobt = Encoding.ASCII.GetBytes(str);

                        _logoAtual = ByteParaImagem(logobt);
                        picLogotipo.Image = ByteParaImagem(logobt);
                    }   

                    txtCNPJ.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static byte[] ImagemParaByte(Image logo)
        {
            using (var stream = new MemoryStream())
            {
                logo.Save(stream, ImageFormat.Png);
                return stream.ToArray();
            }
        }

        public static Image ByteParaImagem(byte[] bytes)
        {
            using (var stream = new MemoryStream(bytes))
            {
                return Image.FromStream(stream);
            }
        }





        //:EVENTS
        //_______Form
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



        //_______Button
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



            //POPULATE
            CadastraisENT dado = new CadastraisENT();

            dado.Cnpj = txtCNPJ.Text;
            dado.Cnpj = txtCNPJ.Text;
            dado.Fantasia = txtNomeFantasia.Text;
            dado.Razao = txtRazaoSocial.Text;
            dado.Ie = txtInscricaoEstadual.Text;
            dado.Im = txtInscricaoMunicipal.Text;
            dado.Endereco = txtEndereco.Text;
            dado.Complemento = txtComplemento.Text;
            dado.Bairro = txtBairro.Text;
            dado.Cidade = txtCidade.Text;
            dado.Cep = txtCEP.Text;
            dado.Uf = cboUF.Text;
            if (txtConstituicao.Text != "")
                dado.Constituicao = Convert.ToDateTime(txtConstituicao.Text);
            dado.Telefone = txtTelefone.Text;
            dado.Telefone2 = txtTelefone2.Text;
            dado.Email = txtEmail.Text;
            dado.Db_banco = txtBanco.Text;
            dado.Db_tipo = cboTipoDeConta.Text;
            dado.Db_agencia = txtAgencia.Text;
            dado.Db_operador = txtOperador.Text;
            dado.Db_conta = txtConta.Text;
            dado.Ct_tomador = cboTomador.Text;
            dado.Ct_edital = txtEdital.Text;
            dado.Ct_contrato = txtContrato.Text;
            if (txtCelebrado.Text != "")
                dado.Ct_celebrado = Convert.ToDateTime(txtCelebrado.Text);
            if (txtInicio.Text != "")
                dado.Ct_inicio = Convert.ToDateTime(txtInicio.Text);
            if (txtTermino.Text != "")
                dado.Ct_termino = Convert.ToDateTime(txtTermino.Text);


            if (picLogotipo.Image != _logoAtual && picLogotipo.ImageLocation != "")
            {
                dado.Logo = ImagemParaByte(picLogotipo.Image);
            }

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



        //_______MaskedTexttBox
        private void txtCNPJ_Enter(object sender, EventArgs e)
        {
            txtCNPJ.Mask = "00,000,000/0000-00";
        }

        private void txtCNPJ_Validated(object sender, EventArgs e)
        {
            if (txtCNPJ.Text == "  .   .   /    -")
                txtCNPJ.Mask = "";
        }



        private void txtTelefone_Enter(object sender, EventArgs e)
        {
            txtTelefone.Mask = "(99) ##########";
        }

        private void txtTelefone_Validated(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "(  ) ")
            {
                txtTelefone.Mask = "";
                return;
            }

            var apenasDigitos = new Regex(@"[^\d]");
            if (apenasDigitos.Replace(txtTelefone.Text, "").Length == 10)
                txtTelefone.Mask = "(99) #########";
            else if (apenasDigitos.Replace(txtTelefone.Text, "").Length == 11)
                txtTelefone.Mask = "(99) ##########";
        }



        private void txtTelefone2_Enter(object sender, EventArgs e)
        {
            txtTelefone2.Mask = "(99) ##########";
        }

        private void txtTelefone2_Validated(object sender, EventArgs e)
        {
            if (txtTelefone2.Text == "(  ) ")
            {
                txtTelefone2.Mask = "";
                return;
            }

            var apenasDigitos = new Regex(@"[^\d]");
            if (apenasDigitos.Replace(txtTelefone2.Text, "").Length == 10)
                txtTelefone2.Mask = "(99) #########";
            else if (apenasDigitos.Replace(txtTelefone2.Text, "").Length == 11)
                txtTelefone2.Mask = "(99) ##########";
        }



        private void txtCEP_Enter(object sender, EventArgs e)
        {
            txtCEP.Mask = "#####-###";
        }

        private void txtCEP_Validated(object sender, EventArgs e)
        {
            if (txtCEP.Text == "     -")
                txtCEP.Mask = "";
        }



        private void txtConstituicao_Enter(object sender, EventArgs e)
        {
            txtConstituicao.Mask = "00/00/0000";
        }

        private void txtConstituicao_Validated(object sender, EventArgs e)
        {
            if (txtConstituicao.Text == "  /  /")
                txtConstituicao.Mask = "";
        }



        private void txtCelebrado_Enter(object sender, EventArgs e)
        {
            txtCelebrado.Mask = "00/00/0000";
        }

        private void txtCelebrado_Validated(object sender, EventArgs e)
        {
            if (txtCelebrado.Text == "  /  /")
                txtCelebrado.Mask = "";
        }



        private void txtInicio_Enter(object sender, EventArgs e)
        {
            txtInicio.Mask = "00/00/0000";
        }

        private void txtInicio_Validated(object sender, EventArgs e)
        {
            if (txtInicio.Text == "  /  /")
                txtInicio.Mask = "";
        }



        private void txtTermino_Enter(object sender, EventArgs e)
        {
            txtTermino.Mask = "00/00/0000";
        }

        private void txtTermino_Validated(object sender, EventArgs e)
        {
            if (txtTermino.Text == "  /  /")
                txtTermino.Mask = "";
        }



    }



}
