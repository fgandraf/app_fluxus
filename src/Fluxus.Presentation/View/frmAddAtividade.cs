using System;
using System.Windows.Forms;
using Fluxus.Services;
using Fluxus.Domain.Entities;

namespace Fluxus.Presentation.View
{
    public partial class frmAddAtividade : Form
    {


        frmPrincipal _frmPrincipal;
        long _id;






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
            txtValor.Text = dado.ValorAtividade;
            txtDeslocamento.Text = dado.ValorDeslocamento;
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


            Atividade activity = PopulateObject();


            if (btnAddSave.Text == "&Adicionar")
                new AtividadeService().Insert(activity);
            else
                new AtividadeService().Update(activity);


            Back();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Back();
        }







        private Atividade PopulateObject()
        {
            Atividade dado = new Atividade
            {
                Id = _id,
                Codigo = txtCodigo.Text,
                Descricao = txtDescricao.Text,
                ValorAtividade = txtValor.Text.Replace(',', '.'),
                ValorDeslocamento = txtDeslocamento.Text.Replace(',', '.')
            };
            return dado;
        }


        private void Back()
        {
            this.Close();
            frmAtividades formFilho = new frmAtividades(_frmPrincipal);
            _frmPrincipal.AbrirFormInPanel(formFilho, _frmPrincipal.pnlMain);
        }

    }


}
