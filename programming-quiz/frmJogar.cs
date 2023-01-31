using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.InteropServices;

namespace programming_quiz
{
    public partial class frmJogar : Form
    {
        #region variaveis
        ArrayList pontuacoes = new ArrayList();
        ArrayList perguntas = new ArrayList();
        ArrayList respostas = new ArrayList();
        ArrayList opcao1 = new ArrayList();
        ArrayList opcao2 = new ArrayList();
        ArrayList opcao3 = new ArrayList();

        clJogo jogo = new clJogo();
        clOperacoes ope = new clOperacoes();
        int cont = 0;
        int indexPergunta = 0;
        int indexRespostaOpcao = 0;
        int limiteTempo = 30;
        int respondidas = 0;
        string nomeJogador = " "; 
        string caminhoImagens = Environment.CurrentDirectory + @"\_front-end\";
        DateTime inicio;
        TimeSpan tempo;
        #endregion

        public frmJogar()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            //carregamentos dos dados
            perguntas = jogo.perguntas;
            respostas = jogo.respostas;
            pontuacoes = ope.LerPontuacao();
            opcao1 = jogo.opcao1;
            opcao2 = jogo.opcao2;
            opcao3 = jogo.opcao3;

            ApresentarPergunta();
            //pegar tempo de início do jogo
            inicio = DateTime.Now;
        }

        private void RemoverRespostaPerguntaOpcoes() {
            respostas.RemoveAt(indexPergunta);
            perguntas.RemoveAt(indexPergunta);
            opcao1.RemoveAt(indexPergunta);
            opcao2.RemoveAt(indexPergunta);
            opcao3.RemoveAt(indexPergunta);
        }

        private void ApresentarPergunta() {
            if (!jogo.VerificarVitoria(perguntas.Count, respondidas, temporizador))
            {
                ope.LimparOpcoesEPergunta(areaJogo.Controls);

                //gera a próxima pergunta aleatória
                indexPergunta = jogo.GerarPosicaoProximaPergunta(perguntas.Count);
                lblPergunta.Text = perguntas[indexPergunta].ToString();
                lblRespondidas.Text = "Pontos: " + respondidas.ToString() + "pt";

                //recomeçar contagem
                cont = 0;

                //apresentar a opção de resposta
                ApresenarResposta();
                ApresentarOutrasOpcoes();

                if (nomeJogador != " ")
                    ope.TocarFundo();
            }
            else {
                ope.DesligarFundo();

                //subitrair tempos
                tempo = ope.Tempo(inicio, DateTime.Now);

                int aux = (int)tempo.TotalSeconds;

                //gravar novo recorde
                pontuacoes.Add(respondidas + " " + aux + nomeJogador);

                //gravar no ficheiro
                ope.GravarPontuacoes(pontuacoes);

                this.Close();
            }
        }

        private void ApresenarResposta() {
            int index = jogo.GerarPosicaoResposta();
            indexRespostaOpcao = index;

            IntroduzirTextoComando(index, respostas[indexPergunta].ToString());
        }

        private bool IntroduzirTextoComando(int index, string texto) {
            bool validar = false;

            switch (index)
            {
                case 0:
                    if (cmdOpcaoA.ButtonText == "")
                    {
                        cmdOpcaoA.ButtonText = texto;
                        validar = true;
                    }
                    break;
                case 1:
                    if (cmdOpcaoB.ButtonText == "")
                    {
                        cmdOpcaoB.ButtonText = texto;
                        validar = true;
                    }
                    break;
                case 2:
                    if (cmdOpcaoC.ButtonText == "")
                    {
                        cmdOpcaoC.ButtonText = texto;
                        validar = true;
                    }
                    break;
                case 3:
                    if (cmdOpcaoD.ButtonText == "")
                    {
                        cmdOpcaoD.ButtonText = texto;
                        validar = true;
                    }
                    break;
            }

            return validar;
        }

        private void ApresentarOutrasOpcoes() {
            int index = 0;
            string texto = "";

            for (int i = 0; i < 3; i++)
            {
                do
                {
                    Random rd = new Random();
                    index = rd.Next(0, 4);

                    switch (i)
                    {
                        case 0:
                            texto = opcao1[indexPergunta].ToString();
                            break;
                        case 1:
                            texto = opcao2[indexPergunta].ToString();
                            break;
                        case 2:
                            texto = opcao3[indexPergunta].ToString();
                            break;
                    }

                } while (!IntroduzirTextoComando(index, texto));
            }
        }

        private void ValidarResposta(string resposta, Bunifu.Framework.UI.BunifuThinButton2 cmd)
        {
            if (jogo.VerificarResposta(resposta, respostas, indexPergunta))
            {
                ope.Toque();

                cmd.IdleFillColor = Color.Lime;
                cmd.ActiveFillColor = Color.Lime;
                Application.DoEvents();
                Thread.Sleep(1000);

                respondidas++;
                RemoverRespostaPerguntaOpcoes();
                ApresentarPergunta();
                DevolverVisibilidadeDesabilitarOpcoes();

                cmd.IdleFillColor = Color.FromArgb(0, 0, 100);
                cmd.ActiveFillColor = Color.Gold;
            }
            else
            {
                ope.Toque(false);
                   
                cmd.IdleFillColor = Color.Red;
                cmd.ActiveFillColor = Color.Red;
                Application.DoEvents();
                Thread.Sleep(1000);

                Finalizar();
            }
        }
        
