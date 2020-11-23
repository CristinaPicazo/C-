using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTAInheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(10.0, 20.0);
            MessageBox.Show("Width= " + rect.Width + " Length= " + rect.Length + "\nArea= " + rect.GetArea());
            
            List<Polygon> polygons = new List<Polygon>();
            polygons.Add(new Polygon());
            polygons.Add(new Rectangle(10.0, 20.0));
            polygons.Add(new Triangle());

            foreach( Polygon p in polygons)
            {
                p.Draw();
            }
            Triangle t = new Triangle();
            t.Draw();
        }
    }
}
