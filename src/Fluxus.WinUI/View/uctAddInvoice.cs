﻿using Fluxus.Core.Models;
using System.Globalization;
using Microsoft.Extensions.DependencyInjection;
using Fluxus.Core.ViewModels;
using System.ComponentModel;
using System.Collections;
using Fluxus.UseCases;

namespace Fluxus.WinUI.View
{
    public partial class uctAddInvoice : UserControl
    {
        private readonly frmMain _frmPrincipal;
        private decimal _subtotal_os = 0.00m;
        private decimal _subtotal_desloc = 0.00m;
        private IServiceProvider _serviceProvider;

        public uctAddInvoice(frmMain frm1, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            InitializeComponent();
            _frmPrincipal = frm1;
        }

        private void frmAddFatura_Load(object sender, EventArgs e)
        {
            var serviceOrderService = _serviceProvider.GetService<OrderUseCases>();

            var orders = serviceOrderService.GetOpenDone();
            if (orders.Success)
            {
                dgvOS.DataSource = new BindingList<OrdersIndexViewModel>(orders.Value);
                Calculate();
                txtDescricao.Text = dtpData.Value.ToString("MMMM", CultureInfo.CreateSpecificCulture("pt-br")) + "-" + dtpData.Value.Year.ToString();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvOS.SelectedRows.Count == 0)
                return;
            else
            {
                var dialog = MessageBox.Show("Deseja remover a O.S. da Fatura?" + "\n\n" + dgvOS.CurrentRow.Cells[2].Value.ToString() + "\n" + dgvOS.CurrentRow.Cells[6].Value.ToString(), "Não Faturar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dialog == DialogResult.Yes)
                {
                    dgvOS.Rows.RemoveAt(dgvOS.CurrentRow.Index);
                    Calculate();
                }
            }
        }

        private void btnFaturar_Click(object sender, EventArgs e)
        {
            var service = _serviceProvider.GetService<InvoiceUseCases>();
            var invoice = PopulateToObject();

            var result = service.Insert(invoice);
            int invoiceId = result.Value;


            if (invoiceId == 0)
            {
                MessageBox.Show(result.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var serviceOrderService = _serviceProvider.GetService<OrderUseCases>();

            var orders = new List<int>();
            foreach (DataGridViewRow row in dgvOS.Rows)
                orders.Add(Convert.ToInt32(row.Cells["id"].Value));
            
            serviceOrderService.UpdateInvoiceId(invoiceId, orders);

            MessageBox.Show("Ordens faturadas com sucesso!", "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnCancelar_Click(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            uctServiceOrder formFilho = new uctServiceOrder(_frmPrincipal, _serviceProvider);
            _frmPrincipal.OpenUserControl(formFilho);
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
            => txtDescricao.Text = dtpData.Value.ToString("MMMM", CultureInfo.CreateSpecificCulture("pt-br")) + "-" + dtpData.Value.Year.ToString();

        private void Calculate()
        {
            _subtotal_os = 0.0m;
            _subtotal_desloc = 0.0m;

            foreach (DataGridViewRow row in dgvOS.Rows)
                _subtotal_os += Convert.ToDecimal(row.Cells["valor_atividade"].Value);

            foreach (DataGridViewRow row in dgvOS.Rows)
                _subtotal_desloc += Convert.ToDecimal(row.Cells["valor_deslocamento"].Value);

            txtValorOS.Text = _subtotal_os.ToString("C", new CultureInfo("pt-br"));
            txtValorDeslocamento.Text = _subtotal_desloc.ToString("C", new CultureInfo("pt-br"));
            txtValorTotal.Text = (_subtotal_os+_subtotal_desloc).ToString("C", new CultureInfo("pt-br"));
        }

        private Invoice PopulateToObject()
        {
            Invoice invoice = new Invoice
            (
                id: 0,
                description: txtDescricao.Text,
                issueDate: dtpData.Value,
                subtotalService: _subtotal_os,
                subtotalMileageAllowance: _subtotal_desloc,
                total: _subtotal_os + _subtotal_desloc
            ) ;
            return invoice;
        }

    }

}
