using System;
using System.Windows.Forms;
using Fluxus.Model;
using Fluxus.Model.ENT;

namespace Fluxus.View
{
    public partial class frmAddAtividade : Form
    {

        frmPrincipal _frmPrincipal;
        long _id;



        //:EVENTS
        ///_______Form
        public frmAddAtividade(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }

        public frmAddAtividade(frmPrincipal frm1, AtividadeENT dado)
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





        ///_______Button
        private void btnAddSave_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Campos com * são obrigatório", "Chave Primária", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //POPULATE
            AtividadeENT dado = new AtividadeENT
            {
                Codigo = txtCodigo.Text,
                Descricao = txtDescricao.Text,
                Valor_atividade = txtValor.Text.Replace(',', '.'),
                Valor_deslocamento = txtDeslocamento.Text.Replace(',', '.')
            };

            if (btnAddSave.Text == "&Adicionar")
            {
                try
                {
                    new AtividadeModel().Insert(dado);
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Duplicata du champ"))
                    {
                        MessageBox.Show($"Atividade com o código '{txtCodigo.Text}' já cadastrada!", "Código existente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                try
                {
                    new AtividadeModel().Update(_id, dado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();
            frmAtividades formFilho = new frmAtividades(_frmPrincipal);
            _frmPrincipal.AbrirFormInPanel(formFilho, _frmPrincipal.pnlMain);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAtividades formFilho = new frmAtividades(_frmPrincipal);
            _frmPrincipal.AbrirFormInPanel(formFilho, _frmPrincipal.pnlMain);
        }

    }



}
