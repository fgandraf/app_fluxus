using Fluxus.Domain.Entities;
using System.Data;
using Fluxus.Services;

namespace Fluxus.WinUI.View
{
    public partial class frmOrderFlow : Form
    {
        private frmMain _frmPrincipal;
        private Control _lastEnteredControl;
        private DataGridView _dgvOrigem;
        private DataTable _dtOSNFaturada;


        public frmOrderFlow(frmMain frm1)
        {
            InitializeComponent();
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

            _dtOSNFaturada = new Services.ServiceOrderService().GetOrdensDoFluxo();

            cboProfissional.DataSource = new ProfessionalService().GetCodeNameid(true);

            if (Logged.Rl)
            {
                cboProfissional.Enabled = true;
                pnlLinhaFaturar.Show();
                pnlFaturar.Show();

                if (Logged.Rt)
                    cboProfissional.SelectedValue = Convert.ToInt32(Logged.ProfessionalId);
                else
                    cboProfissional.SelectedIndex = 0;
            }

            cboProfissional.SelectedValue = Convert.ToInt32(Logged.ProfessionalId);

            GetAllOrders();
        }

        private void cboProfissional_SelectedIndexChanged(object sender, EventArgs e)
            => GetAllOrders();

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddOS formNeto = new frmAddOS(_frmPrincipal, this.Name);
            formNeto.Text = "Adicionar";
            _frmPrincipal.AbrirFormInPanel(formNeto);
        }

        private void btnFaturar_Click(object sender, EventArgs e)
        {
            frmAddFatura formNeto = new frmAddFatura(_frmPrincipal);
            _frmPrincipal.AbrirFormInPanel(formNeto);
        }

        private void DataGridView_DragOver(object sender, DragEventArgs e)
            => e.Effect = DragDropEffects.Move;

        private void DataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            dataGrid.Cursor = Cursors.Hand;
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
                string status = dgvDestino.Tag.ToString();
                int id = Convert.ToInt32(_dgvOrigem.Rows[sourcerow].Cells[0].Value);

                DataRow linha = _dtOSNFaturada.Select("Id = " + id).FirstOrDefault();
                linha["Status"] = status;

                GetOrdersTo(_dgvOrigem);
                GetOrdersTo(dgvDestino);

                if (dgvConcluidas.Rows.Count == 0)
                    btnFaturar.Enabled = false;
                else
                    btnFaturar.Enabled = true;

                new Services.ServiceOrderService().UpdateStatus(id, status);
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
                var ordemDeServico = new ServiceOrderService().GetBy(serviceOrderId);

                frmAddOS formNeto = new frmAddOS(_frmPrincipal, this.Name, ordemDeServico);
                formNeto.Text = "Alterar";
                _frmPrincipal.AbrirFormInPanel(formNeto);
            }
        }

        private void mnuExcluir_Click(object sender, EventArgs e)
        {
            var dgv = (DataGridView)_lastEnteredControl;
            if (dgv != null)
            {
                var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    new Services.ServiceOrderService().Delete((Convert.ToInt32(dgv.CurrentRow.Cells[0].Value)));

                    _dtOSNFaturada = new Services.ServiceOrderService().GetOrdensDoFluxo();
                    GetOrdersTo(dgv);
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
            DataView dvOS = new DataView(_dtOSNFaturada);
            var professionalId = cboProfissional.SelectedValue.ToString();
            var status = Convert.ToInt32(dgv.Tag.ToString());

            if (cboProfissional.SelectedIndex == 0)
                dvOS.RowFilter = String.Format("Status = '{0}'", status);
            else
                dvOS.RowFilter = String.Format("Status = '{0}' AND ProfessionalId = '{1}'", status, professionalId);

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
