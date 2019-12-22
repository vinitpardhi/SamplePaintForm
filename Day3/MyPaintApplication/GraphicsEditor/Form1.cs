using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace GraphicsEditor
{
    public partial class Form1 : Form
    {
        Pen thePen=new Pen(Color.Black);        
        Point startPoint = new Point(0, 0);
        Point endPoint = new Point(0, 0);
        Graphics g;
        enum Shapes
        {
            Line=0,
            Rectangle=1,
            Ellipse=2,
            NoShape=-1
        };
        Shapes SelectedShape = Shapes.NoShape;
        public Form1()
        {
            InitializeComponent();
        }

        private void OnFileExit(object sender, EventArgs e)
        {
           DialogResult result= MessageBox.Show("Do you really want to quit?","Warning",MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                this.Close();
        }
       

        private void OnShapeLine(object sender, EventArgs e)
        {
            this.SelectedShape = Shapes.Line;
        }

        private void OnGDIPenColor(object sender, EventArgs e)
        {
            ColorDialog myColor = new ColorDialog();
            if (myColor.ShowDialog() == DialogResult.OK)
            {
                thePen.Color = myColor.Color;
            }
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            startPoint = new Point(e.X, e.Y);
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            endPoint = new Point(e.X, e.Y);
            g = this.CreateGraphics();
            thePen.Width = 4.0F;
            float width = endPoint.X - startPoint.X;
            float height = endPoint.Y - startPoint.Y;
            switch (this.SelectedShape)
            {
                case Shapes.Line:
                    g.DrawLine(thePen, startPoint, endPoint);
                    break;

                case Shapes.Rectangle:
                    g.DrawRectangle(thePen, startPoint.X, startPoint.Y, width, height);
                    break;
                case Shapes.Ellipse:
                    g.DrawEllipse(thePen, startPoint.X, startPoint.Y, width, height);
                    break;
            }                                   
            
        }

        private void OnShapeEllipse(object sender, EventArgs e)
        {
            this.SelectedShape = Shapes.Ellipse;
            //thePen = new Pen(Color.Navy,5);
            /*g = this.CreateGraphics();
            g.DrawEllipse(thePen, 100, 100, 500, 300);*/

        }

        private void OnClickDrawRectangle(object sender, EventArgs e)
        {
            this.SelectedShape = Shapes.Rectangle;
            //thePen = new Pen(Color.Blue, 5);
            /*g = this.CreateGraphics();
            g.DrawRectangle(thePen,100,100,500,300);           */
        }
    }
}
