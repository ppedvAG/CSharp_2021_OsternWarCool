using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDScreensaver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            myButton1.TribleClick += MyButton1_TribleClick;
            myButton1.TribleClick += (int c) => { MessageBox.Show(c.ToString()); };
            myButton1.TribleClick += (c) =>  MessageBox.Show(c.ToString());
            myButton1.TribleClick += x =>  MessageBox.Show(x.ToString());

            #region Tetrismelodi
            //Task.Run(() =>
            //{ // Tetris
            //    Console.Beep(658, 125);
            //    Console.Beep(1320, 500);
            //    Console.Beep(990, 250);
            //    Console.Beep(1056, 250);
            //    Console.Beep(1188, 250);
            //    Console.Beep(1320, 125);
            //    Console.Beep(1188, 125);
            //    Console.Beep(1056, 250);
            //    Console.Beep(990, 250);
            //    Console.Beep(880, 500);
            //    Console.Beep(880, 250);
            //    Console.Beep(1056, 250);
            //    Console.Beep(1320, 500);
            //    Console.Beep(1188, 250);
            //    Console.Beep(1056, 250);
            //    Console.Beep(990, 750);
            //    Console.Beep(1056, 250);
            //    Console.Beep(1188, 500);
            //    Console.Beep(1320, 500);
            //    Console.Beep(1056, 500);
            //    Console.Beep(880, 500);
            //    Console.Beep(880, 500);
            //    Thread.Sleep(250);
            //    Console.Beep(1188, 500);
            //    Console.Beep(1408, 250);
            //    Console.Beep(1760, 500);
            //    Console.Beep(1584, 250);
            //    Console.Beep(1408, 250);
            //    Console.Beep(1320, 750);
            //    Console.Beep(1056, 250);
            //    Console.Beep(1320, 500);
            //    Console.Beep(1188, 250);
            //    Console.Beep(1056, 250);
            //    Console.Beep(990, 500);
            //    Console.Beep(990, 250);
            //    Console.Beep(1056, 250);
            //    Console.Beep(1188, 500);
            //    Console.Beep(1320, 500);
            //    Console.Beep(1056, 500);
            //    Console.Beep(880, 500);
            //    Console.Beep(880, 500);
            //    Thread.Sleep(500);
            //    Console.Beep(1320, 500);
            //    Console.Beep(990, 250);
            //    Console.Beep(1056, 250);
            //    Console.Beep(1188, 250);
            //    Console.Beep(1320, 125);
            //    Console.Beep(1188, 125);
            //    Console.Beep(1056, 250);
            //    Console.Beep(990, 250);
            //    Console.Beep(880, 500);
            //    Console.Beep(880, 250);
            //    Console.Beep(1056, 250);
            //    Console.Beep(1320, 500);
            //    Console.Beep(1188, 250);
            //    Console.Beep(1056, 250);
            //    Console.Beep(990, 750);
            //    Console.Beep(1056, 250);
            //    Console.Beep(1188, 500);
            //    Console.Beep(1320, 500);
            //    Console.Beep(1056, 500);
            //    Console.Beep(880, 500);
            //    Console.Beep(880, 500);
            //    Thread.Sleep(250);
            //    Console.Beep(1188, 500);
            //    Console.Beep(1408, 250);
            //    Console.Beep(1760, 500);
            //    Console.Beep(1584, 250);
            //    Console.Beep(1408, 250);
            //    Console.Beep(1320, 750);
            //    Console.Beep(1056, 250);
            //    Console.Beep(1320, 500);
            //    Console.Beep(1188, 250);
            //    Console.Beep(1056, 250);
            //    Console.Beep(990, 500);
            //    Console.Beep(990, 250);
            //    Console.Beep(1056, 250);
            //    Console.Beep(1188, 500);
            //    Console.Beep(1320, 500);
            //    Console.Beep(1056, 500);
            //    Console.Beep(880, 500);
            //    Console.Beep(880, 500);
            //    Thread.Sleep(500);
            //    Console.Beep(660, 1000);
            //    Console.Beep(528, 1000);
            //    Console.Beep(594, 1000);
            //    Console.Beep(495, 1000);
            //    Console.Beep(528, 1000);
            //    Console.Beep(440, 1000);
            //    Console.Beep(419, 1000);
            //    Console.Beep(495, 1000);
            //    Console.Beep(660, 1000);
            //    Console.Beep(528, 1000);
            //    Console.Beep(594, 1000);
            //    Console.Beep(495, 1000);
            //    Console.Beep(528, 500);
            //    Console.Beep(660, 500);
            //    Console.Beep(880, 1000);
            //    Console.Beep(838, 2000);
            //    Console.Beep(660, 1000);
            //    Console.Beep(528, 1000);
            //    Console.Beep(594, 1000);
            //    Console.Beep(495, 1000);
            //    Console.Beep(528, 1000);
            //    Console.Beep(440, 1000);
            //    Console.Beep(419, 1000);
            //    Console.Beep(495, 1000);
            //    Console.Beep(660, 1000);
            //    Console.Beep(528, 1000);
            //    Console.Beep(594, 1000);
            //    Console.Beep(495, 1000);
            //    Console.Beep(528, 500);
            //    Console.Beep(660, 500);
            //    Console.Beep(880, 1000);
            //    Console.Beep(838, 2000);
            //});
            #endregion
        }

        private void MyButton1_TribleClick(int clicks)
        {
            MessageBox.Show(clicks.ToString());
        }

        int speedX = 4;
        int speedY = 4;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (myButton1.Right >= ClientRectangle.Width || myButton1.Left <= 0)
            {
                speedX *= -1;
                Task.Run(() => Console.Beep(300, 100));
            }

            myButton1.Left += speedX;

            if (myButton1.Bottom >= ClientRectangle.Height || myButton1.Top <= 0)
            {
                speedY *= -1;
                Task.Run(() => Console.Beep(300, 100));
            }

            myButton1.Top += speedY;

            Text = $"{myButton1.Left}x{myButton1.Top}";
        }


    }
}
