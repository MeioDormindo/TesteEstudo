namespace SistemaVenda
{
    partial class frm_venda
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
            System.Windows.Forms.Label id_pessoaLabel;
            System.Windows.Forms.Label id_vendaLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label id_produtoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cb_cliente = new System.Windows.Forms.ComboBox();
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id_produtoComboBox = new System.Windows.Forms.ComboBox();
            this.itensVendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.id_vendaTextBox = new System.Windows.Forms.TextBox();
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itensVendasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_pessoaLabel = new System.Windows.Forms.Label();
            id_vendaLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            id_produtoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_pessoaLabel
            // 
            id_pessoaLabel.AutoSize = true;
            id_pessoaLabel.Location = new System.Drawing.Point(146, 18);
            id_pessoaLabel.Name = "id_pessoaLabel";
            id_pessoaLabel.Size = new System.Drawing.Size(42, 13);
            id_pessoaLabel.TabIndex = 1;
            id_pessoaLabel.Text = "Cliente:";
            // 
            // id_vendaLabel
            // 
            id_vendaLabel.AutoSize = true;
            id_vendaLabel.Location = new System.Drawing.Point(6, 26);
            id_vendaLabel.Name = "id_vendaLabel";
            id_vendaLabel.Size = new System.Drawing.Size(77, 13);
            id_vendaLabel.TabIndex = 0;
            id_vendaLabel.Text = "Código Venda:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(6, 90);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 4;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(6, 124);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 6;
            valorLabel.Text = "Valor:";
            // 
            // id_produtoLabel
            // 
            id_produtoLabel.AutoSize = true;
            id_produtoLabel.Location = new System.Drawing.Point(6, 56);
            id_produtoLabel.Name = "id_produtoLabel";
            id_produtoLabel.Size = new System.Drawing.Size(50, 13);
            id_produtoLabel.TabIndex = 7;
            id_produtoLabel.Text = " Produto:";
            // 
            // cb_cliente
            // 
            this.cb_cliente.DataSource = this.pessoasBindingSource;
            this.cb_cliente.DisplayMember = "Nome";
            this.cb_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cliente.FormattingEnabled = true;
            this.cb_cliente.Location = new System.Drawing.Point(207, 15);
            this.cb_cliente.Name = "cb_cliente";
            this.cb_cliente.Size = new System.Drawing.Size(173, 21);
            this.cb_cliente.TabIndex = 2;
            this.cb_cliente.ValueMember = "id_pessoa";
            this.cb_cliente.SelectedIndexChanged += new System.EventHandler(this.id_pessoaComboBox_SelectedIndexChanged);
            // 
            // pessoasBindingSource
            // 
            this.pessoasBindingSource.DataSource = typeof(Sistema.DAL.Pessoas);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nova Venda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(id_produtoLabel);
            this.groupBox1.Controls.Add(this.id_produtoComboBox);
            this.groupBox1.Controls.Add(valorLabel);
            this.groupBox1.Controls.Add(this.valorTextBox);
            this.groupBox1.Controls.Add(quantidadeLabel);
            this.groupBox1.Controls.Add(this.quantidadeTextBox);
            this.groupBox1.Controls.Add(id_vendaLabel);
            this.groupBox1.Controls.Add(this.id_vendaTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 164);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova Venda";
            this.groupBox1.Visible = false;
            // 
            // id_produtoComboBox
            // 
            this.id_produtoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itensVendasBindingSource, "id_produto", true));
            this.id_produtoComboBox.DataSource = this.produtosBindingSource;
            this.id_produtoComboBox.DisplayMember = "Descricao";
            this.id_produtoComboBox.FormattingEnabled = true;
            this.id_produtoComboBox.Location = new System.Drawing.Point(101, 56);
            this.id_produtoComboBox.Name = "id_produtoComboBox";
            this.id_produtoComboBox.Size = new System.Drawing.Size(121, 21);
            this.id_produtoComboBox.TabIndex = 8;
            this.id_produtoComboBox.ValueMember = "id";
            // 
            // itensVendasBindingSource
            // 
            this.itensVendasBindingSource.DataSource = typeof(Sistema.DAL.ItensVendas);
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataSource = typeof(Sistema.DAL.Produtos);
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(101, 124);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(121, 20);
            this.valorTextBox.TabIndex = 7;
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itensVendasBindingSource, "Quantidade", true));
            this.quantidadeTextBox.Location = new System.Drawing.Point(101, 90);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(121, 20);
            this.quantidadeTextBox.TabIndex = 5;
            // 
            // id_vendaTextBox
            // 
            this.id_vendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "id_venda", true));
            this.id_vendaTextBox.Location = new System.Drawing.Point(101, 23);
            this.id_vendaTextBox.Name = "id_vendaTextBox";
            this.id_vendaTextBox.Size = new System.Drawing.Size(121, 20);
            this.id_vendaTextBox.TabIndex = 1;
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataSource = typeof(Sistema.DAL.Vendas);
            // 
            // itensVendasDataGridView
            // 
            this.itensVendasDataGridView.AllowUserToAddRows = false;
            this.itensVendasDataGridView.AllowUserToDeleteRows = false;
            this.itensVendasDataGridView.AutoGenerateColumns = false;
            this.itensVendasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itensVendasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.Column1});
            this.itensVendasDataGridView.DataSource = this.itensVendasBindingSource;
            this.itensVendasDataGridView.Location = new System.Drawing.Point(12, 235);
            this.itensVendasDataGridView.Name = "itensVendasDataGridView";
            this.itensVendasDataGridView.ReadOnly = true;
            this.itensVendasDataGridView.Size = new System.Drawing.Size(641, 205);
            this.itensVendasDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_produto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código Produto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 103;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Produtos";
            this.dataGridViewTextBoxColumn6.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn1.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 103;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Valor";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 103;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ValorTotal";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 103;
            // 
            // frm_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(665, 460);
            this.Controls.Add(this.itensVendasDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_pessoaLabel);
            this.Controls.Add(this.cb_cliente);
            this.Name = "frm_venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela De Vendas";
            this.Load += new System.EventHandler(this.frm_venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_cliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.BindingSource itensVendasBindingSource;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.TextBox id_vendaTextBox;
        private System.Windows.Forms.BindingSource vendasBindingSource;
        private System.Windows.Forms.DataGridView itensVendasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ComboBox id_produtoComboBox;
        private System.Windows.Forms.BindingSource produtosBindingSource;
    }
}