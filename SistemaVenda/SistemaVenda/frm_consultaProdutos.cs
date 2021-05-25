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
    public partial class frm_consultaProdutos : Form
    {
        public frm_consultaProdutos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_consultaProdutos_Load(object sender, EventArgs e)
        {
            
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categorias;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Pesquisar((int)cb_categoria.SelectedValue);

        }

        public void Pesquisar (int codigoCategoria)
        {
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produtos.Where(x => x.IdCategoria == codigoCategoria);
        }

        
    }
}
