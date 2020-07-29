using System;
using System.Windows.Forms;
using Arqueng.ENTIDADES;
using Arqueng.MODEL;

namespace Arqueng.VIEW
{


    public partial class frmProfissionais : Form
    {

        frmPrincipal _frmPrincipal;
        ProfissionaisMODEL model = new ProfissionaisMODEL();


        public void ListarProfissionais()
        {
            try
            {
                dgvProfissionais.DataSource = model.ListarProfissionaisModel();
                if (dgvProfissionais.Rows.Count == 0)
                {
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                    dgvProfissionais.Enabled = false;
                }
                else
                {
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                    dgvProfissionais.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExcluirProfissional()
        {
            try
            {
                ENTIDADES.ProfissionaisENT dado = new ENTIDADES.ProfissionaisENT();
                dado.Codigo = dgvProfissionais.CurrentRow.Cells[0].Value.ToString();
                model.DeleteProfissionalModel(dado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public frmProfissionais(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }


        private void frmProfissionais_Load(object sender, EventArgs e)
        {
            ListarProfissionais();
            if (UsuarioENT.Rl == false)
            {
                btnAdicionar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                ExcluirProfissional();
                ListarProfissionais();
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmAddProfissional formNeto = new frmAddProfissional
                (
                _frmPrincipal,
                dgvProfissionais.CurrentRow.Cells["codigo"].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells["nome"].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells["nomeid"].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells["cpf"].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells["nascimento"].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells["profissao"].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells["carteira"].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells["entidade"].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells["telefone1"].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells["telefone2"].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells["email"].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells["rt"].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells["rl"].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells["usr_ativo"].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells["usr_nome"].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells["usr_senha"].Value.ToString()
                );
            formNeto.Text = "Alterar";
            _frmPrincipal.AbrirFormInPanel(formNeto, _frmPrincipal.pnlMain);
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddProfissional formNeto = new frmAddProfissional(_frmPrincipal);
            formNeto.Text = "Adicionar";
            _frmPrincipal.AbrirFormInPanel(formNeto, _frmPrincipal.pnlMain);
        }

        private void dgvProfissionais_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvProfissionais.CurrentCell.Selected)
            {
                btnExcluir.PerformClick();
                //var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                //if (result == DialogResult.Yes)
                //{
                //    ExcluirProfissional();
                //    ListarProfissionais();
                //}
            }
        }

    }


}
