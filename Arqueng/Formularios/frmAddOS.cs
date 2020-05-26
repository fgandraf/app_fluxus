using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Arqueng.Entidades;
using MySql.Data.MySqlClient;


namespace Arqueng.Formularios
{
    public partial class frmAddOS : Form
    {
        
        public void BuscarProfissionais()
        {
            try
            {
                My.conexaoDB = new MySqlConnection(My.dadosdb);
                My.da = new MySqlDataAdapter("SELECT codigo, nome FROM tb_profissionais order by codigo", My.conexaoDB);
                DataTable dt = new DataTable();
                My.da.Fill(dt);
                cboProfissional.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                My.conexaoDB.Close();
                My.conexaoDB = null;
            }
        }

        public void BuscarAtividades()
        {
            try
            {
                My.conexaoDB = new MySqlConnection(My.dadosdb);
                My.da = new MySqlDataAdapter("SELECT * FROM tb_atividades order by codigo", My.conexaoDB);
                DataTable dt = new DataTable();
                My.da.Fill(dt);
                cboAtividade.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                My.conexaoDB.Close();
                My.conexaoDB = null;
            }
        }

        public void BuscarNomeProfissional()
        {
            try
            {
                My.conexaoDB = new MySqlConnection(My.dadosdb);
                My.comando = new MySqlCommand("SELECT nome FROM tb_profissionais WHERE codigo = @codigo", My.conexaoDB);
                My.comando.Parameters.AddWithValue("@codigo", cboProfissional.Text);
                My.conexaoDB.Open();
                My.dr = My.comando.ExecuteReader();
                if (My.dr.HasRows == false)
                {
                    MessageBox.Show("Profissional não cadastrado!", "Não encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    while (My.dr.Read())
                    {
                        txtNomeProfissional.Text = Convert.ToString(My.dr["nome"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                My.conexaoDB.Close();
                My.conexaoDB = null;
            }
        }
        public frmAddOS()
        {
            InitializeComponent();
            BuscarProfissionais();
            BuscarAtividades();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void frmAddOS_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        public frmAddOS(string Referencia, string DataOrdem, string DataExecucao, string Profissional, string Atividade, string Siopi, string NomeCliente, string Cidade, string NomeContato, string TelefoneContato, string Status, string DataVistoria, string DataConcluida, string OBS, string CodFatura)
        {
            InitializeComponent();
            BuscarProfissionais();
            BuscarAtividades();
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
            dtpDataVistoria.Text = DataVistoria;
            dtpDataConcluida.Text = DataConcluida;
            txtOBS.Text = OBS;
            txtCodFatura.Text = CodFatura;
            BuscarNomeProfissional();
        }


        private void btnAddSave_Click(object sender, EventArgs e)
        {
            if (btnAddSave.Text == "&Adicionar")
            {
                if (txtReferencia.Text == "")
                    MessageBox.Show("Campos com * são obrigatório", "Chave Primária", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    try
                    {
                        My.conexaoDB = new MySqlConnection(My.dadosdb);
                        My.comando = new MySqlCommand("INSERT INTO tb_os(referencia, data_ordem, prazo_execucao, profissional_cod, atividade_cod, siopi, nome_cliente, cidade, nome_contato, telefone_contato, status, data_vistoria, data_concluida, obs, fatura_cod) VALUES (@referencia, @data_ordem, @prazo_execucao, @profissional_cod, @atividade_cod, @siopi, @nome_cliente, @cidade, @nome_contato, @telefone_contato, @status, @data_vistoria, @data_concluida, @obs, @fatura_cod)", My.conexaoDB);

                        My.comando.Parameters.AddWithValue("@referencia", txtReferencia.Text);
                        My.comando.Parameters.AddWithValue("@data_ordem", dtpDataOrdem.Value);
                        My.comando.Parameters.AddWithValue("@prazo_execucao", dtpDataExecucao.Value);
                        My.comando.Parameters.AddWithValue("@profissional_cod", cboProfissional.Text);
                        My.comando.Parameters.AddWithValue("@atividade_cod", cboAtividade.Text);
                        My.comando.Parameters.AddWithValue("@siopi", chkSiopi.Checked);
                        My.comando.Parameters.AddWithValue("@nome_cliente", txtNomeCliente.Text);
                        My.comando.Parameters.AddWithValue("@cidade", txtCidade.Text);
                        My.comando.Parameters.AddWithValue("@nome_contato", txtNomeContato.Text);
                        My.comando.Parameters.AddWithValue("@telefone_contato", txtTelefoneContato.Text);
                        if (rbtRecebida.Checked)
                        {
                            My.comando.Parameters.AddWithValue("@status", "RECEBIDA");
                        }
                        if (rbtPendente.Checked)
                        {
                            My.comando.Parameters.AddWithValue("@status", "PENDENTE");
                        }
                        if (rbtVistoriada.Checked)
                        {
                            My.comando.Parameters.AddWithValue("@status", "VISTORIADA");
                        }
                        if (rbtConcluida.Checked)
                        {
                            My.comando.Parameters.AddWithValue("@status", "CONCLUÍDA");
                        }
                        My.comando.Parameters.AddWithValue("@data_vistoria", dtpDataVistoria.Value);
                        My.comando.Parameters.AddWithValue("@data_concluida", dtpDataConcluida.Value);
                        My.comando.Parameters.AddWithValue("@obs", txtOBS.Text);
                        My.comando.Parameters.AddWithValue("@fatura_cod", txtCodFatura.Text);
                        
                        My.conexaoDB.Open();
                        My.comando.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        My.conexaoDB.Close();
                        My.conexaoDB = null;
                        My.comando = null;
                        this.Close();
                    }
                }
            }
            else
            {
                try
                {
                     My.conexaoDB = new MySqlConnection(My.dadosdb);
                     My.comando = new MySqlCommand("UPDATE tb_os SET data_ordem = @data_ordem, prazo_execucao = @prazo_execucao, profissional_cod = @profissional_cod, atividade_cod = @atividade_cod, siopi = @siopi, nome_cliente = @nome_cliente, cidade = @cidade, nome_contato = @nome_contato, telefone_contato = @telefone_contato, status = @status, data_vistoria = @data_vistoria, data_concluida = @data_concluida, obs = @obs, fatura_cod = @fatura_cod WHERE referencia = @referencia", My.conexaoDB);

                         My.comando.Parameters.AddWithValue("@referencia", txtReferencia.Text);
                         My.comando.Parameters.AddWithValue("@data_ordem", dtpDataOrdem.Value);
                         My.comando.Parameters.AddWithValue("@prazo_execucao", dtpDataExecucao.Value);
                         My.comando.Parameters.AddWithValue("@profissional_cod", cboProfissional.Text);
                         My.comando.Parameters.AddWithValue("@atividade_cod", cboAtividade.Text);
                         My.comando.Parameters.AddWithValue("@siopi", chkSiopi.Checked);
                         My.comando.Parameters.AddWithValue("@nome_cliente", txtNomeCliente.Text);
                         My.comando.Parameters.AddWithValue("@cidade", txtCidade.Text);
                         My.comando.Parameters.AddWithValue("@nome_contato", txtNomeContato.Text);
                         My.comando.Parameters.AddWithValue("@telefone_contato", txtTelefoneContato.Text);
                         if (rbtRecebida.Checked)
                         {
                             My.comando.Parameters.AddWithValue("@status", "RECEBIDA");
                         }
                         if (rbtPendente.Checked)
                         {
                             My.comando.Parameters.AddWithValue("@status", "PENDENTE");
                         }
                         if (rbtVistoriada.Checked)
                         {
                             My.comando.Parameters.AddWithValue("@status", "VISTORIADA");
                         }
                         if (rbtConcluida.Checked)
                         {
                             My.comando.Parameters.AddWithValue("@status", "CONCLUÍDA");
                         }
                         My.comando.Parameters.AddWithValue("@data_vistoria", dtpDataVistoria.Value);
                         My.comando.Parameters.AddWithValue("@data_concluida", dtpDataConcluida.Value);
                         My.comando.Parameters.AddWithValue("@obs", txtOBS.Text);
                         My.comando.Parameters.AddWithValue("@fatura_cod", txtCodFatura.Text);

                     My.conexaoDB.Open();
                     My.comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    My.conexaoDB.Close();
                    My.conexaoDB = null;
                    My.comando = null;
                    this.Close();
                }
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
                cboProfissional.SelectedItem = null;
                cboAtividade.Text = "";
            }
                
        }

        private void cboProfissional_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BuscarNomeProfissional();
        }

        private void btnAddProfissional_Click(object sender, EventArgs e)
        {
            
        }
    }
}
