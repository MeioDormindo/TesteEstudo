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
    public partial class frm_natureza : Form
    {
        public frm_natureza()
        {
            InitializeComponent();
        }

        private void frm_natureza_Load(object sender, EventArgs e)
        {
            this.naturezaBindingSource.DataSource = dataContextFactory.DataContext.Naturezas;
        }

        private void naturezaDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 3)
                e.Value = ((TipoConta)e.Value).Nome;
        }
    }
}
