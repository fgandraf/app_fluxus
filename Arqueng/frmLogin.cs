using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Arqueng.ENTIDADES;
using Arqueng.MODEL;

namespace Arqueng
{
    public partial class frmLogin : Form
    {

        ProfissionaisMODEL model = new ProfissionaisMODEL();
        ProfissionaisENT dado = new ProfissionaisENT();



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);














        ///_______Populate component DataTable - tb_os
        private void Listar_tb_os()
        {
            OsMODEL model = new OsMODEL();
            try
            {
                DataTableENT.DT_OS = model.ListarOsModel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela 'tb_os'.\n\n" + ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ///_______Populate component DataTable - tb_dadoscadastrais
        private void Listar_cadastrais()
        {
            CadastraisMODEL model = new CadastraisMODEL();
            try
            {
                DataTableENT.DT_Dados = model.ListarCadastraisModel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela 'tb_dadoscadastrais'.\n\n" + ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ///_______Populate component DataTable - tb_profissionais
        private void Listar_profissionais()
        {
            ProfissionaisMODEL model = new ProfissionaisMODEL();
            try
            {
                DataTableENT.DT_Profissionais = model.ListarProfissionaisModel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela 'tb_profissionais'.\n\n" + ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ///_______Populate component DataTable - tb_atividades
        private void Listar_atividades()
        {
            AtividadesMODEL model = new AtividadesMODEL();
            try
            {
                DataTableENT.DT_Atividades = model.ListarAtividadesModel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela 'tb_atividades'.\n\n" + ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        ///_______Populate component DataTable - tb_agencias
        private void Listar_agencias()
        {
            AgenciasMODEL model = new AgenciasMODEL();
            try
            {
                DataTableENT.DT_Agencias = model.ListarAgenciasModel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela 'tb_agencias'.\n\n" + ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ///_______Populate component DataTable - tb_agencias
        private void Listar_faturas()
        {
            FaturasMODEL model = new FaturasMODEL();
            try
            {
                DataTableENT.DT_Faturas = model.ListarFaturaModel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela 'tb_faturas'.\n\n" + ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }








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
            prbProgress.Value += 1;
            dado.Usr_nome = txtUsuario.Text;
            model.BuscarUsuarioModel(dado);
            prbProgress.Value += 1;
            if (Globais.Usr_nome == null || txtSenha.Text != Globais.Usr_senha || Globais.Usr_ativo == false)
                MessageBox.Show("Nome de usuário/senha incorreto(s) ou usuário não está ativo");
            else
            {
                Listar_atividades();
                prbProgress.Value += 1;

                Listar_faturas();
                prbProgress.Value += 1;

                Listar_cadastrais();
                prbProgress.Value += 1;

                Listar_profissionais();
                prbProgress.Value += 1;

                Listar_agencias();
                prbProgress.Value += 1;

                Listar_tb_os();
                prbProgress.Value += 1;

                

                this.Close();
            }

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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblVersao.Text = "v. " + Globais.Versao;
        }
    }
}
