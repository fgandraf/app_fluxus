using System;
using System.Windows.Forms;
using Arqueng.MODEL;
using Arqueng.ENTIDADES;

namespace Arqueng.VIEW
{
    public partial class frmAddAtividade : Form
    {

        AtividadesMODEL model = new AtividadesMODEL();
        AtividadesENT dado = new AtividadesENT();

        public frmAddAtividade()
        {
            InitializeComponent();
        }



        public frmAddAtividade(string Codigo, string Descricao, string Valor, string Deslocamento)
        {
            InitializeComponent();
            txtCodigo.Text = Codigo;
            txtDescricao.Text = Descricao;
            txtValor.Text = Valor;
            txtDeslocamento.Text = Deslocamento;

        }


        private void frmAddAtividade_Load(object sender, EventArgs e)
        {
            if (this.Text == "Alterar")
            {
                btnAddSave.Text = "&Salvar";
                txtCodigo.Enabled = false;
            }
        }


        private void btnAddSave_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Campos com * são obrigatório", "Chave Primária", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //POPULATE
            dado.Codigo = txtCodigo.Text;
            dado.Descricao = txtDescricao.Text;
            dado.Valor_atividade = txtValor.Text.Replace(',', '.');
            dado.Valor_deslocamento = txtDeslocamento.Text.Replace(',', '.');

            if (btnAddSave.Text == "&Adicionar")
            {
                try
                {
                    model.InsertAtividadeModel(dado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    model.UpdateAtividadeModel(dado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            this.Close();
        }
    }
}
