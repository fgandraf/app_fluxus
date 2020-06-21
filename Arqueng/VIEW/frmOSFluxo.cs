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
        Control _lastEnteredControl;




        //========================LISTAR OS========================//
        //=========================================================//
        public void ListarOS(DataGridView dgv, string status)
        {
            try
            {
                dado.Status = status;
                dgv.DataSource = model.ListarOsStatusModel(dado);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        //========================EDITAR OS========================//
        //=========================================================//
        public void EditarOS(DataGridView dgv)
        {
            dado.Id = dgv.CurrentRow.Cells[0].Value.ToString();
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
            ListarOS(dgvRecebidas, "RECEBIDA");
            ListarOS(dgvPendentes, "PENDENTE");
            ListarOS(dgvVistoriadas, "VISTORIADA");
            ListarOS(dgvConcluidas, "CONCLUÍDA");
        }




        //=======================EXCLUIR OS=======================//
        //========================================================//
        public void ExcluirOS(DataGridView dgv, string sta)
        {
            var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                try
                {
                    ENTIDADES.OsENT dado = new ENTIDADES.OsENT();
                    dado.Id = dgv.CurrentRow.Cells[0].Value.ToString();
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
        public frmOSFluxo()
        {
            InitializeComponent();

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

            ListarOS(dgvRecebidas, "RECEBIDA");
            ListarOS(dgvPendentes, "PENDENTE");
            ListarOS(dgvVistoriadas, "VISTORIADA");
            ListarOS(dgvConcluidas, "CONCLUÍDA");

        }




        //===============CLIQUE DIREITO NOS GRIDS===============//
        //======================================================//
        private void dgvRecebidas_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    _lastEnteredControl = (Control)sender;
                    menuContext.Show(Cursor.Position);
                    break;
            }
        }

        private void dgvPendentes_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    _lastEnteredControl = (Control)sender;
                    menuContext.Show(Cursor.Position);
                    break;
            }
        }

        private void dgvVistoriadas_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    _lastEnteredControl = (Control)sender;
                    menuContext.Show(Cursor.Position);
                    break;
            }
        }

        private void dgvConcluidas_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    _lastEnteredControl = (Control)sender;
                    menuContext.Show(Cursor.Position);
                    break;
            }
        }




        //===============DUPLO CLIQUE NOS GRIDS===============//
        //====================================================//

        private void dgvRecebidas_DoubleClick(object sender, EventArgs e)
        {
            EditarOS(dgvRecebidas);
        }

        private void dgvPendentes_DoubleClick(object sender, EventArgs e)
        {
            EditarOS(dgvPendentes);
        }

        private void dgvVistoriadas_DoubleClick(object sender, EventArgs e)
        {
            EditarOS(dgvVistoriadas);
        }

        private void dgvConcluidas_DoubleClick(object sender, EventArgs e)
        {
            EditarOS(dgvConcluidas);
        }






        //===================BOTÃO ADICIONAR OS===============//
        //====================================================//
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddOS form = new frmAddOS();
            form.Text = "Adicionar";
            form.ShowDialog();
            ListarOS(dgvRecebidas, "RECEBIDA");
            ListarOS(dgvPendentes, "PENDENTE");
            ListarOS(dgvVistoriadas, "VISTORIADA");
            ListarOS(dgvConcluidas, "CONCLUÍDA");
        }



        //=================TECLA DELETE PRESSIONADA=============//
        //======================================================//
        private void dgvRecebidas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvRecebidas.CurrentCell.Selected)
                ExcluirOS(dgvRecebidas, "RECEBIDA");
        }

        private void dgvPendentes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvPendentes.CurrentCell.Selected)
                ExcluirOS(dgvPendentes, "PENDENTE");
        }

        private void dgvVistoriadas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvVistoriadas.CurrentCell.Selected)
                ExcluirOS(dgvVistoriadas, "VISTORIADA");
        }

        private void dgvConcluidas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvConcluidas.CurrentCell.Selected)
                ExcluirOS(dgvConcluidas, "CONCLUÍDA");
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
    }
}
