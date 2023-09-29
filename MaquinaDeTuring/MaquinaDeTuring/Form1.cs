using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaDeTuring
{
    struct Instrucao
    {
        public string Origem;
        public string Leitura;
        public string X;
        public string Destino;
    }
    public partial class Form1 : Form
    {
      
        static string[] estados = new string[100];
        static string[] estados_finais = new string[100];
        static char[] alfabeto = new char[100];
        static char[] alfabeto_fita = new char[100];
        static char[] FITA = new char[1000];
        static int qtd_alfabeto_fita = 0;
        static int qtd_alfabeto_entrada = 0;

        static Dictionary<Tuple<string, string>, Tuple<string, string>> Transicoes = new Dictionary<Tuple<string, string>, Tuple<string, string>>();
        static List<Instrucao> instrucoes = new List<Instrucao>();
        private CancellationTokenSource cancellationTokenSource;


        public Form1()
        {
            InitializeComponent();
            configurarToolTip();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Código a ser executado quando o formulário for carregado
        }
        public void configurarToolTip()
        {
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 200;

            toolTip1.SetToolTip(add, "Criar nova simulação");
            toolTip1.SetToolTip(open, "Abrir ficheiro");
            toolTip1.SetToolTip(save, "Guardar ficheiro");
            toolTip1.SetToolTip(compiller, "Compilar");
            toolTip1.SetToolTip(run, "Executar");
            toolTip1.SetToolTip(stop, "Parar execução");
            toolTip1.SetToolTip(copy, "Copiar");
            toolTip1.SetToolTip(cut, "Cortar");
            toolTip1.SetToolTip(paste, "Colar");
            toolTip1.SetToolTip(sair, "Sair");
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            instrucaoTuring.Text = "";
        }

      

        public void escreverNoArquivo()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                string directoryPath = @"C:\Users\Lukoki Daniel\Documents\ProjectoDeTC\MaquinaDeTuring\MaquinaDeTuring\bin\Debug";
                string fileName = "arquivoAexecutar.txt"; // Nome do arquivo a ser salvo
                string filePath = Path.Combine(directoryPath, fileName);
                string[] lines = instrucaoTuring.Lines;
                File.WriteAllLines(filePath, lines);
            }
        }

        private void run_Click(object sender, EventArgs e)
        {
            inicializa();
            LimparListBox();
            cancellationTokenSource?.Cancel();
            escreverNoArquivo();
            LerArquivo();
            ConstruindoTabelaTransicoes();
            StartSimulationButton();
        }

        static bool EhAlfabetoEntrada(char simbolo)
        {
            return alfabeto.Contains(simbolo);
        }

        static bool EhAlfabetoFita(char simbolo)
        {
            return alfabeto_fita.Contains(simbolo);
        }


        public void AdicionarItemAoListBox(string item)
        {
            if (listBox1.InvokeRequired)
            {
                // Se estivermos em um thread diferente do thread da interface,
                // invocamos o método no thread principal
                listBox1.Invoke(new Action<string>(AdicionarItemAoListBox), item);
                listBox1.Invoke(new Action(() => listBox1.SelectedIndex = listBox1.Items.Count - 1));

            }
            else
            {
                // Estamos no thread principal, podemos adicionar o item diretamente
                listBox1.Items.Add(item);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
        }

        public void LimparListBox()
        {
            if (listBox1.InvokeRequired)
            {
                // Se estivermos em um thread diferente do thread da interface,
                // invocamos o método no thread principal
                listBox1.Invoke(new Action(LimparListBox));
            }
            else
            {
                // Estamos no thread principal, podemos limpar a lista diretamente
                listBox1.Items.Clear();
            }
        }
        public async void SimulacaoMaquinaTuring(CancellationToken cancellationToken)
        {
            int indice = 0;
            int cont = 1;
            int extremidade_esquerda = -1;
            int extremidade_direita = 1000;
            Tuple<string, string> apontador;
            Tuple<string, string> value;
            apontador = new Tuple<string, string>(instrucoes[0].Origem, instrucoes[0].Leitura);
            Console.WriteLine(" ... " + apontador.Item2[0]);

            do
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    return;
                }
                StringBuilder concatenatedString = new StringBuilder();
                foreach (char element in FITA)
                {
                    concatenatedString.Append(element);
                    concatenatedString.Append(" | "); // Adiciona o separador |
                }
               
                AdicionarItemAoListBox(cont + "- |" + concatenatedString.ToString());
             
                if (!(EhAlfabetoEntrada(apontador.Item2[0]) || EhAlfabetoFita(apontador.Item2[0])))
                {
                    AtualizarEstado("Rejeitado. simbolo " + apontador.Item2[0] + " desconhecido", Color.Red);
                    return;
                }
                else if (apontador.Item2 == "qRejeicao")
                {
                    AtualizarEstado("Estado de rejeicao atingida!", Color.Red);
                    return;
                }
                else
                {
                    if (Transicoes.TryGetValue(apontador, out value))
                    {
                        if (value.Item1 == "D")
                        {
                            if (indice + 1 < extremidade_direita)
                            {
                                indice++;
                                apontador = new Tuple<string, string>(value.Item2, FITA[indice].ToString());
                            }
                            else
                            {
                                AtualizarEstado("limite direito ultrapassado!", Color.Red);
                            }
                        }
                        else if (value.Item1 == "E")
                        {
                            if (indice - 1 >= extremidade_esquerda)
                            {
                                indice--;
                                apontador = new Tuple<string, string>(value.Item2, FITA[indice].ToString());
                            }
                            else
                            {
                                AtualizarEstado("limite esquerdo ultrapassado!", Color.Red);
                            }
                        }
                        else
                        {
                            FITA[indice] = value.Item1[0];
                            apontador = new Tuple<string, string>(value.Item2, value.Item1);
                        }
                    }
                    else
                    {
                        if (apontador.Item1 == "qAceite")
                        {
                            AtualizarEstado("Aceite!", Color.Green);
                            return;
                        }
                        else
                        {
                            AtualizarEstado("Rejeitado. Estado de aceitação não atingida!", Color.Red);
                            return;
                        }
                        return;
                    }
                }
                cont++;
            } while (true);
        }

        public void AtualizarEstado(string mensagem, Color cor)
        {
            if (mystate.InvokeRequired)
            {
                mystate.Invoke(new Action<string, Color>(AtualizarEstado), mensagem, cor);
            }
            else
            {
                mystate.Text = mensagem;
                mystate.ForeColor = cor;
            }
        }

        static void ConstruindoTabelaTransicoes()
        {
            int qtdInstrucoes = instrucoes.Count;

            for (int i = 0; i < qtdInstrucoes; i++)
            {
                Tuple<string, string> key = new Tuple<string, string>(instrucoes[i].Origem, instrucoes[i].Leitura);
                Tuple<string, string> value = new Tuple<string, string>(instrucoes[i].X, instrucoes[i].Destino);

                Transicoes[key] = value;
            }
        }

        private async void StartSimulationButton()
        {
            cancellationTokenSource = new CancellationTokenSource();
            await Task.Run(() => SimulacaoMaquinaTuring(cancellationTokenSource.Token));
        }

        public void LerArquivo()
        {
            FITA = new char[1000];
            StringBuilder concatenatedString = new StringBuilder();
            string directoryPath = @"C:\Users\Lukoki Daniel\Documents\ProjectoDeTC\MaquinaDeTuring\MaquinaDeTuring\bin\Debug";
            string fileName = "arquivoAexecutar.txt"; // Nome do arquivo a ser salvo
            string filePath = Path.Combine(directoryPath, fileName);
            using (StreamReader arquivo = new StreamReader(filePath))
            {
                string linha = arquivo.ReadLine();

                int i = 0;
                foreach (char c in linha)
                {
                    if (c == ' ') continue;
                    FITA[i++] = c;
                }

                
                foreach (char element in FITA)
                {
                    concatenatedString.Append(element);
                    concatenatedString.Append("|"); // Adiciona o separador |
                }
                
                listBox1.Items.Add("Palavra "+concatenatedString);
                
                linha = arquivo.ReadLine();
                int qtd = 0;
                foreach (char c in linha)
                {
                    if (c == ' ') continue;
                    alfabeto[qtd++] = c;
                }
                qtd_alfabeto_entrada = qtd;

                qtd = 0;

                linha = arquivo.ReadLine();
                foreach (char c in linha)
                {
                    if (c == ' ') continue;
                    alfabeto_fita[qtd++] = c;
                }
                qtd_alfabeto_fita = qtd;
                int pos = 0;
                while (!arquivo.EndOfStream)
                {
                    linha = arquivo.ReadLine();
                    string[] tokens = linha.Split(' ');
                    try
                    {
                        Instrucao inst;
                        inst.Origem = tokens[0];
                        inst.Leitura = tokens[1];
                        inst.X = tokens[2];
                        inst.Destino = tokens[3];
                        instrucoes.Add(inst);
                        pos++;
                    }
                    catch (Exception)
                    {
                        linha = arquivo.ReadLine();
                        continue;
                    }
                    
                }
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Texto|*.txt|Todos os arquivos|*.*";
            openFileDialog.Title = "Selecionar um arquivo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                try
                {
                    string fileContent = File.ReadAllText(selectedFilePath);
                    instrucaoTuring.Text = fileContent; // Exibe o conteúdo no TextBox
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao ler o arquivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivos de Texto|*.txt|Todos os arquivos|*.*";
            saveFileDialog.Title = "Salvar arquivo";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string saveFilePath = saveFileDialog.FileName;

                try
                {
                    File.WriteAllText(saveFilePath, instrucaoTuring.Text);
                    MessageBox.Show("Arquivo salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar o arquivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void copy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(instrucaoTuring.SelectedText))
            {
                Clipboard.SetText(instrucaoTuring.SelectedText);
            }
        }

        private void paste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                instrucaoTuring.SelectedText = Clipboard.GetText();
            }
        }

        private void cut_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(instrucaoTuring.SelectedText))
            {
                Clipboard.SetText(instrucaoTuring.SelectedText);
                instrucaoTuring.SelectedText = "";
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            cancellationTokenSource?.Cancel();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Para que executes o seu codigo na maquina de turing\n O formato do seu codigo deve estar conforme as regras de implemantacão do prohgrama\n na seguinte sequencia\n1- Palavra\n2- Alfabeto principal\n3- Alfabeto da fita\n4- Os estados!", "Ajuda de Implementação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void inicializa()
        {
            
            estados = new string[100];
            estados_finais = new string[100];
            alfabeto = new char[100];
             alfabeto_fita = new char[100];
             FITA = new char[1000];
             qtd_alfabeto_fita = 0;
              qtd_alfabeto_entrada = 0;
            Transicoes = new Dictionary<Tuple<string, string>, Tuple<string, string>>();
           instrucoes = new List<Instrucao>();
        }
    }
}
