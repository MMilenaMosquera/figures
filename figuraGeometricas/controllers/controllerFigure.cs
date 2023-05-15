using figuraGeometricas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figureGeometric.controllers
{
    internal class FigureController
    {

        public FigureController() { }


        public Triangle createTriangle(double sideA, double sideB, double sideC)
        {
            
            if (validarTriangulo(sideA, sideB, sideC))
            {

                Triangle triangle = new Triangle(sideA, sideB, sideC);
            }
            

            return null;
        }


        private bool validarTriangulo(double sideA, double sideB, double sideC)
        {
            if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos para los lados del triángulo.");
                return false;
            }
        }

        public Circle createCircle(double radius)
        {
            return new Circle(radius);
        }

        public Square createSquare(double side)
        {
            return new Square(side);
        }



    }
}
