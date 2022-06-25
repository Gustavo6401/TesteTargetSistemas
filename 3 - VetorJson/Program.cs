using System;
using System.Linq;
using System.Collections.Generic;
using VetorJson.ConsultarDados;
using Newtonsoft.Json;

namespace VetorJson
{
    class Program
    {
        public static void Main(string[] args)
        {
            Consulta consulta = new();
            var minimo = consulta.MenorValor();
            var maximo = consulta.MaiorValor();
            var dias = consulta.NumeroDiasSemFaturamento();

            Console.WriteLine($"O menor valor é: {minimo}");
            Console.WriteLine($"O maior valor é: {maximo}");
            Console.WriteLine($"O número de dias é: {dias}");
        }
    }
}