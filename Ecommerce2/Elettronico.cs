using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce2
{
    public class Elettronico : Prodotto
    {
        private string _codicemodello;
        private decimal _prezzoscontato;

        public Elettronico(string id, string nome, string produttore, string descrizione, decimal prezzo, string codicemodello) : base(id, nome, produttore, descrizione, prezzo)
        {
            CodiceModello = codicemodello;
            PrezzoScontato = prezzo;
        }

        public string CodiceModello
        {
            get
            {
                return _codicemodello;
            }
            private set
            {
                if (value != null)
                    _codicemodello = value;
                else
                    throw new Exception("Inserire un codice valido");
            }
        }

        public decimal PrezzoScontato
        {
            get
            {
                return _prezzoscontato;
            }
            set
            {
                if (value > 0)
                    _prezzoscontato = value;
                else
                    throw new Exception("Il prezzo deve essere positivo");
            }
        }

        public void ApplicareSconto()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                PrezzoScontato = 0.95m * Prezzo;
            }
        }
    }
}
