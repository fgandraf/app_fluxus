using System;
using System.Windows.Forms;
using Fluxus.Application.Controller;
using Fluxus.Domain.Models;

namespace Fluxus.Application.View
{
    public partial class frmAgencias : Form
    {
        frmPrincipal _frmPrincipal;



        //:METHODS
        private void Listar()
        {
            try
            { 
                dgvAgencias.DataSource = new AgenciaController().GetAll();


                if (dgvAgencias.Rows.Count == 0)
                {
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                    dgvAgencias.Enabled = false;
                }
                else
                {
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                    dgvAgencias.Enabled = true;
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
                new AgenciaController().Delete((Convert.ToInt64(dgvAgencias.CurrentRow.Cells["id"].Value)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        //:EVENTS
        //_______Form
        public frmAgencias(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }

        private void frmAgencias_Load(object sender, EventArgs e)
        {
            Listar();
            txtPesquisar.Focus();
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

            Agencia agencia = new AgenciaController().GetBy(Convert.ToInt32(dgvAgencias.CurrentRow.Cells["id"].Value));

            frmAddAgencia formNeto = new frmAddAgencia (_frmPrincipal, agencia);
            
            formNeto.Text = "Alterar";
            _frmPrincipal.AbrirFormInPanel(formNeto, _frmPrincipal.pnlMain);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddAgencia formNeto = new frmAddAgencia(_frmPrincipal);
            formNeto.Text = "Adicionar";
            _frmPrincipal.AbrirFormInPanel(formNeto, _frmPrincipal.pnlMain);
        }



        //_______DataGridView
        private void dgvAgencias_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvAgencias.CurrentCell.Selected)
                btnExcluir.PerformClick();
        }


        
    }



}
