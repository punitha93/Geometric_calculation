using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricMeasurement
{
    public partial class Triangle : Form
    {
        public Triangle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double side1 = Convert.ToDouble(this.side1triangle.Text);
            double side2 = Convert.ToDouble(this.side2triangle.Text);
            double side3 = Convert.ToDouble(this.side3triangle.Text);

            Calculation Squarecal = new Calculation(side1, side2, side3);

            double area = Squarecal.CubeArea();
            double circumference = Squarecal.CubeVolume();

            this.trianglearea.Text = Convert.ToString(area);
            this.trianglecircumference.Text = Convert.ToString(circumference);
        }
    }
}
