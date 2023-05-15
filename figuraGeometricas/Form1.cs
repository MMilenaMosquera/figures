using figuraGeometricas.Interface;
using figuraGeometricas.Model;
using Microsoft.VisualBasic.Logging;
using Microsoft.VisualBasic;
using System.Drawing;
using System.Security.Policy;
using figureGeometric.controllers;

namespace figuraGeometricas
{
    public partial class Form1 : Form
    {
        List<Ifigure> figures = new List<Ifigure>();
        FigureController controllerFigure = new FigureController();

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
        }
        #endregion

        #region Create Figure

        private void btnCreateFigure_Click_1(object sender, EventArgs e)
        {
            if (cmbFigure.Text == "Triangulo")
            {
                Triangle triangle = controllerFigure.createTriangle(double.Parse(txtSide.Text), double.Parse(txtSide2.Text), double.Parse(txtSide3.Text));
                add_figure(triangle);
                lblCreateFigure.Text = "El Triangulo fue creado correctamente.";
                Show_perimeter_and_surface(triangle);
                showList();

            }

            if (cmbFigure.Text == "Circulo")
            {
                Ifigure circle = controllerFigure.createCircle(double.Parse(txtSide.Text));
                add_figure(circle);
                lblCreateFigure.Text = "El circulo fue creado correctamente.";
                Show_perimeter_and_surface(circle);
                showList();

            }

            if (cmbFigure.Text == "Cuadrado")
            {
                Ifigure square = controllerFigure.createSquare(double.Parse(txtSide.Text));
                add_figure(square);
                lblCreateFigure.Text = "El cuadrado fue creado correctamente.";
                Show_perimeter_and_surface(square);
                showList();
            }
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