        private void AjudaDeixarDuas() {
            RemoverVisibilidadeDesabilitarOpcoes();
            
            Random rd = new Random();
            int index = 0;

            //gerar a outra opcao a mostrar para além da certa
            do
            {
                index = rd.Next(0, 4);
            } while (index == indexRespostaOpcao);

            AtribuirVisibilidadeHablitar(index);
            AtribuirVisibilidadeHablitar(indexRespostaOpcao);
        }

        private void AtribuirVisibilidadeHablitar(int index)
        {
            switch (index)
            {
                case 0:
                    cmdOpcaoA.Visible = true;
                    cmdOpcaoA.Enabled = true;
                    break;
                case 1:
                    cmdOpcaoB.Visible = true;
                    cmdOpcaoB.Enabled = true;
                    break;
                case 2:
                    cmdOpcaoC.Visible = true;
                    cmdOpcaoC.Enabled = true;
                    break;
                case 3:
                    cmdOpcaoD.Visible = true;
                    cmdOpcaoD.Enabled = true;
                    break;
            }
        }

        private void RemoverVisibilidadeDesabilitarOpcoes() {
            //remover visibilidade
            cmdOpcaoA.Visible = false;
            cmdOpcaoB.Visible = false;
            cmdOpcaoC.Visible = false;
            cmdOpcaoD.Visible = false;

            //impedir seus eventos
            cmdOpcaoA.Enabled = false;
            cmdOpcaoB.Enabled = false;
            cmdOpcaoC.Enabled = false;
            cmdOpcaoD.Enabled = false;
        }

        private void DevolverVisibilidadeDesabilitarOpcoes()
        {
            //devolver visibilidade
            cmdOpcaoA.Visible = true;
            cmdOpcaoB.Visible = true;
            cmdOpcaoC.Visible = true;
            cmdOpcaoD.Visible = true;
                              
            //permitir seus eventos
            cmdOpcaoA.Enabled = true;
            cmdOpcaoB.Enabled = true;
            cmdOpcaoC.Enabled = true;
            cmdOpcaoD.Enabled = true;
        }

        private void AjudaPular() {
            ApresentarPergunta();
            DevolverVisibilidadeDesabilitarOpcoes();
        }

        private void cmdAjudaDuas_Click_1(object sender, EventArgs e)
        {
            if (nomeJogador == " ")
                return;
            AjudaDeixarDuas();
            cmdAjudaDuas.Enabled = false;
        }

        private void cmdAjudaPular_Click_1(object sender, EventArgs e)
        {
            if (nomeJogador == " ")
                return;

            if (perguntas.Count > 1)
                AjudaPular();
            cmdAjudaPular.Enabled = false;
        }

        private void cmdAjudaMostrar_Click_1(object sender, EventArgs e)
        {
            if (nomeJogador == " ")
                return;
            jogo.AjudaMostrar(indexPergunta, respostas);
            cmdAjudaMostrar.Enabled = false;
        }

        private void cmdOpcaoA_Click(object sender, EventArgs e)
        {
            if (nomeJogador == " ")
                return;
            ValidarResposta(cmdOpcaoA.ButtonText, cmdOpcaoA);
        }

        private void cmdOpcaoB_Click(object sender, EventArgs e)
        {
            if (nomeJogador == " ")
                return;
            ValidarResposta(cmdOpcaoB.ButtonText, cmdOpcaoB);
        }

        private void cmdOpcaoC_Click(object sender, EventArgs e)
        {
            if (nomeJogador == " ")
                return;
            ValidarResposta(cmdOpcaoC.ButtonText, cmdOpcaoC);
        }

        private void cmdOpcaoD_Click(object sender, EventArgs e)
        {
            if (nomeJogador == " ")
                return;
            ValidarResposta(cmdOpcaoD.ButtonText, cmdOpcaoD);
        }
        
        private void cmdMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void frmJogar_Shown(object sender, EventArgs e)
        {
            frmDados dados = new frmDados();
            dados.ShowDialog();

            if (dados.nome == ""){
                this.Close();
                return;
            }
            nomeJogador += dados.nome;
            temporizador.Enabled = true;

            //tocar pela primeira vez
            ope.TocarFundo();
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            if (cont <= limiteTempo){
                pbTemporizador.Value = cont;
                lblTempo.Text = cont++ + "s";

                //aumentar dificuldade diminuindo o tempo
                if (respondidas == 15)
                {
                    limiteTempo = 15;
                    pbTemporizador.MaxValue = limiteTempo;
                }
            }
            else
                Finalizar();
            
        }

        private void Finalizar() {
            temporizador.Enabled = false;

            //subitrair tempos
            tempo = ope.Tempo(inicio, DateTime.Now);

            int aux = (int)tempo.TotalSeconds;

            //gravar novo recorde
            pontuacoes.Add(respondidas + " " + aux + nomeJogador);

            //gravar no ficheiro
            ope.GravarPontuacoes(pontuacoes);

            frmPerdeu frm = new frmPerdeu(respondidas);
            frm.ShowDialog();
            this.Close();
        }

        private void frmJogar_FormClosing(object sender, FormClosingEventArgs e)
        {
            ope.DesligarFundo();
        }
    }
}
