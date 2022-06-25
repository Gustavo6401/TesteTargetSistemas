using System;
using Fibonacci.Calculo;

namespace Fibonacci 
{
    class Program 
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Me Informe o Número que você quer");
            int n = Convert.ToInt32(Console.ReadLine());

            Fibonacci.Calculo.Fibonacci fibo = new();

            // O programa vai trazer pelo menos seis elementos da sequência de Fibonacci, caso contrário, o número de elementos que o programa vai trazer será igual ao número.
            for(int i = 0; i < 6 || i < n; i++)
            {
                // O elemento é guardado na variável j.
                int j = fibo.SequenciaFibonacci(i);

                // Se o elemento for igual ao número que o usuário informou, o programa vai imprimir essa mensagem.
                if(j == n) 
                {
                    Console.WriteLine($"O elemento {i} da sequência de Fibonacci é igual a n, ou seja, o número pertence à sequência.");
                }
                Console.WriteLine($"O próximo elemento é: {j}");
            }    
        }
    }
}