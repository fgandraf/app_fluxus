using System;
using System.Windows.Forms;
using Arqueng.MODEL;
using Arqueng.ENTIDADES;
using System.Text.RegularExpressions;

namespace Arqueng.VIEW
{

    public partial class frmAddOS : Form
    {

        frmPrincipal _frmPrincipal;
        private string FormFilho;
        private string Agencia = null;

        OsENT dado = new OsENT();
        OsMODEL osmodel = new OsMODEL();
        ProfissionaisMODEL profmodel = new ProfissionaisMODEL();
        AtividadesMODEL ativmodel = new AtividadesMODEL();
        AgenciasMODEL agmodel = new AgenciasMODEL();



        private void ListarProfissionais()
        {
            try
            {
                cboProfissional.DataSource = profmodel.ListarCodNomeProModel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ListarAtividades()
        {
            try
            {
                cboAtividade.DataSource = ativmodel.ListarAtividadesModel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BuscarNomeAtividade()
        {
            try
            {
                ENTIDADES.AtividadesENT dado = new ENTIDADES.AtividadesENT();
                dado.Codigo = cboAtividade.Text;
                ativmodel.BuscarAtividadesModel(dado);

                if (dado.Descricao == null)
                    lblAtividadeNome.Text = "Atividade não cadastrado!";
                else
                {
                    lblAtividadeNome.Text = dado.Descricao;
                    lblAtividadeValor.Text = dado.Valor_atividade;
                    lblAtividadeDeslocamento.Text = dado.Valor_deslocamento;
                }
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
                ENTIDADES.ProfissionaisENT dado = new ENTIDADES.ProfissionaisENT();
                dado.Codigo = cboProfissional.Text;
                profmodel.BuscarProfissionalModel(dado);

                if (dado.Nomeid == null)
                    lblNomeProfissional.Text = "Profissional não cadastrado!";
                else
                    lblNomeProfissional.Text = dado.Nomeid;
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
                ENTIDADES.AgenciasENT dado = new ENTIDADES.AgenciasENT();
                dado.Agencia = txtReferencia.Text.Substring(5, 4);
                agmodel.BuscarAgenciaModel(dado);

                if (dado.Agencia == null)
                {
                    txtAgenciaNome.Text = "Agência não cadastrado!";
                    txtAgenciaTelefone.Text = "";
                    txtAgenciaEmail.Text = "";
                    btnAddAgencia.Show();
                }
                else
                {
                    txtAgenciaNome.Text = dado.Nome;
                    txtAgenciaTelefone.Text = dado.Telefone1;
                    txtAgenciaEmail.Text = dado.Email;
                    Agencia = txtReferencia.Text.Substring(5, 4);
                    btnAddAgencia.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public frmAddOS(frmPrincipal frm1, string frmfilho)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
            FormFilho = frmfilho;
            ListarProfissionais();
            ListarAtividades();
        }


        public frmAddOS(frmPrincipal frm1, string frmfilho, string titulo, string referencia, string dataordem, string prazoexecucao, string profissionalcod, string atividadecod, bool siopi, string nomecliente, string cidade, string nomecontato, string telefonecontato, string status, string datapendente, string datavistoria, string dataconcluida, string obs, string faturacod)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
            FormFilho = frmfilho;

            ListarProfissionais();
            ListarAtividades();

            dado.Titulo = titulo;
            txtReferencia.Text = referencia;
            txtDataOrdem.Text = dataordem;

            txtPrazo.Text = prazoexecucao;
            
            cboProfissional.Text = profissionalcod;
            cboAtividade.Text = atividadecod;
            chkSiopi.Checked = siopi;
            txtNomeCliente.Text = nomecliente;
            txtCidade.Text = cidade;
            txtNomeContato.Text = nomecontato;
            txtTelefoneContato.Text = telefonecontato;
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
                btnCancelar.Size = new System.Drawing.Size(200,25);
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
                txtPrazo.Text = (DateTime.Parse(txtDataOrdem.Text).AddDays(5)).ToString("dd/MM/yyyy");
            }
            txtDataOrdem.Focus();

            
            if (Globais.Rt && Globais.Rl == false)
            {
                cboProfissional.SelectedValue = Globais.Codpro;
                BuscarNomeProfissional();
                cboProfissional.Enabled = false;
                
            }



        }


        private void btnAddSave_Click(object sender, EventArgs e)
        {
            if (txtReferencia.Text == "")
            {
                MessageBox.Show("Campos com * são obrigatório", "Chave Primária", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //POPULATE
            int refe = Convert.ToInt32(txtReferencia.Text.Substring(10, 9));
            dado.Titulo = cboAtividade.Text + "-" + txtCidade.Text + "-" + Convert.ToString(refe) + "\n\n" + "● Prazo: " + txtPrazo.Text + "\nCliente: " + txtNomeCliente.Text.Replace(" ", " ");




            dado.Referencia = txtReferencia.Text;
            if (txtDataOrdem.Text != "")
                dado.Data_ordem = Convert.ToDateTime(txtDataOrdem.Text);
            if (txtPrazo.Text != "")
                dado.Prazo_execucao = Convert.ToDateTime(txtPrazo.Text);
            dado.Profissional_cod = cboProfissional.Text;
            dado.Atividade_cod = cboAtividade.Text;
            dado.Siopi = chkSiopi.Checked;
            dado.Nome_cliente = txtNomeCliente.Text;
            dado.Cidade = txtCidade.Text;
            dado.Nome_contato = txtNomeContato.Text;
            dado.Telefone_contato = txtTelefoneContato.Text;
            if (rbtRecebida.Checked)
                dado.Status = "RECEBIDA";
            else if (rbtPendente.Checked)
                dado.Status = "PENDENTE";
            else if (rbtVistoriada.Checked)
                dado.Status = "VISTORIADA";
            else
                dado.Status = "CONCLUÍDA";

            if (txtDataPendente.Text != "")
                dado.Data_pendente = Convert.ToDateTime(txtDataPendente.Text);
            if (txtDataVistoria.Text != "")
                dado.Data_vistoria = Convert.ToDateTime(txtDataVistoria.Text);
            if (txtDataConcluida.Text != "")
                dado.Data_concluida = Convert.ToDateTime(txtDataConcluida.Text);



            dado.Obs = txtOBS.Text;


            if (btnAddSave.Text == "&Adicionar")
            {
                try
                {
                    osmodel.InsertOsModel(dado);
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


        private void rbtVistoriada_CheckedChanged(object sender, EventArgs e)
        {
            txtDataVistoria.Visible = true;
            txtDataPendente.Hide();
            txtDataConcluida.Hide();
        }


        private void rbtConcluida_CheckedChanged(object sender, EventArgs e)
        {
            txtDataConcluida.Visible = true;
            txtDataVistoria.Visible = true;
            txtDataPendente.Hide();
        }


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
        }



        private void cboProfissional_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BuscarNomeProfissional();
        }


        private void cboAtividade_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BuscarNomeAtividade();
        }

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


        private void btnAddAgencia_Click(object sender, EventArgs e)
        {
            AgenciasENT dado = new AgenciasENT();
            dado.Agencia = txtReferencia.Text.Substring(5, 4);
            frmAddAgencia form = new frmAddAgencia();
            form.Text = "Adicionar";

            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            form.Size = new System.Drawing.Size(400, 600);
            form.ShowDialog();
            BuscarAgencia();
            txtCidade.Focus();
        }

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
        }

        private void txtReferencia_Enter(object sender, EventArgs e)
        {
            txtReferencia.Mask = "0000,0000,000000000/0000,00,00,00";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
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

        private void txtDataOrdem_Validated(object sender, EventArgs e)
        {
            txtPrazo.Text = (   DateTime.Parse(txtDataOrdem.Text).AddDays(5)   ).ToString("dd/MM/yyyy");
        }

        private void rbtRecebida_Click(object sender, EventArgs e)
        {
            txtDataOrdem.Focus();
        }

        private void rbtPendente_Click(object sender, EventArgs e)
        {
            txtDataPendente.Focus();
        }

        private void rbtVistoriada_Click(object sender, EventArgs e)
        {
            txtDataVistoria.Focus();
        }

        private void rbtConcluida_Click(object sender, EventArgs e)
        {
            txtDataConcluida.Focus();
        }
    }


}
