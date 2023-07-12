using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeterminarBilletesMonedas
{
    public class Denominaciones
    {
        List<double> denominaciones = new List<double>();

        public List<double> buscarDenominaciones(double cantidad, double[] arregloBuscar, out double restoCantidad)
        {
            for (int i = arregloBuscar.Length - 1; i >= 0; i--)
            {
                while(cantidad >= arregloBuscar[i])
                {
                    cantidad -= arregloBuscar[i];
                    denominaciones.Add(arregloBuscar[i]);
                }
            }
            restoCantidad = cantidad;
            return denominaciones;
        }
    }
}
