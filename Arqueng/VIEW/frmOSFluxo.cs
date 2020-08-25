using System;
using System.Windows.Forms;
using Arqueng.MODEL;
using Arqueng.ENTIDADES;
using System.Data;


namespace Arqueng.VIEW
{
    public partial class frmOSFluxo : Form
    {

        frmPrincipal _frmPrincipal;
        OsMODEL model = new OsMODEL();
        OsENT dado = new OsENT();
        Control _lastEnteredControl;
        DataGridView dgvOrigem;



        //:METHODS
        private void ContarRegistros(DataGridView dgv)
        {
            if (dgv.Tag.ToString() == "RECEBIDA")
                lblTitRecebidas.Text = "RECEBIDAS [" + dgv.Rows.Count.ToString() + "]";
            if (dgv.Tag.ToString() == "PENDENTE")
                lblTitPendentes.Text = "PENDENTES [" + dgv.Rows.Count.ToString() + "]";
            if (dgv.Tag.ToString() == "VISTORIADA")
                lblTitVistoriadas.Text = "VISTORIADAS [" + dgv.Rows.Count.ToString() + "]";
            if (dgv.Tag.ToString() == "CONCLUÍDA")
                lblTitConcluidas.Text = "CONCLUÍDAS [" + dgv.Rows.Count.ToString() + "]";
        }

