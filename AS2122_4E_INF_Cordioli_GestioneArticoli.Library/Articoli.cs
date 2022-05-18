using System;

namespace AS2122_4E_INF_Cordioli_GestioneArticoli.Library
{
    public class Articoli
    {
        public string codice;
        public string Codice { get { return Codice; } }

        public string descrizione;
        public string Descrizione { get { return Descrizione; } }

        public double prezzo;
        public string Prezzo { get { return Prezzo; } }

        public string unita;
        public string Unita { get { return Unita; } }

        public Articoli(string codice, string descrizione, double prezzo, string unita)
        {
            this.codice = codice;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.unita = unita;
        }

        public string Stampa()
        {
            return $"{codice} {descrizione} {prezzo} {unita}";
        }

    }
}
