using parcial.Entidades;
using parcial.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();
            ClsUsuario clsUsuario = new ClsUsuario();

            Console.WriteLine("Escriba el nombre para iniciar sesión"); //Miguel es el nombre de acceso
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Escriba la contraseña");
            usuario.Contra = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(clsUsuario.acceso(usuario.Nombre, usuario.Contra));
            Console.ReadLine();

            if (clsUsuario.verificar == 1)
            {
                int con = 1;

                while (con == 1)
                {
                    Console.WriteLine("Escriba el id del producto");
                    int identificador_producto = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Escriba el nombre del producto");
                    string nombre_producto = Console.ReadLine();

                    Console.WriteLine("Escriba la descripcion del producto");
                    string descripción = Console.ReadLine();

                    Console.WriteLine("Escriba el precioa del producto");
                    double precio = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Escriba cantidad del producto");
                    int cantidad = Convert.ToInt32(Console.ReadLine());

                    ClsVenta clsventa = new ClsVenta();
                    Venta venta = new Venta();
                    Venta s = new Venta(identificador_producto, nombre_producto, descripción, precio, cantidad);
                    Console.WriteLine(clsventa.cobrar(s));

                    Console.WriteLine("Escriba 2 si desea cerrar el programa y 1 si no");
                    con = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(usuario.ToString());
                    Console.WriteLine(venta.ToString());
                    Console.ReadLine();


                }
            }

            else
                Console.WriteLine("Vuelva pronto");
            Console.ReadLine();
        }
    }
}
