using System;
using System.Windows.Forms;
using Arqueng.MODEL;
using Arqueng.ENTIDADES;

namespace Arqueng.VIEW
{


    public partial class frmAgencias : Form
    {

        frmPrincipal _frmPrincipal;
        AgenciasMODEL model = new AgenciasMODEL();


        public void ListarAgencias()
        {
            try
            {
                dgvAgencias.DataSource = model.ListarAgenciasModel();
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

        public void ExcluirAgencia()
        {
            try
            {
                AgenciasENT dado = new AgenciasENT();
                dado.Agencia = dgvAgencias.CurrentRow.Cells[0].Value.ToString();
                model.DeleteAgenciaModel(dado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public frmAgencias(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                ExcluirAgencia();
                ListarAgencias();
            }
        }

        private void frmAgencias_Load(object sender, EventArgs e)
        {
            ListarAgencias();
            txtPesquisar.Focus();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmAddAgencia formNeto = new frmAddAgencia
                (
                _frmPrincipal,
                dgvAgencias.CurrentRow.Cells[0].Value.ToString(),
                dgvAgencias.CurrentRow.Cells[1].Value.ToString(),        
                dgvAgencias.CurrentRow.Cells[2].Value.ToString(),
                dgvAgencias.CurrentRow.Cells[3].Value.ToString(),
                dgvAgencias.CurrentRow.Cells[4].Value.ToString(),
                dgvAgencias.CurrentRow.Cells[5].Value.ToString(),
                dgvAgencias.CurrentRow.Cells[6].Value.ToString(),
                dgvAgencias.CurrentRow.Cells[7].Value.ToString(),
                dgvAgencias.CurrentRow.Cells[8].Value.ToString(),
                dgvAgencias.CurrentRow.Cells[9].Value.ToString(),
                dgvAgencias.CurrentRow.Cells[10].Value.ToString(),
                dgvAgencias.CurrentRow.Cells[11].Value.ToString()
                );
            formNeto.Text = "Alterar";
            _frmPrincipal.AbrirFormInPanel(formNeto, _frmPrincipal.pnlMain);
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddAgencia formNeto = new frmAddAgencia(_frmPrincipal);
            formNeto.Text = "Adicionar";
            _frmPrincipal.AbrirFormInPanel(formNeto, _frmPrincipal.pnlMain);
        }

        private void dgvAgencias_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvAgencias.CurrentCell.Selected)
            {
                var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    ExcluirAgencia();
                    ListarAgencias();
                }
            }
        }
    }


}
