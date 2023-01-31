using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Media;

namespace programming_quiz
{
    public partial class clOperacoes
    {
        //==============Ficheiros de texto e tabalho com tempo===============================
        string caminhoPasta = Environment.CurrentDirectory + @"\_arquivos\";
        string caminhoPontuacao = "pontuacao.txt";

        private void CriarPastaFicheiros() {
            if (!Directory.Exists(caminhoPasta)) {
                Directory.CreateDirectory(caminhoPasta);
                File.CreateText(caminhoPasta + caminhoPontuacao).Close();
                GravarPrimeirosDados();
            }
            if (!File.Exists(caminhoPasta + caminhoPontuacao)) {
                File.CreateText(caminhoPasta + caminhoPontuacao).Close();
                GravarPrimeirosDados();
            }
        }

        public void GravarPrimeirosDados() {
            StreamWriter sw = new StreamWriter(caminhoPasta + caminhoPontuacao, false);

            for (int i = 0; i < 3; i++)
                sw.WriteLine("0 0 ");

            sw.Close();
        }

        public ArrayList LerPontuacao() {
            ArrayList dados = new ArrayList();
            CriarPastaFicheiros();

            try
            {
                StreamReader rd = new StreamReader(caminhoPasta + caminhoPontuacao, Encoding.Default);

                while (!rd.EndOfStream)
                    dados.Add(rd.ReadLine());

                rd.Close();
            }
            catch {
                MessageBox.Show("ERRO: Não foi possível ler os dados dos recordes.");
            }

            return dados;
        }

        public void GravarPontuacoes(ArrayList dados) {
            try
            {
                dados = Ordenar(dados);
                StreamWriter sw = new StreamWriter(caminhoPasta + caminhoPontuacao, false);

                for (int i = 0; i < dados.Count; i++)
                    sw.WriteLine(dados[i]);

                sw.Close();
            }
            catch {
                MessageBox.Show("ERRO: Não foi possível gravar os dados.");
            }

        }

        public ArrayList OrdenarCriterioQuantidadePerguntas(ArrayList dados) {
            //ordenar consoante ao número de perguntas respondidas
            string[] aux = new string[dados.Count];

            for (int i = 0; i < aux.Length; i++)
                aux[i] = dados[i].ToString();

            Array.Sort(aux);
            Array.Reverse(aux);

            dados.Clear();
            dados.AddRange(aux);

            //remover a menor dentre as 4 melhores pontuacoes
            if (dados.Count > 3)
                dados.RemoveAt(3);

            return dados;
        }

        private ArrayList Ordenar(ArrayList dados) {
            dados = OrdenarCriterioQuantidadePerguntas(dados);

            string[] aux = new string[dados.Count];

            for (int i = 0; i < dados.Count; i++)
                aux[i] = dados[i].ToString();

            //classificar quem respondeu mais perguntas em menor número de tempo
            int[] numeros = RetornarNumeros(aux);

            for (int i = 0; i < aux.Length - 1; i++)
            {
                for (int j = i + 1; j < aux.Length; j++)
                {
                    if (numeros[i] == numeros[j + 1])
                    {
                        if (numeros[j] > numeros[j + 2])
                        {
                            string str = aux[i];
                            aux[i] = aux[j];
                            aux[j] = str;
                        }
                    }
                }
            }

            //introduzir novos dados já ordenados ao arraylis
            dados.Clear();
            dados.AddRange(aux);

            return dados;
        }

        private int[] RetornarNumeros(string[] str)
        {
            int[] nums = new int[str.Length * 2];
            int index = 0;

            foreach (string item in str)
            {
                nums[index++] = int.Parse(item.Substring(0, item.IndexOf(" ")));
                nums[index++] = int.Parse(item.Substring(item.IndexOf(" ") + 1, item.LastIndexOf(" ") - item.IndexOf(" ")));
            }

            return nums;
        }

        public void LimparOpcoesEPergunta(Control.ControlCollection controles) {
            int aux = 0;
            foreach (Control controle in controles)
            {
                if (controle is Bunifu.Framework.UI.BunifuThinButton2) {
                    if (aux < 4)
                        ((Bunifu.Framework.UI.BunifuThinButton2)(controle)).ButtonText = "";
                    aux++;
                }
                if (controle is Label)
                    ((Label)(controle)).Text = "";
            }
        }

        public TimeSpan Tempo(DateTime inicio, DateTime fim) {
            //subitrai o tempo de inicio - tempo fim e gera o tempo que ele fez
            TimeSpan temp = new TimeSpan();

            temp = fim.Subtract(inicio);

            return temp;
        }

        public string ApresentarTempo(string tempo) {
            string tempoCompleto = "0";
            try
            {
                string t = tempo.Substring(tempo.IndexOf(" ") + 1, tempo.LastIndexOf(" ") - tempo.IndexOf(" "));

                tempoCompleto = SepararHora(t) + ":" + SepararMinuto(t) + ":" + SepararSegundo(t);

                tempoCompleto += "  " + tempo.Substring(0, tempo.IndexOf(" "));

                return tempoCompleto;
            }
            catch {
                return tempoCompleto;
            }
        }

        public string ExtrairNome(string pontuacao) {
            return pontuacao.Substring(pontuacao.LastIndexOf(" ") + 1, pontuacao.Length - pontuacao.LastIndexOf(" ") - 1);
        }

        private int SepararHora(string tempo) {
            int hora = 0;

            hora = int.Parse(tempo) / 3600;

            return hora;
        }

        private int SepararMinuto(string tempo) {
            int min = 0;

            min = int.Parse(tempo) / 60;

            return min;
        }

        private int SepararSegundo(string tempo) {
            int seg = 0;

            seg = (int.Parse(tempo) % 3600) % 60;

            return seg;
        }

        //==============Son===============================
        string caminhoMusica = Environment.CurrentDirectory + @"\_musica\";
        SoundPlayer player = new SoundPlayer();

        public void TocarFundo(bool son = true) {
            if (son)
                player.SoundLocation = caminhoMusica + "fundo.wav";
            else
                player.SoundLocation = caminhoMusica + "vitoria.wav";

            player.PlayLooping();
        }
        public void DesligarFundo() {
            player.Stop();
        }
        public void Toque(bool son = true) {
            if (son)
                player.SoundLocation = caminhoMusica + "certo.wav";
            else
                player.SoundLocation = caminhoMusica + "errado.wav";

            player.Play();
        }
        //==========================Tempo===============================
        public void PararTempo(Timer controle){
            controle.Enabled = false;
        }
        
    }
}
