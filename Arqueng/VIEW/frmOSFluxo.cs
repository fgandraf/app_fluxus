using System;
using System.Windows.Forms;
using Arqueng.MODEL;
using Arqueng.ENTIDADES;

namespace Arqueng.VIEW
{
    public partial class frmOSFluxo : Form
    {
        OsMODEL model = new OsMODEL();
        OsENT dado = new OsENT();

        public void ListarOSRecebidas()
        {
            try
            {
                dado.Status = "RECEBIDA";
                dgvRecebidas.DataSource = model.ListarOsStatusModel(dado);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ListarOSVistoriadas()
        {
            try
            {
                dado.Status = "VISTORIADA";
                dgvVistoriadas.DataSource = model.ListarOsStatusModel(dado);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ListarOSPendentes()
        {
            try
            {
                dado.Status = "PENDENTE";
                dgvPendentes.DataSource = model.ListarOsStatusModel(dado);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListarOSConcluidas()
        {
            try
            {
                dado.Status = "CONCLUÍDA";
                dgvConcluidas.DataSource = model.ListarOsStatusModel(dado);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public frmOSFluxo()
        {
            InitializeComponent();
            ListarOSRecebidas();
            ListarOSPendentes();
            ListarOSVistoriadas();
            ListarOSConcluidas();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddOS form = new frmAddOS();
            form.Text = "Adicionar";
            form.ShowDialog();
            ListarOSRecebidas();
            ListarOSPendentes();
            ListarOSVistoriadas();
            ListarOSConcluidas();
        }

        private void dgvRecebidas_DoubleClick(object sender, EventArgs e)
        {
            mnuEditarRecebida.PerformClick();
        }

        private void dgvPendentes_DoubleClick(object sender, EventArgs e)
        {
            mnuEditarPendente.PerformClick();
        }

        private void dgvVistoriadas_DoubleClick(object sender, EventArgs e)
        {
            mnuEditarVistoriada.PerformClick();
        }

        private void dgvConcluidas_DoubleClick(object sender, EventArgs e)
        {
            mnuEditarConcluida.PerformClick();
        }

        private void dgvRecebidas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvRecebidas.CurrentCell.Selected)
                mnuExcluirRecebida.PerformClick();
        }

        private void dgvPendentes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvPendentes.CurrentCell.Selected)
                mnuExcluirPendente.PerformClick();
        }

        private void dgvVistoriadas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvVistoriadas.CurrentCell.Selected)
                mnuExcluirVistoriada.PerformClick();
        }

        private void dgvConcluidas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvConcluidas.CurrentCell.Selected)
                mnuExcluirRecebida.PerformClick();
        }

        private void mnuEditarRecebida_Click(object sender, EventArgs e)
        {
            dado.Id = dgvRecebidas.CurrentRow.Cells[0].Value.ToString();
            model.BuscarOsModel(dado);
            frmAddOS form = new frmAddOS
            (
                dado.Id,
                dado.Titulo,
                dado.Referencia,
                Convert.ToString(dado.Data_ordem),
                Convert.ToString(dado.Prazo_execucao),
                dado.Profissional_cod,
                dado.Atividade_cod,
                Convert.ToString(dado.Siopi),
                dado.Nome_cliente,
                dado.Cidade,
                dado.Nome_contato,
                dado.Telefone_contato,
                dado.Status,
                Convert.ToString(dado.Data_pendente),
                Convert.ToString(dado.Data_vistoria),
                Convert.ToString(dado.Data_concluida),
                dado.Obs,
                Convert.ToString(dado.Faturada),
                dado.Fatura_cod
            );
            form.Text = "Alterar";
            form.ShowDialog();
            ListarOSRecebidas();
            ListarOSPendentes();
            ListarOSVistoriadas();
            ListarOSConcluidas();
        }

