using parcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial.Negocio
{
    class ClsUsuario
    {
        string user = "Miguel";
        int password = 123;
        public int verificar;

        public string acceso (string nombre, int contra)
        {
            if (nombre == user && contra == password)
            {
                verificar = 1;

                return "Inicio de sesión correcto puedes continuar con el proceso de venta";

            }

            else
                verificar = 2;
                return "Nombre de usuario incorrecto";
        }
    }
}
