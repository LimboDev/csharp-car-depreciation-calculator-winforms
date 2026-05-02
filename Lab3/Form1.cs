using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btInfo.Enabled = false;
        }

        private void btInfo_Click(object sender, EventArgs e)
        {
            string marca, modelo;
            double año, costo;
            marca = tbMarca.Text;
            modelo = tbModelo.Text;
            año = Convert.ToDouble(tbAño.Text);
            costo = Convert.ToDouble(tbCosto.Text);

            if (año > 2026)
            {
                lbError.Text = "Ingrese un año válido (2026 o anterior)";
            }
            else if (año < 1930)
            {
                lbError.Text = "Ingrese un año válido (1930 en adelante)";
            }
            else
            {
                lbError.Text = "";
                Vehiculo vehiculo = new Vehiculo(marca, modelo, año, costo);
                Información información = new Información(vehiculo);
                información.Show();
            }
         }


        // Verificar que los campos esten llenos 
        private void VerificarCampos()
        {
            if (tbMarca.Text != "" && tbModelo.Text != "" && tbAño.Text != "" && tbCosto.Text != "")
            {
                btInfo.Enabled = true;
            }
            else
            {
                btInfo.Enabled = false;
            }

        }

        private void tbMarca_TextChanged(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void tbModelo_TextChanged(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void tbAño_TextChanged(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void tbCosto_TextChanged(object sender, EventArgs e)
        {
            VerificarCampos();
        }
    }
}
