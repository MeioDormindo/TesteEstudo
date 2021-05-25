namespace ProvaMeta
{
    partial class frm_natureza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.naturezaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.naturezaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.naturezaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naturezaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // naturezaBindingSource
            // 
            this.naturezaBindingSource.DataSource = typeof(Sistema.DAL.Natureza);
            // 
            // naturezaDataGridView
            // 
            this.naturezaDataGridView.AllowUserToAddRows = false;
            this.naturezaDataGridView.AllowUserToDeleteRows = false;
            this.naturezaDataGridView.AutoGenerateColumns = false;
            this.naturezaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.naturezaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.naturezaDataGridView.DataSource = this.naturezaBindingSource;
            this.naturezaDataGridView.Location = new System.Drawing.Point(170, 95);
            this.naturezaDataGridView.Name = "naturezaDataGridView";
            this.naturezaDataGridView.ReadOnly = true;
            this.naturezaDataGridView.Size = new System.Drawing.Size(588, 301);
            this.naturezaDataGridView.TabIndex = 1;
            this.naturezaDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.naturezaDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_elenco";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_elenco";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TipoConta";
            this.dataGridViewTextBoxColumn4.HeaderText = "TipoConta";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // frm_natureza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(961, 482);
            this.Controls.Add(this.naturezaDataGridView);
            this.Name = "frm_natureza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Natureza";
            this.Load += new System.EventHandler(this.frm_natureza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.naturezaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naturezaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource naturezaBindingSource;
        private System.Windows.Forms.DataGridView naturezaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}