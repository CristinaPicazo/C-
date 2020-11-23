using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTAInheritance
{
    class Polygon
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public virtual void Draw()
        {
            //System.Windows.Forms.MessageBox.Show("Drawing Polygon");
            MessageBox.Show("Drawing Polygon");
        }
    }
}
