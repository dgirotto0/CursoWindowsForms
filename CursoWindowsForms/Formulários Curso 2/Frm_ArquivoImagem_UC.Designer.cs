﻿namespace CursoWindowsForms
{
    partial class Frm_ArquivoImagem_UC
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_ArquivoImagem = new System.Windows.Forms.Label();
            this.Pic_ArquivoImagem = new System.Windows.Forms.PictureBox();
            this.Btn_Cor = new System.Windows.Forms.Button();
            this.Btn_Fonte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_ArquivoImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_ArquivoImagem
            // 
            this.Lbl_ArquivoImagem.AutoSize = true;
            this.Lbl_ArquivoImagem.Location = new System.Drawing.Point(23, 44);
            this.Lbl_ArquivoImagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ArquivoImagem.Name = "Lbl_ArquivoImagem";
            this.Lbl_ArquivoImagem.Size = new System.Drawing.Size(44, 16);
            this.Lbl_ArquivoImagem.TabIndex = 0;
            this.Lbl_ArquivoImagem.Text = "label1";
            // 
            // Pic_ArquivoImagem
            // 
            this.Pic_ArquivoImagem.Location = new System.Drawing.Point(27, 94);
            this.Pic_ArquivoImagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pic_ArquivoImagem.Name = "Pic_ArquivoImagem";
            this.Pic_ArquivoImagem.Size = new System.Drawing.Size(279, 192);
            this.Pic_ArquivoImagem.TabIndex = 1;
            this.Pic_ArquivoImagem.TabStop = false;
            // 
            // Btn_Cor
            // 
            this.Btn_Cor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cor.Location = new System.Drawing.Point(27, 5);
            this.Btn_Cor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Cor.Name = "Btn_Cor";
            this.Btn_Cor.Size = new System.Drawing.Size(100, 28);
            this.Btn_Cor.TabIndex = 2;
            this.Btn_Cor.Text = "Cor";
            this.Btn_Cor.UseVisualStyleBackColor = true;
            this.Btn_Cor.Click += new System.EventHandler(this.Btn_Cor_Click);
            // 
            // Btn_Fonte
            // 
            this.Btn_Fonte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Fonte.Location = new System.Drawing.Point(135, 5);
            this.Btn_Fonte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Fonte.Name = "Btn_Fonte";
            this.Btn_Fonte.Size = new System.Drawing.Size(100, 28);
            this.Btn_Fonte.TabIndex = 3;
            this.Btn_Fonte.Text = "Fonte";
            this.Btn_Fonte.UseVisualStyleBackColor = true;
            this.Btn_Fonte.Click += new System.EventHandler(this.Btn_Fonte_Click);
            // 
            // Frm_ArquivoImagem_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Fonte);
            this.Controls.Add(this.Btn_Cor);
            this.Controls.Add(this.Pic_ArquivoImagem);
            this.Controls.Add(this.Lbl_ArquivoImagem);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_ArquivoImagem_UC";
            this.Size = new System.Drawing.Size(731, 357);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_ArquivoImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_ArquivoImagem;
        private System.Windows.Forms.PictureBox Pic_ArquivoImagem;
        private System.Windows.Forms.Button Btn_Cor;
        private System.Windows.Forms.Button Btn_Fonte;
    }
}
