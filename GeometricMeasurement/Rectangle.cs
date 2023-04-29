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
    public partial class Rectangle : Form
    {
        public Rectangle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double length = Convert.ToDouble(this.lengthrectangle.Text);
            double width = Convert.ToDouble(this.widthrectangle.Text);

            Calculation Squarecal = new Calculation(length,width);

            double area = Squarecal.RectangleArea();
            double circumference = Squarecal.RectangleCircumference();

            this.rectanglearea.Text = Convert.ToString(area);
            this.rectanglecircumference.Text = Convert.ToString(circumference);
        }
    }

}
