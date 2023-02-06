using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ecommerce2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            carica();
            domainUpDown1.SelectedItem = Acqua.Nome;
            listView1.FullRowSelect = true;
        }

        DateTime date1 = new DateTime(2023, 2, 6);

        Carrello kart = new Carrello("C123");

        Alimentare Acqua = new Alimentare("P1", "Acqua", "Levissima", "Un 1.5L di semplice H2O.", 1, DateTime.Today);
        Alimentare Vino = new Alimentare("P2", "Vino", "Tavernello", "5L di acqua sporca in cartone.", 5, DateTime.Today);
        Alimentare Birra = new Alimentare("P3", "Birra", "Guinness", "Lattina da 33cl potenti.", 2, DateTime.Today);
        Alimentare Olio = new Alimentare("P4", "Olio", "unCalabbrese", "1L biologico a Km 0.", 8, DateTime.Today);
        Alimentare Miele = new Alimentare("P5", "Miele", "Franco", "1kg di Miele delle valli.", 15, DateTime.Today);
        Alimentare Carne = new Alimentare("P6", "Cotechini", "Diego", "5 cotechini nostrani.", 10, DateTime.Today);
        Alimentare Pane = new Alimentare("p7", "Pane", "Panificio Locatelli", "4 panini a caso.", 1, DateTime.Today);
        Alimentare Uova = new Alimentare("p8", "Uova", "Ambrogio", "6 uova leghiste.", 2, DateTime.Today);
        Alimentare Pollo = new Alimentare("p9", "Pollo", "Esselunga", "1kg di peti di pollo.", 6, DateTime.Today);
        Alimentare Latte = new Alimentare("p10", "Latte", "Mucca", "1L di latte bio.", 3, DateTime.Today);
        Cancelleria Penna = new Cancelleria("p11", "Penna", "Bic", "Penna a sfera.", 2, 2, "Scrive.");
        Cancelleria Matita = new Cancelleria("p12", "Matita", "Stabilo", "Matita HB.", 1, 1, "Scrive.");
        Cancelleria Gomma = new Cancelleria("p13", "Gomma", "Pirelli", "E' na gomma.", 1, 0, "Cancella.");
        Cancelleria Quaderno = new Cancelleria("p14", "Quaderno", "VerniceFresca", "Quaderno A4, quadretti 5mm.", 4, 0, "Ci scrivi sopra.");
        Elettronico Cellulare = new Elettronico("p15", "S7", "Samsung", "SamrtPhone che esplode.", 200, "s7");
        Elettronico Televisione = new Elettronico("p16", "Q930", "Samsung", "Tv 40'.", 400, "AB-Q930-2");
        Elettronico Cuffie = new Elettronico("p17", "React", "Fnatic", "Cuffie 3D da gaming.", 60, "MP3-3D");
        Elettronico Caricatore = new Elettronico("p18", "Caricatore", "Apple", "venduto a parte dal Cell.", 30, "220W-A");

        Prodotto[] lista = new Prodotto[18];

        public void carica()
        {
            domainUpDown1.Items.Add(Acqua.Nome);
            domainUpDown1.Items.Add(Vino.Nome);
            domainUpDown1.Items.Add(Birra.Nome);
            domainUpDown1.Items.Add(Olio.Nome);
            domainUpDown1.Items.Add(Miele.Nome);
            domainUpDown1.Items.Add(Carne.Nome);
            domainUpDown1.Items.Add(Pane.Nome);
            domainUpDown1.Items.Add(Uova.Nome);
            domainUpDown1.Items.Add(Pollo.Nome);
            domainUpDown1.Items.Add(Latte.Nome);
            domainUpDown1.Items.Add(Penna.Nome);
            domainUpDown1.Items.Add(Matita.Nome);
            domainUpDown1.Items.Add(Gomma.Nome);
            domainUpDown1.Items.Add(Quaderno.Nome);
            domainUpDown1.Items.Add(Cellulare.Nome);
            domainUpDown1.Items.Add(Televisione.Nome);
            domainUpDown1.Items.Add(Cuffie.Nome);
            domainUpDown1.Items.Add(Caricatore.Nome);
            lista[0] = Acqua;
            lista[1] = Vino;
            lista[2] = Birra;
            lista[3] = Olio;
            lista[4] = Miele;
            lista[5] = Carne;
            lista[6] = Pane;
            lista[7] = Uova;
            lista[8] = Pollo;
            lista[9] = Latte;
            lista[10] = Penna;
            lista[11] = Matita;
            lista[12] = Gomma;
            lista[13] = Quaderno;
            lista[14] = Cellulare;
            lista[15] = Televisione;
            lista[16] = Cuffie;
            lista[17] = Caricatore;
        }

        public Prodotto prod(string a)
        {
            Prodotto p;
            for (int i = 0; i < 99; i++)
            {
                if (lista[i].Nome == a)
                {
                    p = lista[i];
                    return p;
                }
            }
            return null;
        }

        public void aggiorna()
        {
            listView1.Items.Clear();
            for (int i = 0; i < 100; i++)
            {
                if (kart.Cerca(kart.getProdotto(i)) != -1)
                {
                    Prodotto p = kart.getProdotto(i);
                    if (p != null)
                    {
                        ListViewItem itm;
                        itm = new ListViewItem(p.Id);
                        itm.SubItems.Add(p.Nome);
                        itm.SubItems.Add(p.Produttore);
                        itm.SubItems.Add(p.Descrizione);
                        itm.SubItems.Add(p.Prezzo+"");
                        itm.SubItems.Add("");
                        listView1.Items.Add(itm);
                    }
                }
            }
            label2.Text = Convert.ToString(kart.Calctot());
            label3.Text = Convert.ToString(kart.Calctots());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string a = Convert.ToString(domainUpDown1.SelectedItem);
                kart.Aggiungi(prod(a));
                aggiorna();
            }
            catch (Exception eccezione)
            {
                MessageBox.Show(eccezione.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                string a = Convert.ToString(domainUpDown1.SelectedItem);
                kart.Rimuovi(prod(a));
                aggiorna();
            }
            catch (Exception eccezione)
            {
                MessageBox.Show(eccezione.Message);
            }
        }

        private void SVUOTA_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sicuro di voler eliminare?", "Attenzione", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                kart.Svuota();
                aggiorna();
            }
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
