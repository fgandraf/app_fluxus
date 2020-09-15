using System;
using System.Windows.Forms;
using Arqueng.MODEL;
using Arqueng.ENTIDADES;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;

namespace Arqueng.VIEW
{

    public partial class frmOSLista : Form
    {

        frmPrincipal _frmPrincipal;
        DataView dvOSFiltrada;
        System.Data.DataTable dtOS = new System.Data.DataTable();




        //:MÉTODOS

        private void EditarOS(DataGridView dgv)
        {
            frmAddOS formNeto = new frmAddOS
            (
                _frmPrincipal, this.Name,
                dgv.CurrentRow.Cells[0].Value.ToString(),//referencia
                dgv.CurrentRow.Cells[1].Value.ToString(),//agencia
                dgv.CurrentRow.Cells[2].Value.ToString(),//titulo
                dgv.CurrentRow.Cells[3].Value.ToString(),//data_ordem
                dgv.CurrentRow.Cells[4].Value.ToString(),//prazo_execucao
                dgv.CurrentRow.Cells[5].Value.ToString(),//profissional_cod
                dgv.CurrentRow.Cells[6].Value.ToString(),//atividade_cod
                Convert.ToBoolean(dgv.CurrentRow.Cells[7].Value),//siopi
                dgv.CurrentRow.Cells[8].Value.ToString(),//nome_cliente
                dgv.CurrentRow.Cells[9].Value.ToString(),//cidade
                dgv.CurrentRow.Cells[10].Value.ToString(),//nome_contato
                dgv.CurrentRow.Cells[11].Value.ToString(),//telefone_contato
                dgv.CurrentRow.Cells[12].Value.ToString(),//coordenada
                dgv.CurrentRow.Cells[13].Value.ToString(),//status
                dgv.CurrentRow.Cells[14].Value.ToString(),//data_pendente
                dgv.CurrentRow.Cells[15].Value.ToString(),//data_vistoria
                dgv.CurrentRow.Cells[16].Value.ToString(),//data_concluida
                dgv.CurrentRow.Cells[17].Value.ToString(),//obs
                dgv.CurrentRow.Cells[18].Value.ToString()//fatura_cod
            );
            formNeto.Text = "Alterar";
            _frmPrincipal.AbrirFormInPanel(formNeto, _frmPrincipal.pnlMain);
        }

