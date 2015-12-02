//Created by: Tasia Reynen
//on December 2, 2015
//Exhaust Port
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWarsObject
{
    public partial class Form1 : Form
    {
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            ExhaustPort(100, 0, 75,200);
        }
        /// <summary>
        /// Draws an exhaust port at any given x and x coordinate with its given width and height in the Star Wars animation
        /// </summary>
        /// <param name="x">Chooses the x coordinate of where to draw the exhaust port</param>
        /// <param name="y">Chooses the y coordinate of where to draw the exhaust port</param>
        /// <param name="width">Determines the width of the exhaust port that is drawn</param>
        /// <param name="height">Determines the hieght of the exhuast port that is drawn</param>
        public void ExhaustPort(float x, float y, float width, float height)
        {
            float scaleX = (width / 75);
            float scaleY = (height / 200);

            Pen exPen = new Pen(Color.White,2);
            //Rectangle base
            g.DrawRectangle(exPen, x, y, width, height);

            //Middle lines
            g.DrawLine(exPen, (24 * scaleX + x), (0 * scaleY + y), (24 * scaleX + x), (173 * scaleY+ y));
            g.DrawLine(exPen, (50 * scaleX + x) , (0 * scaleY + y), (50 * scaleX + x) , (173 * scaleY + y));

            //Outside lines
            exPen.Color = Color.Blue;
            g.DrawLine(exPen,(14 * scaleX + x), (49 * scaleY + y), (14 * scaleX + x), (173 * scaleY + y));
            g.DrawLine(exPen, (60 * scaleX + x), (50 * scaleY + y), (60 * scaleX + x), (173 * scaleY + y));

            //Arc
            exPen.Color = Color.White;
            g.DrawArc(exPen, 16 * scaleX + x, 169 * scaleY + y, 40 * scaleX, 31 * scaleY, -48, 277);

            //Triangle ends
            exPen.Color = Color.Red;
            g.DrawLine(exPen, (24 * scaleX + x), (0 * scaleY + y), (0 * scaleX + x), (50 * scaleY + y));
            g.DrawLine(exPen, (0 * scaleX + x), (50 * scaleY + y), (15 * scaleX + x), (50 * scaleY + y));
            g.DrawLine(exPen, (50 * scaleX + x), (0 * scaleY + y), (75 * scaleX + x), (50 * scaleY + y));
            g.DrawLine(exPen, (60 * scaleX + x), (50 * scaleY + y), (75 * scaleX + x), (50 * scaleY + y));

            //Left outer side of arc
            exPen.Color = Color.Blue;
            g.DrawLine(exPen, (14 * scaleX + x), (171 * scaleY + y), (0 * scaleX + x), (192 * scaleY + y));
            g.DrawLine(exPen, (0 * scaleX + x), (192 * scaleY + y), (24 * scaleX + x), (200 * scaleY + y));

            //Right outer side of arc
            g.DrawLine(exPen, (60 * scaleX + x), (171 * scaleY + y), (74 * scaleX + x), (192 * scaleY + y));
            g.DrawLine(exPen, (74 * scaleX + x), (192 * scaleY + y), (50 * scaleX + x), (200 * scaleY + y));

            //Bottom line
            g.DrawLine(exPen, (24 * scaleX + x), (200 * scaleY + y), (50 * scaleX + x), (200 * scaleY + y));
        }
    }
}
