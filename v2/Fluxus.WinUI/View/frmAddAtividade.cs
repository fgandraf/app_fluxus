using System;
using System.Windows.Forms;
using Fluxus.Services;
using Fluxus.Domain.Entities;

namespace Fluxus.WinUI.View
{
    public partial class frmAddAtividade : UserControl
    {


        frmMain _frmPrincipal;
        int _id;






        public frmAddAtividade(frmMain frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }


        public frmAddAtividade(frmMain frm1, Service dado)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
            _id = dado.Id;
            txtCodigo.Text = dado.Tag;
            txtDescricao.Text = dado.Description;
            txtValor.Text = dado.ServiceAmount;
            txtDeslocamento.Text = dado.MileageAllowance;
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


            Service activity = PopulateObject();


            if (btnAddSave.Text == "&Adicionar")
                new ServiceService().Insert(activity);
            else
                new ServiceService().Update(activity);


            Back();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Back();
        }







        private Service PopulateObject()
        {
            Service dado = new Service
            {
                Id = _id,
                Tag = txtCodigo.Text,
                Description = txtDescricao.Text,
                ServiceAmount = txtValor.Text.Replace(',', '.'),
                MileageAllowance = txtDeslocamento.Text.Replace(',', '.')
            };
            return dado;
        }


        private void Back()
        {
            //this.Close();
            frmService formFilho = new frmService(_frmPrincipal);
            _frmPrincipal.AbrirUserControlInPanel(formFilho);
        }

    }


}
