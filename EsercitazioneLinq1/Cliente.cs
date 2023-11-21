using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneLinq1
{
    internal class Cliente
    {
        public string nome { get; set; }
        public string cognome { get; set; }
        public string codiceFiscale { get; set; }
        public decimal stipendio { get; set; }

        public Cliente(string nome, string cognome, string codiceFiscale, decimal stipendio)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.codiceFiscale = codiceFiscale;
            this.stipendio = stipendio;
        }
    }
}
