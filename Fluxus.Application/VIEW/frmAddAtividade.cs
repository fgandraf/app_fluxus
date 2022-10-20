using System;
using System.Windows.Forms;
using Fluxus.Application.Controller;
using Fluxus.Application.Model;

namespace Fluxus.Application.View
{
    public partial class frmAddAtividade : Form
    {


        frmPrincipal _frmPrincipal;
        long _id;





        //:METHODS
        private Atividade PopulateObject()
        {
            Atividade dado = new Atividade
            {
                Codigo = txtCodigo.Text,
                Descricao = txtDescricao.Text,
                Valor_atividade = txtValor.Text.Replace(',', '.'),
                Valor_deslocamento = txtDeslocamento.Text.Replace(',', '.')
            };
            return dado;
        }


        private void Back()
        {
            this.Close();
            frmAtividades formFilho = new frmAtividades(_frmPrincipal);
            _frmPrincipal.AbrirFormInPanel(formFilho, _frmPrincipal.pnlMain);
        }





        //:EVENTS
        public frmAddAtividade(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }


        public frmAddAtividade(frmPrincipal frm1, Atividade dado)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
            _id = dado.Id;
            txtCodigo.Text = dado.Codigo;
            txtDescricao.Text = dado.Descricao;
            txtValor.Text = dado.Valor_atividade;
            txtDeslocamento.Text = dado.Valor_deslocamento;
        }


        private void frmAddAtividade_Load(object sender, EventArgs e)
        {
            if (this.Text == "Alterar")
            {
                btnAddSave.Text = "&Salvar";
                txtCodigo.Enabled = false;
                txtDescricao.Focus();
            }
            else
                txtCodigo.Focus();
        }


        private void btnAddSave_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Campos com * são obrigatório", "Chave Primária", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            Atividade dado = PopulateObject();


            if (btnAddSave.Text == "&Adicionar")
            {
                try
                {
                    new AtividadeController().Insert(dado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                try
                {
                    new AtividadeController().Update(_id, dado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Back();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Back();
        }


    }


}
