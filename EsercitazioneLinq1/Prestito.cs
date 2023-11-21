using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneLinq1
{
    internal class Prestito
    {
        public Cliente intestatario { get; set; }
        public double ammontare { get; set; }
        public int rata { get; set; }
        public DateTime dataInizio { get; set; }
        public DateTime dataFine { get; set; }

        public Prestito(Cliente intestatario, double ammontare, int rata, DateTime dataInizio, DateTime dataFine)
        {
            this.intestatario = intestatario;
            this.ammontare = ammontare;
            this.rata = rata;
            this.dataInizio = dataInizio;
            this.dataFine = dataFine;
        }
    }
}
