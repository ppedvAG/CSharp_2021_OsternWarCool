using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Du hast mich geklickt");
            button1.Text = $"{textBox1.Text}, du hast mich geklickt";
            
            if (button1.BackColor == Color.MediumAquamarine)
                button1.BackColor = Color.Blue;
            else
                button1.BackColor = Color.MediumAquamarine;

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Left++;
        }
    }
}
