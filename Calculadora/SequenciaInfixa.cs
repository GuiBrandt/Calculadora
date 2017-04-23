using System;
using System.Collections.Generic;
using System.Globalization;

namespace Calculadora
{
    /// <summary>
    /// Classe usada para representar uma sequência infixa
    /// </summary>
    class SequenciaInfixa
    {
        /// <summary>
        /// Lista de relação de uma letra e um double representando os valores que aparecem na sequência
        /// e a letra que os representa
        /// </summary>
        public Dictionary<char, double> Valores { get; private set; } = new Dictionary<char, double>();

        /// <summary>
        /// Sequência com os valores trocados por letras
        /// </summary>
        public string Expressao { get; private set; } = "";

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="sequencia">String a partir da qual o objeto de sequência infixa será criado</param>
        /// <exception cref="FormatException">Caso haja um número mal formatado na expressão</exception>
        /// <exception cref="Exception">Caso a sequência tenha mais valores do que tem letras no alfabeto</exception>
        public SequenciaInfixa(string sequencia)
        {
            string valor = "";

            // Percorre todos os caracteres na sequência até um depois do último
            for (int i = 0; i <= sequencia.Length; i++)
            {
                // Se estiver depois do último usa 0 ao invés do caractere
                char c = i < sequencia.Length ? sequencia[i] : (char)0;

                // Se o caractere for parte de um número, adiciona ele em valor e
                // prossegue
                if (char.IsNumber(c) || c == '.')
                    valor += c;

                // Se não, processa valor e adiciona o caractere à sequência normalmente
                else
                {
                    // Se houver alguma coisa em valor, converte em double, armazena no dicionário
                    // de valores e substitui o número por uma letra na expressão
                    if (!string.IsNullOrEmpty(valor))
                    {
                        char letra = (char)('A' + Valores.Count);

                        if (letra > 'Z')
                            throw new Exception("A sequência tem valores demais");

                        Expressao += letra;
                        Valores.Add(letra, double.Parse(valor, CultureInfo.InvariantCulture));
                        valor = "";
                    }

                    // Não inclui o caractere na sequência se ele for 0
                    if (c != 0)
                        Expressao += c;
                }
            }
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
