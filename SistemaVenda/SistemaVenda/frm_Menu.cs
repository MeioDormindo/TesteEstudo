﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void btn_cad_produtos_Click(object sender, EventArgs e)
        {
            frm_produtos frm = new frm_produtos();
            frm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_categorias frm = new frm_categorias();
            frm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_produtos frm = new frm_produtos();
            frm.Show();


        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_categorias frm = new frm_categorias();
            frm.Show();
        }

        private void produtosCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_consultaProdutos frm = new frm_consultaProdutos();
            frm.Show();

        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_venda frm = new frm_venda();
            frm.Show();
        }
    }
}
