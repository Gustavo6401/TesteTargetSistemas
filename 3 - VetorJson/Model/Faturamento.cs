using System;

namespace VetorJson.Model 
{
    public class Faturamento 
    {
        // Os dados daquele arquivo .json utilizarão este modelo, imagino que cada linguagem tem sua forma de fazer isso.
        public int Dia { get; set; }
        public decimal Valor { get; set; }
    }
}