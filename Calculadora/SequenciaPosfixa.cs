using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculadora
{
    /// <summary>
    /// Classe para sequências posfixas
    /// </summary>
    class SequenciaPosfixa
    {
        /// <summary>
        /// Dicionário de prioridade dos operadores
        /// </summary>
        private static Dictionary<char, int> Prioridades = new Dictionary<char, int>()
        {
            { '(',  3 },
            { '^',  2 },
            { '*',  1 },
            { '/',  1 },
            { '@',  1 },
            { '+',  0 },
            { '-',  0 },
            { ')', -1 },
        };

        /// <summary>
        /// Lista de relação de uma letra e um double representando os valores que aparecem na sequência
        /// e a letra que os representa
        /// </summary>
        public Dictionary<char, double> Valores { get; private set; }

        /// <summary>
        /// Sequência com os valores trocados por letras
        /// </summary>
        public string Expressao { get; private set; }

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="infixa">Sequência infixa a partir da qual criar a sequência posfixa</param>
        public SequenciaPosfixa(SequenciaInfixa infixa)
        {
            Valores = infixa.Valores;
            Expressao = "";

            Stack<char> pilhaSimbolos = new Stack<char>();
            bool valorAEsquerda = false;

            // Percorre todos os caracteres na string
            for (int i = 0; i < infixa.Expressao.Length; i++)
            {
                char c = infixa.Expressao[i];

                if (c == ' ')
                    continue;

                // Se o caractere for uma letra
                if (char.IsLetter(c))
                {
                    Expressao += c;
                    valorAEsquerda = true;
                }

                // Se não for, é um operador
                else
                {
                    if (!valorAEsquerda && (c == '-' || c == '+'))
                        if (c == '-')
                            c = '@';
                        else
                            continue;   // + unário é inútil

                    // Desempilha enquanto a prioridade do operador atual for menor que a do topo da pilha
                    while (pilhaSimbolos.Count > 0 && TemPrioridade(pilhaSimbolos.Peek(), c))
                    {
                        char op = pilhaSimbolos.Pop();
                        if (op != '(') Expressao += op;
                        else if (c == ')')
                            break;
                    }

                    valorAEsquerda = false;

                    if (c != ')')   // ) não deve aparecer na sequência
                        pilhaSimbolos.Push(c);
                    else 
                        valorAEsquerda = true;                    
                }
            }

            while (pilhaSimbolos.Count > 0)
            {
                char op = pilhaSimbolos.Pop();
                if (op != '(' && op != ')') Expressao += op;
            }
        }

        /// <summary>
        /// Calcula o resultado a expressão
        /// </summary>
        /// <returns>O resultado da expressão</returns>
        public double Calcular()
        {
            var stack = new Stack<double>();

            try
            {
                foreach (char c in Expressao)
                {
                    if (char.IsLetter(c))
                        stack.Push(Valores[c]);
                    else
                        ExecutarOperador(c, stack);
                }
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("A sequência é inválida");
            }

            return stack.Pop();
        }

        /// <summary>
        /// Executa um operador
        /// </summary>
        /// <param name="c">Operador</param>
        /// <param name="stack">Pilha com os valores</param>
        private void ExecutarOperador(char c, Stack<double> stack)
        {
            double a, b;

            switch (c)
            {
                case '^':
                    a = stack.Pop();
                    b = stack.Pop();
                    stack.Push(Math.Pow(b, a));
                    break;

                case '*':
                    stack.Push(stack.Pop() * stack.Pop());
                    break;

                case '/':
                    a = stack.Pop();
                    b = stack.Pop();
                    stack.Push(b / a);
                    break;

                case '+':
                    stack.Push(stack.Pop() + stack.Pop());
                    break;

                case '-':
                    a = stack.Pop();
                    b = stack.Pop();
                    stack.Push(b - a);
                    break;

                case '@':
                    stack.Push(-stack.Pop());
                    break;
            }
        }

        /// <summary>
        /// Verifica se A tem prioridade sobre B, sendo A o operador que aparece antes na sequência
        /// </summary>
        /// <param name="a">Operador da pilha</param>
        /// <param name="b">Operador lido</param>
        /// <returns>Retorna verdadeiro se A tiver prioridade e falso se não</returns>
        private bool TemPrioridade(char a, char b)
        {
            int pA = Prioridades.ContainsKey(a) ? Prioridades[a] : int.MinValue,
                pB = Prioridades.ContainsKey(b) ? Prioridades[b] : int.MinValue;

            if (a == '(')
                return b == ')';

            if (a == '^' && b == '^')
                return false;

            return pA >= pB;
        }

        /// <summary>
        /// Converte a sequência em string
        /// </summary>
        /// <returns>A sequência com os valores trocados por letras</returns>
        public override string ToString()
        {
            return Expressao;
        }
    }
}
