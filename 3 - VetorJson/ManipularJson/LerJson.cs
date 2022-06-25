using System;
using System.Collections.Generic;
using VetorJson.Model;
using Newtonsoft.Json;

namespace VetorJson.ManipularJson 
{
    public class LerJson 
    {
        public List<Faturamento> Deserialize() 
        {
            // StreamReader é a classe que utilizamos para leitura de arquivos de texto em C#
            StreamReader r = new StreamReader("Faturamento.json");
            string jsonString = r.ReadToEnd();
            // O vetor que estava em JSON é convertido para uma lista em C#.
            List<Faturamento> f = JsonConvert.DeserializeObject<List<Faturamento>>(jsonString);

            return f;
        }
    }
}