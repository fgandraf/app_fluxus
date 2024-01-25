using Fluxus.Core.Models;
using System.Data;
using Fluxus.Core.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Fluxus.Infra.Services;
using Fluxus.UseCases;

namespace Fluxus.WinUI.View
{
    public partial class uctOrderList : UserControl
    {
        private readonly frmMain _frmPrincipal;
        private List<OrdersIndexViewModel> _dtOS;
        private string _currentFilter;
        private IServiceProvider _serviceProvider;
        private OrderUseCases _serviceOrderService;


        public uctOrderList(frmMain frm1, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            InitializeComponent();
            _serviceOrderService = serviceProvider.GetService<OrderUseCases>();

            _frmPrincipal = frm1;

            var professionalService = _serviceProvider.GetService<ProfessionalUseCases>();
            var professionals = professionalService.GetTagNameid(true);
            if (professionals == null)
            {
                MessageBox.Show(professionals.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cboProfissional.DataSource = professionals.Value;

            var cities = _serviceOrderService.GetCitiesFromOrders(true);
            if (cities.Success)
                cboCidade.DataSource = cities.Value;
            

            var serviceService = _serviceProvider.GetService<ServiceUseCases>();
            cboAtividade.DataSource = serviceService.GetAll(true).Value;

            CleanFilter();

            if (Logged.Rt)
                cboProfissional.SelectedValue = Logged.ProfessionalTag;
            else
                cboProfissional.SelectedIndex = 0;

            if (!Logged.Rl)
                cboProfissional.Enabled = false;

            cboFaturadas.SelectedIndex = 0;
            RefreshFilter();

            var orders = _serviceOrderService.GetOrdensComFiltro(_currentFilter);
            if (orders.Success)
            {
                _dtOS = orders.Value;
                dgvOS.DataSource = _dtOS;

                lblTotalRegistros.Text = dgvOS.Rows.Count.ToString();
                _serviceProvider = serviceProvider;
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uctAddServiceOrder formNeto = new uctAddServiceOrder(_frmPrincipal, this.Name, _serviceProvider);
            _frmPrincipal.OpenUserControl(formNeto);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvOS.RowCount > 0)
            {
                var id = Convert.ToInt32(dgvOS.CurrentRow.Cells[0].Value);
                var serviceOrder = _serviceOrderService.GetById(id);

                if (serviceOrder.Success)
                {
                    uctAddServiceOrder formNeto = new uctAddServiceOrder(_frmPrincipal, this.Name, serviceOrder.Value, _serviceProvider);
                    _frmPrincipal.OpenUserControl(formNeto);
                }
                
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
                    var result = _serviceOrderService.Delete(id);
                    var orders = _serviceOrderService.GetOrdensComFiltro(_currentFilter);

                    if (result.Success && orders.Success)
                    {
                        _dtOS = orders.Value;
                        dgvOS.DataSource = _dtOS;
                        lblTotalRegistros.Text = dgvOS.Rows.Count.ToString();
                    }
                    else
                        MessageBox.Show(result.Message + "\n" + orders.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


            var orders = _serviceOrderService.GetOrdensComFiltro(_currentFilter);
            if (orders.Success)
            {
                _dtOS = orders.Value;
                dgvOS.DataSource = _dtOS;
                lblTotalRegistros.Text = dgvOS.Rows.Count.ToString();
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvOS.Rows.Count > 0)
            {
                var serviceOrders = (List<OrdersIndexViewModel>)dgvOS.DataSource;
                new ExcelInterop().ExportToExcel(serviceOrders);
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


