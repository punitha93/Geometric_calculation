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
    public partial class ShapeSelection : Form
    {
        public ShapeSelection()
        {
            InitializeComponent();
        }

        private void squarebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Square shapesel = new Square();
            shapesel.Show();
        }

        private void circlebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Circle shapesel = new Circle();
            shapesel.Show();
        }
        private void rectanglebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rectangle shapesel = new Rectangle();
            shapesel.Show();
        }

        private void cubebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cube shapesel = new Cube();
            shapesel.Show();
        }

        private void trianglebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Triangle shapesel = new Triangle();
            shapesel.Show();
        }
    }
}
