using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneLinq1
{
    internal class Banca
    {
        string nome { get; set; }

        public List<Cliente> clienti { get; set; } = new List<Cliente>();

        public List<Prestito> prestiti { get; set; } = new List<Prestito>();

        public Banca(string nome)
        {
            this.nome = nome;
        }


        public void AggiungiCliente(Cliente cliente) 
        {
            clienti.Add(cliente);
        }

        public void ModificaCliente(Cliente cliente) 
        {
            Cliente clienteTrovato = clienti.First(x => x.codiceFiscale == cliente.codiceFiscale);
            if (clienteTrovato != null) 
            {
                clienteTrovato.nome = cliente.nome;
                clienteTrovato.cognome = cliente.cognome;
            }         
        }

        public void EliminaCliente(String codiceFiscale) 
        {
            Cliente clienteTrovato = clienti.First(x => x.codiceFiscale == codiceFiscale);
            if (clienteTrovato != null)
                clienti.Remove(clienteTrovato);
        }

        public void RicercaCliente(String codiceFiscale) 
        {
            Cliente clienteTrovato = clienti.FirstOrDefault(x => x.codiceFiscale == codiceFiscale);
            if (clienteTrovato != null)
            Console.WriteLine($"{clienteTrovato.nome} {clienteTrovato.cognome} {clienteTrovato.codiceFiscale} {clienteTrovato.stipendio}");
        }

        public void totalePrestiti(String codiceFiscale) 
        {
            double totalePrestiti = prestiti.Where(x => x.intestatario.codiceFiscale == codiceFiscale).Sum(y => y.ammontare);
                Console.WriteLine(totalePrestiti);
        }

        public void aggiungiPrestito(Prestito prestito) 
        {
            prestiti.Add(prestito);
        }
    }
}
