using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    abstract class Shape
    {
        public IColor color { get; set; }

        public Color GetColor()
        {
            return color.GetColor();
        }

        public abstract void drawShape(Graphics graphics);
    }
}
