using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
namespace programming_quiz
{
    internal partial class clJogo
    {
        #region perguntas
        public ArrayList perguntas = new ArrayList()
        {
            "Porque que o HTML não é uma liguagem de programação?",
            "Oque é uma IDE?",
            "Oque é uma liguagem Case Sensitive?",
            "Qual destas Linguagens não é Case Sensitive?",
            "O que significa a sigla CSS?",
            "O que significa a sigla HTTP?",
            "O que significa a sigla WWW?",
            "O que significa a sigla POO?",
            "Quais são as duas pricipais funções do Browser?",
            "Em que ano surgiu o C#?", 
            "Quem foi o criador da linguagem HTML?",
            "Qual foi a primeira linguagem criada para multiplataforma?",
            "Qual foi o primeiro nome da linguagem JAVA?",
            "A que empresa pertence a linguagem Python?",
            "Qual a principal função do compilador?",
            "O que é um compilador?",
            "O que significa a sigla SQL?",
            "Qual a principal IDE para criação de códigos em C#?",
            "Qual destas não é uma linguagem da Microsoft?",
            "Qual a área de desenvolvimento da Linguagem JavaScript?",
            "Qual a função do HTML em uma página WEB?",
            "Qual a função do CSS em uma página WEB?",
            "Qual a função do JS em uma página WEB?",
            "Quais são os pilares para construção de uma página WEB?",
            "Quantos paradigmas de programação existem?",
            "Quais são os paradigmas de programação que existem?",
            "O que significa a sigla URL?",
            "O que deve conter uma URL?",
            "Qual a função do protocolo FTP?",
            "Quem criou a internet?",
            "De onde Surgiu a internet?",
            "Qual destas funções não pertencia a máquina básica de Turing?",
            "Quando é que uma limguagem de computador é considerada uma linguagem de programação?",
            "O que entendes por código aberto?",
            "O que entendes por uma aplicação DEMO?",
            "O que entendes por uma aplicação DESKTOP?",
            "O que entendes por uma aplicação Mobile?",
            "O que entendes por uma aplicação WEB?",
            "Como podemos colocar um site na Internet?",
            "O que significa a expressão InternetWork?",
            "Quem criou a Microsoft?",
            "Qual foi a empresa que padronizou a Ex linguagem Moca?",
            "Qual é a função do servidor web?",
            "O que é preciso para programar em HTML?",
            "Qual é o paradigma de programação mais recente?",
            "Para que serve o PHP?"
        };
        #endregion

        #region respostas
        public ArrayList respostas = new ArrayList()
        {
            "Poque não é Turing Complete.",
            "Interface Development Entegrate.",
            "É uma linguagem que destingue minúsculas das maiúsculas.",
            "CSS.",
            "Cascading Style Sheets.",
            "Hipertext Transfer Protocol.",
            "Word Wide Web.",
            "Programação Orientada a Objectos.",
            "Request e Response.",
            "2000.",
            "Timothy John Berners-Lee.",
            "C.",
            "OAK.",
            "JetBreins.",
            "Tranformar o código fonte em código maquina.",
            "Aplicação que transforma código fonte em código objecto.",
            "Structured Query Language.",
            "Visual Studio.",
            "JS.",
            "Mobile, Game e Web.",
            "Define e estrutura a página.",
            "Definir o estilo.",
            "Trabalhar com interatividade.",
            "HTML, CSS e JS.",
            "2.",
            "Programação procedural e POO.",
            "Uniform Resource Locator.",
            "Protocolo do documento, endereço do servidor e localização do arquivo.",
            "Transferência de ficheiros de texto.",
            "Ninguém.",
            "Da comunicação humana.",
            "Marcar o texto.",
            "Quando é Turing Complete.",
            "Código em que todo mundo pode fazer suas alterações.",
            "É parte de uma aplicação completa.",
            "Aplicação para computadores.",
            "Aplicação para telemóveis e tabletes.",
            "Aplicação na internet.",
            "Atavés de Hospedagem.",
            "Conjunto de redes.",
            "Bill Gate e Paul Alen.",
            "Ecma.",
            "Gerenciar.",
            "Um editor de texto.",
            "POO.",
            "Programar Back/End em uma página."
        };
        #endregion

        #region opcao1
        public ArrayList opcao1 = new ArrayList() {
            "HTML é uma linguagem de programação.",
            "Internal Development Energy.",
            "é uma lingugem sensível.",
            "PhP.",
            "Estilização da Página.",
            "Abrir paginas que têm coteúdo multimédia.",
            "War Wide Web.",
            "Programação Orientada a Obstaculos.",
            "Navegar e Manter a Segurança.",
            "2002.",
            "Tim Lee!",
            "C#.",
            "B.",
            "Microsoft.",
            "Transformar código objecto em fonte.",
            "Aplicação que permite escrever.",
            "Language Question Structured.",
            "Falcon.",
            "C#.",
            "Desktop, Game.",
            "Estilo da página.",
            "Interpretar o código html.",
            "Estilo da página.",
            "C#, HTML e C.",
            "3.",
            "Herança e Polimorfismo.",
            "Uniform Resolve Locator.",
            "Localização, IP e DNS.",
            "Armarzenar os ficheiros na pagina.",
            "Timothy Jet-Lee.",
            "Da necessidade de fazer compras online.",
            "Alterar dados na memória.",
            "Quando não é Turing Complete.",
            "Código que so eu altero.",
            "Aplicação completa.",
            "Aplicação para computadores e telemóveis.",
            "Aplicação para computadores e tabletes.",
            "Aplicação só para computadores.",
            "Simplesmente conectando-me a internet.",
            "Internet.",
            "Paul Alen.",
            "JetBreins.",
            "Solicitar dados.",
            "Obrigatoriamente uma IDE.",
            "Programação procedural.",
            "Programar Front/End da página."
        };
        #endregion

