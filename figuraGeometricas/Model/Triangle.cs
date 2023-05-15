using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using figuraGeometricas.Interface;

namespace figuraGeometricas.Model
{
    internal class Triangle : Ifigure
    {
        private static int id = 0;
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideBase)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideBase;
        }
        public double SideA { get { return sideA; } }
        public double SideB { get { return sideB; } }
        public double SideC { get { return sideC; } }

       
        public double calculate_perimeter()
        {
            return sideA + sideB + sideC;
        }

        public double calculate_surface()
        {
            double semiperimeter = (sideA + sideB + sideC) / 2;

            double surface = Math.Sqrt(semiperimeter * (semiperimeter - sideA) * (semiperimeter - sideB) * (semiperimeter - sideC));

            return surface;
        }

         public double get_height()
         {
            double h = 0;
            if (sideA == sideB ^ sideA == sideC ^ sideB == sideC)
            {
                h = (sideA * Math.Sqrt(3)) / 2;

                return h;
            }
            else if((sideA != sideB) ^ (sideA != sideC) ^ (sideB != sideC))
            {
                h = (2 / sideA) * calculate_surface();
                return h;
            }
            else             {
                return h = Math.Sqrt(SideA * sideB - Math.Pow((sideC / 2), 2));
            }

         }
             public override string ToString()
             {
                return "Triangulo nº: " + id + 
                      " Lados: " + sideA+ "cm," + sideB+ "cm," + sideC + " cm" +
                      " Altura: " + get_height()+
                      " Superfice: " + calculate_surface() +
                      " Perimétro: " + calculate_perimeter();

            }

    }
}

