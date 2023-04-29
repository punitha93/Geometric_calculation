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
    public partial class Square : Form
    {
        public Square()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double side = Convert.ToDouble(this.squareside.Text);
                        
            Calculation Squarecal = new Calculation(side);
                        
            double area = Squarecal.SquareArea();            
            double circumference = Squarecal.SquareCircumference();
                        
            this.squarearea.Text = Convert.ToString(area);
            this.squarecircumference.Text = Convert.ToString(circumference);
        }
    }
}
