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
    public partial class Circle : Form
    {
        public Circle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(this.radiuscircle.Text);

            Calculation Squarecal = new Calculation(radius);

            double area = Squarecal.CircleArea();
            double circumference = Squarecal.CircleCircumference();

            this.circlearea.Text = Convert.ToString(area);
            this.circlecircumference.Text = Convert.ToString(circumference);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(this.radiuscircle.Text);

            Calculation Squarecal = new Calculation(radius);

            double area = Squarecal.CircleArea();
            double circumference = Squarecal.CircleCircumference();

            this.circlearea.Text = Convert.ToString(area);
            this.circlecircumference.Text = Convert.ToString(circumference);
        }
    }
}
