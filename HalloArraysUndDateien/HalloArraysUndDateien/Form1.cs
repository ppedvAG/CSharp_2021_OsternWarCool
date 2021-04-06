using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloArraysUndDateien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var arrayVordefiniert = new int[] { 124, -274, 3124, 3324, -66, 0, 5, 12, -4 };

            //MessageBox.Show(arrayVordefiniert[4].ToString());

            for (int i = 0; i < arrayVordefiniert.Length; i++)
            {
                listBox1.Items.Add(arrayVordefiniert[i]);
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            object dasAusgewählteEtwas = listBox1.SelectedItem;

            if (dasAusgewählteEtwas == null)
                MessageBox.Show("Das ist nicht ausgewählt");
            else
            {
                int dasAusgewählteAlsZahl = (int)listBox1.SelectedItem;
                MessageBox.Show($"{checked(dasAusgewählteAlsZahl * 2)} ist das doppelte");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] hunterterArray = new int[100];
            var ran = new Random(17);

            for (int i = 0; i < hunterterArray.Length; i++)
            {
                hunterterArray[i] = ran.Next();

                listBox1.Items.Add(hunterterArray[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //listBox1.Items.RemoveAt(2);
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var writer = new System.IO.StreamWriter("zahlen.txt");

            //for (int i = 0; i < listBox1.Items.Count; i++)
            //{
            //    writer.WriteLine(listBox1.Items[i]);
            //}

            foreach (var item in listBox1.Items)
            {
                writer.WriteLine(item);
            }

            writer.Close();
            MessageBox.Show("Wurde gespeichert");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Textdatei mit Zahlen auswählen";
            openFileDialog.Filter = "Textdateien|*.txt|Alle Dateien|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var reader = new System.IO.StreamReader(openFileDialog.FileName);

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var chunks = line.Split(',');
                    
                    listBox1.Items.Add(line);
                }

                reader.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }
        }
    }
}
