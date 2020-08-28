using System;
using System.Windows.Forms;
using Arqueng.MODEL;
using Arqueng.ENTIDADES;
using System.Text.RegularExpressions;
using System.Data;

namespace Arqueng.VIEW
{

    public partial class frmAddOS : Form
    {

        frmPrincipal _frmPrincipal;
        private string FormFilho;
        private string Agencia = null;

        OsENT dado = new OsENT();
        OsMODEL osmodel = new OsMODEL();




        //:METHODS

 
        private void BuscarNomeAtividade()
        {
            try
            {
                DataRow[] dataRowAtividade = DT.Atividades.Select(String.Format("codigo = '{0}'", cboAtividade.Text));
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
                DataRow[] dataRowPro = DT.Profissionais.Select(String.Format("codigo = '{0}'", cboProfissional.Text));
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
                DataRow[] dataRowAgencia = DT.Agencias.Select(String.Format("agencia = '{0}'", txtReferencia.Text.Substring(5, 4)));
                if (dataRowAgencia.Length == 0)
                {
                    txtAgenciaNome.Text = "Agência não cadastrado!";
                    txtAgenciaTelefone.Text = "";
                    txtAgenciaEmail.Text = "";
                    btnAddAgencia.Show();
                }
                else
                {
                    txtAgenciaNome.Text = dataRowAgencia[0]["nome"].ToString();
                    txtAgenciaTelefone.Text = dataRowAgencia[0]["telefone1"].ToString();
                    txtAgenciaEmail.Text = dataRowAgencia[0]["email"].ToString();
                    Agencia = txtReferencia.Text.Substring(5, 4);
                    btnAddAgencia.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        //:EVENTS
        ///_______Form
        public frmAddOS(frmPrincipal frm1, string frmfilho)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
            FormFilho = frmfilho;
            cboProfissional.DataSource = Globais.Profissionais(false);
            cboAtividade.DataSource = Globais.Atividades(false);
        }

        public frmAddOS(frmPrincipal frm1, string frmfilho, string referencia, string agencia, string titulo, string dataordem, string prazoexecucao, string profissionalcod, string atividadecod, bool siopi, string nomecliente, string cidade, string nomecontato, string telefonecontato, string coordenada, string status, string datapendente, string datavistoria, string dataconcluida, string obs, string faturacod)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
            FormFilho = frmfilho;

            //POPULATE
            cboProfissional.DataSource = Globais.Profissionais(false);
            cboAtividade.DataSource = Globais.Atividades(false);
            dado.Titulo = titulo;
            txtReferencia.Text = referencia;
            Agencia = agencia;
            txtDataOrdem.Text = dataordem;
            dtpPrazo.Text = prazoexecucao;
            cboProfissional.Text = profissionalcod;
            cboAtividade.Text = atividadecod;
            chkSiopi.Checked = siopi;
            txtNomeCliente.Text = nomecliente;
            txtCidade.Text = cidade;
            txtNomeContato.Text = nomecontato;
            txtTelefoneContato.Text = telefonecontato;
            txtCoordenada.Text = coordenada;
            if (status == "RECEBIDA")
                rbtRecebida.Checked = true;
            else if (status == "PENDENTE")
                rbtPendente.Checked = true;
            else if (status == "VISTORIADA")
                rbtVistoriada.Checked = true;
            else
                rbtConcluida.Checked = true;
            txtDataPendente.Text = datapendente;
            txtDataVistoria.Text = datavistoria;
            txtDataConcluida.Text = dataconcluida;
            txtOBS.Text = obs;




            BuscarNomeProfissional();
            BuscarNomeAtividade();
            BuscarAgencia();

            if (faturacod != "0")
            {
                lblFaturada.Show();
                txtCodFatura.Text = "Fatura n°: " + faturacod;
                txtCodFatura.Show();

                foreach (Control c in this.tabPage1.Controls)
                {
                    if (c is TextBox || c is MaskedTextBox || c is CheckBox || c is DateTimePicker || c is RadioButton)
                        c.Enabled = false;
                }

                foreach (Control c in this.tableLayoutPanel1.Controls)
                {
                    if (c is MaskedTextBox || c is RadioButton)
                        c.Enabled = false;
                }

                cboAtividade.Enabled = false;
                cboProfissional.Enabled = false;
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
                txtReferencia.Enabled = false;
            }
            else
            {
                cboAtividade.Text = null;
                cboProfissional.Text = null;
                txtDataOrdem.Text = DateTime.Now.ToString("dd/MM/yyyy");
                dtpPrazo.Text = (DateTime.Parse(txtDataOrdem.Text).AddDays(5)).ToString("dd/MM/yyyy");
            }
            txtDataOrdem.Focus();
            txtDataOrdem.SelectAll();


            if (Globais.Rt && Globais.Rl == false)
            {
                cboProfissional.SelectedValue = Globais.Codpro;
                BuscarNomeProfissional();
                cboProfissional.Enabled = false;

            }



        }





        ///_______Button
        private void btnAddSave_Click(object sender, EventArgs e)
        {
            //CHECK PRIMARY KEY
            if (txtReferencia.Text == "")
            {
                MessageBox.Show("Campos com * são obrigatório", "Chave Primária", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //POPULATE
            int refe = Convert.ToInt32(txtReferencia.Text.Substring(10, 9));
            dado.Titulo = cboAtividade.Text + "-" + txtCidade.Text + "-" + Convert.ToString(refe) + "\n\n" + "● Prazo: " + dtpPrazo.Value.ToString("dd/MM/yyyy") + "\nCliente: " + txtNomeCliente.Text.Replace(" ", " ");
            dado.Referencia = txtReferencia.Text;
            dado.Agencia = Agencia;
            if (txtDataOrdem.Text != "")
                dado.Data_ordem = Convert.ToDateTime(txtDataOrdem.Text);
            dado.Prazo_execucao = dtpPrazo.Value;
            dado.Profissional_cod = cboProfissional.Text;
            dado.Atividade_cod = cboAtividade.Text;
            dado.Siopi = chkSiopi.Checked;
            dado.Nome_cliente = txtNomeCliente.Text;
            dado.Cidade = txtCidade.Text;
            dado.Nome_contato = txtNomeContato.Text;
            dado.Telefone_contato = txtTelefoneContato.Text;
            dado.Coordenada = txtCoordenada.Text;
            if (rbtRecebida.Checked)
                dado.Status = "RECEBIDA";
            else if (rbtPendente.Checked)
                dado.Status = "PENDENTE";
            else if (rbtVistoriada.Checked)
                dado.Status = "VISTORIADA";
            else
                dado.Status = "CONCLUÍDA";
            if (txtDataPendente.Text != "  /  /")
                dado.Data_pendente = Convert.ToDateTime(txtDataPendente.Text);
            if (txtDataVistoria.Text != "  /  /")
                dado.Data_vistoria = Convert.ToDateTime(txtDataVistoria.Text);
            if (txtDataConcluida.Text != "  /  /")
                dado.Data_concluida = Convert.ToDateTime(txtDataConcluida.Text);
            dado.Obs = txtOBS.Text;

            //INSERT OR UPDATE
            if (btnAddSave.Text == "&Adicionar")
            {
                try
                {
                    osmodel.InsertOsModel(dado);
                    DT.OS = osmodel.ListarOsModel();
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Duplicata du champ"))
                    {
                        MessageBox.Show($"Ordem de Serviço '{txtReferencia.Text}' já cadastrada!", "Código existente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                try
                {
                    osmodel.UpdateOsModel(dado);
                    DT.OS = osmodel.ListarOsModel();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            this.Close();
            if (FormFilho == "frmOSLista")
            {
                frmOSLista formFilho = new frmOSLista(_frmPrincipal);
                _frmPrincipal.AbrirFormInPanel(formFilho, _frmPrincipal.pnlMain);
            }
            else
            {
                frmOSFluxo formFilho = new frmOSFluxo(_frmPrincipal);
                _frmPrincipal.AbrirFormInPanel(formFilho, _frmPrincipal.pnlMain);
            }


        }

        private void btnAddAgencia_Click(object sender, EventArgs e)
        {
            AgenciasENT dado = new AgenciasENT();
            dado.Agencia = txtReferencia.Text.Substring(5, 4);

            frmAddAgencia form = new frmAddAgencia(txtReferencia.Text.Substring(5, 4));
            form.Text = "Adicionar";

            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            form.Size = new System.Drawing.Size(650, 600);
            form.ShowDialog();
            BuscarAgencia();
            txtNomeCliente.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            if (FormFilho == "frmRelatorios")
            {
                frmOSLista formFilho = new frmOSLista(_frmPrincipal);
                _frmPrincipal.AbrirFormInPanel(formFilho, _frmPrincipal.pnlMain);
            }
            else
            {
                frmOSFluxo formFilho = new frmOSFluxo(_frmPrincipal);
                _frmPrincipal.AbrirFormInPanel(formFilho, _frmPrincipal.pnlMain);
            }
        }





        ///_______RadioButton
        private void rbtRecebida_CheckedChanged(object sender, EventArgs e)
        {
            txtDataPendente.Hide();
            txtDataVistoria.Hide();
            txtDataConcluida.Hide();
            txtDataOrdem.Focus();
        }

        private void rbtPendente_CheckedChanged(object sender, EventArgs e)
        {
            txtDataPendente.Visible = true;
            txtDataVistoria.Hide();
            txtDataConcluida.Hide();
            txtDataPendente.Focus();
        }

        private void rbtVistoriada_CheckedChanged(object sender, EventArgs e)
        {
            txtDataVistoria.Visible = true;
            txtDataPendente.Hide();
            txtDataConcluida.Hide();
            txtDataVistoria.Focus();
        }

        private void rbtConcluida_CheckedChanged(object sender, EventArgs e)
        {
            txtDataConcluida.Visible = true;
            txtDataVistoria.Visible = true;
            txtDataPendente.Hide();
            txtDataConcluida.Focus();
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





        ///_______TextBox
        private void txtReferencia_Validated(object sender, EventArgs e)
        {
            if (txtReferencia.Text == "    .    .         /    .  .  .")
            {
                txtReferencia.Mask = "";
                txtAgenciaNome.Text = "";
                txtAgenciaTelefone.Text = "";
                txtAgenciaEmail.Text = "";
            }
            else
                if (txtReferencia.Text.Substring(5, 4) != Agencia)
                BuscarAgencia();
        }





        ///_______MaskedTextBox
        private void txtTelefoneContato_Enter(object sender, EventArgs e)
        {
            txtTelefoneContato.Mask = "(99) ##########";
        }

        private void txtTelefoneContato_Validated(object sender, EventArgs e)
        {
            if (txtTelefoneContato.Text == "(  ) ")
            {
                txtTelefoneContato.Mask = "";
                return;
            }

            var apenasDigitos = new Regex(@"[^\d]");
            if (apenasDigitos.Replace(txtTelefoneContato.Text, "").Length == 10)
                txtTelefoneContato.Mask = "(99) #########";
            else if (apenasDigitos.Replace(txtTelefoneContato.Text, "").Length == 11)
                txtTelefoneContato.Mask = "(99) ##########";
        }

        private void txtReferencia_Enter(object sender, EventArgs e)
        {
            txtReferencia.Mask = "0000,0000,000000000/0000,00,00,00";
        }

        private void txtDataOrdem_Validated(object sender, EventArgs e)
        {
            dtpPrazo.Text = (DateTime.Parse(txtDataOrdem.Text).AddDays(5)).ToString("dd/MM/yyyy");
        }





    }


}
