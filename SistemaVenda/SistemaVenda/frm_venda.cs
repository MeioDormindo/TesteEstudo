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

namespace SistemaVenda
{
    public partial class frm_venda : Form
    {
        public frm_venda()
        {
            InitializeComponent();
        }

        

        private void id_pessoaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_venda_Load(object sender, EventArgs e)
        {
            this.pessoasBindingSource.DataSource = DataContextFactory.DataContext.Pessoas;
            this.itensVendasBindingSource.DataSource = DataContextFactory.DataContext.ItensVendas;
            this.produtosBindingSource.DataSource = DataContextFactory.DataContext.Produtos;
            this.vendasBindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.vendasBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            groupBox1.Visible = true;
        }
    }
}
