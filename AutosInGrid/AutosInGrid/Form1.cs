using Bogus;
using HalloKlassen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutosInGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Auto auto = new Auto("Grün")
            {
                Hersteller = "Besla",
                Modell = "CXS-824"
            };

            auto.SetPS(700);
            auto.Hupen();

            List<Auto> autoListe = new List<Auto>();
            autoListe.Add(auto);
            autoListe.Add(new Auto("gelb") { Hersteller = "BlaBla", Modell = "Taxi" });


            Faker<Auto> faker = new Faker<Auto>("de");
            faker.UseSeed(17);
            faker.CustomInstantiator(x => new Auto(x.Commerce.Color()));
            faker.RuleFor(x => x.Hersteller, f => f.Vehicle.Manufacturer());
            faker.RuleFor(x => x.Modell, f => f.Vehicle.Model());
            faker.RuleFor(x => x.Besitzer, f => f.Person.FullName);

            var fakeAutos = faker.Generate(100);
            autoListe.AddRange(fakeAutos);

            dataGridView1.DataSource = autoListe;


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if( dataGridView1.CurrentRow.DataBoundItem is Auto auto)
            {
                MessageBox.Show(auto.Hersteller);
            }
        }
    }
}
