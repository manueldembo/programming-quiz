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
    public partial class frmVitoria : Form
    {
        public frmVitoria(int pontos)
        {
            InitializeComponent();
            label1.Text = "<" + pontos + "pt/>";
        }

        private void cmdVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
