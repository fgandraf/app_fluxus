using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Arqueng.ENTIDADES;
using Arqueng.MODEL;

namespace Arqueng
{
    public partial class frmLogin : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);




        //:METHODS
        public void BuscarDadosEmpresa()
        {
            try
            {
                CadastraisMODEL model = new CadastraisMODEL();
                DataRow[] dadosDaEmpresa = (model.DadosParaImpressaoModel()).Select();

                Globais.Cnpj = dadosDaEmpresa[0]["cnpj"].ToString();
                Globais.Razao = dadosDaEmpresa[0]["razao"].ToString();
                Globais.Edital = dadosDaEmpresa[0]["ct_edital"].ToString();
                Globais.Contrato = dadosDaEmpresa[0]["ct_contrato"].ToString();
                Globais.Fantasia = dadosDaEmpresa[0]["fantasia"].ToString();
                Globais.Logo = (byte[])(dadosDaEmpresa[0]["logo"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        //:EVENTS
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAppFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            lblLoad.Text = "Validando usuário";

            ProfissionaisMODEL model = new ProfissionaisMODEL();
            DataTable dtUsuario = model.BuscarUsuarioModel(txtUsuario.Text);
            DataRow[] dataRow;

            if (dtUsuario.Rows.Count == 0)
            {
                MessageBox.Show("Usuário não encontrado", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblLoad.Text = "";
                return;
            }
            else
            {
                dataRow = dtUsuario.Select();
                if (dataRow[0]["usr_senha"].ToString() != txtSenha.Text || Convert.ToBoolean(dataRow[0]["usr_ativo"]) == false)
                {
                    MessageBox.Show("Senha incorreta ou usuário não está ativo", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblLoad.Text = "";
                    return;
                }
            }
            Globais.Usr_nome = dataRow[0]["usr_nome"].ToString();
            Globais.Codpro = dataRow[0]["codigo"].ToString();
            Globais.Rt = Convert.ToBoolean(dataRow[0]["rt"]);
            Globais.Rl = Convert.ToBoolean(dataRow[0]["rl"]);

            BuscarDadosEmpresa();














            ////TABELA DE PROFISSIONAIS
            //Listar_profissionais();
            //DataView dvUsr = new DataView(DT.Profissionais);
            //dvUsr.RowFilter = String.Format("usr_nome = '{0}'", txtUsuario.Text);
            //DataRow[] dataRow;
            //prbProgress.Value += 1;

            //if (dvUsr.Count == 0)
            //{
            //    MessageBox.Show("Usuário não encontrado", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    prbProgress.Value = 0;
            //    lblLoad.Text = "";
            //    return;
            //}
            //else
            //{
            //    dataRow = ((DataTable)dvUsr.ToTable()).Select(String.Format("usr_nome = '{0}'", txtUsuario.Text));
            //    if (dataRow[0]["usr_senha"].ToString() != txtSenha.Text || Convert.ToBoolean(dataRow[0]["usr_ativo"]) == false)
            //    {
            //        MessageBox.Show("Senha incorreta ou usuário não está ativo", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        prbProgress.Value = 0;
            //        lblLoad.Text = "";
            //        return;
            //    }
            //}
            //prbProgress.Value += 1;
            //Globais.Usr_nome = dataRow[0]["usr_nome"].ToString();
            //prbProgress.Value += 1;
            //Globais.Codpro = dataRow[0]["codigo"].ToString();
            //prbProgress.Value += 1;
            //Globais.Rt = Convert.ToBoolean(dataRow[0]["rt"]);
            //prbProgress.Value += 1;
            //Globais.Rl = Convert.ToBoolean(dataRow[0]["rl"]);
            //prbProgress.Value += 1;
            ////FIM DA TABELA DE PROFISSIONAIS

           
            //prbProgress.Value += 1;


            lblLoad.Text = "";
            //prbProgress.Hide();
            this.Close();
        }

    

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnEntrar.PerformClick();
        }

        private void imgShowPwd_Click(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '\0';
            imgShowPwd.Hide();
        }

        private void imgHidePwd_Click(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
            imgShowPwd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblVersao.Text = "v. " + Globais.Versao;
        }
    }
}
