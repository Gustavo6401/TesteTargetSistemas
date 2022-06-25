using System;
using System.Collections.Generic;
using System.Collections;
using Faturamento.Model;
using Faturamento.CalculoPorcentagem;

namespace Faturamento 
{
    class Program 
    {
        static FaturamentoMensal[] faturamento = new FaturamentoMensal[5];
        public static void Main(string[] args) 
        {
            Calculo c = new Calculo();
            CriarVetor();

            foreach (var item in faturamento)
            {
                Console.WriteLine($"A porcentagem do estado {item.Estado} é: {c.ValorPorcentagem(faturamento, item.Estado)}, o valor: {item.Valor}, ");
            }
        }
        public static void CriarVetor()
        {
            faturamento[0] = new FaturamentoMensal();
            faturamento[0].Estado = "SP";
            faturamento[0].Valor = 67836.43M;

            faturamento[1] = new FaturamentoMensal();
            faturamento[1].Estado = "RJ";
            faturamento[1].Valor = 36678.66M;

            faturamento[2] = new FaturamentoMensal();
            faturamento[2].Estado = "MG";
            faturamento[2].Valor = 29229.88M;

            faturamento[3] = new FaturamentoMensal();
            faturamento[3].Estado = "ES";
            faturamento[3].Valor = 27165.48M;

            faturamento[4] = new FaturamentoMensal();
            faturamento[4].Estado = "Outros Estados";
            faturamento[4].Valor = 19849.53M;
        }
    }
}