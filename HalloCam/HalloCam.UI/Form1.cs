using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloCam.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            aboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            aboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            aboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            aboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            aboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            aboutToolStripMenuItem.Click -= AboutToolStripMenuItem_Click;
            aboutToolStripMenuItem.Click -= AboutToolStripMenuItem_Click;
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hallo");
        }
    }
}