        private void mnuExcluirRecebida_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                try
                {
                    ENTIDADES.OsENT dado = new ENTIDADES.OsENT();
                    dado.Id = dgvRecebidas.CurrentRow.Cells[0].Value.ToString();
                    model.DeleteOsModel(dado);
                    ListarOSRecebidas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mnuExcluirVistoriada_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                try
                {
                    ENTIDADES.OsENT dado = new ENTIDADES.OsENT();
                    dado.Id = dgvVistoriadas.CurrentRow.Cells[0].Value.ToString();
                    model.DeleteOsModel(dado);
                    ListarOSVistoriadas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mnuEditarPendente_Click(object sender, EventArgs e)
        {
            dado.Id = dgvPendentes.CurrentRow.Cells[0].Value.ToString();
            model.BuscarOsModel(dado);
            frmAddOS form = new frmAddOS
            (
                dado.Id,
                dado.Titulo,
                dado.Referencia,
                Convert.ToString(dado.Data_ordem),
                Convert.ToString(dado.Prazo_execucao),
                dado.Profissional_cod,
                dado.Atividade_cod,
                Convert.ToString(dado.Siopi),
                dado.Nome_cliente,
                dado.Cidade,
                dado.Nome_contato,
                dado.Telefone_contato,
                dado.Status,
                Convert.ToString(dado.Data_pendente),
                Convert.ToString(dado.Data_vistoria),
                Convert.ToString(dado.Data_concluida),
                dado.Obs,
                Convert.ToString(dado.Faturada),
                dado.Fatura_cod
            );
            form.Text = "Alterar";
            form.ShowDialog();
            ListarOSRecebidas();
            ListarOSPendentes();
            ListarOSVistoriadas();
            ListarOSConcluidas();
        }

        private void mnuExcluirPendente_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                try
                {
                    ENTIDADES.OsENT dado = new ENTIDADES.OsENT();
                    dado.Id = dgvPendentes.CurrentRow.Cells[0].Value.ToString();
                    model.DeleteOsModel(dado);
                    ListarOSPendentes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mnuExcluirConcluida_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                try
                {
                    ENTIDADES.OsENT dado = new ENTIDADES.OsENT();
                    dado.Id = dgvConcluidas.CurrentRow.Cells[0].Value.ToString();
                    model.DeleteOsModel(dado);
                    ListarOSConcluidas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mnuEditarConcluida_Click(object sender, EventArgs e)
        {
            dado.Id = dgvConcluidas.CurrentRow.Cells[0].Value.ToString();
            model.BuscarOsModel(dado);
            frmAddOS form = new frmAddOS
            (
                dado.Id,
                dado.Titulo,
                dado.Referencia,
                Convert.ToString(dado.Data_ordem),
                Convert.ToString(dado.Prazo_execucao),
                dado.Profissional_cod,
                dado.Atividade_cod,
                Convert.ToString(dado.Siopi),
                dado.Nome_cliente,
                dado.Cidade,
                dado.Nome_contato,
                dado.Telefone_contato,
                dado.Status,
                Convert.ToString(dado.Data_pendente),
                Convert.ToString(dado.Data_vistoria),
                Convert.ToString(dado.Data_concluida),
                dado.Obs,
                Convert.ToString(dado.Faturada),
                dado.Fatura_cod
            );
            form.Text = "Alterar";
            form.ShowDialog();
            ListarOSRecebidas();
            ListarOSPendentes();
            ListarOSVistoriadas();
            ListarOSConcluidas();
        }

        private void mnuEditarVistoriada_Click(object sender, EventArgs e)
        {
            dado.Id = dgvVistoriadas.CurrentRow.Cells[0].Value.ToString();
            model.BuscarOsModel(dado);
            frmAddOS form = new frmAddOS
            (
                dado.Id,
                dado.Titulo,
                dado.Referencia,
                Convert.ToString(dado.Data_ordem),
                Convert.ToString(dado.Prazo_execucao),
                dado.Profissional_cod,
                dado.Atividade_cod,
                Convert.ToString(dado.Siopi),
                dado.Nome_cliente,
                dado.Cidade,
                dado.Nome_contato,
                dado.Telefone_contato,
                dado.Status,
                Convert.ToString(dado.Data_pendente),
                Convert.ToString(dado.Data_vistoria),
                Convert.ToString(dado.Data_concluida),
                dado.Obs,
                Convert.ToString(dado.Faturada),
                dado.Fatura_cod
            );
            form.Text = "Alterar";
            form.ShowDialog();
            ListarOSRecebidas();
            ListarOSPendentes();
            ListarOSVistoriadas();
            ListarOSConcluidas();
        }
    }



    }
