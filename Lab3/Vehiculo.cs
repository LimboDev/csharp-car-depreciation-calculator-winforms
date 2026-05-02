using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Lab3
{
    public partial class Vehiculo
    {
        public string marca, modelo;
        public double año, costo;

        public Vehiculo(string marca, string modelo, double año, double costo)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.año = año;
            this.costo = costo;
        }
        public string getMarca()
        {
            return marca;
        }
        public string getModelo()
        {
            return modelo;
        }
        public double getAño()
        {
            return año;
        }
        public double getCosto()
        {
            return costo;
        }
     }
}

