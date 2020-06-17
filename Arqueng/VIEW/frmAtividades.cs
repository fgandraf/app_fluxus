using System;
using System.Windows.Forms;
using Arqueng.MODEL;

namespace Arqueng.VIEW
{
    public partial class frmAtividades : Form
    {
        AtividadesMODEL model = new AtividadesMODEL();

        //public delegate void NextFormEventHandler(object source, string name);
        //public event NextFormEventHandler NextForm;
        


        //public virtual void OnNextForm(string name)
        //{
        //    if (NextForm != null)
        //        NextForm(this, name);
        //}

        public void ListarAtividades()
        {
            try
            {
                dgvAtividades.DataSource = model.ListarAtividadesModel();
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

        public frmAtividades()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                try
                {
                    ENTIDADES.AtividadesENT dado = new ENTIDADES.AtividadesENT();
                    dado.Codigo = dgvAtividades.CurrentRow.Cells[0].Value.ToString();
                    model.DeleteAtividadeModel(dado);
                    ListarAtividades();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void frmAtividades_Load(object sender, EventArgs e)
        {
            ListarAtividades();
            txtPesquisar.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmAddAtividade form = new frmAddAtividade(dgvAtividades.CurrentRow.Cells[0].Value.ToString(), dgvAtividades.CurrentRow.Cells[1].Value.ToString(), dgvAtividades.CurrentRow.Cells[2].Value.ToString(), dgvAtividades.CurrentRow.Cells[3].Value.ToString());
            form.Text = "Alterar";
            form.ShowDialog();
            ListarAtividades();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            //OnNextForm("frmAddAtividade");

            frmAddAtividade form = new frmAddAtividade();
            form.Text = "Adicionar";
            form.ShowDialog();
            ListarAtividades();

        }
    }
}
