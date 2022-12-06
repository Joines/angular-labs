using System;
using System.Text.Json.Serialization;

namespace Back.src.Proeventos.API
{
    public class Pessoa
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }
        
        [JsonPropertyName("SobreNome")]
        public string Sobrenome { get; set; }

        [JsonPropertyName("Idade")]
        public short Idade { get; set; }
        
        [JsonPropertyName("data de nascimento")]
        public DateTime DataDeNascimento { get; set; }
    }
}