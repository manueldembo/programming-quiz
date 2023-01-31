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
    public partial class frmMostrar : Form
    {
        public frmMostrar(string resposta)
        {
            InitializeComponent();
            lblResposta.Text = resposta;
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
