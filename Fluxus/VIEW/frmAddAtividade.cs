using System;
using System.Windows.Forms;
using Fluxus.MODEL;
using Fluxus.ENTIDADES;

namespace Fluxus.VIEW
{
    public partial class frmAddAtividade : Form
    {
        frmPrincipal _frmPrincipal;
        AtividadesMODEL model = new AtividadesMODEL();
        AtividadesENT dado = new AtividadesENT();



        //:METHODS





        //:EVENTS
        ///_______Form
        public frmAddAtividade(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }

        public frmAddAtividade(frmPrincipal frm1, string codigo, string descricao, string valor, string deslocamento)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
            txtCodigo.Text = codigo;
            txtDescricao.Text = descricao;
            txtValor.Text = valor;
            txtDeslocamento.Text = deslocamento;
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
            dado.Codigo = txtCodigo.Text;
            dado.Descricao = txtDescricao.Text;
            dado.Valor_atividade = txtValor.Text.Replace(',', '.');
            dado.Valor_deslocamento = txtDeslocamento.Text.Replace(',', '.');

            if (btnAddSave.Text == "&Adicionar")
            {
                try
                {
                    model.InsertAtividadeMODEL(dado);
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
                    model.UpdateAtividadeMODEL(dado);
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
