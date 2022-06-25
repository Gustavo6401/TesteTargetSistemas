using System;
using System.Linq;
using VetorJson.Model;
using VetorJson.ManipularJson;

namespace VetorJson.ConsultarDados 
{
    public class Consulta 
    {
        public decimal MenorValor() 
        {
            // O var permite que você crie variáveis sem expecificar explícitamente o tipo delas.
            var ler = new LerJson();
            var f = ler.Deserialize();

            /* Lambda expressions podem estar juntas ou não. 
             *  A primeira expressão que é comum para os três métodos é responsável por filtrar os dias sem faturamento.
             *  A segunda, para calcular o menor valor nos dias com faturamento.
             */
            var faturamento = f.Where(x => x.Valor > 0)
                               .Min(x => x.Valor);

            return faturamento;
        }

        public decimal MaiorValor() 
        {
            LerJson ler = new();            
            var f = ler.Deserialize();

            // A função Max é responsável por saber o maior valor de faturamento.
            var faturamento = f.Where(x => x.Valor > 0)
                               .Max(x => x.Valor);

            return faturamento;
        }
        
        public int NumeroDiasSemFaturamento() 
        {
            LerJson ler = new();
            var f = ler.Deserialize();

            // A função count é responsável por contar o número de dias, ou no caso aqui, de dias com faturamento.
            var dias = f.Where(x => x.Valor > 0)
                        .Count();

            return dias;
        }
    }
}