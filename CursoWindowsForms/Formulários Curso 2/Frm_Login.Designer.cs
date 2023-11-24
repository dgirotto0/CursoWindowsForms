namespace CursoWindowsForms
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.Lbl_Login = new System.Windows.Forms.Label();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Txt_Login = new System.Windows.Forms.TextBox();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_infordoc = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Llbl_esqueceuSenha = new System.Windows.Forms.LinkLabel();
            this.lbl_tituloLogin = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.Cbx_Infordoc = new System.Windows.Forms.CheckBox();
            this.Cbx_Eagle = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Login
            // 
            this.Lbl_Login.AutoSize = true;
            this.Lbl_Login.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Login.ForeColor = System.Drawing.Color.White;
            this.Lbl_Login.Location = new System.Drawing.Point(33, 93);
            this.Lbl_Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Login.Name = "Lbl_Login";
            this.Lbl_Login.Size = new System.Drawing.Size(44, 16);
            this.Lbl_Login.TabIndex = 1;
            this.Lbl_Login.Text = "label1";
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Password.ForeColor = System.Drawing.Color.White;
            this.Lbl_Password.Location = new System.Drawing.Point(33, 152);
            this.Lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(44, 16);
            this.Lbl_Password.TabIndex = 2;
            this.Lbl_Password.Text = "label2";
            // 
            // Txt_Login
            // 
            this.Txt_Login.Location = new System.Drawing.Point(36, 113);
            this.Txt_Login.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Login.Name = "Txt_Login";
            this.Txt_Login.Size = new System.Drawing.Size(240, 22);
            this.Txt_Login.TabIndex = 3;
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Location = new System.Drawing.Point(36, 172);
            this.Txt_Senha.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PasswordChar = '*';
            this.Txt_Senha.Size = new System.Drawing.Size(240, 22);
            this.Txt_Senha.TabIndex = 4;
            this.Txt_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Senha_KeyDown);
            // 
            // Btn_OK
            // 
            this.Btn_OK.BackColor = System.Drawing.Color.Transparent;
            this.Btn_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_OK.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.ForeColor = System.Drawing.Color.White;
            this.Btn_OK.Location = new System.Drawing.Point(70, 214);
            this.Btn_OK.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(156, 28);
            this.Btn_OK.TabIndex = 5;
            this.Btn_OK.Text = "button1";
            this.Btn_OK.UseVisualStyleBackColor = false;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Cancel.BackgroundImage")));
            this.Btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cancel.FlatAppearance.BorderSize = 0;
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Location = new System.Drawing.Point(826, -1);
            this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(46, 37);
            this.Btn_Cancel.TabIndex = 6;
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lbl_infordoc);
            this.panel1.Controls.Add(this.Btn_Cancel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 36);
            this.panel1.TabIndex = 7;
            // 
            // lbl_infordoc
            // 
            this.lbl_infordoc.AutoSize = true;
            this.lbl_infordoc.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_infordoc.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_infordoc.Location = new System.Drawing.Point(11, 4);
            this.lbl_infordoc.Name = "lbl_infordoc";
            this.lbl_infordoc.Size = new System.Drawing.Size(70, 22);
            this.lbl_infordoc.TabIndex = 8;
            this.lbl_infordoc.Text = "Infordoc";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Llbl_esqueceuSenha
            // 
            this.Llbl_esqueceuSenha.AutoSize = true;
            this.Llbl_esqueceuSenha.BackColor = System.Drawing.Color.Transparent;
            this.Llbl_esqueceuSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Llbl_esqueceuSenha.LinkColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Llbl_esqueceuSenha.Location = new System.Drawing.Point(98, 261);
            this.Llbl_esqueceuSenha.Name = "Llbl_esqueceuSenha";
            this.Llbl_esqueceuSenha.Size = new System.Drawing.Size(96, 16);
            this.Llbl_esqueceuSenha.TabIndex = 9;
            this.Llbl_esqueceuSenha.TabStop = true;
            this.Llbl_esqueceuSenha.Text = "Esqueci senha";
            // 
            // lbl_tituloLogin
            // 
            this.lbl_tituloLogin.AutoSize = true;
            this.lbl_tituloLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tituloLogin.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tituloLogin.ForeColor = System.Drawing.Color.White;
            this.lbl_tituloLogin.Location = new System.Drawing.Point(116, 33);
            this.lbl_tituloLogin.Name = "lbl_tituloLogin";
            this.lbl_tituloLogin.Size = new System.Drawing.Size(65, 27);
            this.lbl_tituloLogin.TabIndex = 6;
            this.lbl_tituloLogin.Text = "Login";
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Gray;
            this.pnlLogin.Controls.Add(this.Cbx_Infordoc);
            this.pnlLogin.Controls.Add(this.Cbx_Eagle);
            this.pnlLogin.Controls.Add(this.pictureBox2);
            this.pnlLogin.Controls.Add(this.pictureBox1);
            this.pnlLogin.Controls.Add(this.Llbl_esqueceuSenha);
            this.pnlLogin.Controls.Add(this.lbl_tituloLogin);
            this.pnlLogin.Controls.Add(this.Lbl_Login);
            this.pnlLogin.Controls.Add(this.Lbl_Password);
            this.pnlLogin.Controls.Add(this.Btn_OK);
            this.pnlLogin.Controls.Add(this.Txt_Login);
            this.pnlLogin.Controls.Add(this.Txt_Senha);
            this.pnlLogin.Location = new System.Drawing.Point(46, 88);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(295, 362);
            this.pnlLogin.TabIndex = 8;
            this.pnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogin_Paint);
            // 
            // Cbx_Infordoc
            // 
            this.Cbx_Infordoc.AutoSize = true;
            this.Cbx_Infordoc.BackColor = System.Drawing.Color.Transparent;
            this.Cbx_Infordoc.ForeColor = System.Drawing.Color.White;
            this.Cbx_Infordoc.Location = new System.Drawing.Point(46, 316);
            this.Cbx_Infordoc.Name = "Cbx_Infordoc";
            this.Cbx_Infordoc.Size = new System.Drawing.Size(77, 20);
            this.Cbx_Infordoc.TabIndex = 12;
            this.Cbx_Infordoc.Text = "Infordoc";
            this.Cbx_Infordoc.UseVisualStyleBackColor = false;
            // 
            // Cbx_Eagle
            // 
            this.Cbx_Eagle.AutoSize = true;
            this.Cbx_Eagle.BackColor = System.Drawing.Color.Transparent;
            this.Cbx_Eagle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Cbx_Eagle.ForeColor = System.Drawing.Color.White;
            this.Cbx_Eagle.Location = new System.Drawing.Point(189, 316);
            this.Cbx_Eagle.Name = "Cbx_Eagle";
            this.Cbx_Eagle.Size = new System.Drawing.Size(65, 20);
            this.Cbx_Eagle.TabIndex = 13;
            this.Cbx_Eagle.Text = "Eagle";
            this.Cbx_Eagle.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(871, 482);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(871, 482);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Login;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.TextBox Txt_Login;
        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_infordoc;
        private System.Windows.Forms.Label lbl_tituloLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel Llbl_esqueceuSenha;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.CheckBox Cbx_Infordoc;
        private System.Windows.Forms.CheckBox Cbx_Eagle;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}