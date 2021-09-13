using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial.Entidades
{
    class Venta
    {
        private int identificador_producto;
        private string nombre_producto;
        private string descripcion;
        private double precio;
        private int cantidad;

        public int Identificador_producto { get => identificador_producto; set => identificador_producto = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public Venta(int identificador_producto, string nombre_producto, string descripcion, double precio, int cantidad)
        {
            this.Identificador_producto = identificador_producto;
            this.Nombre_producto = nombre_producto;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Cantidad = cantidad;
        }

        public Venta()
        {
        }

        public override string ToString()
        {
            return "El id del prducto que usted compró " + Identificador_producto + " el nombre de su producto es: " + Nombre_producto + " " + Descripcion + " el precio unitario de estes es: " + Precio + " va llevar " + Cantidad;
        }
    }
}
