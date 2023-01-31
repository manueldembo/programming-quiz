using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.InteropServices;

namespace programming_quiz
{
    public partial class frmPontuacao : Form
    {
        clOperacoes ope = new clOperacoes();
        ArrayList dados = new ArrayList();
        public frmPontuacao()
        {
            InitializeComponent();
            dados = ope.LerPontuacao();
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

        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmPontuacao_Load(object sender, EventArgs e)
        {
            Apresentar();
        }

        private void Apresentar()
        {
            //apresentar nomes
            lblPrimeiro.Text = ope.ExtrairNome(dados[0].ToString());
            lblSegundo.Text = ope.ExtrairNome(dados[1].ToString());
            lblTerceiro.Text = ope.ExtrairNome(dados[2].ToString());

            //apresentar pontos ou recordes
            lblP.Text = ope.ApresentarTempo(dados[0].ToString());
            lblS.Text = ope.ApresentarTempo(dados[1].ToString());
            lblT.Text = ope.ApresentarTempo(dados[2].ToString());
        }

        private void cmdVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdLimpar_Click(object sender, EventArgs e)
        {
            frmSair limpar = new frmSair("Tem a certeza que deseja apagar todos os recordes?", "Limpar");
            limpar.ShowDialog();
            if (limpar.sair)
            {
                ope.GravarPrimeirosDados();
                MessageBox.Show("Dados removidos com sucesso!");
            }
            dados = ope.LerPontuacao();

            Apresentar();
        }
    }
}
