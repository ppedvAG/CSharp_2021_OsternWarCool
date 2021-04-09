using HalloCam.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloCam.UI
{
    public partial class KameraView : UserControl
    {
        BindingSource bs = new BindingSource();

        public KameraView()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bs; // complex binding

            //herstellerTextBox.DataBindings.Add("Text", bs, "Hersteller", true, DataSourceUpdateMode.OnPropertyChanged);
            herstellerTextBox.DataBindings.Add(nameof(TextBox.Text), bs, nameof(Kamera.Hersteller), true, DataSourceUpdateMode.OnPropertyChanged);
            modellTextBox.DataBindings.Add(nameof(TextBox.Text), bs, nameof(Kamera.Modell), true, DataSourceUpdateMode.OnPropertyChanged);


            CreateDemoDaten();
        }

        void CreateDemoDaten()
        {
            Kamera cam1 = new Kamera()
            {
                Hersteller = "Bony",
                Modell = "BIIOO",
                Anschlusstyp = Anschlusstyp.Sony,
                Sensoregröße = 12,
                SensorTyp = "ja"
            };

            Kamera cam2 = new Kamera()
            {
                Hersteller = "Banon",
                Modell = "PicMax",
                Anschlusstyp = Anschlusstyp.Canon,
                Sensoregröße = 16,
                SensorTyp = "jein"
            };

            Kamera cam3 = new Kamera()
            {
                Hersteller = "Bikon",
                Modell = "UltraPixx",
                Anschlusstyp = Anschlusstyp.Nikon,
                Sensoregröße = 17,
                SensorTyp = "jo"
            };

            bs.Add(cam1);
            bs.Add(cam2);
            bs.Add(cam3);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kamera newCam = new Kamera()
            {
                Hersteller = "NEU",
                Modell = "NEU"
            };

            bs.Add(newCam);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bs.Current is Kamera cam)
            {
                string msg = $"Soll die Kamera {cam.Modell} von {cam.Hersteller} wirklich entfernt werden?";
                DialogResult dr = MessageBox.Show(msg, "Entfernen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    bs.Remove(cam);
                }
            }
            else
            {
                MessageBox.Show("Keine Kamera ausgewählt");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //StreamWriter sw = new StreamWriter("Kameras.xml");
                Logger.Log("Hallo, es soll gespeichert werden");

                DataManager dm = new DataManager("Kameras.xml");
                dm.SaveKameras(bs.Cast<Kamera>());

                MessageBox.Show("Kameras wurde gespeichert");
            }
            catch (PathTooLongException ex)
            {
                MessageBox.Show($"Der Pfad ist zu lang: {ex.Message}");

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Das stimmt was mit den Pfad nicht: {ex.Message}");
                Logger.Log($"Fehler beim speichern: {ex.Message}");

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Fehler: {ex.Message}");
                MessageBox.Show($"Fehler: {ex.Message}");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataManager dm = new DataManager("Kameras.xml");
            bs.DataSource = dm.LoadKameras();

            BrauchtManNicht krjewng = new BrauchtManNicht();
            
            System.Int32 zahl = 5;
            int zahl2 = 10;
            
        }
    }


    struct BrauchtManNicht
    {
        public int MyProperty { get; set; }
        void KillMe()
        {


        }
    }
}