        private void ExcluirOS(DataGridView dgv)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                try
                {
                    OsMODEL model = new OsMODEL();
                    ENTIDADES.OsENT dado = new ENTIDADES.OsENT();
                    dado.Referencia = dgv.CurrentRow.Cells["referencia"].Value.ToString();
                    model.DeleteOsModel(dado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ListarOS(DataGridView dgv)
        {
            try
            {
                OsMODEL model = new OsMODEL();
                dtOS = model.ListarOSFiltradaModel(GerarStringSQL());
                dgvOS.DataSource = dtOS;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lblTotalRegistros.Text = dgvOS.Rows.Count.ToString();
        }

        //private string GerarFiltro()
        //{
        //    string faturadas;
        //    {
        //        if (cboFaturadas.SelectedIndex == 0)
        //            faturadas = ">= 0";
        //        else if (cboFaturadas.SelectedIndex == 1)
        //            faturadas = "> 0";
        //        else
        //            faturadas = "= 0";
        //    }

        //    string profissional;
        //    {
        //        if (cboProfissional.SelectedValue.ToString() == "")
        //            profissional = "<> ' '";
        //        else
        //            profissional = "= '" + cboProfissional.SelectedValue.ToString() + "'";
        //    }

        //    string atividade;
        //    {
        //        if (cboAtividade.SelectedIndex == 0)
        //            atividade = "<> ' '";
        //        else
        //            atividade = "= '" + cboAtividade.SelectedValue.ToString() + "'";
        //    }

        //    string cidade;
        //    {
        //        if (cboCidade.SelectedIndex == 0)
        //            cidade = "<> ' '";
        //        else
        //            cidade = "= '" + cboCidade.SelectedValue.ToString() + "'";
        //    }

        //    string status;
        //    {
        //        if (cboStatus.SelectedIndex == 0)
        //            status = "<> ' '";
        //        else
        //            status = "= '" + cboStatus.SelectedItem + "'";
        //    }

        //    string filtro = String.Format("profissional_cod {0} AND atividade_cod {1} AND cidade {2} AND status {3} AND fatura_cod {4}", profissional, atividade, cidade, status, faturadas);

        //    return filtro;
        //}

        private void LimparFiltro()
        {
            cboProfissional.SelectedIndex = 0;
            cboCidade.SelectedIndex = 0;
            cboAtividade.SelectedIndex = 0;
            cboFaturadas.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            txtPesquisar.Text = null;
            dvOSFiltrada = new DataView();
        }

        private string GerarStringSQL()
        {
            string profissional;
            {
                if (cboProfissional.SelectedValue.ToString() == "")
                    profissional = "<> ' '";
                else
                    profissional = "= '" + cboProfissional.SelectedValue.ToString() + "'";
            }

            string faturadas;
            {
                if (cboFaturadas.SelectedIndex == 0)
                    faturadas = ">= 0";
                else if (cboFaturadas.SelectedIndex == 1)
                    faturadas = "> 0";
                else
                    faturadas = "= 0";
            }



            string atividade;
            {
                if (cboAtividade.SelectedIndex == 0)
                    atividade = "<> ' '";
                else
                    atividade = "= '" + cboAtividade.SelectedValue.ToString() + "'";
            }

            string cidade;
            {
                if (cboCidade.SelectedIndex == 0)
                    cidade = "<> ' '";
                else
                    cidade = "= '" + cboCidade.SelectedValue.ToString() + "'";
            }

            string status;
            {
                if (cboStatus.SelectedIndex == 0)
                    status = "<> ' '";
                else
                    status = "= '" + cboStatus.SelectedItem + "'";
            }

            string filtro = String.Format("SELECT * from tb_os WHERE profissional_cod {0} AND atividade_cod {1} AND cidade {2} AND status {3} AND fatura_cod {4} ORDER BY data_ordem", profissional, atividade, cidade, status, faturadas);

            return filtro;
        }





        //:EVENTOS

        ///_______FORMULÁRIO
        public frmOSLista(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
        }

        private void frmOS_Load(object sender, EventArgs e)
        {
            ProfissionaisMODEL promodel = new ProfissionaisMODEL();
            cboProfissional.DataSource = promodel.ListarCodigoENomeidModel(true);
            cboCidade.DataSource = Globais.Cidades(true);
            cboAtividade.DataSource = Globais.Atividades(true);
            LimparFiltro();

            if (Globais.Rt)
                cboProfissional.SelectedValue = Globais.Codpro;
            else
                cboProfissional.SelectedIndex = 0;

            cboFaturadas.SelectedIndex = 2;

            ListarOS(dgvOS);
            lblTotalRegistros.Text = dgvOS.Rows.Count.ToString();
            btnLimparFiltro.Show();


        }





        ///_______BOTÔES
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvOS.CurrentRow.Cells["fatura_cod"].Value.ToString() != "0")
            {
                MessageBox.Show("Não é possível excluir uma Ordem de Serviço já faturada!", "OS já faturada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                ExcluirOS(dgvOS);
                ListarOS(dgvOS);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarOS(dgvOS);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            //OsMODEL model = new OsMODEL();
            //dgvOS.DataSource = model.ListarOSFiltradaModel(GerarStringSQL());
            //dvOSFiltrada = new DataView(dtOS);
            //dvOSFiltrada.RowFilter = GerarFiltro();
            //dgvOS.DataSource = dvOSFiltrada;
            ListarOS(dgvOS);
            lblTotalRegistros.Text = dgvOS.Rows.Count.ToString();
            btnLimparFiltro.Show();
        }

        private void btnLimparFiltro_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente prosseguir?" + "\n\n" + "Isto irá retornar todas as ordens de serviços existentes no banco de dados." + "\n\n" + "O processo pode ser lento dependendo do tamanho da base.", "Limpar filtro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                LimparFiltro();
                ListarOS(dgvOS);
                btnLimparFiltro.Hide();
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvOS.Rows.Count > 0)
            {
                Excel.Application XcelApp = new Excel.Application();
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);


                    ////Titulo das células
                    XcelApp.Cells[1, 1] = dgvOS.Columns["profissional_cod"].HeaderText;
                    XcelApp.Cells[1, 2] = dgvOS.Columns["status"].HeaderText;
                    XcelApp.Cells[1, 3] = dgvOS.Columns["data_ordem"].HeaderText;
                    XcelApp.Cells[1, 4] = dgvOS.Columns["prazo_execucao"].HeaderText;
                    XcelApp.Cells[1, 5] = dgvOS.Columns["referencia"].HeaderText;
                    XcelApp.Cells[1, 6] = dgvOS.Columns["atividade_cod"].HeaderText;
                    XcelApp.Cells[1, 7] = dgvOS.Columns["cidade"].HeaderText;
                    XcelApp.Cells[1, 8] = dgvOS.Columns["agencia"].HeaderText;
                    XcelApp.Cells[1, 9] = dgvOS.Columns["siopi"].HeaderText;
                    XcelApp.Cells[1, 10] = dgvOS.Columns["nome_cliente"].HeaderText;
                    XcelApp.Cells[1, 11] = dgvOS.Columns["nome_contato"].HeaderText;
                    XcelApp.Cells[1, 12] = dgvOS.Columns["telefone_contato"].HeaderText;
                    XcelApp.Cells[1, 13] = dgvOS.Columns["data_pendente"].HeaderText;
                    XcelApp.Cells[1, 14] = dgvOS.Columns["data_vistoria"].HeaderText;
                    XcelApp.Cells[1, 15] = dgvOS.Columns["data_concluida"].HeaderText;
                    XcelApp.Cells[1, 16] = dgvOS.Columns["coordenada"].HeaderText;
                    XcelApp.Cells[1, 17] = dgvOS.Columns["obs"].HeaderText;


                    //Linhas
                    for (int i = 0; i < dgvOS.RowCount - 1; i++)
                    {
                        //for (int j = 0; j < dgvOS.ColumnCount; j++)
                        XcelApp.Cells[i + 2, 1] = dgvOS.Rows[i].Cells["profissional_cod"].Value.ToString();
                        XcelApp.Cells[i + 2, 2] = dgvOS.Rows[i].Cells["status"].Value.ToString();

                        if (((DateTime)dgvOS.Rows[i].Cells["data_ordem"].Value).ToString("dd/MM/yyyy") != "01/01/0001")
                            XcelApp.Cells[i + 2, 3] = ((DateTime)dgvOS.Rows[i].Cells["data_ordem"].Value).ToString("MM/dd/yyyy");
                        
                        if (((DateTime)dgvOS.Rows[i].Cells["prazo_execucao"].Value).ToString("dd/MM/yyyy") != "01/01/0001")
                            XcelApp.Cells[i + 2, 4] = ((DateTime)dgvOS.Rows[i].Cells["prazo_execucao"].Value).ToString("MM/dd/yyyy");
                        
                        XcelApp.Cells[i + 2, 5] = dgvOS.Rows[i].Cells["referencia"].Value.ToString();
                        XcelApp.Cells[i + 2, 6] = dgvOS.Rows[i].Cells["atividade_cod"].Value.ToString();
                        XcelApp.Cells[i + 2, 7] = dgvOS.Rows[i].Cells["cidade"].Value.ToString();
                        XcelApp.Cells[i + 2, 8] = dgvOS.Rows[i].Cells["agencia"].Value.ToString();

                        if (Convert.ToBoolean(dgvOS.Rows[i].Cells["siopi"].Value) == true)
                            XcelApp.Cells[i + 2, 9] = "✔";
                        else
                            XcelApp.Cells[i + 2, 9] = "✘";

                        XcelApp.Cells[i + 2, 10] = dgvOS.Rows[i].Cells["nome_cliente"].Value.ToString();
                        XcelApp.Cells[i + 2, 11] = dgvOS.Rows[i].Cells["nome_contato"].Value.ToString();
                        XcelApp.Cells[i + 2, 12] = dgvOS.Rows[i].Cells["telefone_contato"].Value.ToString();
                        
                        if (((DateTime)dgvOS.Rows[i].Cells["data_pendente"].Value).ToString("dd/MM/yyyy") != "01/01/0001")
                            XcelApp.Cells[i + 2, 13] = ((DateTime)dgvOS.Rows[i].Cells["data_pendente"].Value).ToString("MM/dd/yyyy");
                        
                        if (((DateTime)dgvOS.Rows[i].Cells["data_vistoria"].Value).ToString("dd/MM/yyyy") != "01/01/0001")
                            XcelApp.Cells[i + 2, 14] = ((DateTime)dgvOS.Rows[i].Cells["data_vistoria"].Value).ToString("MM/dd/yyyy");
                        
                        if (((DateTime)dgvOS.Rows[i].Cells["data_concluida"].Value).ToString("dd/MM/yyyy") != "01/01/0001")
                            XcelApp.Cells[i + 2, 15] = ((DateTime)dgvOS.Rows[i].Cells["data_concluida"].Value).ToString("MM/dd/yyyy");
                        
                        XcelApp.Cells[i + 2, 16] = dgvOS.Rows[i].Cells["coordenada"].Value.ToString();
                        XcelApp.Cells[i + 2, 17] = dgvOS.Rows[i].Cells["obs"].Value.ToString();
                    }


                    //Configurações
                    XcelApp.Columns.AutoFit();
                    //XcelApp.Columns.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    XcelApp.Rows.RowHeight = 15;


                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                    XcelApp.Quit();
                }

            }
        }




