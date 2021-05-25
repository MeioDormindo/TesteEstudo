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
    public partial class frm_elenco : Form
    {
        public frm_elenco()
        {
            InitializeComponent();
        }

        private void frm_elenco_Load(object sender, EventArgs e)
        {
            this.tipoContaBindingSource.DataSource = dataContextFactory.DataContext.TipoContas;
        }
    }
}
