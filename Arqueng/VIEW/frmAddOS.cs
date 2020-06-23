using System;
using System.Windows.Forms;
using Arqueng.MODEL;
using Arqueng.ENTIDADES;

namespace Arqueng.VIEW
{
    public partial class frmAddOS : Form
    {

        OsMODEL osmodel = new OsMODEL();
        ProfissionaisMODEL profmodel = new ProfissionaisMODEL();
        AtividadesMODEL ativmodel = new AtividadesMODEL();
        AgenciasMODEL agmodel = new AgenciasMODEL();
        
        OsENT dado = new OsENT();

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

                if (dado.Nome == null)
                    lblNomeProfissional.Text = "Profissional não cadastrado!";
                else
                    lblNomeProfissional.Text = dado.Nome;
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
                    btnAddAgencia.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public frmAddOS()
        {
            InitializeComponent();
            ListarProfissionais();
            ListarAtividades();
        }

        public frmAddOS(string Id, string Titulo, string Referencia, string DataOrdem, string DataExecucao, string Profissional, string Atividade, string Siopi, string NomeCliente, string Cidade, string NomeContato, string TelefoneContato, string Status, string DataPendente, string DataVistoria, string DataConcluida, string OBS, string Faturada, string CodFatura)
        {
            InitializeComponent();
            ListarProfissionais();
            ListarAtividades();

            dado.Id = Id;
            dado.Titulo = Titulo;
            txtReferencia.Text = Referencia;
            dtpDataOrdem.Text = DataOrdem;
            dtpDataExecucao.Text = DataExecucao;
            cboProfissional.Text = Profissional;
            cboAtividade.Text = Atividade;
            if (Siopi == "True")
                chkSiopi.Checked = true;
            else
                chkSiopi.Checked = false;
            txtNomeCliente.Text = NomeCliente;
            txtCidade.Text = Cidade;
            txtNomeContato.Text = NomeContato;
            txtTelefoneContato.Text = TelefoneContato;
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
            dtpDataPendente.Text = DataPendente;
            dtpDataVistoria.Text = DataVistoria;
            dtpDataConcluida.Text = DataConcluida;
            txtOBS.Text = OBS;

            BuscarNomeProfissional();
            BuscarNomeAtividade();
            BuscarAgencia();

            if (Faturada == "1")
            {
                lblFaturada.Show();
                txtCodFatura.Text = "Fatura n°: " + CodFatura;
                txtCodFatura.Show();
                foreach (Control c in this.pnlDados.Controls)
                {
                    if (c is TextBox || c is MaskedTextBox || c is CheckBox || c is DateTimePicker)
                        c.Enabled = false;
                }
                cboAtividade.Enabled = false;
                cboProfissional.Enabled = false;
                txtOBS.Enabled = false;
                btnAddSave.Enabled = false;
                tlpStatus.Enabled = false;
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
            dado.Titulo = txtCidade.Text + "-" + Convert.ToString(refe);
            dado.Referencia = txtReferencia.Text;
            dado.Data_ordem = dtpDataOrdem.Value;
            dado.Prazo_execucao = dtpDataExecucao.Value;
            dado.Profissional_cod = cboProfissional.Text;
            //CASO O DisplayMember FOR DIFERENTE DO ValueMember:
            //dado.Profissional_cod = Convert.ToString(cboProfissional.SelectedValue);
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
                    MessageBox.Show(ex.Message);
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
            BuscarAgencia();
        }

        private void btnAddAgencia_Click(object sender, EventArgs e)
        {
            AgenciasENT dado = new AgenciasENT();
            dado.Agencia = txtReferencia.Text.Substring(5, 4);
            frmAddAgencia form = new frmAddAgencia();
            form.Text = "Adicionar";
            form.ShowDialog();
            BuscarAgencia();
            txtCidade.Focus();
        }
    }
}
