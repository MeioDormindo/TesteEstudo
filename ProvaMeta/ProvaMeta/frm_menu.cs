using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaMeta
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void naturezaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_natureza frm = new frm_natureza();
            frm.Show();

        }

        private void elencoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_elenco frm = new frm_elenco();
            frm.Show();
        }

        private void contaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_conta frm = new frm_conta();
            frm.Show();
        }
    }
}
