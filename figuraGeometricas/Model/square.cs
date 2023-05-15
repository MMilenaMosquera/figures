using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using figuraGeometricas.Interface;

namespace figuraGeometricas.Model
{
    internal class Square: Ifigure 
    {
        private static int id = 0; 
        private double side; 

        public Square(double side)
        {
           
            this.side = side;
        }
        public int getId() { return id; }
        public double getSide() { return side; }

        public double calculate_perimeter()
        {
            return side * 4 ;
        }

        public double calculate_surface()
        {
            return side * side;
        }

        public override string ToString()
        {
            return "Cuadrado nº: " +id + " Lados: " + side + " cm" +
              " Superfice: " + calculate_surface() +
              " Perimétro: " + calculate_perimeter();

        }
    }
}
