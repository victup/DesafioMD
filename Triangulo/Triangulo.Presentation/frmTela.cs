using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Triangulo.Presentation;
using Triangulo.Domain;

namespace Triangulo.Presentation
{
    public partial class frmTela : Form
    {
        public frmTela()
        {
            InitializeComponent();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            btnLimpar.Visible = true;
            btnVerificar.Visible = false;

            string resultado = CheckTriangle(txtLado1.Text.ToString(), txtLado2.Text.ToString(), txtLado3.Text.ToString());
            

            lblResultado.Text = resultado;

            lblResultado.Visible = true;

           

        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            btnVerificar.Visible = true;
            btnLimpar.Visible = false;
            LimparForm();
        }

        private string CheckTriangle(string v1, string v2, string v3)
        {

            double x = InputValidator(v1);

            double y = InputValidator(v2);

            double z = InputValidator(v3);

            Domain.Triangulo triangulo = new Domain.Triangulo(x, y, z);

            return triangulo.TriangleType();


        }

        private double InputValidator(string value)
        {
            string input = value.ToString();

            bool validConverter = double.TryParse(value, out double output);


            if (validConverter) return output;
            else return 0;

        }

        private void LimparForm()
        {
            txtLado1.Text = "";
            txtLado2.Text = "";
            txtLado3.Text = "";
            lblResultado.Text = "";
        }

       
    }
}
