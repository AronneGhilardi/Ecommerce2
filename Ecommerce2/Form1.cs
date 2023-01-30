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
        }

        Prodotto Acqua = new Prodotto("P1", "Acqua", "Levissima", "Un 1.5L di semplice H2O.", 0,25);
        Prodotto Vino = new Prodotto("P2", "Vino", "Tavernello", "5L di acqua sporca in cartone.", 5);
        Prodotto Birra = new Prodotto("P3", "Birra", "Guinness", "Lattina da 33cl potenti.", 1);
        Prodotto Olio = new Prodotto("P4", "Olio", "unCalabbrese", "1L biologico a Km 0.", 8);
        Prodotto Miele = new Prodotto("P5", "Miele", "Franco", "1kg di Miele delle valli.", 15);
        Prodotto Carne = new Prodotto("P6", "Cotechini", "Diego", "5 cotechini nostrani.", 10);
        Prodotto Pane = new Prodotto("p7", "Pane", "Panificio Locatelli", "4 panini a caso", 1);
        Prodotto Uova = new Prodotto("p8", "Uova", "Ambrogio", "6 uova leghiste", 2);


        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
