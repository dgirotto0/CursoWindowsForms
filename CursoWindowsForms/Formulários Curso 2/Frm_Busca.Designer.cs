namespace CursoWindowsForms
{
    partial class Frm_Busca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Busca));
            this.Tls_Principal = new System.Windows.Forms.ToolStrip();
            this.salvarStripButton = new System.Windows.Forms.ToolStripButton();
            this.excluirStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.Lst_Busca = new System.Windows.Forms.ListBox();
            this.Tls_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tls_Principal
            // 
            this.Tls_Principal.BackColor = System.Drawing.Color.Black;
            this.Tls_Principal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Tls_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarStripButton,
            this.excluirStripButton,
            this.toolStripSeparator1,
            this.toolStripSeparator});
            this.Tls_Principal.Location = new System.Drawing.Point(0, 0);
            this.Tls_Principal.Name = "Tls_Principal";
            this.Tls_Principal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Tls_Principal.Size = new System.Drawing.Size(620, 27);
            this.Tls_Principal.TabIndex = 65;
            this.Tls_Principal.Text = "toolStrip1";
            // 
            // salvarStripButton
            // 
            this.salvarStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarStripButton.ForeColor = System.Drawing.Color.White;
            this.salvarStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarStripButton.Image")));
            this.salvarStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarStripButton.Name = "salvarStripButton";
            this.salvarStripButton.Size = new System.Drawing.Size(29, 24);
            this.salvarStripButton.Text = "toolStripButton3";
            this.salvarStripButton.Click += new System.EventHandler(this.salvarStripButton_Click);
            // 
            // excluirStripButton
            // 
            this.excluirStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.excluirStripButton.ForeColor = System.Drawing.Color.White;
            this.excluirStripButton.Image = ((System.Drawing.Image)(resources.GetObject("excluirStripButton.Image")));
            this.excluirStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.excluirStripButton.Name = "excluirStripButton";
            this.excluirStripButton.Size = new System.Drawing.Size(29, 24);
            this.excluirStripButton.Text = "toolStripButton4";
            this.excluirStripButton.Click += new System.EventHandler(this.excluirStripButton_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // Lst_Busca
            // 
            this.Lst_Busca.FormattingEnabled = true;
            this.Lst_Busca.ItemHeight = 16;
            this.Lst_Busca.Location = new System.Drawing.Point(12, 70);
            this.Lst_Busca.Name = "Lst_Busca";
            this.Lst_Busca.Size = new System.Drawing.Size(596, 388);
            this.Lst_Busca.TabIndex = 66;
            // 
            // Frm_Busca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 478);
            this.Controls.Add(this.Lst_Busca);
            this.Controls.Add(this.Tls_Principal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Busca";
            this.Text = "Buscar";
            this.Tls_Principal.ResumeLayout(false);
            this.Tls_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Tls_Principal;
        private System.Windows.Forms.ToolStripButton salvarStripButton;
        private System.Windows.Forms.ToolStripButton excluirStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ListBox Lst_Busca;
    }
}