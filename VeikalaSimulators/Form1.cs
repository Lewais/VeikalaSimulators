using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeikalaSimulators
{
    public partial class Form1 : Form
    {

        private VeikalaLogika veikals;
        private Random random;

        public Form1()
        {
            InitializeComponent();
            veikals = new VeikalaLogika();
            random = new Random();
            UpdateText();
        }

        private void UpdateText()
        {
            Budzets.Text = $"Budžets: {veikals.Budzets} €";
            Inventars.Text = $"Preces invetārā: {veikals.Invetars}";
            PrecesCena.Text = $"Produkta cena: {veikals.ProduktaCena} €";
        }
    }
}
