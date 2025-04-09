using Fluxus.Core.Models;
using System.Data;
using Microsoft.Extensions.DependencyInjection;
using Fluxus.Infra.Services;
using Fluxus.UseCases;
using Fluxus.Core.Dtos.Orders;

namespace Fluxus.WinUI.View
{
    public partial class uctOrderList : UserControl
    {
        private readonly frmMain _frmPrincipal;
        private List<OrderFilteredResponse> _dtOS;
        private OrderFilterRequest _currentFilter;
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
                                                     //item.ServiceId.Contains(a) ||
                                                     item.City.Contains(a) //||
                                                     //item.ProfessionalId.Contains(a)
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
                var serviceOrders = (List<OrderFilteredResponse>)dgvOS.DataSource;
                new ExcelInterop().ExportToExcel(serviceOrders);
            }
        }





        private void RefreshFilter()
        {
            _currentFilter = new OrderFilterRequest();


            string professional = null;
            if (cboProfissional.Items.Count > 1)
                professional = cboProfissional.SelectedIndex == 0 ? null : cboProfissional.SelectedValue.ToString();
            _currentFilter.professionalTag = professional;

            int? status = null;
            if (cboStatus.Items.Count > 0)
                status = cboStatus.SelectedIndex == 0 ? null : cboStatus.SelectedIndex;
            _currentFilter.status = status;

            string city = null;
            if (cboCidade.Items.Count > 0)
                city = cboCidade.SelectedIndex == 0 ? null : $"{cboCidade.Text}";
            _currentFilter.city = city;

            string service = null;
            if (cboAtividade.Items.Count > 0)
                service = cboAtividade.SelectedIndex == 0 ? null : $"{cboAtividade.Text}";
            _currentFilter.serviceTag = service;

            int? invoiced = null;
            if (cboFaturadas.Items.Count > 0)
                invoiced = cboFaturadas.SelectedIndex == 0 ? null : cboFaturadas.SelectedIndex;
            _currentFilter.invoiced = Convert.ToBoolean(invoiced);
        }

        private void CleanFilter()
        {
            if (cboProfissional.Items.Count > 0)
                cboProfissional.SelectedIndex = 0;

            if (cboCidade.Items.Count > 0)
                cboCidade.SelectedIndex = 0;

            if (cboAtividade.Items.Count > 0)
                cboAtividade.SelectedIndex = 0;

            if (cboFaturadas.Items.Count > 0)
                cboFaturadas.SelectedIndex = 0;

            if (cboStatus.Items.Count > 0)
                cboStatus.SelectedIndex = 0;
            txtSearch.Text = null;
        }

    }

}


