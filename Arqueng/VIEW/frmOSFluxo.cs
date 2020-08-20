using System;
using System.Windows.Forms;
using Arqueng.MODEL;
using Arqueng.ENTIDADES;
using System.Data;
using System.Drawing;

namespace Arqueng.VIEW
{


    public partial class frmOSFluxo : Form
    {

        frmPrincipal _frmPrincipal;
        OsMODEL model = new OsMODEL();
        OsENT dado = new OsENT();
        Control _lastEnteredControl;
        ProfissionaisMODEL profmodel = new ProfissionaisMODEL();
        DataGridView dgvOrigem;


        //:MÉTODOS

        ///_______Listar Profissionais
        private void ListarProfissionais()
        {
            try
            {
                DataTable dt = profmodel.ListarCodNomeProModel();
                DataRow linha = dt.NewRow();
                linha[1] = "--TODOS--";
                dt.Rows.InsertAt(linha, 0);
                cboProfissional.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ///_______Listar Os
        private void ListarOS(DataGridView dgv, string status)
        {
            try
            {
                dado.Status = status;
                dado.Profissional_cod = cboProfissional.SelectedValue.ToString();

                dgv.DataSource = model.ListarOsStatusModel(dado);

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

            if (status == "RECEBIDA")
                lblTitRecebidas.Text = "RECEBIDAS [" + dgv.Rows.Count.ToString() + "]";
            if (status == "PENDENTE")
                lblTitPendentes.Text = "PENDENTES [" + dgv.Rows.Count.ToString() + "]";
            if (status == "VISTORIADA")
                lblTitVistoriadas.Text = "VISTORIADAS [" + dgv.Rows.Count.ToString() + "]";
            if (status == "CONCLUÍDA")
                lblTitConcluidas.Text = "CONCLUÍDAS [" + dgv.Rows.Count.ToString() + "]";

        }

        ///_______Editar Os
        private void EditarOS(DataGridView dgv)
        {
            dado.Referencia = dgv.CurrentRow.Cells[0].Value.ToString();
            model.BuscarOsModel(dado);
            frmAddOS formNeto = new frmAddOS
            (
                _frmPrincipal, this.Name,
                dado.Titulo,
                dado.Referencia,
                dado.Agencia,
                Convert.ToString(dado.Data_ordem),
                Convert.ToString(dado.Prazo_execucao),
                dado.Profissional_cod,
                dado.Atividade_cod,
                Convert.ToBoolean(dado.Siopi),
                dado.Nome_cliente,
                dado.Cidade,
                dado.Nome_contato,
                dado.Telefone_contato,
                dado.Coordenada,
                dado.Status,
                Convert.ToString(dado.Data_pendente),
                Convert.ToString(dado.Data_vistoria),
                Convert.ToString(dado.Data_concluida),
                dado.Obs,
                dado.Fatura_cod
            );
            formNeto.Text = "Alterar";
            _frmPrincipal.AbrirFormInPanel(formNeto, _frmPrincipal.pnlMain);
        }

        ///_______Excluir Os
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
                    ListarOS(dgv, sta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        ///_______Atualizar Status
        private void AtualizaStatus(DataGridView dgvDestino, DragEventArgs ev)
        {
            int sourcerow = Convert.ToInt32(ev.Data.GetData(Type.GetType("System.Int32")));
            dado.Status = dgvDestino.Tag.ToString();
            dado.Referencia = dgvOrigem.Rows[sourcerow].Cells[0].Value.ToString();
            try
            {
                model.UpdateStatusModel(dado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ListarOS(dgvOrigem, dgvOrigem.Tag.ToString());
            ListarOS(dgvDestino, dgvDestino.Tag.ToString());
        }

        ///_______Capturar DataGridView de Origem
        private void CapturaOrigem(DataGridView dgv, MouseEventArgs e)
        {
            int SourceRow;
            dgvOrigem = dgv;
            SourceRow = dgv.HitTest(e.X, e.Y).RowIndex;
            dgv.DoDragDrop(SourceRow, DragDropEffects.Move);
        }










        //:EVENTOS

        ///_______CRIAÇÃO DO FORMULÁRIO
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
            ListarProfissionais();



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


            ListarOS(dgvRecebidas, "RECEBIDA");
            ListarOS(dgvPendentes, "PENDENTE");
            ListarOS(dgvVistoriadas, "VISTORIADA");
            ListarOS(dgvConcluidas, "CONCLUÍDA");

        }

        ///_______INICIALIZAÇÃO DO FORMULÁRIO
        private void frmOSFluxo_Load(object sender, EventArgs e)
        {
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
        }

        ///_______SAIR DO FORMULÁRIO
        private void frmOSFluxo_Leave(object sender, EventArgs e)
        {
            GC.Collect();
        }






        ///_______BOTÃO ADICIONAR OS
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddOS formNeto = new frmAddOS(_frmPrincipal, this.Name);
            formNeto.Text = "Adicionar";
            _frmPrincipal.AbrirFormInPanel(formNeto, _frmPrincipal.pnlMain);
        }

        ///_______BOTÃO FATURAR CLICK
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






        ///_______MENU EDITAR CLICK
        private void mnuEditar_Click(object sender, EventArgs e)
        {
            if (_lastEnteredControl == dgvRecebidas)
                EditarOS(dgvRecebidas);

            if (_lastEnteredControl == dgvPendentes)
                EditarOS(dgvPendentes);

            if (_lastEnteredControl == dgvVistoriadas)
                EditarOS(dgvVistoriadas);

            if (_lastEnteredControl == dgvConcluidas)
                EditarOS(dgvConcluidas);

        }

        ///_______MENU EXCLUIR CLICK
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






        ///_______COMBOBOX PROFISSIONAIS
        private void cboProfissional_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarOS(dgvRecebidas, "RECEBIDA");
            ListarOS(dgvPendentes, "PENDENTE");
            ListarOS(dgvVistoriadas, "VISTORIADA");
            ListarOS(dgvConcluidas, "CONCLUÍDA");
        }






        ///_______MUDAR CURSOR DO MOUSE
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



        ///_______DRAG OVER
        private void dgvRecebidas_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dgvPendentes_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dgvVistoriadas_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dgvConcluidas_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }



        ///_______DRAG DROP
        private void dgvRecebidas_DragDrop(object sender, DragEventArgs e)
        {
            AtualizaStatus((DataGridView)sender, e);
        }

        private void dgvPendentes_DragDrop(object sender, DragEventArgs e)
        {
            AtualizaStatus((DataGridView)sender, e);
        }

        private void dgvVistoriadas_DragDrop(object sender, DragEventArgs e)
        {
            AtualizaStatus((DataGridView)sender, e);
        }

        private void dgvConcluidas_DragDrop(object sender, DragEventArgs e)
        {
            AtualizaStatus((DataGridView)sender, e);
        }







































        ///_______CLIQUE DIREITO NOS GRIDS
        private void dgvRecebidas_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            _lastEnteredControl = (Control)sender;
            var row = dataGrid.Rows[e.RowIndex];
            dataGrid.CurrentCell = row.Cells[e.ColumnIndex == -1 ? 1 : e.ColumnIndex];
            row.Selected = true;
            dataGrid.Focus();

            //if (e.Button == MouseButtons.Left && e.RowIndex != -1)
            //    EditarOS(dataGrid);
        }

        private void dgvPendentes_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            _lastEnteredControl = (Control)sender;
            var row = dataGrid.Rows[e.RowIndex];
            dataGrid.CurrentCell = row.Cells[e.ColumnIndex == -1 ? 1 : e.ColumnIndex];
            row.Selected = true;
            dataGrid.Focus();

            //if (e.Button == MouseButtons.Left && e.RowIndex != -1)
            //    EditarOS(dataGrid);
        }

