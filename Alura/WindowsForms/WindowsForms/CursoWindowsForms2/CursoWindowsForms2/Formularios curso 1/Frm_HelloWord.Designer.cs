namespace CursoWindowsForms2
{
    partial class Frm_HelloWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HelloWord));
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Btn_MoficaLabel = new System.Windows.Forms.Button();
            this.Txt_ConteudoLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Sair.Location = new System.Drawing.Point(640, 389);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(148, 49);
            this.Btn_Sair.TabIndex = 0;
            this.Btn_Sair.Text = "Fechar Aplicação";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(30, 30);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(238, 23);
            this.Lbl_Titulo.TabIndex = 1;
            this.Lbl_Titulo.Text = "Visual Studio .Net Version";
            // 
            // Btn_MoficaLabel
            // 
            this.Btn_MoficaLabel.Location = new System.Drawing.Point(34, 56);
            this.Btn_MoficaLabel.Name = "Btn_MoficaLabel";
            this.Btn_MoficaLabel.Size = new System.Drawing.Size(234, 33);
            this.Btn_MoficaLabel.TabIndex = 2;
            this.Btn_MoficaLabel.Text = "Modifica Texto da Label";
            this.Btn_MoficaLabel.UseVisualStyleBackColor = true;
            this.Btn_MoficaLabel.Click += new System.EventHandler(this.Btn_MoficaLabel_Click);
            // 
            // Txt_ConteudoLabel
            // 
            this.Txt_ConteudoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_ConteudoLabel.Location = new System.Drawing.Point(34, 108);
            this.Txt_ConteudoLabel.Name = "Txt_ConteudoLabel";
            this.Txt_ConteudoLabel.Size = new System.Drawing.Size(241, 20);
            this.Txt_ConteudoLabel.TabIndex = 3;
            // 
            // Frm_HelloWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txt_ConteudoLabel);
            this.Controls.Add(this.Btn_MoficaLabel);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Btn_Sair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_HelloWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Button Btn_MoficaLabel;
        private System.Windows.Forms.TextBox Txt_ConteudoLabel;
    }
}

