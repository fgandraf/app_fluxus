using System;
using System.Windows.Forms;
using Fluxus.Model.ENT;
using System.Text.RegularExpressions;
using System.Data;
using Fluxus.Model;

namespace Fluxus.View
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
                DataRow[] dataRowAgencia = (new AgenciaModel().BuscarAgencia(txtReferencia.Text.Substring(5, 4))).Select();

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
                    _agencia = txtReferencia.Text.Substring(5, 4);
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
            _formFilho = frmfilho;

            DtProfissionais = new ProfissionalModel().ListarCodigoENomeid(false);
            cboProfissional.DataSource = DtProfissionais;

            DtAtividades = new AtividadeModel().ListarAtividades(false);
            cboAtividade.DataSource = DtAtividades;

            //cboCidade.DataSource = new OsController().GetCidadesDasOrdens(false);
            cboCidade.DataSource = new OsModel().GetCidadesDasOrdens(false);
            cboCidade.SelectedIndex = -1;
        }



        public frmAddOS(frmPrincipal frm1, string frmfilho, OsENT dado)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
            _formFilho = frmfilho;

            DtProfissionais = new ProfissionalModel().ListarCodigoENomeid(false);

            DtAtividades = new AtividadeModel().ListarAtividades(false);

            cboCidade.DataSource = new OsModel().GetCidadesDasOrdens(false);
            cboCidade.SelectedIndex = -1;

            //POPULATE
            cboProfissional.DataSource = DtProfissionais;

            cboAtividade.DataSource = DtAtividades;

            _id = dado.Id;

            txtReferencia.Text = dado.Referencia;
            _agencia = dado.Agencia;
            txtDataOrdem.Text = dado.Data_ordem.ToString();
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
            txtDataPendente.Text = dado.Data_pendente.ToString();
            txtDataVistoria.Text = dado.Data_vistoria.ToString();
            txtDataConcluida.Text = dado.Data_concluida.ToString();
            txtOBS.Text = dado.Obs;




            BuscarNomeProfissional();
            BuscarNomeAtividade();
            BuscarAgencia();

            if (dado.Fatura_cod != 0)
            {
                lblFaturada.Show();
                txtCodFatura.Text = "Fatura: " + new FaturaModel().DescricaoFatura(dado.Fatura_cod);


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
            cboProfissional.Focus();




            if (Logged.Rt && Logged.Rl == false)
            {
                cboProfissional.SelectedValue = Logged.Codpro;
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

            string titulo = cboAtividade.Text + "-" + cboCidade.Text + "-" + Convert.ToString(refe) + "\n\n" + "● Prazo: " + dtpPrazo.Value.ToString("dd/MM/yyyy") + "\nCliente: " + txtNomeCliente.Text.Replace(" ", " ");

            Nullable<DateTime> dataOrdem;
            if (txtDataOrdem.Text != "")
                dataOrdem = Convert.ToDateTime(txtDataOrdem.Text);
            else
                dataOrdem = null;

            string status;
            if (rbtRecebida.Checked)
                status = "RECEBIDA";
            else if (rbtPendente.Checked)
                status = "PENDENTE";
            else if (rbtVistoriada.Checked)
                status = "VISTORIADA";
            else
                status = "CONCLUÍDA";


            Nullable<DateTime> dataPendente;
            if (txtDataPendente.Text != "  /  /")
                dataPendente = Convert.ToDateTime(txtDataPendente.Text);
            else
                dataPendente = null;

            Nullable<DateTime> dataVistoria;
            if (txtDataVistoria.Text != "  /  /")
                dataVistoria = Convert.ToDateTime(txtDataVistoria.Text);
            else
                dataVistoria = null;


            Nullable<DateTime> dataConcluida;
            if (txtDataConcluida.Text != "  /  /")
                dataConcluida = Convert.ToDateTime(txtDataConcluida.Text);
            else
                dataConcluida = null;


            OsENT dado = new OsENT
            {
                Titulo = titulo,
                Referencia = txtReferencia.Text,
                Agencia = _agencia,
                Data_ordem = Convert.ToDateTime(dataOrdem),
                Prazo_execucao = Convert.ToDateTime(dtpPrazo.Value),
                Profissional_cod = cboProfissional.Text,
                Atividade_cod = cboAtividade.Text,
                Siopi = chkSiopi.Checked,
                Nome_cliente = txtNomeCliente.Text,
                Cidade = cboCidade.Text,
                Nome_contato = txtNomeContato.Text,
                Telefone_contato = txtTelefoneContato.Text,
                Coordenada = txtCoordenada.Text,
                Status = status,
                Data_pendente = Convert.ToDateTime(dataPendente),
                Data_vistoria = Convert.ToDateTime(dataVistoria),
                Data_concluida = Convert.ToDateTime(dataConcluida),
                Obs = txtOBS.Text
            };






            //INSERT OR UPDATE
            if (btnAddSave.Text == "&Adicionar")
            {
                try
                {
                    new OsModel().Insert(dado);
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
                    new OsModel().Update(_id, dado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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

        private void btnAddAgencia_Click(object sender, EventArgs e)
        {
            AgenciaENT dado = new AgenciaENT();
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

        private void cboCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.KeyChar = Char.ToUpper(e.KeyChar);
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
                if (txtReferencia.Text.Substring(5, 4) != _agencia)
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
