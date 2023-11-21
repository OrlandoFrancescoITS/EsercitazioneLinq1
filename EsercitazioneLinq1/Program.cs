// See https://aka.ms/new-console-template for more information
using EsercitazioneLinq1;
using System.Collections;

Random random = new Random();

Banca banca = new Banca("Banca");
banca.clienti.Add(new Cliente("Mario", "Rossi", "6cwwcwc6w5ce", random.Next(1200, 3000)));
banca.clienti.Add(new Cliente("Luigi", "Verdi", "sdvewrv68464", random.Next(1200, 3000)));
banca.clienti.Add(new Cliente("Elena", "Bianchi", "etger688reg", random.Next(1200, 3000)));

foreach (Cliente cliente in banca.clienti) 
{
    for (int i = 0; i < random.Next(1, 3); i++) 
    {
        banca.prestiti.Add(new Prestito(
        cliente,
        random.Next(1000, 3000),
        random.Next(3, 10),
        DateTime.Now,
        DateTime.Now.AddYears(3)));
    }
}

Console.WriteLine("Clienti");
foreach (Cliente c in banca.clienti) 
{
    Console.WriteLine($"Nome:{c.nome} | Cognome:{c.cognome} | Codice fiscale:{c.codiceFiscale} | Stipendio:{c.stipendio}");
}

Console.WriteLine("\nPrestiti");
foreach (Prestito p in banca.prestiti) 
{
    Console.WriteLine($"Nome intestatario:{p.intestatario.nome} | Ammontare:{p.ammontare} | Rate:{p.rata} | Data di inizio:{p.dataInizio.ToString("dd/MM/yyyy")} | Data di fine:{p.dataFine.ToString("dd/MM/yyyy")}");
}


// test cliente
Cliente nuovoCliente = new Cliente("Gennaro", "Esposito", "654c6sd3c1", random.Next(1200, 3000));
// ricerca
banca.ricercaCliente("6cwwcwc6w5ce");
// aggiunta
banca.aggiungiCliente(nuovoCliente);
// modifica
banca.modificaCliente("6cwwcwc6w5ce", nuovoCliente);
// elimina
banca.eliminaCliente("654c6sd3c1");


// test prestiti
banca.totalePrestiti("sdvewrv68464");
// aggiunta prestito
Prestito prestito = new Prestito(nuovoCliente, 5000, 15, DateTime.Now, DateTime.Now.AddYears(4));
banca.aggiungiPrestito(prestito);
