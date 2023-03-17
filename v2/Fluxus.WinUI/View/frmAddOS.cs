using System;
using System.Windows.Forms;
using Fluxus.Domain.Entities;
using System.Data;
using Fluxus.Services;
using System.Text;

namespace Fluxus.WinUI.View
{
    public partial class frmAddOS : Form
    {
        frmPrincipal _frmPrincipal;
        private string _formFilho;
        private string _agencia;
        private int _id;
        DataTable DtAtividades = new DataTable();
        DataTable DtProfissionais = new DataTable();


        private void OnValidated_MaskedTextBox(object sender, EventArgs e)
        {
            MaskedTextBox box = (MaskedTextBox)sender;
            box.Mask = Util.MaskValidated(sender);
        }


        private void OnEnter_MaskedTextBox(object sender, EventArgs e)
        {
            MaskedTextBox box = (MaskedTextBox)sender;
            box.Mask = Util.MaskEnter(sender);
        }


        private void BuscarNomeAtividade()
        {
            DataRow[] dataRowAtividade = DtAtividades.Select(String.Format("tag = '{0}'", cboAtividade.Text));
            lblAtividadeNome.Text = dataRowAtividade[0]["description"].ToString();
            lblAtividadeValor.Text = dataRowAtividade[0]["serviceAmount"].ToString();
            lblAtividadeDeslocamento.Text = dataRowAtividade[0]["mileageAllowance"].ToString();
        }


        private void BuscarNomeProfissional()
        {
            DataRow[] dataRowPro = DtProfissionais.Select(String.Format("id = '{0}'", cboProfissional.SelectedValue.ToString()));
            lblNomeProfissional.Text = dataRowPro[0]["nameid"].ToString();
        }


        private void BuscarAgencia()
        {
            DataTable dtAgencia = new BankBranchService().BuscarAgencia(txtRef1.Text);

            if (dtAgencia == null)
            {
                txtAgenciaNome.Text = "Agência não cadastrado!";
                txtAgenciaTelefone.Text = "";
                txtAgenciaEmail.Text = "";
                btnAddAgencia.Show();
            }
            else
            {
                txtAgenciaNome.Text = dtAgencia.Rows[0]["name"].ToString();
                txtAgenciaTelefone.Text = dtAgencia.Rows[0]["phone1"].ToString();
                txtAgenciaEmail.Text = dtAgencia.Rows[0]["email"].ToString();
                _agencia = txtRef1.Text;
                btnAddAgencia.Hide();
            }
        }


        private void Back()
        {
            this.Close();
            if (_formFilho == "frmOSLista")
            {
                frmOS formFilho = new frmOS(_frmPrincipal, 1);
                _frmPrincipal.AbrirFormInPanel(formFilho);
            }
            else
            {
                frmOS formFilho = new frmOS(_frmPrincipal);
                _frmPrincipal.AbrirFormInPanel(formFilho);
            }
        }


        private ServiceOrder PopulateObject()
        {
            //CRIA O TÍTULO DA ORDEN DE SERVIÇO
            int refe = Convert.ToInt32(txtRef2.Text);
            string titulo = cboAtividade.Text + "-" + cboCidade.Text + "-" + Convert.ToString(refe) + "\n\n" + "● Prazo: " + dtpPrazo.Value.ToString("dd/MM/yyyy") + "\nCliente: " + txtNomeCliente.Text.Replace(" ", " ");

            //CRIA/CONCATENA A REFERENCIA
            string referencia = string.Format("{0}.{1}.{2}/{3}.{4}.{5}.{6}", txtRef0.Text, txtRef1.Text, txtRef2.Text, txtRef3.Text, txtRef4.Text, txtRef5.Text, txtRef6.Text);

            //VALIDA O STATUS
            EnumStatus status;
            if (rbtRecebida.Checked)
                status = EnumStatus.RECEIVED;
            else if (rbtPendente.Checked)
                status = EnumStatus.PENDING;
            else if (rbtVistoriada.Checked)
                status = EnumStatus.SURVEYED;
            else
                status = EnumStatus.DONE;


            //POPULATE OBJECT TO RETURN
            ServiceOrder dado = new ServiceOrder
            {
                Id = _id,
                Title = titulo,
                ReferenceCode = referencia,
                Branch = _agencia,
                OrderDate = Util.ValidateDate(txtDataOrdem.Text),
                Deadline = Convert.ToDateTime(dtpPrazo.Value),
                ProfessionalId = cboProfissional.SelectedValue.ToString(),
                ServiceId = cboAtividade.SelectedValue.ToString(),
                ServiceAmount = lblAtividadeValor.Text.Replace(',', '.'),
                MileageAllowance = lblAtividadeDeslocamento.Text.Replace(',', '.'),
                Siopi = chkSiopi.Checked,
                CustomerName = txtNomeCliente.Text,
                City = cboCidade.Text,
                ContactName = txtNomeContato.Text,
                ContactPhone = txtTelefoneContato.Text,
                Coordinates = txtCoordenada.Text,
                Status = status,
                PendingDate = Util.ValidateDate(txtDataPendente.Text),
                SurveyDate = Util.ValidateDate(txtDataVistoria.Text),
                DoneDate = Util.ValidateDate(txtDataConcluida.Text),
                Comments = txtOBS.Text
            };

            return dado;
        }

