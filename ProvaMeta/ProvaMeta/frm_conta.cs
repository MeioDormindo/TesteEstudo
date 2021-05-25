using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.DAL;

namespace ProvaMeta
{
    public partial class frm_conta : Form
    {
        public frm_conta()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_conta_Load(object sender, EventArgs e)
        {
            this.contaBindingSource.DataSource = dataContextFactory.DataContext.Contas;
            this.naturezaBindingSource.DataSource = dataContextFactory.DataContext.Naturezas;
            
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.contaBindingSource.AddNew();
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            if (this.valida())
            {
                this.contaBindingSource.EndEdit();
                dataContextFactory.DataContext.SubmitChanges();
                dataGridView1.Refresh();
                MessageBox.Show("Conta " + txt_Nome.ToString() + " do tipo "+cb_tipoConta.ToString() +"Criado com sucesso!");
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.contaBindingSource.RemoveCurrent();
                dataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Conta " + txt_Nome + " excluida com sucesso!");
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.contaBindingSource.CancelEdit();

        }

        private bool valida()
        {
            if(txt_Nome.Text.Trim() == String.Empty)
            {
                MessageBox.Show("O Campo Nome é obrigatorio!");
                txt_Nome.Focus();
                return false;
            }
            return true;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (e.Value != null && e.ColumnIndex == 3)
                e.Value = ((Natureza)e.Value).Nome;
           
             
        }

      
    }
}
