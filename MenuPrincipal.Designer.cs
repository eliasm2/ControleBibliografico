namespace Controle_bibliografico
{
    partial class MenuPrincial
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
            this.dgvReferencia = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.txtPagina = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.txtAutor3 = new System.Windows.Forms.TextBox();
            this.txtAutor2 = new System.Windows.Forms.TextBox();
            this.txtAutor1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodBibliografico = new System.Windows.Forms.TextBox();
            this.lblQtdReposicao = new System.Windows.Forms.Label();
            this.lblAutor3 = new System.Windows.Forms.Label();
            this.lblQtdEstoque = new System.Windows.Forms.Label();
            this.lblAutor2 = new System.Windows.Forms.Label();
            this.lblPrecoUnitario = new System.Windows.Forms.Label();
            this.lblAutor1 = new System.Windows.Forms.Label();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.lblEdicao = new System.Windows.Forms.Label();
            this.txtEdição = new System.Windows.Forms.TextBox();
            this.btListar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReferencia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReferencia
            // 
            this.dgvReferencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReferencia.Location = new System.Drawing.Point(15, 217);
            this.dgvReferencia.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReferencia.Name = "dgvReferencia";
            this.dgvReferencia.Size = new System.Drawing.Size(1360, 430);
            this.dgvReferencia.TabIndex = 42;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(661, 65);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(47, 17);
            this.lblTitulo.TabIndex = 41;
            this.lblTitulo.Text = "Titulo:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(395, 16);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 28);
            this.btnPesquisar.TabIndex = 40;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(907, 176);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 28);
            this.btnExcluir.TabIndex = 39;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(1152, 176);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 28);
            this.btnFechar.TabIndex = 38;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(787, 176);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 28);
            this.btnAlterar.TabIndex = 37;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(655, 176);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(100, 28);
            this.btnIncluir.TabIndex = 36;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // txtPagina
            // 
            this.txtPagina.Location = new System.Drawing.Point(386, 179);
            this.txtPagina.Margin = new System.Windows.Forms.Padding(4);
            this.txtPagina.Name = "txtPagina";
            this.txtPagina.Size = new System.Drawing.Size(91, 22);
            this.txtPagina.TabIndex = 8;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(65, 176);
            this.txtAno.Margin = new System.Windows.Forms.Padding(4);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(91, 22);
            this.txtAno.TabIndex = 7;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(722, 126);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(405, 22);
            this.txtCidade.TabIndex = 6;
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(722, 66);
            this.txttitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(405, 22);
            this.txttitulo.TabIndex = 4;
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(722, 96);
            this.txtEditora.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(405, 22);
            this.txtEditora.TabIndex = 5;
            // 
            // txtAutor3
            // 
            this.txtAutor3.Location = new System.Drawing.Point(84, 121);
            this.txtAutor3.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor3.Name = "txtAutor3";
            this.txtAutor3.Size = new System.Drawing.Size(480, 22);
            this.txtAutor3.TabIndex = 3;
            // 
            // txtAutor2
            // 
            this.txtAutor2.Location = new System.Drawing.Point(84, 92);
            this.txtAutor2.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor2.Name = "txtAutor2";
            this.txtAutor2.Size = new System.Drawing.Size(480, 22);
            this.txtAutor2.TabIndex = 2;
            // 
            // txtAutor1
            // 
            this.txtAutor1.Location = new System.Drawing.Point(84, 62);
            this.txtAutor1.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor1.Name = "txtAutor1";
            this.txtAutor1.Size = new System.Drawing.Size(480, 22);
            this.txtAutor1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Pagina:";
            // 
            // txtCodBibliografico
            // 
            this.txtCodBibliografico.Location = new System.Drawing.Point(199, 19);
            this.txtCodBibliografico.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodBibliografico.Name = "txtCodBibliografico";
            this.txtCodBibliografico.Size = new System.Drawing.Size(132, 22);
            this.txtCodBibliografico.TabIndex = 27;
            // 
            // lblQtdReposicao
            // 
            this.lblQtdReposicao.AutoSize = true;
            this.lblQtdReposicao.Location = new System.Drawing.Point(23, 179);
            this.lblQtdReposicao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtdReposicao.Name = "lblQtdReposicao";
            this.lblQtdReposicao.Size = new System.Drawing.Size(37, 17);
            this.lblQtdReposicao.TabIndex = 25;
            this.lblQtdReposicao.Text = "Ano:";
            // 
            // lblAutor3
            // 
            this.lblAutor3.AutoSize = true;
            this.lblAutor3.Location = new System.Drawing.Point(23, 126);
            this.lblAutor3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutor3.Name = "lblAutor3";
            this.lblAutor3.Size = new System.Drawing.Size(58, 17);
            this.lblAutor3.TabIndex = 21;
            this.lblAutor3.Text = "Autor 3:";
            // 
            // lblQtdEstoque
            // 
            this.lblQtdEstoque.AutoSize = true;
            this.lblQtdEstoque.Location = new System.Drawing.Point(661, 131);
            this.lblQtdEstoque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtdEstoque.Name = "lblQtdEstoque";
            this.lblQtdEstoque.Size = new System.Drawing.Size(56, 17);
            this.lblQtdEstoque.TabIndex = 24;
            this.lblQtdEstoque.Text = "Cidade:";
            // 
            // lblAutor2
            // 
            this.lblAutor2.AutoSize = true;
            this.lblAutor2.Location = new System.Drawing.Point(22, 96);
            this.lblAutor2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutor2.Name = "lblAutor2";
            this.lblAutor2.Size = new System.Drawing.Size(58, 17);
            this.lblAutor2.TabIndex = 20;
            this.lblAutor2.Text = "Autor 2:";
            // 
            // lblPrecoUnitario
            // 
            this.lblPrecoUnitario.AutoSize = true;
            this.lblPrecoUnitario.Location = new System.Drawing.Point(661, 99);
            this.lblPrecoUnitario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecoUnitario.Name = "lblPrecoUnitario";
            this.lblPrecoUnitario.Size = new System.Drawing.Size(57, 17);
            this.lblPrecoUnitario.TabIndex = 23;
            this.lblPrecoUnitario.Text = "Editora:";
            // 
            // lblAutor1
            // 
            this.lblAutor1.AutoSize = true;
            this.lblAutor1.Location = new System.Drawing.Point(22, 66);
            this.lblAutor1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutor1.Name = "lblAutor1";
            this.lblAutor1.Size = new System.Drawing.Size(58, 17);
            this.lblAutor1.TabIndex = 22;
            this.lblAutor1.Text = "Autor 1:";
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Location = new System.Drawing.Point(23, 23);
            this.lblCodProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(133, 17);
            this.lblCodProduto.TabIndex = 19;
            this.lblCodProduto.Text = "Codigo Bibliografico";
            // 
            // lblEdicao
            // 
            this.lblEdicao.AutoSize = true;
            this.lblEdicao.Location = new System.Drawing.Point(164, 179);
            this.lblEdicao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdicao.Name = "lblEdicao";
            this.lblEdicao.Size = new System.Drawing.Size(55, 17);
            this.lblEdicao.TabIndex = 26;
            this.lblEdicao.Text = "Edição:";
            // 
            // txtEdição
            // 
            this.txtEdição.Location = new System.Drawing.Point(228, 176);
            this.txtEdição.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdição.Name = "txtEdição";
            this.txtEdição.Size = new System.Drawing.Size(91, 22);
            this.txtEdição.TabIndex = 8;
            // 
            // btListar
            // 
            this.btListar.Location = new System.Drawing.Point(527, 176);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(100, 28);
            this.btListar.TabIndex = 43;
            this.btListar.Text = "Listar";
            this.btListar.UseVisualStyleBackColor = true;
            this.btListar.Click += new System.EventHandler(this.btListar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(1040, 176);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(87, 28);
            this.btnImportar.TabIndex = 44;
            this.btnImportar.Text = "importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // MenuPrincial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 675);
            this.ControlBox = false;
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btListar);
            this.Controls.Add(this.dgvReferencia);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtEdição);
            this.Controls.Add(this.txtPagina);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.txtAutor3);
            this.Controls.Add(this.txtAutor2);
            this.Controls.Add(this.lblEdicao);
            this.Controls.Add(this.txtAutor1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodBibliografico);
            this.Controls.Add(this.lblQtdReposicao);
            this.Controls.Add(this.lblAutor3);
            this.Controls.Add(this.lblQtdEstoque);
            this.Controls.Add(this.lblAutor2);
            this.Controls.Add(this.lblPrecoUnitario);
            this.Controls.Add(this.lblAutor1);
            this.Controls.Add(this.lblCodProduto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuPrincial";
            this.Text = "Controle Biblografico";
            this.Load += new System.EventHandler(this.MenuPrincial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReferencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvReferencia;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox txtPagina;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.TextBox txtAutor3;
        private System.Windows.Forms.TextBox txtAutor2;
        private System.Windows.Forms.TextBox txtAutor1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodBibliografico;
        private System.Windows.Forms.Label lblQtdReposicao;
        private System.Windows.Forms.Label lblAutor3;
        private System.Windows.Forms.Label lblQtdEstoque;
        private System.Windows.Forms.Label lblAutor2;
        private System.Windows.Forms.Label lblPrecoUnitario;
        private System.Windows.Forms.Label lblAutor1;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.Label lblEdicao;
        private System.Windows.Forms.TextBox txtEdição;
        private System.Windows.Forms.Button btListar;
        private System.Windows.Forms.Button btnImportar;
    }
}

