using Fluxus.Domain.Entities;
using System.Data;
using Fluxus.App;

namespace Fluxus.WinUI.View
{
    public partial class uctOrderList : UserControl
    {
        frmMain _frmPrincipal;
        DataTable _dtOS;
        private string _currentFilter;


        public uctOrderList(frmMain frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;

            cboProfissional.DataSource = new ProfessionalApp().GetCodeNameid(true);
            cboCidade.DataSource = new App.ServiceOrderApp().GetCidadesDasOrdens(true);
            cboAtividade.DataSource = new ServiceApp().GetAll(true);

            CleanFilter();

            if (Logged.Rt)
                cboProfissional.SelectedIndex = Convert.ToInt32(Logged.ProfessionalId);
            else
                cboProfissional.SelectedIndex = 0;
            cboFaturadas.SelectedIndex = 0;

            RefreshFilter();

            _dtOS = new App.ServiceOrderApp().GetOrdensComFiltro(_currentFilter);
            dgvOS.DataSource = _dtOS;

            lblTotalRegistros.Text = dgvOS.Rows.Count.ToString();
            btnLimparFiltro.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddOS formNeto = new frmAddOS(_frmPrincipal, this.Name);
            formNeto.Text = "Adicionar";
            _frmPrincipal.OpenUserControl(formNeto);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvOS.CurrentRow.Cells[0].Value);
            var serviceOrder = new App.ServiceOrderApp().GetBy(id);
            frmAddOS formNeto = new frmAddOS(_frmPrincipal, this.Name, serviceOrder);
            formNeto.Text = "Alterar";
            _frmPrincipal.OpenUserControl(formNeto);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvOS.CurrentRow.Cells["id"].Value);
            var serviceOrder = new App.ServiceOrderApp().GetBy(id);

            var dialog = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.Yes)
            {
                var result = new App.ServiceOrderApp().Delete(serviceOrder);
                MessageBox.Show(result, "Ordem de Serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _dtOS = new App.ServiceOrderApp().GetOrdensComFiltro(_currentFilter);
                dgvOS.DataSource = _dtOS;
                lblTotalRegistros.Text = dgvOS.Rows.Count.ToString();
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSearch.Text == "")
                dgvOS.DataSource = _dtOS;
            else
            {
                DataTable dtFiltrada = _dtOS.Copy();
                DataView dvPesquisa = new DataView(dtFiltrada);
                dvPesquisa.RowFilter = String.Format("customerName LIKE '%{0}%' OR referenceCode LIKE '%{0}%' OR service LIKE '%{0}%' OR city LIKE '%{0}%' OR professional LIKE '%{0}%'", txtSearch.Text);
                dgvOS.DataSource = dvPesquisa;
            }
            lblTotalRegistros.Text = dgvOS.Rows.Count.ToString();
        }

        private void GetFilteredChanges(object sender, EventArgs e)
        {
            RefreshFilter();
            _dtOS = new App.ServiceOrderApp().GetOrdensComFiltro(_currentFilter);
            dgvOS.DataSource = _dtOS;
            lblTotalRegistros.Text = dgvOS.Rows.Count.ToString();
            btnLimparFiltro.Show();
        }

        private void btnLimparFiltro_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Deseja realmente prosseguir?" + "\n\n" + "Isto irá retornar todas as ordens de serviços existentes no banco de dados." + "\n\n" + "O processo pode ser lento dependendo do tamanho da base.", "Limpar filtro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.Yes)
            {
                CleanFilter();
                RefreshFilter();
                _dtOS = new App.ServiceOrderApp().GetOrdensComFiltro(_currentFilter);
                dgvOS.DataSource = _dtOS;
                btnLimparFiltro.Hide();
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvOS.Rows.Count > 0)
            {
                var serviceOrders = (DataTable)dgvOS.DataSource;
                new App.ServiceOrderApp().ExportToSheet(serviceOrders);
            }
        }





        private void RefreshFilter()
        {
            string professional = cboProfissional.SelectedIndex == 0 ? "%" : $"{cboProfissional.SelectedValue.ToString()}";
            string status = cboStatus.SelectedIndex == 0 ? "%" : $"{cboStatus.SelectedIndex}";
            string city = cboCidade.SelectedIndex == 0 ? "%" : $"{cboCidade.Text}";
            string service = cboAtividade.SelectedIndex == 0 ? "%" : $"{cboAtividade.Text}";
            string invoiced = cboFaturadas.SelectedIndex.ToString();

            _currentFilter = $"{professional},{service},{city},{status},{invoiced}";
        }

        private void CleanFilter()
        {
            cboProfissional.SelectedIndex = 0;
            cboCidade.SelectedIndex = 0;
            cboAtividade.SelectedIndex = 0;
            cboFaturadas.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            txtSearch.Text = null;
        }

    }

}


