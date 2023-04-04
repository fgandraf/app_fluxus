using Fluxus.Domain.Entities;
using System.Data;
using Fluxus.App;
using Fluxus.Domain.Struct;

namespace Fluxus.WinUI.View
{
    public partial class uctOrderList : UserControl
    {
        private readonly frmMain _frmPrincipal;
        private List<ServiceOrderFiltered> _dtOS;
        private string _currentFilter;


        public uctOrderList(frmMain frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;

            cboProfissional.DataSource = new ProfessionalApp().GetCodeNameid(true);
            cboCidade.DataSource = new App.ServiceOrderApp().GetCitiesFromOrders(true);
            cboAtividade.DataSource = new ServiceApp().GetAll(true);

            CleanFilter();

            if (Logged.Rt)
                cboProfissional.SelectedValue = Logged.ProfessionalTag;
            else
                cboProfissional.SelectedIndex = 0;

            if (!Logged.Rl)
                cboProfissional.Enabled = false;

            cboFaturadas.SelectedIndex = 0;
            RefreshFilter();

            _dtOS = new App.ServiceOrderApp().GetOrdensComFiltro(_currentFilter);
            dgvOS.DataSource = _dtOS;

            lblTotalRegistros.Text = dgvOS.Rows.Count.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddOS formNeto = new frmAddOS(_frmPrincipal, this.Name);
            formNeto.Text = "Adicionar";
            _frmPrincipal.OpenUserControl(formNeto);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvOS.RowCount > 0)
            {
                var id = Convert.ToInt32(dgvOS.CurrentRow.Cells[0].Value);
                var serviceOrder = new App.ServiceOrderApp().GetBy(id);
                frmAddOS formNeto = new frmAddOS(_frmPrincipal, this.Name, serviceOrder);
                formNeto.Tag = "Alterar";
                _frmPrincipal.OpenUserControl(formNeto);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvOS.RowCount > 0)
            {
                var dialog = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dialog == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(dgvOS.CurrentRow.Cells["id"].Value);
                    var app = new ServiceOrderApp();
                    var success = app.Delete(id);

                    if (success)
                    {
                        _dtOS = app.GetOrdensComFiltro(_currentFilter);
                        dgvOS.DataSource = _dtOS;
                        lblTotalRegistros.Text = dgvOS.Rows.Count.ToString();
                    }
                    else
                        MessageBox.Show(app.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSearch.Text == "")
                dgvOS.DataSource = _dtOS;
            else
            {
                var a = txtSearch.Text.ToUpper();
                var dtFiltrada = _dtOS.Where(item => item.CustomerName.Contains(a) ||
                                                     item.ReferenceCode.Contains(a) ||
                                                     item.Service.Contains(a) ||
                                                     item.City.Contains(a) ||
                                                     item.Professional.Contains(a)
                                                     ).ToList();
                dgvOS.DataSource = dtFiltrada;
            }
            lblTotalRegistros.Text = dgvOS.Rows.Count.ToString();
        }

        private void GetFilteredChanges(object sender, EventArgs e)
        {
            RefreshFilter();
            _dtOS = new App.ServiceOrderApp().GetOrdensComFiltro(_currentFilter);
            dgvOS.DataSource = _dtOS;
            lblTotalRegistros.Text = dgvOS.Rows.Count.ToString();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvOS.Rows.Count > 0)
            {
                var serviceOrders = (List<ServiceOrderFiltered>)dgvOS.DataSource;
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


