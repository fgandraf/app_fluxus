using Fluxus.Core.Models;
using System.Data;
using Fluxus.Core.Enums;
using Microsoft.Extensions.DependencyInjection;
using Fluxus.UseCases;
using Fluxus.Core.Dtos.Orders;
using System.ComponentModel;

namespace Fluxus.WinUI.View
{
    public partial class uctOrderFlow : UserControl
    {
        private frmMain _frmPrincipal;
        private Control _lastEnteredControl;
        private DataGridView _dgvOrigem;
        private List<OrderFlowResponse> _dtOSNFaturada;
        private IServiceProvider _serviceProvider;
        private OrderUseCases _serviceOrderService;


        public uctOrderFlow(frmMain frm1, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            InitializeComponent();
            _serviceOrderService = serviceProvider.GetService<OrderUseCases>();

            _frmPrincipal = frm1;

            foreach (Control ctrl in Controls)
            {
                if (ctrl is DataGridView)
                    ctrl.Enter += delegate (object sender, EventArgs e)
                    {
                        _lastEnteredControl = (Control)sender;
                    };
            }

            DataGridView[] views = { dgvRecebidas, dgvPendentes, dgvVistoriadas, dgvConcluidas };
            foreach (var view in views)
            {
                view.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                view.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                view.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }

            var serviceOrderService = _serviceProvider.GetService<OrderUseCases>();

            var orders = serviceOrderService.GetOrdensDoFluxo();
            if (orders.Success)
            {
                _dtOSNFaturada = orders.Value;
            }



            var professionalService = _serviceProvider.GetService<ProfessionalUseCases>();
            var professionals = professionalService.GetTagNameid(true);
            if (professionals == null)
            {
                MessageBox.Show(professionals.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cboProfissional.DataSource = professionals.Value;

            _serviceProvider = serviceProvider;
        }

        private void uctOrderFlow_Load(object sender, EventArgs e)
        {
            if (Logged.Rl)
            {
                cboProfissional.Enabled = true;
                pnlLinhaFaturar.Show();
                pnlFaturar.Show();

                if (Logged.Rt)
                    cboProfissional.SelectedValue = Logged.ProfessionalId;
                else
                    cboProfissional.SelectedIndex = 0;
            }

            GetAllOrders();
        }


        private void cboProfissional_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAllOrders();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            uctAddServiceOrder formNeto = new uctAddServiceOrder(_frmPrincipal, this.Name, _serviceProvider);
            _frmPrincipal.OpenUserControl(formNeto);
        }

        private void btnFaturar_Click(object sender, EventArgs e)
        {
            uctAddInvoice formNeto = new uctAddInvoice(_frmPrincipal, _serviceProvider);
            _frmPrincipal.OpenUserControl(formNeto);
        }

        private void DataGridView_DragOver(object sender, DragEventArgs e)
            => e.Effect = DragDropEffects.Move;


        private void DataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            dataGrid.Cursor = Cursors.NoMoveHoriz;
        }

        private void DataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            dataGrid.Cursor = Cursors.Default;
        }

        private void DataGridView_DragDrop(object sender, DragEventArgs e)
        {
            var dgvDestino = (DataGridView)sender;
            int sourcerow = Convert.ToInt32(e.Data.GetData(Type.GetType("System.Int32")));

            if (sourcerow >= 0)
            {
                var status = (EStatus)Convert.ToInt32(dgvDestino.Tag);

                int id = Convert.ToInt32(_dgvOrigem.Rows[sourcerow].Cells[0].Value);

                var linha = _dtOSNFaturada.Where(item => item.Id == id).FirstOrDefault();
                _dtOSNFaturada.Remove(linha);
                linha.Status = (int)status;
                _dtOSNFaturada.Add(linha);

                GetOrdersTo(_dgvOrigem);
                GetOrdersTo(dgvDestino);

                if (dgvConcluidas.Rows.Count == 0)
                    btnFaturar.Enabled = false;
                else
                    btnFaturar.Enabled = true;

                _serviceOrderService.UpdateStatus(id, (int)status);
            }

            ContarRegistros(_dgvOrigem);
            ContarRegistros((DataGridView)sender);
        }

        private void DataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                int SourceRow;
                _dgvOrigem = (DataGridView)sender;
                SourceRow = _dgvOrigem.HitTest(e.X, e.Y).RowIndex;
                _dgvOrigem.DoDragDrop(SourceRow, DragDropEffects.Move);
            }
        }

        private void DataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            _lastEnteredControl = (Control)sender;
            var row = dataGrid.Rows[e.RowIndex];
            dataGrid.CurrentCell = row.Cells[e.ColumnIndex == -1 ? 1 : e.ColumnIndex];
            row.Selected = true;
            dataGrid.Focus();
        }

        private void mnuEditar_Click(object sender, EventArgs e)
        {
            var dgv = (DataGridView)_lastEnteredControl;
            if (dgv != null)
            {
                int serviceOrderId = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                var ordemDeServico = _serviceOrderService.GetById(serviceOrderId);

                if (ordemDeServico.Success)
                {
                    uctAddServiceOrder formNeto = new uctAddServiceOrder(_frmPrincipal, this.Name, ordemDeServico.Value, _serviceProvider);
                    _frmPrincipal.OpenUserControl(formNeto);
                }

            }
        }

        private void mnuExcluir_Click(object sender, EventArgs e)
        {
            var dgv = (DataGridView)_lastEnteredControl;
            if (dgv != null)
            {
                var dialog = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dialog == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                    var deleted = _serviceOrderService.Delete(id);
                    var serviceOrders = _serviceOrderService.GetOrdensDoFluxo();

                    if (deleted.Success && serviceOrders.Success)
                    {
                        _dtOSNFaturada = serviceOrders.Value;
                        GetOrdersTo(dgv);
                    }
                    else
                        MessageBox.Show(deleted.Message + "\n" + serviceOrders.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void GetAllOrders()
        {
            DataGridView[] views = { dgvRecebidas, dgvPendentes, dgvVistoriadas, dgvConcluidas };
            foreach (var view in views)
                GetOrdersTo(view);
        }

        private void GetOrdersTo(DataGridView dgv)
        {
            var professionalId = Convert.ToInt64(cboProfissional.SelectedValue);
            var statusInt = Convert.ToInt32(dgv.Tag.ToString());

            List<OrderFlowResponse> dvOS;

            if (cboProfissional.SelectedIndex == 0)
                dvOS = new BindingList<OrderFlowResponse>(_dtOSNFaturada).Where(item => (int)item.Status == statusInt).ToList();
            else
                dvOS = new BindingList<OrderFlowResponse>(_dtOSNFaturada).Where(item => (int)item.Status == statusInt && item.ProfessionalId == professionalId).ToList();

            if (dvOS.Count > 0)
                dgv.ContextMenuStrip = menuContext;

            dgv.DataSource = dvOS;

            ContarRegistros(dgv);
        }

        private void ContarRegistros(DataGridView dgv)
        {
            var counter = dgv.Rows.Count.ToString();

            switch (dgv.Tag.ToString())
            {
                case "1": lblTitRecebidas.Text = $"RECEBIDAS [{counter}]"; break;
                case "2": lblTitPendentes.Text = $"PENDENTES [{counter}]"; break;
                case "3": lblTitVistoriadas.Text = $"VISTORIADAS [{counter}]"; break;
                case "4": lblTitConcluidas.Text = $"CONCLUÍDAS [{counter}]"; break;
                default: break;
            }
        }


    }

}
