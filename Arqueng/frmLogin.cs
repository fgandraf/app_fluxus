using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
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
        private void Listar_tb_os()
        {
            OsMODEL model = new OsMODEL();
            try
            {
                DT.OS = model.ListarOsModel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela 'tb_os'.\n\n" + ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar_tbOsFatura()
        {
            OsMODEL model = new OsMODEL();
            try
            {
                DT.OSFatura = model.ListarOSFaturaModel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela 'tb_os'.\n\n" + ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar_cadastrais()
        {
            CadastraisMODEL model = new CadastraisMODEL();
            try
            {
                DT.DadosCadastrais = model.ListarCadastraisModel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela 'tb_dadoscadastrais'.\n\n" + ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar_profissionais()
        {
            ProfissionaisMODEL model = new ProfissionaisMODEL();
            try
            {
                DT.Profissionais = model.ListarProfissionaisModel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela 'tb_profissionais'.\n\n" + ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar_atividades()
        {
            AtividadesMODEL model = new AtividadesMODEL();
            try
            {
                DT.Atividades = model.ListarAtividadesModel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela 'tb_atividades'.\n\n" + ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar_agencias()
        {
            AgenciasMODEL model = new AgenciasMODEL();
            try
            {
                DT.Agencias = model.ListarAgenciasModel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela 'tb_agencias'.\n\n" + ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar_faturas()
        {
            FaturasMODEL model = new FaturasMODEL();
            try
            {
                DT.Faturas = model.ListarFaturaModel();
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
            prbProgress.Show();
            prbProgress.Value += 1;

            lblLoad.Text = "Validando usuário";
            Listar_profissionais();
            DataView dvUsr = new DataView(DT.Profissionais);
            dvUsr.RowFilter = String.Format("usr_nome = '{0}'", txtUsuario.Text);
            DataRow[] dataRow;
            prbProgress.Value += 1;

            if (dvUsr.Count == 0)
            {
                MessageBox.Show("Usuário não encontrado", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                prbProgress.Value = 0;
                lblLoad.Text = "";
                return;
            }
            else
            {
                dataRow = ((DataTable)dvUsr.ToTable()).Select(String.Format("usr_nome = '{0}'", txtUsuario.Text));
                if (dataRow[0]["usr_senha"].ToString() != txtSenha.Text || Convert.ToBoolean(dataRow[0]["usr_ativo"]) == false)
                {
                    MessageBox.Show("Senha incorreta ou usuário não está ativo", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    prbProgress.Value = 0;
                    lblLoad.Text = "";
                    return;
                }
            }
            Globais.Usr_nome = dataRow[0]["usr_nome"].ToString();
            Globais.Codpro = dataRow[0]["codigo"].ToString();
            Globais.Rt = Convert.ToBoolean(dataRow[0]["rt"]);
            Globais.Rl = Convert.ToBoolean(dataRow[0]["rl"]);

            prbProgress.Value += 1;

            lblLoad.Text = "Carregando Banco de Dados";
            Listar_atividades();
            prbProgress.Value += 1;

            Listar_faturas();
            prbProgress.Value += 1;

            Listar_cadastrais();
            prbProgress.Value += 1;

            Listar_agencias();
            prbProgress.Value += 1;

            Listar_tb_os();
            prbProgress.Value += 1;

            Listar_tbOsFatura();
            prbProgress.Value += 1;

            lblLoad.Text = "";
            prbProgress.Hide();
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
