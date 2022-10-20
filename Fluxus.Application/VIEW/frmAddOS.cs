using System;
using System.Windows.Forms;
using Fluxus.Domain.Models;
using System.Data;
using Fluxus.Application.Controller;
using System.Text;

namespace Fluxus.Application.View
{
    public partial class frmAddOS : Form
    {


        frmPrincipal _frmPrincipal;
        private string _formFilho;
        private string _agencia;
        private long _id;
        DataTable DtAtividades = new DataTable();
        DataTable DtProfissionais = new DataTable();





        //:METHODS
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
            try
            {
                DataRow[] dataRowAtividade = DtAtividades.Select(String.Format("codigo = '{0}'", cboAtividade.Text));
                lblAtividadeNome.Text = dataRowAtividade[0]["descricao"].ToString();
                lblAtividadeValor.Text = dataRowAtividade[0]["valor_atividade"].ToString();
                lblAtividadeDeslocamento.Text = dataRowAtividade[0]["valor_deslocamento"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BuscarNomeProfissional()
        {
            try
            {
                DataRow[] dataRowPro = DtProfissionais.Select(String.Format("codigo = '{0}'", cboProfissional.Text));
                lblNomeProfissional.Text = dataRowPro[0]["nomeid"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BuscarAgencia()
        {
            try
            {
                string agenciaCodigo = txtRef1.Text;
                DataTable dtAgencia = new AgenciaController().BuscarAgencia(agenciaCodigo);

                if (dtAgencia == null )
                {
                    txtAgenciaNome.Text = "Agência não cadastrado!";
                    txtAgenciaTelefone.Text = "";
                    txtAgenciaEmail.Text = "";
                    btnAddAgencia.Show();
                }
                else
                {
                    txtAgenciaNome.Text = dtAgencia.Rows[0]["nome"].ToString();
                    txtAgenciaTelefone.Text = dtAgencia.Rows[0]["telefone1"].ToString();
                    txtAgenciaEmail.Text = dtAgencia.Rows[0]["email"].ToString();
                    _agencia = txtRef1.Text;
                    btnAddAgencia.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Back()
        {
            this.Close();
            if (_formFilho == "frmOSLista")
            {
                frmOS formFilho = new frmOS(_frmPrincipal, 1);
                _frmPrincipal.AbrirFormInPanel(formFilho, _frmPrincipal.pnlMain);
            }
            else
            {
                frmOS formFilho = new frmOS(_frmPrincipal);
                _frmPrincipal.AbrirFormInPanel(formFilho, _frmPrincipal.pnlMain);
            }
        }


        private Os PopulateObject()
        {
            //CRIA O TÍTULO DA ORDEN DE SERVIÇO
            int refe = Convert.ToInt32(txtRef2.Text);
            string titulo = cboAtividade.Text + "-" + cboCidade.Text + "-" + Convert.ToString(refe) + "\n\n" + "● Prazo: " + dtpPrazo.Value.ToString("dd/MM/yyyy") + "\nCliente: " + txtNomeCliente.Text.Replace(" ", " ");


            //CRIA/CONCATENA A REFERENCIA
            string referencia = string.Format("{0}.{1}.{2}/{3}.{4}.{5}.{6}", txtRef0.Text, txtRef1.Text, txtRef2.Text, txtRef3.Text, txtRef4.Text, txtRef5.Text, txtRef6.Text);


            //VALIDA O STATUS
            string status;
            if (rbtRecebida.Checked)
                status = "RECEBIDA";
            else if (rbtPendente.Checked)
                status = "PENDENTE";
            else if (rbtVistoriada.Checked)
                status = "VISTORIADA";
            else
                status = "CONCLUÍDA";







            //POPULATE OBJECT TO RETURN
            Os dado = new Os
            {
                Titulo = titulo,
                Referencia = referencia,
                Agencia = _agencia,
                Data_ordem = Util.ValidateDateString(txtDataOrdem.Text),
                Prazo_execucao = Convert.ToDateTime(dtpPrazo.Value),
                Profissional_cod = cboProfissional.Text,
                Atividade_cod = cboAtividade.Text,
                Valor_atividade = lblAtividadeValor.Text.Replace(',', '.'),
                Valor_deslocamento = lblAtividadeDeslocamento.Text.Replace(',', '.'),
                Siopi = chkSiopi.Checked,
                Nome_cliente = txtNomeCliente.Text,
                Cidade = cboCidade.Text,
                Nome_contato = txtNomeContato.Text,
                Telefone_contato = txtTelefoneContato.Text,
                Coordenada = txtCoordenada.Text,
                Status = status,
                Data_pendente = Util.ValidateDateString(txtDataPendente.Text),
                Data_vistoria = Util.ValidateDateString(txtDataVistoria.Text),
                Data_concluida = Util.ValidateDateString(txtDataConcluida.Text),
                Obs = txtOBS.Text
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

            DtProfissionais = new ProfissionalController().ListarCodigoENomeid(false);
            DtAtividades = new AtividadeController().ListarAtividades(false);

            cboProfissional.DataSource = DtProfissionais;
            cboAtividade.DataSource = DtAtividades;
            cboCidade.DataSource = new OsController().GetCidadesDasOrdens(false);
            cboCidade.SelectedIndex = -1;

        }


        public frmAddOS(frmPrincipal frm1, string frmfilho, Os dado) : this(frm1, frmfilho)
        {

            //POPULATE
            _id = dado.Id;
            

            txtRef0.Text = dado.Referencia.Substring(0, 4);
            txtRef1.Text = dado.Referencia.Substring(5, 4);
            txtRef2.Text = dado.Referencia.Substring(10, 9);
            txtRef3.Text = dado.Referencia.Substring(20, 4);
            txtRef4.Text = dado.Referencia.Substring(25, 2);
            txtRef5.Text = dado.Referencia.Substring(28, 2);
            txtRef6.Text = dado.Referencia.Substring(31, 2);



                        
            _agencia = dado.Agencia;
            txtDataOrdem.Text = dado.Data_ordem;
            dtpPrazo.Text = dado.Prazo_execucao.ToString();
            cboProfissional.Text = dado.Profissional_cod;
            cboAtividade.Text = dado.Atividade_cod;
            chkSiopi.Checked = dado.Siopi;
            txtNomeCliente.Text = dado.Nome_cliente;
            cboCidade.Text = dado.Cidade;
            txtNomeContato.Text = dado.Nome_contato;
            txtTelefoneContato.Text = dado.Telefone_contato;
            txtCoordenada.Text = dado.Coordenada;
            if (dado.Status == "RECEBIDA")
                rbtRecebida.Checked = true;
            else if (dado.Status == "PENDENTE")
                rbtPendente.Checked = true;
            else if (dado.Status == "VISTORIADA")
                rbtVistoriada.Checked = true;
            else
                rbtConcluida.Checked = true;

            txtDataPendente.Text = dado.Data_pendente;
            txtDataVistoria.Text = dado.Data_vistoria;
            txtDataConcluida.Text = dado.Data_concluida;
            txtOBS.Text = dado.Obs;


            BuscarNomeProfissional();
            BuscarNomeAtividade();
            BuscarAgencia();


            if (dado.Fatura_cod != 0)
            {
                lblFaturada.Show();
                txtCodFatura.Text = "Fatura: " + new FaturaController().DescricaoFatura(dado.Fatura_cod);
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
                cboProfissional.SelectedValue = Logged.Codpro;
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



            Os dado = PopulateObject();



            //INSERT OR UPDATE
            if (btnAddSave.Text == "&Adicionar")
            {
                try
                {
                    new OsController().Insert(dado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                try
                {
                    new OsController().Update(_id, dado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

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
        //if (BuscarReferencia(referencia) == true)
        // MessageBox("Referecia " + referencia + " já cadastrada!")
        
        }

        private void txtDataOrdem_Enter(object sender, EventArgs e)
        {
            txtDataOrdem.Focus();
            txtDataOrdem.SelectAll();
        }
    }



}
