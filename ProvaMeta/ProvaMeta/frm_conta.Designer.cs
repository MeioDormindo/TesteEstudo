namespace ProvaMeta
{
    partial class frm_conta
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.contaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cb_tipoConta = new System.Windows.Forms.ComboBox();
            this.naturezaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnaturezaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naturezaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frmcontaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.contaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naturezaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmcontaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Conta:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contaBindingSource, "Nome", true));
            this.txt_Nome.Location = new System.Drawing.Point(109, 26);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(152, 20);
            this.txt_Nome.TabIndex = 1;
            // 
            // contaBindingSource
            // 
            this.contaBindingSource.DataSource = typeof(Sistema.DAL.Conta);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo Conta: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cb_tipoConta
            // 
            this.cb_tipoConta.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contaBindingSource, "id_natureza", true));
            this.cb_tipoConta.DataSource = this.naturezaBindingSource;
            this.cb_tipoConta.DisplayMember = "Nome";
            this.cb_tipoConta.FormattingEnabled = true;
            this.cb_tipoConta.Location = new System.Drawing.Point(358, 26);
            this.cb_tipoConta.Name = "cb_tipoConta";
            this.cb_tipoConta.Size = new System.Drawing.Size(156, 21);
            this.cb_tipoConta.TabIndex = 3;
            this.cb_tipoConta.ValueMember = "id";
            // 
            // naturezaBindingSource
            // 
            this.naturezaBindingSource.DataSource = typeof(Sistema.DAL.Natureza);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(542, 26);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(75, 23);
            this.btn_novo.TabIndex = 5;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.Location = new System.Drawing.Point(623, 26);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastro.TabIndex = 6;
            this.btn_cadastro.Text = "Cadastro";
            this.btn_cadastro.UseVisualStyleBackColor = true;
            this.btn_cadastro.Click += new System.EventHandler(this.btn_cadastro_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(788, 26);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(707, 26);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 7;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.idnaturezaDataGridViewTextBoxColumn,
            this.naturezaDataGridViewTextBoxColumn,
            this.TipoConta});
            this.dataGridView1.DataSource = this.contaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(897, 367);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 250;
            // 
            // idnaturezaDataGridViewTextBoxColumn
            // 
            this.idnaturezaDataGridViewTextBoxColumn.DataPropertyName = "id_natureza";
            this.idnaturezaDataGridViewTextBoxColumn.HeaderText = "id_natureza";
            this.idnaturezaDataGridViewTextBoxColumn.Name = "idnaturezaDataGridViewTextBoxColumn";
            this.idnaturezaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // naturezaDataGridViewTextBoxColumn
            // 
            this.naturezaDataGridViewTextBoxColumn.DataPropertyName = "Natureza";
            this.naturezaDataGridViewTextBoxColumn.HeaderText = "Natureza";
            this.naturezaDataGridViewTextBoxColumn.Name = "naturezaDataGridViewTextBoxColumn";
            this.naturezaDataGridViewTextBoxColumn.ReadOnly = true;
            this.naturezaDataGridViewTextBoxColumn.Width = 150;
            // 
            // TipoConta
            // 
            this.TipoConta.DataPropertyName = "idConta";
            this.TipoConta.HeaderText = "TipoConta";
            this.TipoConta.Name = "TipoConta";
            this.TipoConta.ReadOnly = true;
            // 
            // frmcontaBindingSource
            // 
            this.frmcontaBindingSource.DataSource = typeof(ProvaMeta.frm_conta);
            // 
            // frm_conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 482);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cadastro);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.cb_tipoConta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label1);
            this.Name = "frm_conta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Conta";
            this.Load += new System.EventHandler(this.frm_conta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naturezaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmcontaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_tipoConta;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_cadastro;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource frmcontaBindingSource;
        private System.Windows.Forms.BindingSource contaBindingSource;
        private System.Windows.Forms.BindingSource naturezaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnaturezaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naturezaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoConta;
    }
}