using System;
using System.Windows.Forms;
using Fluxus.Domain.Entities;
using Fluxus.Services;

namespace Fluxus.Presentation.View
{
    public partial class frmAtividades : Form
    {
        frmPrincipal _frmPrincipal;
        



        //:METHODS
        private void Listar()
        {
            try
            {
                dgvAtividades.DataSource = new AtividadeService().ListarAtividades(false);

                if (dgvAtividades.Rows.Count == 0)
                {
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                    dgvAtividades.Enabled = false;
                }
                else
                {
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                    dgvAtividades.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void Delete()
        {
            try
            {
                new AtividadeService().Delete((Convert.ToInt64(dgvAtividades.CurrentRow.Cells["id"].Value)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        //:EVENTS
        //_______Form
        public frmAtividades(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }

        private void frmAtividades_Load(object sender, EventArgs e)
        {
            Listar();
            if (Logged.Rl == false)
            {
                btnAdicionar.Enabled = false;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }



        //_______Button
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                Delete();
                Listar();
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Logged.Rl == false)
                return;

            Atividade atividade = new AtividadeService().GetBy(Convert.ToInt32(dgvAtividades.CurrentRow.Cells["id"].Value));

            frmAddAtividade formNeto = new frmAddAtividade(_frmPrincipal, atividade);
            
            
            formNeto.Text = "Alterar";
            _frmPrincipal.AbrirFormInPanel(formNeto, _frmPrincipal.pnlMain);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddAtividade formNeto = new frmAddAtividade(_frmPrincipal);
            formNeto.Text = "Adicionar";
            _frmPrincipal.AbrirFormInPanel(formNeto, _frmPrincipal.pnlMain);
        }



        //_______DataGridView
        private void dgvAtividades_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvAtividades.CurrentCell.Selected)
                btnExcluir.PerformClick();
        }



    }



}