        #region opcao2
        public ArrayList opcao2 = new ArrayList()
        {
            "Porque trabalha com outras linguagens.",
            "Development Internal Entegrated.",
            "É aquela que escrita em ingles.",
            "C++.",
            "Cascading Style Search.",
            "Transfer Hipertext Protocol Transcend.",
            "West War Web.",
            "Programação Feita com Orientação.",
            "Response e Navegar.",
            "2001.",
            "Bill Gates.",
            "B.",
            "GD.",
            "Apple.",
            "Mudar o código.",
            "Programa que serve para acessar a internet.",
            "Quatification Structured Language.",
            "Visual Studio Code.",
            "VB Script.",
            "Web.",
            "Interação da página.",
            "Formatar o texto.",
            "Controle de variáveis.",
            "JS, CSS e Python.",
            "5.",
            "Herança e POO.",
            "Uniform Resourse Localizator.",
            "Cabeça Tronco e Membro.",
            "Encontrar todos documentos da página",
            "Steve Jobs.",
            "Para facilitar a vida económica.",
            "Mudar o fluxo de execução.",
            "Quando altera dados na memoria.",
            "Código inacabado.",
            "Aplicação so para computadores.",
            "Aplicação inacabada.",
            "Aplicação para desenvolvedores.",
            "Aplicação para navegar na internet.",
            "Todo site depois de acabado e automaticamente hospedado.",
            "Rede.",
            "Pedro Vasco.",
            "Apple.",
            "Investigar.",
            "Visual Studio Code.",
            "HTML5.",
            "Fazer calculos na página."
        };
        #endregion

        #region opcao3
        public ArrayList opcao3 = new ArrayList()
        {
            "Porque é Turing Complete.",
            "Interface Developed Entegrate.",
            "Aquela que não destingue minúsculas das maiúsculas.",
            "Rubby.",
            "Search Casting Service.",
            "Hipertext Transfer Transend Protocol.",
            "Woode War Web.",
            "Programação Feita para Objecto.",
            "Request e Interpretar.",
            "1200.",
            "Timothy Jay Bernards Lee.",
            "C++.",
            "Moca.",
            "Google.",
            "Escrever o código.",
            "Programa de atualização do código.",
            "Quad Language Structured.",
            "VisualG.",
            "Visual Basic.",
            "Android, Mobile.",
            "Criatividade da página.",
            "Ler a página.",
            "Organizar página.",
            "HTML, C++ e PhP.",
            "4.",
            "POO e Polimorfismo.",
            "Localizator Resource Uniform.",
            "IP, endereço do servidor e DNS.",
            "Encontrar o destino do ficheiro.",
            "Timothy John Berners-Lee.",
            "Das grandes distâncias entre as pessoas.",
            "Fazer cálculos.",
            "Quando faz cálculos.",
            "Código  feito no bloco de notas.",
            "Aplicação com defeito.",
            "Aplicação para dispositivos móveis",
            "Aplicação para computadores.",
            "Aplicação só para telemóveis.",
            "Enviando o site para um servidor.",
            "Rede privada.",
            "Bill Gates.",
            "Microsoft.",
            "Solicitar serviços.",
            "Um compilador.",
            "C#.",
            "Oferecer maior segurança."
        };
        #endregion

        public int GerarPosicaoProximaPergunta(int max) {
            int index = 0;
            Random rd = new Random();
            index = rd.Next(0, max);
                
            return index;
        }

        public bool VerificarVitoria(int max, int pontos, Timer temporizador) {
            bool validar = false;

            if (max == 0)
            {
                validar = true;

                clOperacoes ope = new clOperacoes();
                ope.TocarFundo(false);
                ope.PararTempo(temporizador);

                frmVitoria vitoria = new frmVitoria(pontos);
                vitoria.ShowDialog();
            }
            
            return validar;
        }

        public bool VerificarResposta(string resposta, ArrayList respostas, int index) {
            bool validar = true;

            if (resposta != respostas[index].ToString())
                validar = false;

            return validar;
        }

        public void AjudaMostrar(int pos, ArrayList respostas) {
            frmMostrar frm = new frmMostrar(respostas[pos].ToString());
            frm.ShowDialog();
        }
        
        public int GerarPosicaoResposta() {
            int index = 0;
            Random rd = new Random();
            index = rd.Next(0, 4);
            return index;
        }
    }
}
