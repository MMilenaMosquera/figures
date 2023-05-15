using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using figuraGeometricas.Interface;
using Microsoft.VisualBasic.Devices;

namespace figuraGeometricas.Model
{
    internal class Circle: Ifigure
    {
        private static int id = 0;
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double calculate_perimeter()
        {
            return 2 * Math.PI * radius;
        }

        public double calculate_surface()
        {
            return Math.PI * Math.Pow(radius, 2);       
        }
        public override string ToString()
        {
            return "Circulo nº: "+(id += 1)+ " Radio: " + radius + " cm" +
              " Superfice: " + calculate_surface() +
              " Perimétro: " + calculate_perimeter();

        }
    }


    
}
