namespace Controle_bibliografico.Forms
{
    partial class importar
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
            this.tb_diretorioImportarArquivo = new System.Windows.Forms.TextBox();
            this.bt_fecharImportarArquivo = new System.Windows.Forms.Button();
            this.bt_processarImportarArquivo = new System.Windows.Forms.Button();
            this.bt_uploadImportarArquivo = new System.Windows.Forms.Button();
            this.lb_importarArquivo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_diretorioImportarArquivo
            // 
            this.tb_diretorioImportarArquivo.Location = new System.Drawing.Point(32, 43);
            this.tb_diretorioImportarArquivo.Margin = new System.Windows.Forms.Padding(4);
            this.tb_diretorioImportarArquivo.Name = "tb_diretorioImportarArquivo";
            this.tb_diretorioImportarArquivo.Size = new System.Drawing.Size(315, 22);
            this.tb_diretorioImportarArquivo.TabIndex = 9;
            // 
            // bt_fecharImportarArquivo
            // 
            this.bt_fecharImportarArquivo.Location = new System.Drawing.Point(248, 101);
            this.bt_fecharImportarArquivo.Margin = new System.Windows.Forms.Padding(4);
            this.bt_fecharImportarArquivo.Name = "bt_fecharImportarArquivo";
            this.bt_fecharImportarArquivo.Size = new System.Drawing.Size(100, 28);
            this.bt_fecharImportarArquivo.TabIndex = 8;
            this.bt_fecharImportarArquivo.Text = "Fechar";
            this.bt_fecharImportarArquivo.UseVisualStyleBackColor = true;
            this.bt_fecharImportarArquivo.Click += new System.EventHandler(this.bt_fecharImportarArquivo_Click);
            // 
            // bt_processarImportarArquivo
            // 
            this.bt_processarImportarArquivo.Enabled = false;
            this.bt_processarImportarArquivo.Location = new System.Drawing.Point(140, 101);
            this.bt_processarImportarArquivo.Margin = new System.Windows.Forms.Padding(4);
            this.bt_processarImportarArquivo.Name = "bt_processarImportarArquivo";
            this.bt_processarImportarArquivo.Size = new System.Drawing.Size(100, 28);
            this.bt_processarImportarArquivo.TabIndex = 7;
            this.bt_processarImportarArquivo.Text = "Processar";
            this.bt_processarImportarArquivo.UseVisualStyleBackColor = true;
            this.bt_processarImportarArquivo.Click += new System.EventHandler(this.bt_processarImportarArquivo_Click_1);
            // 
            // bt_uploadImportarArquivo
            // 
            this.bt_uploadImportarArquivo.Location = new System.Drawing.Point(32, 101);
            this.bt_uploadImportarArquivo.Margin = new System.Windows.Forms.Padding(4);
            this.bt_uploadImportarArquivo.Name = "bt_uploadImportarArquivo";
            this.bt_uploadImportarArquivo.Size = new System.Drawing.Size(100, 28);
            this.bt_uploadImportarArquivo.TabIndex = 6;
            this.bt_uploadImportarArquivo.Text = "Upload";
            this.bt_uploadImportarArquivo.UseVisualStyleBackColor = true;
            this.bt_uploadImportarArquivo.Click += new System.EventHandler(this.bt_uploadImportarArquivo_Click_1);
            // 
            // lb_importarArquivo
            // 
            this.lb_importarArquivo.AutoSize = true;
            this.lb_importarArquivo.Location = new System.Drawing.Point(28, 24);
            this.lb_importarArquivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_importarArquivo.Name = "lb_importarArquivo";
            this.lb_importarArquivo.Size = new System.Drawing.Size(66, 17);
            this.lb_importarArquivo.TabIndex = 5;
            this.lb_importarArquivo.Text = "Diretório:";
            // 
            // importar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 179);
            this.ControlBox = false;
            this.Controls.Add(this.tb_diretorioImportarArquivo);
            this.Controls.Add(this.bt_fecharImportarArquivo);
            this.Controls.Add(this.bt_processarImportarArquivo);
            this.Controls.Add(this.bt_uploadImportarArquivo);
            this.Controls.Add(this.lb_importarArquivo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "importar";
            this.Text = "importar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_diretorioImportarArquivo;
        private System.Windows.Forms.Button bt_fecharImportarArquivo;
        private System.Windows.Forms.Button bt_processarImportarArquivo;
        private System.Windows.Forms.Button bt_uploadImportarArquivo;
        private System.Windows.Forms.Label lb_importarArquivo;
    }
}