        ///_______DATAGRIDVIEW
        private void dgvOS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvOS.CurrentCell.Selected)
            {
                if (dgvOS.CurrentRow.Cells["fatura_cod"].Value.ToString() != "0")
                {
                    MessageBox.Show("Não é possível excluir uma Ordem de Serviço já faturada!", "OS já faturada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    ExcluirOS(dgvOS);
                    ListarOS(dgvOS);
                }
            }
        }

        private void dgvOS_DoubleClick(object sender, EventArgs e)
        {
            EditarOS(dgvOS);
        }





        ///_______TEXTBOX PESQUISAR
        private void txtPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPesquisar.Text == "")// && btnLimparFiltro.Visible == false)
                dgvOS.DataSource = dtOS;
            //else if (txtPesquisar.Text == "" && btnLimparFiltro.Visible == true)
            //    dgvOS.DataSource = dtOS;//dgvOS.DataSource = dvOSFiltrada;
            else
            {
                if (btnLimparFiltro.Visible == true)
                {
                    System.Data.DataTable dtFiltrada = dtOS.Copy();//dvOSFiltrada.ToTable();
                    DataView dvPesquisa = new DataView(dtFiltrada);
                    dvPesquisa.RowFilter = String.Format("nome_cliente LIKE '%{0}%' OR referencia LIKE '%{0}%' OR atividade_cod LIKE '%{0}%' OR cidade LIKE '%{0}%' OR nome_contato LIKE '%{0}%' OR profissional_cod LIKE '%{0}%' OR status LIKE '%{0}%'", txtPesquisar.Text);
                    dgvOS.DataSource = dvPesquisa;
                }
                else
                {
                    DataView dvPesquisa = new DataView(dtOS);
                    dvPesquisa.RowFilter = String.Format("nome_cliente LIKE '%{0}%' OR referencia LIKE '%{0}%' OR atividade_cod LIKE '%{0}%' OR cidade LIKE '%{0}%' OR nome_contato LIKE '%{0}%' OR profissional_cod LIKE '%{0}%' OR status LIKE '%{0}%'", txtPesquisar.Text);
                    dgvOS.DataSource = dvPesquisa;
                }
            }
            lblTotalRegistros.Text = dgvOS.Rows.Count.ToString();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddOS formNeto = new frmAddOS(_frmPrincipal, this.Name);
            formNeto.Text = "Adicionar";
            _frmPrincipal.AbrirFormInPanel(formNeto, _frmPrincipal.pnlMain);
        }


    }
}