        private void NextControl(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Length == txt.MaxLength)
                SendKeys.Send("{TAB}");
        }



        //:EVENTS
        public frmAddOS(frmPrincipal frm1, string frmfilho)
        {
            InitializeComponent();

            _frmPrincipal = frm1;
            _formFilho = frmfilho;

            DtProfissionais = new ProfissionalService().ListarCodigoENomeid(false);
            DtAtividades = new ServiceService().ListarAtividades(false);

            cboProfissional.DataSource = DtProfissionais;
            cboAtividade.DataSource = DtAtividades;
            cboCidade.DataSource = new Services.ServiceOrderService().GetCidadesDasOrdens(false);
            cboCidade.SelectedIndex = -1;
        }


        public frmAddOS(frmPrincipal frm1, string frmfilho, ServiceOrder dado) : this(frm1, frmfilho)
        {
            //POPULATE
            _id = dado.Id;

            txtRef0.Text = dado.ReferenceCode.Substring(0, 4);
            txtRef1.Text = dado.ReferenceCode.Substring(5, 4);
            txtRef2.Text = dado.ReferenceCode.Substring(10, 9);
            txtRef3.Text = dado.ReferenceCode.Substring(20, 4);
            txtRef4.Text = dado.ReferenceCode.Substring(25, 2);
            txtRef5.Text = dado.ReferenceCode.Substring(28, 2);
            txtRef6.Text = dado.ReferenceCode.Substring(31, 2);

            _agencia = dado.Branch;
            txtDataOrdem.Text = dado.OrderDate.ToString();
            dtpPrazo.Text = dado.Deadline.ToString();
            cboProfissional.SelectedValue = dado.ProfessionalId;
            cboAtividade.SelectedValue = dado.ServiceId;
            chkSiopi.Checked = dado.Siopi;
            txtNomeCliente.Text = dado.CustomerName;
            cboCidade.Text = dado.City;
            txtNomeContato.Text = dado.ContactName;
            txtTelefoneContato.Text = dado.ContactPhone;
            txtCoordenada.Text = dado.Coordinates;
            if (dado.Status == EnumStatus.RECEIVED)
                rbtRecebida.Checked = true;
            else if (dado.Status == EnumStatus.PENDING)
                rbtPendente.Checked = true;
            else if (dado.Status == EnumStatus.SURVEYED)
                rbtVistoriada.Checked = true;
            else
                rbtConcluida.Checked = true;

            txtDataPendente.Text = dado.PendingDate.ToString();
            txtDataVistoria.Text = dado.SurveyDate.ToString();
            txtDataConcluida.Text = dado.DoneDate.ToString();
            txtOBS.Text = dado.Comments;


            BuscarNomeProfissional();
            BuscarNomeAtividade();
            BuscarAgencia();


            if (dado.InvoiceId != 0)
            {
                lblFaturada.Show();
                txtCodFatura.Text = "Fatura: " + new FaturaService().DescricaoFatura(dado.InvoiceId);
                txtCodFatura.Show();


                //DISABLE CONTROLS
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
                btnCancelar.Size = new System.Drawing.Size(200, 25);
                btnCancelar.Location = new System.Drawing.Point(696, 13);

            }
        }


