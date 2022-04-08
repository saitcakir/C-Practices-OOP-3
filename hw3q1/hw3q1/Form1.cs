using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hw3q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      public  class Circle
        {
            public double Radius { get; set; }
            public double CirclePerimeter { get; set; }
            public double CircleArea { get; set; }
            public Circle() { }
            public Circle(double Radius)
            {
                this.Radius = Radius;
            }
            public void CirclePerimeterFun()
            {
                CirclePerimeter = 2 * Math.PI * Radius;
            }
            public void CircleAreaFun()
            {
                CircleArea = Math.PI * Radius * Radius;
            }
        }
       public class Cylinder : Circle
        {
            public double CylinderSurfaceArea { get; set; }
            public double CylinderVolume { get; set; }
            public double Height { get; set; }
            public Cylinder() { }
            public Cylinder(double Radius, double Height) : base(Radius)
            {
                this.Height = Height;
            }
            public void CylinderSurfaceAreaFun()
            {
                CircleAreaFun();
                CirclePerimeterFun();
                CylinderSurfaceArea = CircleArea * 2 + CirclePerimeter * Height;
            }
            public void CylinderVolumeFun()
            {
                CircleAreaFun();
                CylinderVolume = CircleArea * Height;
            }
        }
        private void button_Calculate_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox_Radius.Text, out double Radius);
            double.TryParse(textBox_Radius.Text, out double Height);

            Cylinder Cylinder1 = new Cylinder(Radius,Height);
            Cylinder1.CylinderSurfaceAreaFun();
            Cylinder1.CylinderVolumeFun();
            textBox_Area.Text = Cylinder1.CylinderSurfaceArea.ToString();
            textBox_Volume.Text = Cylinder1.CylinderVolume.ToString();
        }
    }
}
