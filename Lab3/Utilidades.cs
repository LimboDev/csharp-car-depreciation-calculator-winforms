using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Utilidades
    {
        public static double CalcularAntiguedad(double año)
        {
            if (año == 2026)
            {
                return 0;
            }
            else
            {
                return 2026 - año;
            }
        }
        public static double CalcularDepreciacion(double costo, double antiguedad)
        {
            double porcentaje = antiguedad * 0.10;
            double depreciacion = costo - (costo * porcentaje);
            if (antiguedad == 0)
            {
                depreciacion = costo;
            }

            else if (porcentaje > 0.70)
            {
                porcentaje = 0.70;
                depreciacion = costo - (costo * porcentaje);
            }
            return depreciacion;
        }
    }
}
