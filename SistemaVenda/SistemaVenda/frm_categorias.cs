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
    public partial class frm_categorias : Form
    {
        public frm_categorias()
        {
            InitializeComponent();
        }

        private void frm_categorias_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categorias;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            txt_categoria.Enabled= true;
            this.categoriaBindingSource.AddNew();

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (this.valida())
            {

                this.categoriaBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                txt_categoria.Enabled = false;
                MessageBox.Show("Categoria inserida com sucesso!");
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Tem certeza?", "Confirmação", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes){

                if (CategoriaPossuiProduto(this.categoriaAtual))
                    MessageBox.Show("Voce não pode excluir está categoria, porque existem produtos nela.");
                else
                {

                    this.categoriaBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Categoria excluida com sucesso!");
                }
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.CancelEdit();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            txt_categoria.Enabled = true;
        }

        private bool valida()
        {
            if(txt_categoria.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O Campo categoria é obrigatorio");
                txt_categoria.Focus();
                return false;
            }
            return true;
        }

        public Categorias categoriaAtual
        {
            get
            {
                return (Categorias)this.categoriaBindingSource.Current;
            }

        }

        private bool CategoriaPossuiProduto(Categorias categoria)
        {
            var produtos = DataContextFactory.DataContext.Produtos.Where(x => x.IdCategoria == categoria.id);
            if (produtos.Count() > 0)
                return true;
             else
                return false;

        }

    }
}
