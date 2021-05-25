namespace ProvaMeta
{
    partial class frm_elenco
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
            this.tipoContaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoContaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tipoContaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoContaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tipoContaBindingSource
            // 
            this.tipoContaBindingSource.DataSource = typeof(Sistema.DAL.TipoConta);
            // 
            // tipoContaDataGridView
            // 
            this.tipoContaDataGridView.AllowUserToAddRows = false;
            this.tipoContaDataGridView.AllowUserToDeleteRows = false;
            this.tipoContaDataGridView.AutoGenerateColumns = false;
            this.tipoContaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tipoContaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tipoContaDataGridView.DataSource = this.tipoContaBindingSource;
            this.tipoContaDataGridView.Location = new System.Drawing.Point(244, 105);
            this.tipoContaDataGridView.Name = "tipoContaDataGridView";
            this.tipoContaDataGridView.ReadOnly = true;
            this.tipoContaDataGridView.Size = new System.Drawing.Size(446, 280);
            this.tipoContaDataGridView.TabIndex = 1;
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
            // frm_elenco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(961, 482);
            this.Controls.Add(this.tipoContaDataGridView);
            this.Name = "frm_elenco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Elenco";
            this.Load += new System.EventHandler(this.frm_elenco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipoContaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoContaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tipoContaBindingSource;
        private System.Windows.Forms.DataGridView tipoContaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}