        private void ListarProfissionais()
        {
            try
            {
                DataView dvPro = new DataView(DT.DT_Profissionais);
                DataTable dtPro = dvPro.ToTable("Selected", false, "codigo", "nomeid");
                DataRow linha = dtPro.NewRow();
                linha[1] = "--TODOS--";
                dtPro.Rows.InsertAt(linha, 0);
                cboProfissional.DataSource = dtPro;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarOS(DataGridView dgv)
        {
            try
            {
                DataView dvOS = new DataView(DT.DT_OS);
                if (cboProfissional.SelectedIndex == 0)
                    dvOS.RowFilter = String.Format("status = '{0}' AND fatura_cod = 0", dgv.Tag.ToString());
                else
                    dvOS.RowFilter = String.Format("status = '{0}' AND profissional_cod = '{1}' AND fatura_cod = 0", dgv.Tag.ToString(), cboProfissional.SelectedValue.ToString());
                //DataTable dtOS = dvOS.ToTable("Selected", false, "referencia", "titulo");
                
                dgv.DataSource = dvOS;


                if (dgv.Rows.Count == 0)
                {
                    dgv.Enabled = false;
                }
                else
                {
                    dgv.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ContarRegistros(dgv);
        }

        private void EditarOS(DataGridView dgv, string referencia)
        {




            //DataView dvOS = new DataView(DT.DT_OS);
            //dvOS.RowFilter = ("referencia = '" + referencia + "'");

            //DataTable dtOS = dvOS.ToTable();



            //frmAddOS formNeto = new frmAddOS
            //(
            //    _frmPrincipal, this.Name,
            //    dtOS.Rows[0]["referencia"].ToString(),//referencia
            //    dtOS.Rows[0]["agencia"].ToString(),//agencia
            //    dtOS.Rows[0]["titulo"].ToString(),//titulo
            //    dtOS.Rows[0]["data_ordem"].ToString(),//data_ordem
            //    dtOS.Rows[0]["prazo_execucao"].ToString(),//prazo_execucao
            //    dtOS.Rows[0]["profissional_cod"].ToString(),//profissional_cod
            //    dtOS.Rows[0]["atividade_cod"].ToString(),//atividade_cod
            //    Convert.ToBoolean(dtOS.Rows[0]["siopi"].ToString()),//siopi
            //    dtOS.Rows[0]["nome_cliente"].ToString(),//nome_cliente
            //    dtOS.Rows[0]["cidade"].ToString(),//cidade
            //    dtOS.Rows[0]["nome_contato"].ToString(),//nome_contato
            //    dtOS.Rows[0]["telefone_contato"].ToString(),//telefone_contato
            //    dtOS.Rows[0]["coordenada"].ToString(),//coordenada
            //    dtOS.Rows[0]["status"].ToString(),//status
            //    dtOS.Rows[0]["data_pendente"].ToString(),//data_pendente
            //    dtOS.Rows[0]["data_vistoria"].ToString(),//data_vistoria
            //    dtOS.Rows[0]["data_concluida"].ToString(),//data_concluida
            //    dtOS.Rows[0]["obs"].ToString(),//obs
            //    dtOS.Rows[0]["fatura_cod"].ToString()//fatura_cod
            //);






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

        private void ExcluirOS(DataGridView dgv, string sta)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                try
                {
                    ENTIDADES.OsENT dado = new ENTIDADES.OsENT();
                    dado.Referencia = dgv.CurrentRow.Cells[0].Value.ToString();
                    model.DeleteOsModel(dado);
                    ListarOS(dgv);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AtualizaStatus(DataGridView dgvDestino, DragEventArgs ev)
        {
            int sourcerow = Convert.ToInt32(ev.Data.GetData(Type.GetType("System.Int32")));
            dado.Status = dgvDestino.Tag.ToString();
            dado.Referencia = dgvOrigem.Rows[sourcerow].Cells[0].Value.ToString();
            try
            {
                model.UpdateStatusModel(dado);
                DT.DT_OS = model.ListarOsModel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ListarOS(dgvOrigem);
            ListarOS(dgvDestino);
        }

        private void CapturaDGVOrigem(DataGridView dgv, MouseEventArgs e)
        {
            int SourceRow;
            dgvOrigem = dgv;
            SourceRow = dgv.HitTest(e.X, e.Y).RowIndex;
            dgv.DoDragDrop(SourceRow, DragDropEffects.Move);
        }





        //:EVENTS
        ///_______Form
        public frmOSFluxo(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;

            foreach (Control ctrl in Controls)
            {
                if (ctrl is DataGridView)
                    ctrl.Enter += delegate (object sender, EventArgs e)
                    {
                        _lastEnteredControl = (Control)sender;
                    };
            }

            dgvRecebidas.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvRecebidas.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvRecebidas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvPendentes.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvPendentes.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvPendentes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvVistoriadas.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvVistoriadas.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvVistoriadas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvConcluidas.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvConcluidas.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvConcluidas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void frmOSFluxo_Load(object sender, EventArgs e)
        {
            ListarProfissionais();
            if (Globais.Rl)
            {
                cboProfissional.Enabled = true;
                pnlLinhaFaturar.Show();
                pnlFaturar.Show();


                if (Globais.Rt)
                    cboProfissional.SelectedValue = Globais.Codpro;
                else
                    cboProfissional.SelectedIndex = 0;
                return;
            }
            cboProfissional.SelectedValue = Globais.Codpro;
            ListarOS(dgvRecebidas);
            ListarOS(dgvPendentes);
            ListarOS(dgvVistoriadas);
            ListarOS(dgvConcluidas);
        }





        ///_______Button
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddOS formNeto = new frmAddOS(_frmPrincipal, this.Name);
            formNeto.Text = "Adicionar";
            _frmPrincipal.AbrirFormInPanel(formNeto, _frmPrincipal.pnlMain);
        }

        private void btnFaturar_Click(object sender, EventArgs e)
        {
            if (dgvConcluidas.Rows.Count > 0)
            {
                _frmPrincipal.lblTitulo.Text = "Fatura";
                _frmPrincipal.lblTitulo.Refresh();
                frmAddFatura formNeto = new frmAddFatura(_frmPrincipal);
                _frmPrincipal.AbrirFormInPanel(formNeto, _frmPrincipal.pnlMain);
            }
            else
                MessageBox.Show("Não há ordens concluídas à faturar!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





        ///_______ContextMenu
        private void mnuEditar_Click(object sender, EventArgs e)
        {
            if (_lastEnteredControl == dgvRecebidas)
                EditarOS(dgvRecebidas, dgvRecebidas.CurrentRow.Cells["referencia_recebida"].Value.ToString());

            if (_lastEnteredControl == dgvPendentes)
                EditarOS(dgvPendentes, dgvPendentes.CurrentRow.Cells["referencia_pendente"].Value.ToString());

            if (_lastEnteredControl == dgvVistoriadas)
                EditarOS(dgvVistoriadas, dgvVistoriadas.CurrentRow.Cells["referencia_vistoriada"].Value.ToString());

            if (_lastEnteredControl == dgvConcluidas)
                EditarOS(dgvConcluidas, dgvConcluidas.CurrentRow.Cells["referencia_concluida"].Value.ToString());

        }

        private void mnuExcluir_Click(object sender, EventArgs e)
        {
            if (_lastEnteredControl == dgvRecebidas)
                ExcluirOS(dgvRecebidas, "RECEBIDA");

            if (_lastEnteredControl == dgvPendentes)
                ExcluirOS(dgvPendentes, "PENDENTE");

            if (_lastEnteredControl == dgvVistoriadas)
                ExcluirOS(dgvVistoriadas, "VISTORIADA");

            if (_lastEnteredControl == dgvConcluidas)
                ExcluirOS(dgvConcluidas, "CONCLUÍDA");
        }






        ///_______ComboBox
        private void cboProfissional_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarOS(dgvRecebidas);
            ListarOS(dgvPendentes);
            ListarOS(dgvVistoriadas);
            ListarOS(dgvConcluidas);
        }





        ///_______DataGridView
        private void dgvRecebidas_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            dataGrid.Cursor = Cursors.Hand;
        }

        private void dgvRecebidas_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            dataGrid.Cursor = Cursors.Default;
        }

        private void dgvRecebidas_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dgvRecebidas_DragDrop(object sender, DragEventArgs e)
        {
            AtualizaStatus((DataGridView)sender, e);
        }

        private void dgvRecebidas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                CapturaDGVOrigem((DataGridView)sender, e);
        }

        private void dgvRecebidas_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            _lastEnteredControl = (Control)sender;
            var row = dataGrid.Rows[e.RowIndex];
            dataGrid.CurrentCell = row.Cells[e.ColumnIndex == -1 ? 1 : e.ColumnIndex];
            row.Selected = true;
            dataGrid.Focus();
        }





        private void dgvPendentes_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            dataGrid.Cursor = Cursors.Hand;
        }

        private void dgvPendentes_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            dataGrid.Cursor = Cursors.Default;
        }

        private void dgvPendentes_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dgvPendentes_DragDrop(object sender, DragEventArgs e)
        {
            AtualizaStatus((DataGridView)sender, e);
        }

        private void dgvPendentes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                CapturaDGVOrigem((DataGridView)sender, e);
        }

        private void dgvPendentes_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            _lastEnteredControl = (Control)sender;
            var row = dataGrid.Rows[e.RowIndex];
            dataGrid.CurrentCell = row.Cells[e.ColumnIndex == -1 ? 1 : e.ColumnIndex];
            row.Selected = true;
            dataGrid.Focus();
        }





