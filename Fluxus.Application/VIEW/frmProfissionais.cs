using System;
using System.Windows.Forms;
using Fluxus.Domain.Models;
using Fluxus.Application.Controller;

namespace Fluxus.Application.View
{
    public partial class frmProfissionais : Form
    {
        frmPrincipal _frmPrincipal;



        //:METHODS
        private void Listar()
        {
            try
            {
                dgvProfissionais.DataSource = new ProfissionalController().ListarProfissionais();

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

        private void Delete()
        {
            try
            {
                new ProfissionalController().Delete((Convert.ToInt64(dgvProfissionais.CurrentRow.Cells[0].Value)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        //:EVENTS
        //_______Form
        public frmProfissionais(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }
        private void frmProfissionais_Load(object sender, EventArgs e)
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

            Profissional profissional = new ProfissionalController().GetBy(Convert.ToInt32(dgvProfissionais.CurrentRow.Cells["id"].Value));

            frmAddProfissional formNeto = new frmAddProfissional(_frmPrincipal, profissional);
            
            
            formNeto.Text = "Alterar";
            _frmPrincipal.AbrirFormInPanel(formNeto, _frmPrincipal.pnlMain);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddProfissional formNeto = new frmAddProfissional(_frmPrincipal);
            formNeto.Text = "Adicionar";
            _frmPrincipal.AbrirFormInPanel(formNeto, _frmPrincipal.pnlMain);
        }





        //_______DataGridView
        private void dgvProfissionais_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvProfissionais.CurrentCell.Selected)
                btnExcluir.PerformClick();
        }



    }



}
