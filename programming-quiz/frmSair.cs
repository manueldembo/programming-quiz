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
    public partial class frmSair : Form
    {
        public bool sair = false;
        public frmSair(string mensgem = "", string titulo = "")
        {
            InitializeComponent();
            if (titulo != "")
                lblTitulo.Text = titulo;

            if (mensgem != "")
                lblTexto.Text = mensgem;
        }

        private void cmdSim_Click(object sender, EventArgs e)
        {
            sair = true;
            this.Close();
        }

        private void cmdNao_Click(object sender, EventArgs e)
        {
            sair = false;
            this.Close();
        }

        private void cmdFechar_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
