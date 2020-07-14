using System;
using System.Windows.Forms;
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
            txtPesquisar.Focus();
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
                dgvProfissionais.CurrentRow.Cells[0].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells[1].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells[2].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells[3].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells[4].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells[5].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells[6].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells[7].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells[8].Value.ToString(),
                dgvProfissionais.CurrentRow.Cells[9].Value.ToString()
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
                var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    ExcluirProfissional();
                    ListarProfissionais();
                }
            }
        }
    }


}
