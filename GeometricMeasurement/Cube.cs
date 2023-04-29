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
    public partial class Cube : Form
    {
        public Cube()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(this.radiuscube.Text);

            Calculation Squarecal = new Calculation(radius);

            double area = Squarecal.CubeArea();
            double volume = Squarecal.CubeVolume();

            this.cubearea.Text = Convert.ToString(area);
            this.cubevolume.Text = Convert.ToString(volume);
        }
    }
}