        private void frmAddOS_Load(object sender, EventArgs e)
        {
            if (this.Text == "Alterar")
            {
                btnAddSave.Text = "&Salvar";

                foreach (Control c in this.pnlReferencia.Controls)
                {
                    if (c is TextBox)
                    {
                        TextBox txt = (TextBox)c;
                        txt.ReadOnly = true;
                        txt.ForeColor = System.Drawing.Color.DarkSlateGray;

                    }
                }
            }
            else
            {
                cboAtividade.Text = null;
                cboProfissional.Text = null;
                txtDataOrdem.Text = DateTime.Now.ToString("dd/MM/yyyy");
                dtpPrazo.Text = (DateTime.Parse(txtDataOrdem.Text).AddDays(5)).ToString("dd/MM/yyyy");
            }


            if (Logged.Rt)
            {
                cboProfissional.SelectedValue = Logged.ProfessionalId;
                BuscarNomeProfissional();

                if (Logged.Rl == false)
                    cboProfissional.Enabled = false;

            }

            txtRef0.Focus();
            txtDataOrdem.SelectAll();

        }


        private void btnAddSave_Click(object sender, EventArgs e)
        {
            //CHECK PRIMARY KEY
            if (txtRef0.Text == "" || txtRef1.Text == "" || txtRef2.Text == "" || txtRef3.Text == "" || txtRef4.Text == "" || txtRef5.Text == "" || txtRef6.Text == "")
            {
                MessageBox.Show("Campos com * são obrigatório", "Chave Primária", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ServiceOrder dado = PopulateObject();

            //INSERT OR UPDATE
            if (btnAddSave.Text == "&Adicionar")
                new Services.ServiceOrderService().Insert(dado);
            else
                new Services.ServiceOrderService().Update(dado);

            Back();
        }


        private void btnAddAgencia_Click(object sender, EventArgs e)
        {
            frmAddAgencia form = new frmAddAgencia(txtRef1.Text);
            form.ShowDialog();

            BuscarAgencia();
            txtRef2.Focus();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Back();
        }





        ///_______RadioButton
        private void rbtRecebida_CheckedChanged(object sender, EventArgs e)
        {
            txtDataPendente.Hide();
            txtDataVistoria.Hide();
            txtDataConcluida.Hide();

        }

        private void rbtPendente_CheckedChanged(object sender, EventArgs e)
        {
            txtDataPendente.Visible = true;
            txtDataVistoria.Hide();
            txtDataConcluida.Hide();
            txtDataPendente.Focus();
            txtDataPendente.SelectAll();
        }

        private void rbtVistoriada_CheckedChanged(object sender, EventArgs e)
        {
            txtDataVistoria.Visible = true;
            txtDataPendente.Hide();
            txtDataConcluida.Hide();
            txtDataVistoria.Focus();
            txtDataVistoria.SelectAll();
        }

        private void rbtConcluida_CheckedChanged(object sender, EventArgs e)
        {
            txtDataConcluida.Visible = true;
            txtDataVistoria.Visible = true;
            txtDataPendente.Hide();
            txtDataConcluida.Focus();
            txtDataConcluida.SelectAll();
        }





        ///_______ComboBox
        private void cboProfissional_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BuscarNomeProfissional();
        }

        private void cboAtividade_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BuscarNomeAtividade();
        }

        private void cboCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.KeyChar = Char.ToUpper(e.KeyChar);
        }







        ///_______MaskedTextBox


        private void txtDataOrdem_Validated(object sender, EventArgs e)
        {
            dtpPrazo.Text = (DateTime.Parse(txtDataOrdem.Text).AddDays(5)).ToString("dd/MM/yyyy");
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
                    BuscarAgencia();
            }
        }

        private void txtRef2_Validated(object sender, EventArgs e)
        {
            string referencia = txtRef2.Text;
            string zeros = "";


            if (referencia.Length < 9)
            {
                for (int i = 0; i < 9 - referencia.Length; i++)
                {
                    zeros += "0";
                }
            }

            txtRef2.Text = zeros + referencia;

        }

        private void pnlReferencia_Validated(object sender, EventArgs e)
        {
            string referencia = string.Format("{0}.{1}.{2}/{3}.{4}.{5}.{6}", txtRef0.Text, txtRef1.Text, txtRef2.Text, txtRef3.Text, txtRef4.Text, txtRef5.Text, txtRef6.Text);

        }

        private void txtDataOrdem_Enter(object sender, EventArgs e)
        {
            txtDataOrdem.Focus();
            txtDataOrdem.SelectAll();
        }

    }



}
