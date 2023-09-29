using System;
using System.Collections.Generic;
using System.IO;

namespace TuringMachine
{
    struct Instrucao
    {
        public string origem;
        public string leitura;
        public string X; // pode ser: valor a escrever, sentido da instrucao(esquerda ou direita)
        public string destino;
    }

    class Program
    {
        static Dictionary<Tuple<string, string>, Tuple<string, string>> Transicoes = new Dictionary<Tuple<string, string>, Tuple<string, string>>();
        static List<Instrucao> instrucoes = new List<Instrucao>();

        static char[] FITA = new char[1000];
        static string estado_inicial;
        static string[] estados = new string[100];
        static string[] estados_finais = new string[100];
        static char[] alfabeto = new char[100];
        static char[] alfabeto_fita = new char[100];
        static int qtd_estados_finais = 0;
        static int qtd_alfabeto_fita = 0;
        static int qtd_alfabeto_entrada = 0;

        static void LerArquivo()
        {
            using (StreamReader arquivo = new StreamReader("escreverEapagarInfinito.txt"))
            {
                string linha = arquivo.ReadLine();
                int i = 0;
                foreach (char c in linha)
                {
                    if (c == ' ') continue;
                    FITA[i++] = c;
                }
                Console.WriteLine(FITA);

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
                    Instrucao inst;
                    inst.origem = tokens[0];
                    inst.leitura = tokens[1];
                    inst.X = tokens[2];
                    inst.destino = tokens[3];
                    instrucoes.Add(inst);
                    pos++;
                }
            }
        }


        static bool EhAlfabetoEntrada(char simbolo)
        {
            for (int i = 0; i < qtd_alfabeto_entrada; i++)
                if (alfabeto[i] == simbolo) return true;
            return false;
        }

        static bool EhAlfabetoFita(char simbolo)
        {
            for (int i = 0; i < qtd_alfabeto_fita; i++)
                if (alfabeto_fita[i] == simbolo) return true;
            return false;
        }

        static void SimulacaoMaquinaTuring()
        {
            int indice = 0;
            int extremidade_esquerda = -1;
            int extremidade_direita = 1000;
            Tuple<string, string> apontador;
            Tuple<string, string> value;
            apontador = new Tuple<string, string>(instrucoes[0].origem, instrucoes[0].leitura);
            Console.WriteLine(" ... " + apontador.Item2[0]);

            do
            {
                Console.Clear();
                Console.WriteLine("\n\n------- simulando   ----");
                Console.WriteLine("\t" + new string(FITA));
                Console.WriteLine("\n-------------------------");

                if (!(EhAlfabetoEntrada(apontador.Item2[0]) || EhAlfabetoFita(apontador.Item2[0])))
                {
                    Console.WriteLine("Rejeitado. simbolo " + apontador.Item2[0] + " desconhecido");
                    break;
                }
                else if (apontador.Item2 == "qRejeicao")
                {
                    Console.WriteLine("Estado de rejeicao atingida!");
                    break;
                }
                else
                {
                    if (Transicoes.TryGetValue(apontador, out value))
                    {
                        if (value.Item1 == "D")
                        {
                            if (indice + 1 < extremidade_direita)
                            {
                                apontador = new Tuple<string, string>(value.Item2, FITA[++indice].ToString());
                            }
                            else
                            {
                                Console.WriteLine("limite direito ultrapassado");
                            }
                        }
                        else if (value.Item1 == "E")
                        {
                            if (indice - 1 >= extremidade_esquerda)
                            {
                                apontador = new Tuple<string, string>(value.Item2, FITA[--indice].ToString());
                            }
                            else
                            {
                                Console.WriteLine("limite esquerdo ultrapassado");
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
                            Console.WriteLine("Aceite");
                        }
                        else
                        {
                            Console.WriteLine("Rejeitado. Estado de aceitação não atingida");
                        }
                        break;
                    }
                }
            } while (true);
        }

        static void ConstruindoTabelaTransicoes()
        {
            foreach (Instrucao instr in instrucoes)
            {
                Tuple<string, string> key = new Tuple<string, string>(instr.origem, instr.leitura);
                Tuple<string, string> value = new Tuple<string, string>(instr.X, instr.destino);
                Transicoes[key] = value;
            }
        }

        static void Main(string[] args)
        {
            LerArquivo();
            ConstruindoTabelaTransicoes();
            SimulacaoMaquinaTuring();
        }
    }
}
