using System;

namespace Cadeia 
{
    class Program 
    {
        public static void Main(string[] args) 
        {
            string palavra = "Gustavo";
            char[] vetorCaracter = palavra.ToCharArray(); // Joga a string num array de caracter
            string aux = "";

            // Tem a função de inverter a palavra.
            // O i deve ser maior que menos um, porque a primeira letra da palavra está na posição 0.
            for(int i = vetorCaracter.Length - 1; i > -1; i--) 
            {
                // O laço for vai passar de letra em letra, e vai jogar tudo isso nessa string.
                aux = aux + vetorCaracter[i];
            }

            Console.WriteLine($"{aux}");
        }
    }
}