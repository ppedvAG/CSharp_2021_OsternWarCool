using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDScreensaver
{
    public delegate void TribleClickDelegate(int clicks);

    public class MyButton : Button
    {
        //public event EventHandler TribleClick;
        public event TribleClickDelegate TribleClick;

        int clickCount = 0;

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            clickCount++;

            if (clickCount % 3 == 0)
            {
                if (TribleClick != null)//wurde das Event aboniert?
                    TribleClick.Invoke(clickCount);
            }
        }


        protected override void OnPaint(PaintEventArgs pevent)
        {
            //base.OnPaint(pevent);
            pevent.Graphics.FillRectangle(new SolidBrush(Parent.BackColor), pevent.ClipRectangle);
            pevent.Graphics.FillEllipse(Brushes.Red, ClientRectangle);

            var sf = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            pevent.Graphics.DrawString(Text, new Font("Showcard Gothic", 24f), Brushes.Aqua, ClientRectangle, sf); ;

            if (ClientRectangle.Contains(PointToClient(Cursor.Position)))
            {
                var rect = ClientRectangle;
                rect.Inflate(-5, -5);
                pevent.Graphics.DrawEllipse(new Pen(Color.Aqua, 10), rect);
            }

        }
    }
}
