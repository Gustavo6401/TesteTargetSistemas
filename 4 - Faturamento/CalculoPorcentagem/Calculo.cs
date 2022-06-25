using System;
using System.Linq;
using System.Collections.Generic;
using Faturamento.Model;

namespace Faturamento.CalculoPorcentagem 
{
    public class Calculo 
    {
        public decimal ValorPorcentagem(FaturamentoMensal[] faturamento, string estado) 
        {
            decimal total = faturamento.Sum(f => f.Valor);
            var uf = faturamento.FirstOrDefault(f => f.Estado.Contains(estado));

            return (100 * uf.Valor) / total;
        }
    }
}