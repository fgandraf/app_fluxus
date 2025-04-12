using Fluxus.Core.Models;
using Fluxus.Core.Enums;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using Fluxus.UseCases;
using Fluxus.Core.Dtos.Services;
using Fluxus.Core.Dtos.Professionals;
using Fluxus.Core.Dtos.Orders;
using System.Text.RegularExpressions;

namespace Fluxus.WinUI.View
{
    public partial class uctAddServiceOrder : UserControl
    {
        private readonly frmMain _formMain;
        private string _formChild;
        private string _agencia;
        private long _id;
        private EMethod _method;
        private IServiceProvider _serviceProvider;
        private OrderUseCases _serviceOrderService;

        public uctAddServiceOrder(frmMain formMain, string frmChild, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            _serviceOrderService = _serviceProvider.GetService<OrderUseCases>();
            InitializeComponent();

            _method = EMethod.Insert;

            _formMain = formMain;
            _formChild = frmChild;

            var professionalService = _serviceProvider.GetService<ProfessionalUseCases>();
            var professionals = professionalService.GetTagNameid(false);
            if (professionals == null)
            {
                MessageBox.Show(professionals.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cboProfissional.DataSource = professionals.Value;


            var serviceService = _serviceProvider.GetService<ServiceUseCases>();
            cboAtividade.DataSource = serviceService.GetAll(false).Value;

            var cities = _serviceOrderService.GetCitiesFromOrders(false);
            if (cities.Success)
                cboCidade.DataSource = cities.Value;

            if (!Logged.Rl)
                cboProfissional.Enabled = false;
        }

        public uctAddServiceOrder(frmMain formMain, string frmChild, OrderResponse serviceOrder, IServiceProvider serviceProvider) : this(formMain, frmChild, serviceProvider)
        {

            _method = EMethod.Update;
            btnAddSave.Text = "&Alterar";
            PopulateFromModel(serviceOrder);

            if (serviceOrder.Invoiced)
                DisableEdit(serviceOrder.InvoiceId ?? 0);
        }

        private void frmAddOS_Load(object sender, EventArgs e)
        {
            if (_method == EMethod.Insert)
            {
                cboCidade.SelectedIndex = -1;
                cboAtividade.SelectedIndex = -1;
                dtpPrazo.Value = dtpPrazo.Value.AddDays(6);
                cboProfissional.SelectedValue = Logged.Rt ? Logged.ProfessionalId : -1;
            }
            else
            {
                foreach (Control c in pnlReferencia.Controls)
                {
                    if (c is TextBox)
                    {
                        TextBox txt = (TextBox)c;
                        txt.ReadOnly = true;
                        txt.ForeColor = System.Drawing.Color.DarkSlateGray;
                    }
                }

                GetServiceName(sender, e);
                GetBankBranch();
            }

            if (cboProfissional.SelectedIndex != -1)
                GetProfessionalName(sender, e);
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            var service = _serviceProvider.GetService<OrderUseCases>();
            var serviceOrder = PopulateObject();

            var result = _method == EMethod.Insert ? service.Insert(serviceOrder) : service.Update(serviceOrder);

            if (result.Success)
                btnCancelar_Click(sender, e);
            else
                MessageBox.Show(result.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (_formChild == "uctOrderList")
            {
                uctServiceOrder formFilho = new uctServiceOrder(_formMain, 1, _serviceProvider);
                _formMain.OpenUserControl(formFilho);
            }
            else
            {
                uctServiceOrder formFilho = new uctServiceOrder(_formMain, _serviceProvider);
                _formMain.OpenUserControl(formFilho);
            }
        }

        private void dtpDataOrdem_Validated(object sender, EventArgs e)
            => dtpPrazo.Value = dtpDataOrdem.Value.AddDays(6);

        private void txtRef2_Validated(object sender, EventArgs e)
        {
            string referencia = txtRef2.Text;
            string zeros = "";

            if (referencia.Length < 9)
            {
                for (int i = 0; i < 9 - referencia.Length; i++)
                    zeros += "0";
            }

            txtRef2.Text = zeros + referencia;
        }

        private void txtRef1_Validated(object sender, EventArgs e)
        {
            if (txtRef1.Text == "")
            {
                txtBranchName.Text = "";
                txtBranchPhone.Text = "";
                txtBranchEmail.Text = "";
            }
            else
            {
                if (txtRef1.Text != _agencia)
                    GetBankBranch();
            }
        }

        private void btnAddAgencia_Click(object sender, EventArgs e)
        {
            var form = new uctAddBankBranch(txtRef1.Text, _serviceProvider);
            //form.ShowDialog();

            GetBankBranch();
            txtRef2.Focus();
        }

        private void PopulateFromModel(OrderResponse serviceOrder)
        {

            _id = serviceOrder.Id;
            txtRef0.Text = serviceOrder.ReferenceCode.Substring(0, 4);
            txtRef1.Text = serviceOrder.ReferenceCode.Substring(4, 4);
            txtRef2.Text = serviceOrder.ReferenceCode.Substring(8, 9);
            txtRef3.Text = serviceOrder.ReferenceCode.Substring(17, 4);
            txtRef4.Text = serviceOrder.ReferenceCode.Substring(21, 2);
            txtRef5.Text = serviceOrder.ReferenceCode.Substring(23, 2);
            txtRef6.Text = serviceOrder.ReferenceCode.Substring(25, 2);
            _agencia = serviceOrder.BranchId;
            dtpDataOrdem.Value = serviceOrder.OrderDate;
            dtpPrazo.Value = serviceOrder.Deadline;
            cboProfissional.SelectedValue = serviceOrder.ProfessionalId;
            cboAtividade.SelectedValue = serviceOrder.ServiceId;
            chkSiopi.Checked = serviceOrder.Siopi;
            txtNomeCliente.Text = serviceOrder.CustomerName;
            cboCidade.Text = serviceOrder.City;
            txtNomeContato.Text = serviceOrder.ContactName;

            if (serviceOrder.ContactPhone.Length == 11)
            {
                txtTelefoneContato.Text = string.Format("({0}) {1}-{2}",
                serviceOrder.ContactPhone.Substring(0, 2),
                serviceOrder.ContactPhone.Substring(2, 5),
                serviceOrder.ContactPhone.Substring(7, 4));
            }
            
            if (serviceOrder.ContactPhone.Length == 10)
            {
                txtTelefoneContato.Text = string.Format("({0}) {1}-{2}",
                serviceOrder.ContactPhone.Substring(0, 2),
                serviceOrder.ContactPhone.Substring(2, 4),
                serviceOrder.ContactPhone.Substring(6, 4));
            }

            txtCoordenada.Text = serviceOrder.Coordinates;
            if (serviceOrder.Status == EStatus.RECEBIDA)
                rbtRecebida.Checked = true;
            else if (serviceOrder.Status == EStatus.PENDENTE)
                rbtPendente.Checked = true;
            else if (serviceOrder.Status == EStatus.VISTORIADA)
                rbtVistoriada.Checked = true;
            else
                rbtConcluida.Checked = true;
            if (serviceOrder.PendingDate != null)
                dtpDataPendente.Value = (DateTime)serviceOrder.PendingDate;
            if (serviceOrder.SurveyDate != null)
                dtpDataVistoria.Value = (DateTime)serviceOrder.SurveyDate;
            if (serviceOrder.DoneDate != null)
                dtpDataConcluida.Value = (DateTime)serviceOrder.DoneDate;
        }

        private Order PopulateObject()
        {
            string referenceCode = string.Format("{0}{1}{2}{3}{4}{5}{6}", txtRef0.Text, txtRef1.Text, txtRef2.Text, txtRef3.Text, txtRef4.Text, txtRef5.Text, txtRef6.Text);

            EStatus status;
            if (rbtRecebida.Checked)
                status = EStatus.RECEBIDA;
            else if (rbtPendente.Checked)
                status = EStatus.PENDENTE;
            else if (rbtVistoriada.Checked)
                status = EStatus.VISTORIADA;
            else
                status = EStatus.CONCLUIDA;

            var professionalId = (long)cboProfissional.SelectedValue;
            var serviceId = (long)cboAtividade.SelectedValue;

            Order serviceOrder = new Order
            (
                id: _id,
                referenceCode: referenceCode,
                branch: _agencia,
                professionalId: professionalId,
                serviceId: serviceId,
                serviceAmount: double.Parse(lblAtividadeValor.Text, NumberStyles.Currency, new CultureInfo("pt-br")),
                mileageAllowance: double.Parse(lblAtividadeDeslocamento.Text, NumberStyles.Currency, new CultureInfo("pt-br")),
                customerName: txtNomeCliente.Text,
                city: cboCidade.Text,
                contactName: txtNomeContato.Text,
                contactPhone: Regex.Replace(txtTelefoneContato.Text, @"[^\d]", ""),
                coordinates: txtCoordenada.Text,
                status: status,
                invoiced: false,
                invoiceId: 0,
                orderDate: dtpDataOrdem.Value,
                deadline: dtpPrazo.Value,
                pendingDate: dtpDataPendente.Value,
                surveyDate: dtpDataVistoria.Value,
                doneDate: dtpDataConcluida.Value,
                siopi: chkSiopi.Checked
            );

            return serviceOrder;
        }

        private void DisableEdit(long invoiceId)
        {
            lblFaturada.Show();
            var invoiceService = _serviceProvider.GetService<InvoiceUseCases>();
            txtCodFatura.Text = "Fatura: " + invoiceService.GetDescription(invoiceId).Value;
            txtCodFatura.Show();


            foreach (Control c in pnlMain.Controls)
            {
                if (c is TextBox || c is MaskedTextBox || c is CheckBox || c is DateTimePicker || c is RadioButton || c is ComboBox)
                    c.Enabled = false;
            }

            btnAddSave.Hide();
            btnCancelar.Size = new System.Drawing.Size(433, 62);
            btnCancelar.Location = new System.Drawing.Point(1508, 32);
        }

        private void GetServiceName(object sender, EventArgs e)
        {
            var source = (List<ServiceResponse>)cboAtividade.DataSource;
            var service = source.FirstOrDefault(x => x.Tag == cboAtividade.Text);

            lblAtividadeNome.Text = service.Description;
            lblAtividadeValor.Text = service.ServiceAmount.ToString("C", new CultureInfo("pt-br"));
            lblAtividadeDeslocamento.Text = service.MileageAllowance.ToString("C", new CultureInfo("pt-br"));
        }

        private void GetBankBranch()
        {
            var service = _serviceProvider.GetService<BranchUseCases>();
            var result = service.GetById(txtRef1.Text);

            if (!result.Success)
            {
                txtBranchName.Text = "Agência não cadastrado!";
                txtBranchPhone.Text = "";
                txtBranchEmail.Text = "";
                return;
            }

            var branch = result.Value;
            txtBranchName.Text = branch.Name;
            txtBranchPhone.Text = branch.Phone1;
            txtBranchEmail.Text = branch.Email;
            _agencia = txtRef1.Text;

        }

        private void GetProfessionalName(object sender, EventArgs e)
        {
            var source = (List<ProfessionalTagNameIdResponse>)cboProfissional.DataSource;
            var professional = source.FirstOrDefault(item => item.Tag == cboProfissional.Text);

            lblNomeProfissional.Text = professional.NameId;
        }



        #region "UI Behavior"
        private void cboCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void OnValidated_MaskedTextBox(object sender, EventArgs e)
            => ((MaskedTextBox)sender).Mask = Util.MaskValidated(sender);

        private void OnEnter_MaskedTextBox(object sender, EventArgs e)
            => ((MaskedTextBox)sender).Mask = Util.MaskEnter(sender);

        private void NextControl(object sender, KeyEventArgs e)
        {
            var txt = (TextBox)sender;
            if (txt.Text.Length == txt.MaxLength)
                SendKeys.Send("{TAB}");
        }

        private void rbtRecebida_CheckedChanged(object sender, EventArgs e)
        {
            dtpDataPendente.Hide();
            dtpDataVistoria.Hide();
            dtpDataConcluida.Hide();
        }

        private void rbtPendente_CheckedChanged(object sender, EventArgs e)
        {
            dtpDataPendente.Visible = true;
            dtpDataVistoria.Hide();
            dtpDataConcluida.Hide();
            dtpDataPendente.Focus();
        }

        private void rbtVistoriada_CheckedChanged(object sender, EventArgs e)
        {
            dtpDataVistoria.Visible = true;
            dtpDataPendente.Hide();
            dtpDataConcluida.Hide();
            dtpDataVistoria.Focus();
        }

        private void rbtConcluida_CheckedChanged(object sender, EventArgs e)
        {
            dtpDataConcluida.Visible = true;
            dtpDataVistoria.Visible = true;
            dtpDataPendente.Hide();
            dtpDataConcluida.Focus();
        }
        #endregion
    }

}