        private void dgvVistoriadas_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            _lastEnteredControl = (Control)sender;
            var row = dataGrid.Rows[e.RowIndex];
            dataGrid.CurrentCell = row.Cells[e.ColumnIndex == -1 ? 1 : e.ColumnIndex];
            row.Selected = true;
            dataGrid.Focus();

            //if (e.Button == MouseButtons.Left && e.RowIndex != -1)
            //    EditarOS(dataGrid);
        }

        private void dgvConcluidas_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            _lastEnteredControl = (Control)sender;
            var row = dataGrid.Rows[e.RowIndex];
            dataGrid.CurrentCell = row.Cells[e.ColumnIndex == -1 ? 1 : e.ColumnIndex];
            row.Selected = true;
            dataGrid.Focus();

            //if (e.Button == MouseButtons.Left && e.RowIndex != -1)
            //    EditarOS(dataGrid);
        }





        ///_______MOUSE DOWN
        private void dgvRecebidas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            CapturaOrigem((DataGridView)sender, e);
        }

        private void dgvPendentes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                CapturaOrigem((DataGridView)sender, e);
        }

        private void dgvVistoriadas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                CapturaOrigem((DataGridView)sender, e);
        }

        private void dgvConcluidas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                CapturaOrigem((DataGridView)sender, e);
        }






        private void dgvRecebidas_DoubleClick(object sender, EventArgs e)
        {
            EditarOS((DataGridView)sender);
        }
    }


}
