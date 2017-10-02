using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeBodegas
{
    class Program
    {
        Hortaliza[] arregloHortaliza = new Hortaliza[10];
        int contadorp = 0;
        static void Main(string[] args)
        {
            Program p = new Program();
            int opc = -1;
            do
            {
                Console.WriteLine("Control de bodegas");
                Console.WriteLine("1. Alta de hortaliza");
                Console.WriteLine("2. Alta de bodega");
                Console.WriteLine("3. Captura de entrada y salida de hortalizas");
                Console.WriteLine("4. Movimientos por tipo");
                Console.WriteLine("0. Salir");
                Console.WriteLine("Elija una opción: ");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        p.AltaHortaliza();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.ReadKey();
                        break;
                    default:
                        if (opc == 0)
                            Console.WriteLine("Programa terminado");
                        else
                            Console.WriteLine("Opción invalida");
                        break;
                }
            } while (opc != 0);
            Console.ReadKey();
        }
        public void AltaHortaliza()
        {
            Console.WriteLine(" -- ALTA DE HORTALIZA -- ");
            Console.WriteLine("Ingrese la clave del producto: ");
            int clave = Convert.ToInt32(Console.ReadLine());
            while (clave < 0 || clave.Equals(""))
            {
                Console.WriteLine("Ingrese una clave valida");
                clave = Convert.ToInt32(Console.ReadLine());
            }
            if (BuscaClave(clave) == true)
            {
                Console.WriteLine("Clave: {0} ya existe.");
                clave = Convert.ToInt32(Console.ReadLine());
            }else
            {
                Console.WriteLine("Ingrese el nombre del producto: ");
                string producto = Console.ReadLine();
                while(producto.Equals(""))
                {
                    Console.WriteLine("Ingrese un producto valido");
                }
                Console.WriteLine("Descripción del {0}: ", producto);
                string descripcion = Console.ReadLine();
                while(descripcion.Equals(""))
                {
                    Console.WriteLine("Ingrese el dato correspondiente");
                    descripcion = Console.ReadLine();
                }
                Hortaliza hort = new Hortaliza(clave, producto, descripcion);
                arregloHortaliza[contadorp] = hort;
                Console.WriteLine("El producto {0} ah sido agregado con exito.", producto);
                contadorp++;
            }
        }
        public bool BuscaClave(int clv)
        {
            bool encontro = false;
            for(int i=0;i<contadorp;i++)
            {
                if(arregloHortaliza[i].pClave==clv)
                {
                    encontro = true;
                }
            }
            return encontro;
        }
    }
}
