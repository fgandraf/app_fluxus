using System;
using System.Windows.Forms;
using Arqueng.Entidades;
using Arqueng.Model;

namespace Arqueng
{
    public partial class frmAddAtividade : Form
    {

        AtividadesModel model = new AtividadesModel();

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
            if (btnAddSave.Text == "&Adicionar")
            {
                if (txtCodigo.Text == "")
                    MessageBox.Show("Campos com * são obrigatório", "Chave Primária", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    
                    try
                    {
                        Atividades dado = new Atividades();
                        dado.Codigo = txtCodigo.Text;
                        dado.Descricao = txtDescricao.Text;
                        dado.Valor_atividade = txtValor.Text.Replace(',', '.');
                        dado.Valor_deslocamento = txtDeslocamento.Text.Replace(',', '.');
                        model.InsertAtividadeModel(dado);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                try
                {
                    Atividades dado = new Atividades();
                    dado.Codigo = txtCodigo.Text;
                    dado.Descricao = txtDescricao.Text;
                    dado.Valor_atividade = txtValor.Text.Replace(',', '.');
                    dado.Valor_deslocamento = txtDeslocamento.Text.Replace(',', '.');
                    model.UpdateAtividadeModel(dado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.Close();
                }
            }
        }
    }
}
