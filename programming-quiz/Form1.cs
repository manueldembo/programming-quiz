using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programming_quiz
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void cmd_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmd_pontuacao_Click(object sender, EventArgs e)
        {
            frmPontuacao frm = new frmPontuacao();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void cmd_jogar_Click(object sender, EventArgs e)
        {
            frmJogar frm = new frmJogar();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair do jogo?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
