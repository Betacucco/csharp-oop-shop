using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Shop
{
    internal class Prodotto
    {
        private int codice;
        private string nome;
        private string descrizione;
        private double prezzo;
        private int iva;

        public Prodotto(string nome, string descrizione, double prezzo, int iva)
        {
            Random r = new Random();
            int codice = r.Next(10000000, 100000000);
            this.codice = codice;

            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }

        public int GetCodice()
        {
            return codice;
        }

        public int GetIva()
        {
            return iva;
        }

        public void SetIva(int iva)
        {
            this.iva = iva;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetDescrizione()
        {
            return descrizione;
        }

        public void SetDescrizione(string descrizione)
        {
            this.descrizione = descrizione;
        }

        public double GetPrezzo()
        {
            return prezzo;
        }

        public void SetPrezzo(double prezzo)
        {
            this.prezzo = prezzo;
        }

        private string PrezzoIvato()
        {
            double ivaSulPrezzo = prezzo + (prezzo * iva / 100);
            string strIva = ivaSulPrezzo.ToString("N2");
            return strIva;
        }

        private string NomeEsteso()
        {
            string nomePiuCodice = codice + nome;
            return nomePiuCodice;
        }

        //METODO PER STAMPARE 
        public void StampaProdottiSenzaIva()
        {
            Console.WriteLine("Codice: " + codice);
            Console.WriteLine("Nome prodotto: " + nome);
            Console.WriteLine("Descrizione prodotto: " + descrizione);
            Console.WriteLine("Prezzo: " + prezzo + "$");
        }

        public void StampaProdottiConIva()
        {
            Console.WriteLine("Codice: " + codice);
            Console.WriteLine("Nome prodotto: " + nome);
            Console.WriteLine("Descrizione prodotto: " + descrizione);
            Console.WriteLine("IVA: " + iva + "%");
            Console.WriteLine("Prezzo ivato: " + PrezzoIvato() + "$");
        }

        public void StampaProdottiConcatenati()
        {
            Console.WriteLine("Codice e nome del prodotto: " + NomeEsteso());
            Console.WriteLine("Descrizione prodotto: " + descrizione);
            Console.WriteLine("IVA: " + iva + "%");
            Console.WriteLine("Prezzo ivato: " + PrezzoIvato() + "$");
        }
    }
}
