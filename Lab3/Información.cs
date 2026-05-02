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
    public partial class Información : Form
    {
        public Vehiculo vehiculo;
        public Información(Vehiculo vehiculo)
        {
            InitializeComponent();
            this.vehiculo = vehiculo;
        }
        private void Información_Load(object sender, EventArgs e)
        {
            lbMarca.Text = "Marca: " + vehiculo.getMarca();
            lbModelo.Text = "Modelo: " + vehiculo.getModelo();
            lbAño.Text = "Año: " + vehiculo.getAño();
            lbCosto.Text = "Costo Original: " + vehiculo.getCosto();
            double antiguedad = Utilidades.CalcularAntiguedad(vehiculo.año);
            double costo = vehiculo.getCosto();
            lbPrecioFinal.Text = "$" + Utilidades.CalcularDepreciacion(costo, antiguedad);

        }
    }
}
