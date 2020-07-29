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
        string _formFilho;

        OsENT dado = new OsENT();
        OsMODEL osmodel = new OsMODEL();
        ProfissionaisMODEL profmodel = new ProfissionaisMODEL();
        AtividadesMODEL ativmodel = new AtividadesMODEL();
        AgenciasMODEL agmodel = new AgenciasMODEL();
        string agencia = null;


        public void ListarProfissionais()
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


        public void ListarAtividades()
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


        public void BuscarNomeAtividade()
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


        public void BuscarNomeProfissional()
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


        public void BuscarAgencia()
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
                    agencia = txtReferencia.Text.Substring(5, 4);
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
            _formFilho = frmfilho;
            ListarProfissionais();
            ListarAtividades();
        }


        public frmAddOS(frmPrincipal frm1, string frmfilho, string Titulo, string Referencia, string DataOrdem, string Prazo_execucao, string Profissional_cod, string Atividade_cod, string Siopi, string Nome_cliente, string Cidade, string Nome_contato, string Telefone_contato, string Status, string Data_pendente, string Data_vistoria, string Data_concluida, string OBS, string Fatura_cod)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
            _formFilho = frmfilho;

            ListarProfissionais();
            ListarAtividades();

            dado.Titulo = Titulo;
            txtReferencia.Text = Referencia;
            dtpDataOrdem.Text = DataOrdem;
            dtpDataExecucao.Text = Prazo_execucao;
            cboProfissional.Text = Profissional_cod;
            cboAtividade.Text = Atividade_cod;

            if (Siopi == "True")
                chkSiopi.Checked = true;
            else
                chkSiopi.Checked = false;

            txtNomeCliente.Text = Nome_cliente;
            txtCidade.Text = Cidade;
            txtNomeContato.Text = Nome_contato;
            txtTelefoneContato.Text = Telefone_contato;

            if (Status == "RECEBIDA")
            {
                rbtRecebida.Checked = true;
            }

            if (Status == "PENDENTE")
            {
                rbtPendente.Checked = true;
            }

            if (Status == "VISTORIADA")
            {
                rbtVistoriada.Checked = true;
            }

            if (Status == "CONCLUÍDA")
            {
                rbtConcluida.Checked = true;
            }

            dtpDataPendente.Text = Data_pendente;
            dtpDataVistoria.Text = Data_vistoria;
            dtpDataConcluida.Text = Data_concluida;
            txtOBS.Text = OBS;

            BuscarNomeProfissional();
            BuscarNomeAtividade();
            BuscarAgencia();

            if (Fatura_cod != "0")
            {
                lblFaturada.Show();
                txtCodFatura.Text = "Fatura n°: " + Fatura_cod;
                txtCodFatura.Show();

                foreach (Control c in this.pnlDados.Controls)
                {
                    if (c is TextBox || c is MaskedTextBox || c is CheckBox || c is DateTimePicker || c is RadioButton)
                        c.Enabled = false;
                }
                cboAtividade.Enabled = false;
                cboProfissional.Enabled = false;
                txtOBS.Enabled = false;
                btnAddSave.Enabled = false;
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
                dtpDataExecucao.Value = dtpDataExecucao.Value.AddDays(5);
            }
            dtpDataOrdem.Focus();
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
            dado.Titulo = cboAtividade.Text + "-" + txtCidade.Text + "-" + Convert.ToString(refe);
            dado.Referencia = txtReferencia.Text;
            dado.Data_ordem = dtpDataOrdem.Value;
            dado.Prazo_execucao = dtpDataExecucao.Value;
            dado.Profissional_cod = cboProfissional.Text;
            dado.Atividade_cod = cboAtividade.Text;
            dado.Siopi = chkSiopi.Checked;
            dado.Nome_cliente = txtNomeCliente.Text;
            dado.Cidade = txtCidade.Text;
            dado.Nome_contato = txtNomeContato.Text;
            dado.Telefone_contato = txtTelefoneContato.Text;
            if (rbtRecebida.Checked)
            {
                dado.Status = "RECEBIDA";
            }
            if (rbtPendente.Checked)
            {
                dado.Status = "PENDENTE";
            }
            if (rbtVistoriada.Checked)
            {
                dado.Status = "VISTORIADA";
            }
            if (rbtConcluida.Checked)
            {
                dado.Status = "CONCLUÍDA";
            }
            dado.Data_pendente = dtpDataPendente.Value;
            dado.Data_vistoria = dtpDataVistoria.Value;
            dado.Data_concluida = dtpDataConcluida.Value;
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
            if (_formFilho == "frmOSLista")
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
            dtpDataVistoria.Visible = true;
            dtpDataPendente.Hide();
            dtpDataConcluida.Hide();
        }


        private void rbtConcluida_CheckedChanged(object sender, EventArgs e)
        {
            dtpDataConcluida.Visible = true;
            dtpDataVistoria.Visible = true;
            dtpDataPendente.Hide();
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
        }


        private void dtpDataOrdem_Validated(object sender, EventArgs e)
        {
            dtpDataExecucao.Value = dtpDataOrdem.Value.AddDays(5);
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
                if (txtReferencia.Text.Substring(5, 4) != agencia)
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
            if (_formFilho == "frmOSLista")
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
    }


}
