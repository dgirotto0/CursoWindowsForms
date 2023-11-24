namespace CursoWindowsForms
{
    partial class Frm_Mascara_UC
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
            this.Btn_VerConteudo = new System.Windows.Forms.Button();
            this.Btn_Telefone = new System.Windows.Forms.Button();
            this.Btn_Senha = new System.Windows.Forms.Button();
            this.Btn_Data = new System.Windows.Forms.Button();
            this.Btn_Moeda = new System.Windows.Forms.Button();
            this.Btn_CEP = new System.Windows.Forms.Button();
            this.Btn_Hora = new System.Windows.Forms.Button();
            this.Lbl_MascaraAtiva = new System.Windows.Forms.Label();
            this.Lbl_Conteudo = new System.Windows.Forms.Label();
            this.Msk_TextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Btn_VerConteudo
            // 
            this.Btn_VerConteudo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_VerConteudo.Location = new System.Drawing.Point(36, 236);
            this.Btn_VerConteudo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_VerConteudo.Name = "Btn_VerConteudo";
            this.Btn_VerConteudo.Size = new System.Drawing.Size(344, 46);
            this.Btn_VerConteudo.TabIndex = 19;
            this.Btn_VerConteudo.Text = "Ver Conteúdo";
            this.Btn_VerConteudo.UseVisualStyleBackColor = true;
            this.Btn_VerConteudo.Click += new System.EventHandler(this.Btn_VerConteudo_Click);
            // 
            // Btn_Telefone
            // 
            this.Btn_Telefone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Telefone.Location = new System.Drawing.Point(271, 183);
            this.Btn_Telefone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Telefone.Name = "Btn_Telefone";
            this.Btn_Telefone.Size = new System.Drawing.Size(109, 46);
            this.Btn_Telefone.TabIndex = 18;
            this.Btn_Telefone.Text = "Telefone";
            this.Btn_Telefone.UseVisualStyleBackColor = true;
            this.Btn_Telefone.Click += new System.EventHandler(this.Btn_Telefone_Click);
            // 
            // Btn_Senha
            // 
            this.Btn_Senha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Senha.Location = new System.Drawing.Point(153, 183);
            this.Btn_Senha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Senha.Name = "Btn_Senha";
            this.Btn_Senha.Size = new System.Drawing.Size(109, 46);
            this.Btn_Senha.TabIndex = 17;
            this.Btn_Senha.Text = "Senha";
            this.Btn_Senha.UseVisualStyleBackColor = true;
            this.Btn_Senha.Click += new System.EventHandler(this.Btn_Senha_Click);
            // 
            // Btn_Data
            // 
            this.Btn_Data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Data.Location = new System.Drawing.Point(36, 183);
            this.Btn_Data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Data.Name = "Btn_Data";
            this.Btn_Data.Size = new System.Drawing.Size(109, 46);
            this.Btn_Data.TabIndex = 16;
            this.Btn_Data.Text = "Data";
            this.Btn_Data.UseVisualStyleBackColor = true;
            this.Btn_Data.Click += new System.EventHandler(this.Btn_Data_Click);
            // 
            // Btn_Moeda
            // 
            this.Btn_Moeda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Moeda.Location = new System.Drawing.Point(271, 130);
            this.Btn_Moeda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Moeda.Name = "Btn_Moeda";
            this.Btn_Moeda.Size = new System.Drawing.Size(109, 46);
            this.Btn_Moeda.TabIndex = 15;
            this.Btn_Moeda.Text = "Moeda";
            this.Btn_Moeda.UseVisualStyleBackColor = true;
            this.Btn_Moeda.Click += new System.EventHandler(this.Btn_Moeda_Click);
            // 
            // Btn_CEP
            // 
            this.Btn_CEP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CEP.Location = new System.Drawing.Point(153, 130);
            this.Btn_CEP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_CEP.Name = "Btn_CEP";
            this.Btn_CEP.Size = new System.Drawing.Size(109, 46);
            this.Btn_CEP.TabIndex = 14;
            this.Btn_CEP.Text = "CEP";
            this.Btn_CEP.UseVisualStyleBackColor = true;
            this.Btn_CEP.Click += new System.EventHandler(this.Btn_CEP_Click);
            // 
            // Btn_Hora
            // 
            this.Btn_Hora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Hora.Location = new System.Drawing.Point(36, 130);
            this.Btn_Hora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Hora.Name = "Btn_Hora";
            this.Btn_Hora.Size = new System.Drawing.Size(109, 46);
            this.Btn_Hora.TabIndex = 13;
            this.Btn_Hora.Text = "Hora";
            this.Btn_Hora.UseVisualStyleBackColor = true;
            this.Btn_Hora.Click += new System.EventHandler(this.Btn_Hora_Click);
            // 
            // Lbl_MascaraAtiva
            // 
            this.Lbl_MascaraAtiva.AutoSize = true;
            this.Lbl_MascaraAtiva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MascaraAtiva.Location = new System.Drawing.Point(36, 87);
            this.Lbl_MascaraAtiva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_MascaraAtiva.Name = "Lbl_MascaraAtiva";
            this.Lbl_MascaraAtiva.Size = new System.Drawing.Size(0, 24);
            this.Lbl_MascaraAtiva.TabIndex = 12;
            // 
            // Lbl_Conteudo
            // 
            this.Lbl_Conteudo.AutoSize = true;
            this.Lbl_Conteudo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Conteudo.Location = new System.Drawing.Point(36, 298);
            this.Lbl_Conteudo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Conteudo.Name = "Lbl_Conteudo";
            this.Lbl_Conteudo.Size = new System.Drawing.Size(0, 19);
            this.Lbl_Conteudo.TabIndex = 11;
            // 
            // Msk_TextBox
            // 
            this.Msk_TextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msk_TextBox.Location = new System.Drawing.Point(36, 33);
            this.Msk_TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Msk_TextBox.Name = "Msk_TextBox";
            this.Msk_TextBox.Size = new System.Drawing.Size(343, 30);
            this.Msk_TextBox.TabIndex = 10;
            // 
            // Frm_Mascara_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_VerConteudo);
            this.Controls.Add(this.Btn_Telefone);
            this.Controls.Add(this.Btn_Senha);
            this.Controls.Add(this.Btn_Data);
            this.Controls.Add(this.Btn_Moeda);
            this.Controls.Add(this.Btn_CEP);
            this.Controls.Add(this.Btn_Hora);
            this.Controls.Add(this.Lbl_MascaraAtiva);
            this.Controls.Add(this.Lbl_Conteudo);
            this.Controls.Add(this.Msk_TextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Mascara_UC";
            this.Size = new System.Drawing.Size(424, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_VerConteudo;
        private System.Windows.Forms.Button Btn_Telefone;
        private System.Windows.Forms.Button Btn_Senha;
        private System.Windows.Forms.Button Btn_Data;
        private System.Windows.Forms.Button Btn_Moeda;
        private System.Windows.Forms.Button Btn_CEP;
        private System.Windows.Forms.Button Btn_Hora;
        private System.Windows.Forms.Label Lbl_MascaraAtiva;
        private System.Windows.Forms.Label Lbl_Conteudo;
        private System.Windows.Forms.MaskedTextBox Msk_TextBox;
    }
}
