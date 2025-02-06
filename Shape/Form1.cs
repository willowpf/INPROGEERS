using System;
using System.Windows.Forms;

namespace Shape
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = pictureBox2.Visible = pictureBox3.Visible = pictureBox4.Visible = false;
            groupBoxCircle.Visible = groupBoxTriangle.Visible = groupBoxSquare.Visible = groupBoxRectangle.Visible = false;
        }

        private void radioButtonCircle_CheckedChanged(object sender, EventArgs e)
        {
            ToggleShapeVisibility(pictureBox1, groupBoxCircle);
        }

        private void radioButtonTriangle_CheckedChanged(object sender, EventArgs e)
        {
            ToggleShapeVisibility(pictureBox2, groupBoxTriangle);
        }

        private void radioButtonSquare_CheckedChanged(object sender, EventArgs e)
        {
            ToggleShapeVisibility(pictureBox3, groupBoxSquare);
        }

        private void radioButtonRectangle_CheckedChanged(object sender, EventArgs e)
        {
            ToggleShapeVisibility(pictureBox4, groupBoxRectangle);
        }

        private void ToggleShapeVisibility(PictureBox pictureBox, GroupBox groupBox)
        {
            pictureBox1.Visible = pictureBox2.Visible = pictureBox3.Visible = pictureBox4.Visible = false;
            groupBoxCircle.Visible = groupBoxTriangle.Visible = groupBoxSquare.Visible = groupBoxRectangle.Visible = false;

            pictureBox.Visible = true;
            groupBox.Visible = true;
        }

        private void buttonComputeCircle_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(textBoxRadius.Text);
            DisplayResults("Circle", "Red", 0, Math.PI * radius * radius, 2 * Math.PI * radius);
        }

        private void buttonComputeTriangle_Click(object sender, EventArgs e)
        {
            double baseLength = double.Parse(textBoxBase.Text);
            double height = double.Parse(textBoxHeight.Text);
            double side = Math.Sqrt(Math.Pow(baseLength / 2, 2) + Math.Pow(height, 2));
            DisplayResults("Triangle", "Green", 3, 0.5 * baseLength * height, baseLength + 2 * side);
        }

        private void buttonComputeSquare_Click(object sender, EventArgs e)
        {
            double side = double.Parse(textBoxSide.Text);
            DisplayResults("Square", "Blue", 4, side * side, 4 * side);
        }

        private void buttonComputeRectangle_Click(object sender, EventArgs e)
        {
            double length = double.Parse(textBoxLength.Text);
            double width = double.Parse(textBoxWidth.Text);
            DisplayResults("Rectangle", "Yellow", 4, length * width, 2 * (length + width));
        }

        private void DisplayResults(string shapeName, string color, int sides, double area, double perimeter)
        {
            labelName.Text = "Name: " + shapeName;
            labelColor.Text = "Color: " + color;
            labelSides.Text = "No. of Sides: " + sides;
            labelArea.Text = "Area: " + area.ToString("0.##");
            labelPerimeter.Text = "Perimeter: " + perimeter.ToString("0.##");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
