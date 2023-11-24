using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Login : Form
    {

        public string senha;
        public string login;

        public Frm_Login()
        {
            InitializeComponent();

            Lbl_Login.Text = "Usuário";
            Lbl_Password.Text = "Senha";
            Btn_OK.Text = "OK";

            Cbx_Eagle.Visible = false;
            Cbx_Infordoc.Visible = false;       
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {
            pnlLogin.BackColor = Color.FromArgb(85, 0, 0, 0);
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {           
            DialogResult = DialogResult.OK;

            senha = Txt_Senha.Text;
            login = Txt_Login.Text;
          
            Frm_Principal_Menu_UC frm = Application.OpenForms["Form"] as Frm_Principal_Menu_UC;
            if (frm == null)
            {
                // Se o Form2 não existe, crie uma nova instância
                frm = new Frm_Principal_Menu_UC();
            }
            this.Hide();
            frm.Show();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7)
            {
                if (Cbx_Eagle.Visible && Cbx_Infordoc.Visible)
                {
                    Cbx_Eagle.Visible = false;
                    Cbx_Infordoc.Visible = false;
                }
                else
                {
                    Cbx_Eagle.Visible = true;
                    Cbx_Infordoc.Visible = true;
                }

            }
            
            if(e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
                senha = Txt_Senha.Text;
                login = Txt_Login.Text;

                Frm_Principal_Menu_UC frm = Application.OpenForms["Form"] as Frm_Principal_Menu_UC;

                if (frm == null)
                {
                    // Se o Form2 não existe, crie uma nova instância
                    frm = new Frm_Principal_Menu_UC();
                }
                this.Hide();
                frm.Show();
            }
        }
    }
}

