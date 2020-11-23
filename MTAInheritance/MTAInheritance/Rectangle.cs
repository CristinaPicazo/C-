using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTAInheritance
{
    class Rectangle:Polygon
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public override void Draw()
        {
            MessageBox.Show("Drawing Rectangle");
        }
        public double GetArea()
        {
            return Width * Length;
        }
    }
    class Triangle:Polygon
    {
        public new void Draw()
        {
            MessageBox.Show("Drawing Triangle");
        }
    }
}
