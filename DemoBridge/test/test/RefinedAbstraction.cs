using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Square : Shape
    {
        public override void drawShape(Graphics graphics)
        {
            Pen myPen = new Pen(color.GetColor(), 5);

            Rectangle myRectangle = new Rectangle(100, 100, 100, 100);

            graphics.DrawRectangle(myPen, myRectangle);
        }
    }

    class Circle : Shape
    {
        public override void drawShape(Graphics graphics)
        {
            Pen myPen = new Pen(color.GetColor(), 5);

            Rectangle myRectangle = new Rectangle(100, 100, 100, 100);

            graphics.DrawEllipse(myPen, myRectangle);
        }
    }
  /*  class Triangle : Shape
    {
        public override void drawShape(Graphics graphics)
        {
            Pen myPen = new Pen(color.GetColor(), 5);

            graphics.DrawLine(myPen, new Point(0, 50), new Point(50, 0));
            graphics.DrawLine(myPen, new Point(50, 0), new Point(50, 100));
            graphics.DrawLine(myPen, new Point(50, 100), new Point(0, 50));
        }   
    }*/
}
