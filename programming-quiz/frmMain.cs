using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace programming_quiz
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        

        private void cmdJogar_Click(object sender, EventArgs e)
        {
            frmJogar frm = new frmJogar();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void cmdPontuacao_Click(object sender, EventArgs e)
        {
            frmPontuacao frm = new frmPontuacao();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            frmSair sair = new frmSair();
            sair.ShowDialog();
            if (sair.sair)
                Application.Exit();
        }

        private void cmdMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lOaram);
        

        private void cmdFechar_Click_1(object sender, EventArgs e)
        {
            frmSair sair = new frmSair();
            sair.ShowDialog();
            if (sair.sair)
                Application.Exit();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            cmdSair.BackColor = Color.Transparent;
            cmdJogar.BackColor = Color.Transparent;
            cmdPontuacao.BackColor = Color.Transparent;
        }
    }
}
