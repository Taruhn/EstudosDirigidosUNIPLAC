namespace ListaCompras.WinApp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tab_produto = new System.Windows.Forms.TabPage();
            this.btn_confirmar_teste = new System.Windows.Forms.Button();
            this.cmb_unidade_produto = new System.Windows.Forms.ComboBox();
            this.Txt_preco_produto = new System.Windows.Forms.TextBox();
            this.Txt_nome_produto = new System.Windows.Forms.TextBox();
            this.Label_preco_produto = new System.Windows.Forms.Label();
            this.Label_unidade_produto = new System.Windows.Forms.Label();
            this.Label_nome_produto = new System.Windows.Forms.Label();
            this.Tab_lista_compras = new System.Windows.Forms.TabPage();
            this.listaProdutos = new System.Windows.Forms.ListBox();
            this.btnSalvarProduto = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Tab_produto.SuspendLayout();
            this.Tab_lista_compras.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tab_produto);
            this.tabControl1.Controls.Add(this.Tab_lista_compras);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(522, 410);
            this.tabControl1.TabIndex = 0;
            // 
            // Tab_produto
            // 
            this.Tab_produto.Controls.Add(this.btnSalvarProduto);
            this.Tab_produto.Controls.Add(this.btn_confirmar_teste);
            this.Tab_produto.Controls.Add(this.cmb_unidade_produto);
            this.Tab_produto.Controls.Add(this.Txt_preco_produto);
            this.Tab_produto.Controls.Add(this.Txt_nome_produto);
            this.Tab_produto.Controls.Add(this.Label_preco_produto);
            this.Tab_produto.Controls.Add(this.Label_unidade_produto);
            this.Tab_produto.Controls.Add(this.Label_nome_produto);
            this.Tab_produto.Location = new System.Drawing.Point(4, 22);
            this.Tab_produto.Name = "Tab_produto";
            this.Tab_produto.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_produto.Size = new System.Drawing.Size(514, 384);
            this.Tab_produto.TabIndex = 0;
            this.Tab_produto.Text = "Produto";
            this.Tab_produto.UseVisualStyleBackColor = true;
            // 
            // btn_confirmar_teste
            // 
            this.btn_confirmar_teste.Location = new System.Drawing.Point(55, 340);
            this.btn_confirmar_teste.Name = "btn_confirmar_teste";
            this.btn_confirmar_teste.Size = new System.Drawing.Size(75, 23);
            this.btn_confirmar_teste.TabIndex = 10;
            this.btn_confirmar_teste.Text = "Confirmar teste";
            this.btn_confirmar_teste.UseVisualStyleBackColor = true;
            this.btn_confirmar_teste.Click += new System.EventHandler(this.Btn_confirmar_teste_Click);
            // 
            // cmb_unidade_produto
            // 
            this.cmb_unidade_produto.FormattingEnabled = true;
            this.cmb_unidade_produto.Items.AddRange(new object[] {
            "Quilo(s)",
            "Grama(s)",
            "Litro(s)",
            "ml"});
            this.cmb_unidade_produto.Location = new System.Drawing.Point(207, 150);
            this.cmb_unidade_produto.Name = "cmb_unidade_produto";
            this.cmb_unidade_produto.Size = new System.Drawing.Size(121, 21);
            this.cmb_unidade_produto.TabIndex = 9;
            // 
            // Txt_preco_produto
            // 
            this.Txt_preco_produto.Location = new System.Drawing.Point(207, 86);
            this.Txt_preco_produto.Name = "Txt_preco_produto";
            this.Txt_preco_produto.Size = new System.Drawing.Size(121, 20);
            this.Txt_preco_produto.TabIndex = 6;
            // 
            // Txt_nome_produto
            // 
            this.Txt_nome_produto.Location = new System.Drawing.Point(207, 24);
            this.Txt_nome_produto.Name = "Txt_nome_produto";
            this.Txt_nome_produto.Size = new System.Drawing.Size(121, 20);
            this.Txt_nome_produto.TabIndex = 5;
            this.Txt_nome_produto.TextChanged += new System.EventHandler(this.Txt_nome_produto_TextChanged);
            // 
            // Label_preco_produto
            // 
            this.Label_preco_produto.AutoSize = true;
            this.Label_preco_produto.Location = new System.Drawing.Point(52, 86);
            this.Label_preco_produto.Name = "Label_preco_produto";
            this.Label_preco_produto.Size = new System.Drawing.Size(93, 13);
            this.Label_preco_produto.TabIndex = 2;
            this.Label_preco_produto.Text = "Preço do Produto:";
            // 
            // Label_unidade_produto
            // 
            this.Label_unidade_produto.AutoSize = true;
            this.Label_unidade_produto.Location = new System.Drawing.Point(52, 153);
            this.Label_unidade_produto.Name = "Label_unidade_produto";
            this.Label_unidade_produto.Size = new System.Drawing.Size(105, 13);
            this.Label_unidade_produto.TabIndex = 1;
            this.Label_unidade_produto.Text = "Unidade do Produto:";
            // 
            // Label_nome_produto
            // 
            this.Label_nome_produto.AutoSize = true;
            this.Label_nome_produto.Location = new System.Drawing.Point(52, 24);
            this.Label_nome_produto.Name = "Label_nome_produto";
            this.Label_nome_produto.Size = new System.Drawing.Size(93, 13);
            this.Label_nome_produto.TabIndex = 0;
            this.Label_nome_produto.Text = "Nome do Produto:";
            // 
            // Tab_lista_compras
            // 
            this.Tab_lista_compras.Controls.Add(this.listaProdutos);
            this.Tab_lista_compras.Location = new System.Drawing.Point(4, 22);
            this.Tab_lista_compras.Name = "Tab_lista_compras";
            this.Tab_lista_compras.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_lista_compras.Size = new System.Drawing.Size(514, 384);
            this.Tab_lista_compras.TabIndex = 1;
            this.Tab_lista_compras.Text = "Lista de Compras";
            this.Tab_lista_compras.UseVisualStyleBackColor = true;
            // 
            // listaProdutos
            // 
            this.listaProdutos.FormattingEnabled = true;
            this.listaProdutos.Location = new System.Drawing.Point(30, 28);
            this.listaProdutos.Name = "listaProdutos";
            this.listaProdutos.Size = new System.Drawing.Size(444, 342);
            this.listaProdutos.TabIndex = 0;
            this.listaProdutos.SelectedIndexChanged += new System.EventHandler(this.ListBox_lista_compras_SelectedIndexChanged);
            // 
            // btnSalvarProduto
            // 
            this.btnSalvarProduto.Location = new System.Drawing.Point(240, 213);
            this.btnSalvarProduto.Name = "btnSalvarProduto";
            this.btnSalvarProduto.Size = new System.Drawing.Size(88, 23);
            this.btnSalvarProduto.TabIndex = 11;
            this.btnSalvarProduto.Text = "Salvar";
            this.btnSalvarProduto.UseVisualStyleBackColor = true;
            this.btnSalvarProduto.Click += new System.EventHandler(this.btnSalvarProduto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 442);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Produto";
            this.tabControl1.ResumeLayout(false);
            this.Tab_produto.ResumeLayout(false);
            this.Tab_produto.PerformLayout();
            this.Tab_lista_compras.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tab_produto;
        private System.Windows.Forms.ComboBox cmb_unidade_produto;
        private System.Windows.Forms.TextBox Txt_preco_produto;
        private System.Windows.Forms.TextBox Txt_nome_produto;
        private System.Windows.Forms.Label Label_preco_produto;
        private System.Windows.Forms.Label Label_unidade_produto;
        private System.Windows.Forms.Label Label_nome_produto;
        private System.Windows.Forms.TabPage Tab_lista_compras;
        private System.Windows.Forms.ListBox listaProdutos;
        private System.Windows.Forms.Button btn_confirmar_teste;
        private System.Windows.Forms.Button btnSalvarProduto;
    }
}

