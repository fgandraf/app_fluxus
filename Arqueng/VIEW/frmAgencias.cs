using System;
using System.Windows.Forms;
using Arqueng.MODEL;
using Arqueng.ENTIDADES;
using System.Data;

namespace Arqueng.VIEW
{


    public partial class frmAgencias : Form
    {

        frmPrincipal _frmPrincipal;
        AgenciasMODEL model = new AgenciasMODEL();



        //:METHODS
        private void PopulateGrid()
        {
            try
            {
                DataView dvAgencias = new DataView(DT.Agencias);//------
                dgvAgencias.DataSource = dvAgencias;//-----------
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
                AgenciasENT dado = new AgenciasENT();
                dado.Agencia = dgvAgencias.CurrentRow.Cells[0].Value.ToString();
                model.DeleteAgenciaModel(dado);
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
            PopulateGrid();
            txtPesquisar.Focus();
        }



        //_______Button
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                Delete();
                DT.Agencias = model.ListarAgenciasModel();//-------
                PopulateGrid();//---------
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmAddAgencia formNeto = new frmAddAgencia
                (
                _frmPrincipal,
                Convert.ToString(dgvAgencias.CurrentRow.Cells["agencia"].Value),
                Convert.ToString(dgvAgencias.CurrentRow.Cells["nome"].Value),
                Convert.ToString(dgvAgencias.CurrentRow.Cells["endereco"].Value),
                Convert.ToString(dgvAgencias.CurrentRow.Cells["complemento"].Value),
                Convert.ToString(dgvAgencias.CurrentRow.Cells["bairro"].Value),
                Convert.ToString(dgvAgencias.CurrentRow.Cells["cidade"].Value),
                Convert.ToString(dgvAgencias.CurrentRow.Cells["cep"].Value),
                Convert.ToString(dgvAgencias.CurrentRow.Cells["uf"].Value),
                Convert.ToString(dgvAgencias.CurrentRow.Cells["contato"].Value),
                Convert.ToString(dgvAgencias.CurrentRow.Cells["telefone1"].Value),
                Convert.ToString(dgvAgencias.CurrentRow.Cells["telefone2"].Value),
                Convert.ToString(dgvAgencias.CurrentRow.Cells["email"].Value)
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



        //_______DataGridView
        private void dgvAgencias_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvAgencias.CurrentCell.Selected)
                btnExcluir.PerformClick();
        }


        
    }


}
