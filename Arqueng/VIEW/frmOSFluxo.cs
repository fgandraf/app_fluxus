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
        ProfissionaisMODEL profmodel = new ProfissionaisMODEL();

        private  void ListarProfissionais()
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

        //========================LISTAR OS========================//
        //=========================================================//
        private  void ListarOS(DataGridView dgv, string status)
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


        //========================EDITAR OS========================//
        //=========================================================//
        private  void EditarOS(DataGridView dgv)
        {
            dado.Referencia = dgv.CurrentRow.Cells[0].Value.ToString();
            model.BuscarOsModel(dado);
            frmAddOS formNeto = new frmAddOS
            (
                _frmPrincipal, this.Name,
                dado.Titulo,
                dado.Referencia,
                Convert.ToString(dado.Data_ordem),
                Convert.ToString(dado.Prazo_execucao),
                dado.Profissional_cod,
                dado.Atividade_cod,
                Convert.ToBoolean(dado.Siopi),
                dado.Nome_cliente,
                dado.Cidade,
                dado.Nome_contato,
                dado.Telefone_contato,
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


        //=======================EXCLUIR OS=======================//
        //========================================================//
        private  void ExcluirOS(DataGridView dgv, string sta)
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


        //==============INICIALIZAÇÃO DO FORMULÁRIO==============//
        //=======================================================//
        public frmOSFluxo(frmPrincipal frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;

            foreach (Control ctrl in Controls)
            {
                if (ctrl is DataGridView)
                {
                    ctrl.Enter += delegate (object sender, EventArgs e)
                    {
                        _lastEnteredControl = (Control)sender;
                    };
                }
            }
            ListarProfissionais();
            ListarOS(dgvRecebidas, "RECEBIDA");
            ListarOS(dgvPendentes, "PENDENTE");
            ListarOS(dgvVistoriadas, "VISTORIADA");
            ListarOS(dgvConcluidas, "CONCLUÍDA");

        }


        //===============CLIQUE DIREITO NOS GRIDS===============//
        //======================================================//
        private void dgvRecebidas_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            _lastEnteredControl = (Control)sender;
            var row = dataGrid.Rows[e.RowIndex];
            dataGrid.CurrentCell = row.Cells[e.ColumnIndex == -1 ? 1 : e.ColumnIndex];
            row.Selected = true;
            dataGrid.Focus();

            if (e.Button == MouseButtons.Left && e.RowIndex != -1)
                EditarOS(dataGrid);
        }

        private void dgvPendentes_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            _lastEnteredControl = (Control)sender;
            var row = dataGrid.Rows[e.RowIndex];
            dataGrid.CurrentCell = row.Cells[e.ColumnIndex == -1 ? 1 : e.ColumnIndex];
            row.Selected = true;
            dataGrid.Focus();

            if (e.Button == MouseButtons.Left && e.RowIndex != -1)
                EditarOS(dataGrid);
        }

        private void dgvVistoriadas_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            _lastEnteredControl = (Control)sender;
            var row = dataGrid.Rows[e.RowIndex];
            dataGrid.CurrentCell = row.Cells[e.ColumnIndex == -1 ? 1 : e.ColumnIndex];
            row.Selected = true;
            dataGrid.Focus();

            if (e.Button == MouseButtons.Left && e.RowIndex != -1)
                EditarOS(dataGrid);
        }

        private void dgvConcluidas_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            _lastEnteredControl = (Control)sender;
            var row = dataGrid.Rows[e.RowIndex];
            dataGrid.CurrentCell = row.Cells[e.ColumnIndex == -1 ? 1 : e.ColumnIndex];
            row.Selected = true;
            dataGrid.Focus();

            if (e.Button == MouseButtons.Left && e.RowIndex != -1)
                EditarOS(dataGrid);
        }



        //===================BOTÃO ADICIONAR OS===============//
        //====================================================//
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddOS formNeto = new frmAddOS(_frmPrincipal, this.Name);
            formNeto.Text = "Adicionar";
            _frmPrincipal.AbrirFormInPanel(formNeto, _frmPrincipal.pnlMain);
        }



        //====================MENU EDITAR CLICK================//
        //=====================================================//
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



        //====================MENU EXCLUIR CLICK================//
        //=====================================================//
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

        //====================BOTÃO FATURAR CLICK================//
        //=======================================================//
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


        //===================MUDAR CURSOR DO MOUSE===============//
        //=======================================================//
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





        private void cboProfissional_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarOS(dgvRecebidas, "RECEBIDA");
            ListarOS(dgvPendentes, "PENDENTE");
            ListarOS(dgvVistoriadas, "VISTORIADA");
            ListarOS(dgvConcluidas, "CONCLUÍDA");
        }

        private void frmOSFluxo_Load(object sender, EventArgs e)
        {
            if (Globais.Rl)
            {
                cboProfissional.Show();
                lblProfissional.Show();
                pnlFaturar.Show();
                pnlLinhaFaturar.Show();

                if (Globais.Rt)
                    cboProfissional.SelectedValue = Globais.Codpro;
                else
                    cboProfissional.SelectedIndex = 0;
                return;
            }
            cboProfissional.SelectedValue = Globais.Codpro;
        }

    }


}