        private void dgvVistoriadas_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            dataGrid.Cursor = Cursors.Hand;
        }

        private void dgvVistoriadas_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            dataGrid.Cursor = Cursors.Default;
        }

        private void dgvVistoriadas_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dgvVistoriadas_DragDrop(object sender, DragEventArgs e)
        {
            AtualizaStatus((DataGridView)sender, e);
        }

        private void dgvVistoriadas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                CapturaDGVOrigem((DataGridView)sender, e);
        }

        private void dgvVistoriadas_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            _lastEnteredControl = (Control)sender;
            var row = dataGrid.Rows[e.RowIndex];
            dataGrid.CurrentCell = row.Cells[e.ColumnIndex == -1 ? 1 : e.ColumnIndex];
            row.Selected = true;
            dataGrid.Focus();
        }





        private void dgvConcluidas_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            dataGrid.Cursor = Cursors.Hand;
        }

        private void dgvConcluidas_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            dataGrid.Cursor = Cursors.Default;
        }

        private void dgvConcluidas_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dgvConcluidas_DragDrop(object sender, DragEventArgs e)
        {
            AtualizaStatus((DataGridView)sender, e);
        }

        private void dgvConcluidas_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            _lastEnteredControl = (Control)sender;
            var row = dataGrid.Rows[e.RowIndex];
            dataGrid.CurrentCell = row.Cells[e.ColumnIndex == -1 ? 1 : e.ColumnIndex];
            row.Selected = true;
            dataGrid.Focus();
        }

        private void dgvConcluidas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                CapturaDGVOrigem((DataGridView)sender, e);
        }

    }


}
