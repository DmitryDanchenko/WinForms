using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPaint1
{
    public partial class Form1 : Form
    {
        private int _pozichion1X;
        private int _pozichion1Y;
        private int _pozichion2X;
        private int _pozichion2Y;
        private Figure _figure;
        
        public Form1()
        {
         InitializeComponent();
         _pozichion1X = 0;
         _pozichion1Y = 0;
         _pozichion2X = 0;
         _pozichion2Y = 0;

        }

     

        private void toolStripMenuItem1_MouseDown(object sender, MouseEventArgs e)
        {
            _pozichion1X = e.X;
            _pozichion1Y = e.Y;

        }

        private void toolStripMenuItem1_MouseUp(object sender, MouseEventArgs e)
        {
           
           
            _pozichion2X = e.X;
            _pozichion2Y = e.Y;
            panel1.Invalidate();

            if (_figure == Figure.Line)
            {
                _pozichion2X = e.X;
                _pozichion2Y = e.Y;
            }
            else
            {

                if (_pozichion2X < _pozichion1X)
                {
                    _pozichion2X = _pozichion1X;
                    _pozichion1X = e.X;

                }
                if (_pozichion2Y < _pozichion1Y)
                {
                    _pozichion2Y = _pozichion1Y;
                    _pozichion1Y = e.Y;
                }
            }
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pn = new Pen(Brushes.Black, 3);
            int H = Math.Abs(_pozichion2Y - _pozichion1Y);
            int SH=Math.Abs(_pozichion2X - _pozichion1X);


            switch (_figure)
            {
                case Figure.Line:
                    


                    e.Graphics.DrawLine(pn, _pozichion1X, _pozichion1Y, _pozichion2X, _pozichion2Y);
                    break;

                case Figure.Rectangle:
                    
                    e.Graphics.DrawRectangle(pn, _pozichion1X, _pozichion1Y, SH, H);
                    break;

                case Figure.Ellipse:

                    e.Graphics.DrawEllipse(pn, _pozichion1X, _pozichion1Y, SH, H);
                    break;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _figure = Figure.Line;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            _figure = Figure.Rectangle;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            _figure = Figure.Ellipse;
        }
    }
}
