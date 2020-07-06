﻿using System;
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
            ListarAtividades();   //proffi sopi contato
        }

        /*
         *      dgvOS.CurrentRow.Cells[0].Value.ToString(),//id
                dgvOS.CurrentRow.Cells[1].Value.ToString(),//titulo
                dgvOS.CurrentRow.Cells[2].Value.ToString(),//referencia
                dgvOS.CurrentRow.Cells[3].Value.ToString(),//data_ordem
                dgvOS.CurrentRow.Cells[4].Value.ToString(),//prazo_execucao
                dgvOS.CurrentRow.Cells[5].Value.ToString(),//profissional_cod
                dgvOS.CurrentRow.Cells[6].Value.ToString(),//atividade_cod
                dgvOS.CurrentRow.Cells[7].Value.ToString(),//siopi
                dgvOS.CurrentRow.Cells[8].Value.ToString(),//nome_cliente
                dgvOS.CurrentRow.Cells[9].Value.ToString(),//cidade
                dgvOS.CurrentRow.Cells[10].Value.ToString(),//nome_contato
                dgvOS.CurrentRow.Cells[11].Value.ToString(),//telefone_contato
                dgvOS.CurrentRow.Cells[12].Value.ToString(),//status
                dgvOS.CurrentRow.Cells[13].Value.ToString(),//data_pendente
                dgvOS.CurrentRow.Cells[14].Value.ToString(),//data_vistoria
                dgvOS.CurrentRow.Cells[15].Value.ToString(),//data_concluida
                dgvOS.CurrentRow.Cells[16].Value.ToString(),//obs
                dgvOS.CurrentRow.Cells[17].Value.ToString()//fatura_cod   
         */

        public frmAddOS(string Id, string Titulo, string Referencia, string DataOrdem, string Prazo_execucao, string Profissional_cod, string Atividade_cod, string Siopi, string Nome_cliente, string Cidade, string Nome_contato, string Telefone_contato, string Status, string Data_pendente, string Data_vistoria, string Data_concluida, string OBS, string Fatura_cod)
        {
            InitializeComponent();
            ListarProfissionais();
            ListarAtividades();

            dado.Id = Id;
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
