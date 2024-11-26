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
        public static int simulacijas = 0;

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
            ProduktaCena.Text = veikals.ProduktaCena.ToString();
        }

        private void DienasSimulacija_Click(object sender, EventArgs e)
        {
            simulacijas++;
            DienasSimuletas.Text = $"Dienas simulētas: {simulacijas.ToString()}";
            var rezultats = veikals.DienasSimulacija(random);
            NotikumuKaste.AppendText(rezultats + Environment.NewLine);

            var NejausNotikums = Notikumi.NotikumuGenerators(veikals, random);
            if (!string.IsNullOrEmpty(NejausNotikums))
            {
                NotikumuKaste.AppendText(NejausNotikums + Environment.NewLine);
            }

            UpdateText();

            if (veikals.Budzets < 0)
            {
                MessageBox.Show($"Tu bankrotēji! Spēle beigusies.\nSimulētas dienas: {simulacijas}", "Simulācijas beigas");
                DienasSimulacija.Enabled = false;
                IepirktInvetaru.Enabled = false;
                IepirkumaDaudzums.Enabled = false;
                simulacijas = 0;
            }
        }

        private void IepirktInvetaru_Click(object sender, EventArgs e)
        {
            if (int.TryParse(IepirkumaDaudzums.Text, out int value)) {
                if (value > 100 || value == 0)
                {
                    MessageBox.Show("Maksimālais iepirkuma skaits ir 1-100.");
                }
                else if(veikals.InvetaraIepirkums(value))
                {
                    NotikumuKaste.AppendText($"+ Veiksmīgi iepirkti {value} produkti." + Environment.NewLine);
                    UpdateText();
                } else {
                    MessageBox.Show("Nepietiek līdzkļu.");
                }
            }
        }

        private void MainitProduktaCenu_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(ProduktaCena.Text, out decimal value))
            {
                veikals.ProduktaCena = value;
                UpdateText();
            }
        }
    }
}
