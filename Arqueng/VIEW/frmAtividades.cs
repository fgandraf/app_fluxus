using System;
using System.Data;
using System.Windows.Forms;
using Arqueng.ENTIDADES;
using Arqueng.MODEL;

namespace Arqueng.VIEW
{


    public partial class frmAtividades : Form
    {

        frmPrincipal _frmPrincipal;
        AtividadesMODEL model = new AtividadesMODEL();



        //:METHODS
        private void PopulateGrid()//---------------
        {
            try
            {
                DataView dvAtividades = new DataView(DT.Atividades);//------
                dgvAtividades.DataSource = dvAtividades;//-----------
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
                ENTIDADES.AtividadesENT dado = new ENTIDADES.AtividadesENT();
                dado.Codigo = dgvAtividades.CurrentRow.Cells[0].Value.ToString();
                model.DeleteAtividadeModel(dado);
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
            PopulateGrid();//---------
            if (Globais.Rl == false)
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
                DT.Atividades = model.ListarAtividadesModel();//-------
                PopulateGrid();//---------
            }

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Globais.Rl == false)
                return;

            frmAddAtividade formNeto = new frmAddAtividade
                (
                _frmPrincipal,
                Convert.ToString(dgvAtividades.CurrentRow.Cells["codigo"].Value),
                Convert.ToString(dgvAtividades.CurrentRow.Cells["descricao"].Value),
                Convert.ToString(dgvAtividades.CurrentRow.Cells["valor_atividade"].Value),
                Convert.ToString(dgvAtividades.CurrentRow.Cells["valor_deslocamento"].Value)
                );
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
