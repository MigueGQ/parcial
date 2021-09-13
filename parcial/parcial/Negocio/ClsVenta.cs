using parcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial.Negocio
{
    class ClsVenta
    {
        internal string cobrar(Venta s)
        {
            double monto = s.Precio * s.Cantidad;

            if (monto> 50)
            {
                Console.WriteLine("tiene descuento del 20%");
                double descuento = monto - (monto * 0.20);
                Console.WriteLine(monto + "precio sin descuento " + descuento + " es el precio con descuento");
            }

            else
            {
                Console.WriteLine("No aplica descuento");
            }
            return "";
        }
    }
}
