using Fluxus.Domain.Entities;
using Fluxus.App.Services;
using Fluxus.Domain.Enums;
using Microsoft.Extensions.DependencyInjection;
using Fluxus.Domain.Records;

namespace Fluxus.WinUI.View
{
    public partial class uctAddServiceOrder : UserControl
    {
        private readonly frmMain _formMain;
        private string _formChild;
        private string _agencia;
        private int _id;
        private EnumMethod _method;
        private IServiceProvider _serviceProvider;
        private ServiceOrderService _serviceOrderService;

        public uctAddServiceOrder(frmMain formMain, string frmChild, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            _serviceOrderService = _serviceProvider.GetService<ServiceOrderService>();
            InitializeComponent();

            _method = EnumMethod.Insert;

            _formMain = formMain;
            _formChild = frmChild;

            var professionalService = _serviceProvider.GetService<ProfessionalService>();
            var professionals = professionalService.GetTagNameid(false);
            if (professionals == null)
            {
                MessageBox.Show(professionals.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cboProfissional.DataSource = professionals.Object as List<ProfessionalNameId>;


            var serviceService = _serviceProvider.GetService<ServiceService>();
            cboAtividade.DataSource = serviceService.GetAll(false).Object as List<ServiceIndex>;

            var cities = _serviceOrderService.GetCitiesFromOrders(false);
            if (cities.Success)
                cboCidade.DataSource = cities.Object as List<string>;

            if (!Logged.Rl)
                cboProfissional.Enabled = false;
        }

        public uctAddServiceOrder(frmMain formMain, string frmChild, ServiceOrder serviceOrder, IServiceProvider serviceProvider) : this(formMain, frmChild, serviceProvider)
        {

            _method = EnumMethod.Update;
            btnAddSave.Text = "&Alterar";
            PopulateFromModel(serviceOrder);

            if (serviceOrder.Invoiced)
                DisableEdit(serviceOrder.InvoiceId);
        }

        private void frmAddOS_Load(object sender, EventArgs e)
        {
            if (_method == EnumMethod.Insert)
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
            var service = _serviceProvider.GetService<ServiceOrderService>();
            var serviceOrder = PopulateObject();

            var result = _method == EnumMethod.Insert ? service.Insert(serviceOrder) : service.Update(serviceOrder);

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

        private void PopulateFromModel(ServiceOrder serviceOrder)
        {
            _id = serviceOrder.Id;
            txtRef0.Text = serviceOrder.ReferenceCode.Substring(0, 4);
            txtRef1.Text = serviceOrder.ReferenceCode.Substring(5, 4);
            txtRef2.Text = serviceOrder.ReferenceCode.Substring(10, 9);
            txtRef3.Text = serviceOrder.ReferenceCode.Substring(20, 4);
            txtRef4.Text = serviceOrder.ReferenceCode.Substring(25, 2);
            txtRef5.Text = serviceOrder.ReferenceCode.Substring(28, 2);
            txtRef6.Text = serviceOrder.ReferenceCode.Substring(31, 2);
            _agencia = serviceOrder.Branch;
            dtpDataOrdem.Value = serviceOrder.OrderDate;
            dtpPrazo.Value = serviceOrder.Deadline;
            cboProfissional.SelectedValue = Convert.ToInt32(serviceOrder.ProfessionalId);
            cboAtividade.SelectedValue = Convert.ToInt32(serviceOrder.ServiceId);
            chkSiopi.Checked = serviceOrder.Siopi;
            txtNomeCliente.Text = serviceOrder.CustomerName;
            cboCidade.Text = serviceOrder.City;
            txtNomeContato.Text = serviceOrder.ContactName;
            txtTelefoneContato.Text = serviceOrder.ContactPhone;
            txtCoordenada.Text = serviceOrder.Coordinates;
            if (serviceOrder.Status == EnumStatus.RECEBIDA)
                rbtRecebida.Checked = true;
            else if (serviceOrder.Status == EnumStatus.PENDENTE)
                rbtPendente.Checked = true;
            else if (serviceOrder.Status == EnumStatus.VISTORIADA)
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

        private ServiceOrder PopulateObject()
        {
            string referenceCode = string.Format("{0}.{1}.{2}/{3}.{4}.{5}.{6}", txtRef0.Text, txtRef1.Text, txtRef2.Text, txtRef3.Text, txtRef4.Text, txtRef5.Text, txtRef6.Text);

            EnumStatus status;
            if (rbtRecebida.Checked)
                status = EnumStatus.RECEBIDA;
            else if (rbtPendente.Checked)
                status = EnumStatus.PENDENTE;
            else if (rbtVistoriada.Checked)
                status = EnumStatus.VISTORIADA;
            else
                status = EnumStatus.CONCLUIDA;

            string professionalId = cboProfissional.SelectedValue == null ? String.Empty : cboProfissional.SelectedValue.ToString();
            string serviceId = cboAtividade.SelectedValue == null ? String.Empty : cboAtividade.SelectedValue.ToString();

            ServiceOrder serviceOrder = new ServiceOrder
            (
                id: _id,
                referenceCode: referenceCode,
                branch: _agencia,
                professionalId: professionalId,
                serviceId: serviceId,
                serviceAmount: lblAtividadeValor.Text,
                mileageAllowance: lblAtividadeDeslocamento.Text,
                customerName: txtNomeCliente.Text,
                city: cboCidade.Text,
                contactName: txtNomeContato.Text,
                contactPhone: txtTelefoneContato.Text,
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

        private void DisableEdit(int invoiceId)
        {
            lblFaturada.Show();
            var invoiceService = _serviceProvider.GetService<InvoiceService>();
            txtCodFatura.Text = "Fatura: " + invoiceService.GetDescription(invoiceId).Object as String;
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
            var source = (List<ServiceIndex>)cboAtividade.DataSource;
            var service = source.FirstOrDefault(item => item.Tag == cboAtividade.Text);

            lblAtividadeNome.Text = service.Description;
            lblAtividadeValor.Text = service.ServiceAmount;
            lblAtividadeDeslocamento.Text = service.MileageAllowance;
        }

        private void GetBankBranch()
        {
            var service = _serviceProvider.GetService<BankBranchService>();
            var result = service.GetByCode(txtRef1.Text);

            if (!result.Success)
            {
                txtBranchName.Text = "Agência não cadastrado!";
                txtBranchPhone.Text = "";
                txtBranchEmail.Text = "";
                return;
            }

            var branch = result.Object as BankBranch;
            txtBranchName.Text = branch.Name;
            txtBranchPhone.Text = branch.Phone1;
            txtBranchEmail.Text = branch.Email;
            _agencia = txtRef1.Text;

        }

        private void GetProfessionalName(object sender, EventArgs e)
        {
            var source = (List<ProfessionalNameId>)cboProfissional.DataSource;
            var professional = source.FirstOrDefault(item => item.Tag == cboProfissional.Text);

            lblNomeProfissional.Text = professional.Nameid;
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
