using figuraGeometricas.Interface;
using figuraGeometricas.Model;
using Microsoft.VisualBasic.Logging;
using Microsoft.VisualBasic;
using System.Drawing;

namespace figuraGeometricas
{
    public partial class Form1 : Form
    {
        List<Ifigure> figures = new List<Ifigure>();

        public Form1()
        {
            InitializeComponent();

            txtSide.Visible = false;
            txtSide2.Visible = false;
            txtSide3.Visible = false;
            lblSide.Text = "Ingrese los datos";
            lblSide2.Visible = false;
            lblSide3.Visible = false;
            btnCreateFigure.Visible = false;
            btnNew.Visible = false;
        }

        void add_figure(Ifigure figure)
        {
            figures.Add(figure);
        }

        #region figure combo box

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear_all_fields();

        }
        private void cmbFigure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFigure.Text == "Circulo")
            {
                btnCreateFigure.Visible = true;
                lblSide.Text = "Radio";
                txtSide.Visible = true;
                txtSide2.Visible = false;
                txtSide3.Visible = false;
                lblSide2.Visible = false;
                lblSide3.Visible = false;
                btnNew.Visible = true;
            }
            if (cmbFigure.Text == "Triangulo")
            {
                btnCreateFigure.Visible = true;
                txtSide.Visible = true;
                txtSide2.Visible = true;
                txtSide3.Visible = true;
                lblSide.Text = "Lado 1";
                lblSide2.Visible = true;
                lblSide3.Visible = true;
                btnNew.Visible = true;
            }
            if (cmbFigure.Text == "Cuadrado")
            {
                btnCreateFigure.Visible = true;
                btnNew.Visible = true;
                txtSide.Visible = true;
                txtSide2.Visible = false;
                txtSide3.Visible = false;
                lblSide.Text = "Lado";
                lblSide2.Visible = false;
                lblSide3.Visible = false;
            }
        }

        #endregion

        #region show perimeter and figure

        private void Show_perimeter_and_surface(Ifigure figure)
        {
            lblPerimeter.Text = "Perimetro: " + (figure.calculate_perimeter()) + " cm";
            lblSurface.Text = "Superficie: " + (figure.calculate_surface()) + " cm";
            //lblCreateFigure.Text = figure.getDate();
        }
        #endregion

        #region Create Figure

        private void btnCreateFigure_Click_1(object sender, EventArgs e)
        {
            if (cmbFigure.Text == "Triangulo")
            {
                Ifigure triangle = create_triangle();
                add_figure(triangle);
                lblCreateFigure.Text = "El Triangulo fue creado correctamente.";
                Show_perimeter_and_surface(triangle);
                //showList();

            }

            if (cmbFigure.Text == "Circulo")
            {
                Ifigure circle = create_circle();
                add_figure(circle);
                lblCreateFigure.Text = "El circulo fue creado correctamente.";
                Show_perimeter_and_surface(circle);
                showList();

            }

            if (cmbFigure.Text == "Cuadrado")
            {
                Ifigure square = create_square();
                add_figure(square);
                lblCreateFigure.Text = "El cuadrado fue creado correctamente.";
                Show_perimeter_and_surface(square);
                //showList();
            }
        }
        #endregion

        #region method create
        private Triangle create_triangle()
        {
            double ladoA, ladoB, ladoC;

            if (double.TryParse(txtSide.Text, out ladoA) &&
                double.TryParse(txtSide2.Text, out ladoB) &&
                double.TryParse(txtSide3.Text, out ladoC))
            {
                if (valid_triangle(ladoA, ladoB, ladoC))

                {

                    return new Triangle(ladoA, ladoB, ladoC);
                }
                else
                {
                    MessageBox.Show("Las longitudes de los lados no forman un triángulo válido.");

                    return null;
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos para los lados del triángulo.");
                return null;
            }
        }


        private Circle create_circle()
        {
            return new Circle(Convert.ToDouble(txtSide.Text));
        }
        private Square create_square()
        {
            return new Square(Convert.ToDouble(txtSide.Text));
        }


        #endregion

        #region clear all fields
        private void Clear_all_fields()
        {
            lblSide.Text = "Ingrese los datos";
            txtSide.Visible = false;
            txtSide.Text = " ";
            txtSide2.Visible = false;
            txtSide2.Text = " ";
            txtSide3.Visible = false;
            txtSide3.Text = " ";
            lblSide2.Visible = false;
            lblSide3.Visible = false;
            lblPerimeter.Text = "";
            lblSurface.Text = "";
            lblCreateFigure.Text = "";
            btnCreateFigure.Visible = false;
            btnNew.Visible = false;
            cmbFigure.Text = null;
           
        }

        #endregion


        #region valid triangle
        static bool valid_triangle(double sideA, double sideB, double sideC)
        { // Verificar que la suma de las longitudes de dos lados sea mayor que la longitud del tercer lado
            if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        #endregion

        #region List of figures
        private void showList()
        {
            foreach (var figura in figures)
            {
                listFigure.Items.Add(figura.ToString());
            }
        }

        private void btnListFigure_Click(object sender, EventArgs e)
        {
            showList();
        }

        #endregion
    }
}


