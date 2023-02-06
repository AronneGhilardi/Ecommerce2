using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce2
{
    internal class Cancelleria : Prodotto
    {
        public int _grammatura;
        public string _funzionamento;

        public Cancelleria(string id, string nome, string prod, string descr, decimal prezzo, int grammatura, string funzionamento) : base(id, nome, prod, descr, prezzo)
        {
            Grammatura = grammatura;
            Funzionamento = funzionamento;
        }

        public int Grammatura
        {
            get
            {
                return _grammatura;
            }
            set
            {
                if (value >= 0)
                    _grammatura = value;
                else
                    throw new Exception("Grammatura errata");
            }
        }

        public string Funzionamento
        {
            get
            {
                return _funzionamento;
            }
            private set
            {
                if (value != null)
                    _funzionamento = value;
                else
                    throw new Exception("Inserire un funzionamento valido");
            }
        }

        public decimal PrezzoScontato()
        {
            decimal prezzoScontato = Prezzo;
            if (DateTime.Today.Day % 2 == 0)
                prezzoScontato -= Prezzo * 0.03m;
            return prezzoScontato;
        }
    }
}
