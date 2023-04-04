using Fluxus.Domain.Entities;
using Fluxus.App;

namespace Fluxus.WinUI.View
{
    public partial class frmAddOS : UserControl
    {
        private readonly frmMain _formMain;
        private string _formChild;
        private string _agencia;
        private int _id;

        public frmAddOS(frmMain formMain, string frmChild)
        {
            InitializeComponent();

            _formMain = formMain;
            _formChild = frmChild;

            cboProfissional.DataSource = new ProfessionalApp().GetCodeNameid(false);
            cboAtividade.DataSource = new ServiceApp().GetAll(false);
            cboCidade.DataSource = new App.ServiceOrderApp().GetCitiesFromOrders(false);

            if (!Logged.Rl)
                cboProfissional.Enabled = false;
        }

        public frmAddOS(frmMain formMain, string frmChild, ServiceOrder serviceOrder) : this(formMain, frmChild)
        {
            this.Tag = "Alterar";
            btnAddSave.Text = "&Alterar";
            PopulateFromModel(serviceOrder);

            if (serviceOrder.Invoiced)
                DisableEdit(serviceOrder.InvoiceId);
        }

        private void frmAddOS_Load(object sender, EventArgs e)
        {
            if (Tag.ToString() != "Alterar")
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
            var model = PopulateObject();
            var app = new ServiceOrderApp();
            var success = app.InsertOrUpdate(model, this.Tag.ToString());

            if (success)
                btnCancelar_Click(sender, e);
            else
                MessageBox.Show(app.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (_formChild == "uctOrderList")
            {
                uctServiceOrder formFilho = new uctServiceOrder(_formMain, 1);
                _formMain.OpenUserControl(formFilho);
            }
            else
            {
                uctServiceOrder formFilho = new uctServiceOrder(_formMain);
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
                txtAgenciaNome.Text = "";
                txtAgenciaTelefone.Text = "";
                txtAgenciaEmail.Text = "";
            }
            else
            {
                if (txtRef1.Text != _agencia)
                    GetBankBranch();
            }
        }

        private void btnAddAgencia_Click(object sender, EventArgs e)
        {
            var form = new uctAddBankBranch(txtRef1.Text);
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
            cboProfissional.SelectedValue = serviceOrder.ProfessionalId;
            cboAtividade.Text = serviceOrder.ServiceId;
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
            dtpDataPendente.Value = (DateTime)serviceOrder.PendingDate;
            dtpDataVistoria.Value = (DateTime)serviceOrder.SurveyDate;
            dtpDataConcluida.Value = (DateTime)serviceOrder.DoneDate;
            txtOBS.Text = serviceOrder.Comments;
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
            {
                Id = _id,
                ReferenceCode = referenceCode,
                Title = cboAtividade.Text,
                Branch = _agencia,
                OrderDate = dtpDataOrdem.Value,
                Deadline = dtpPrazo.Value,
                ProfessionalId = professionalId,
                ServiceId = serviceId,
                ServiceAmount = lblAtividadeValor.Text,
                MileageAllowance = lblAtividadeDeslocamento.Text,
                Siopi = chkSiopi.Checked,
                CustomerName = txtNomeCliente.Text,
                City = cboCidade.Text,
                ContactName = txtNomeContato.Text,
                ContactPhone = txtTelefoneContato.Text,
                Coordinates = txtCoordenada.Text,
                Status = status,
                PendingDate = dtpDataPendente.Value,
                SurveyDate = dtpDataVistoria.Value,
                DoneDate = dtpDataConcluida.Value,
                Comments = txtOBS.Text
            };

            return serviceOrder;
        }

        private void DisableEdit(int invoiceId)
        {
            lblFaturada.Show();
            txtCodFatura.Text = "Fatura: " + new InvoiceApp().GetDescription(invoiceId);
            txtCodFatura.Show();


            foreach (Control c in this.tabPage1.Controls)
            {
                if (c is TextBox || c is MaskedTextBox || c is CheckBox || c is DateTimePicker || c is RadioButton || c is ComboBox)
                    c.Enabled = false;
            }

            foreach (Control c in this.pnlStatus.Controls)
            {
                if (c is MaskedTextBox || c is RadioButton)
                    c.Enabled = false;
            }

            txtOBS.Enabled = false;
            btnAddSave.Hide();
            btnCancelar.Size = new System.Drawing.Size(433, 62);
            btnCancelar.Location = new System.Drawing.Point(1508, 32);
        }

        private void GetServiceName(object sender, EventArgs e)
        {
            var source = (List<Service>)cboAtividade.DataSource;
            var service = source.FirstOrDefault(item => item.Tag == cboAtividade.Text);

            lblAtividadeNome.Text = service.Description;
            lblAtividadeValor.Text = service.ServiceAmount;
            lblAtividadeDeslocamento.Text = service.MileageAllowance;
        }

        private void GetBankBranch()
        {
            var branch = new BankBranchApp().BuscarAgencia(txtRef1.Text);
            if (branch == null)
            {
                txtAgenciaNome.Text = "Agência não cadastrado!";
                txtAgenciaTelefone.Text = "";
                txtAgenciaEmail.Text = "";
                btnAddAgencia.Show();
            }
            else
            {
                txtAgenciaNome.Text = branch.Name;
                txtAgenciaTelefone.Text = branch.Phone1;
                txtAgenciaEmail.Text = branch.Email;
                _agencia = txtRef1.Text;
                btnAddAgencia.Hide();
            }
        }

        private void GetProfessionalName(object sender, EventArgs e)
        {
            var source = (List<Professional>)cboProfissional.DataSource;
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

        private void NextControl(object sender, EventArgs e)
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
