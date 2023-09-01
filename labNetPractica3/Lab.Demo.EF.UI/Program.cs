using Lab.Demo.EF.Entities;
using Lab.Demo.EF.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            ShippersLogic shippersLogic = new ShippersLogic();
            InvoicesLogic invoicesLogic = new InvoicesLogic();
            CustomersLogic customersLogic = new CustomersLogic();

            string menu = "";
            string decision = "";

            Console.Write("\n            MENU  \n\n     [1] TRANSPORTES \n     [2] CLIENTES \n     [3] FACTURAS \n\n     [0]SALIR\n\n     Indique la opcion deseada y precione 'Enter': ");
            menu = Console.ReadLine();
            

            while (menu != "0")
            {
                switch (menu)
                {
                    case "1":

                        Opciones("TRANSPORTISTAS");
                        decision = Console.ReadLine();
                        shippersLogic.Menu(decision);
                        menu = "4";
                        
                        break;

                    case "2":

                        Opciones("CUSTOMMER");
                        decision = Console.ReadLine();
                        customersLogic.Menu(decision);
                        Console.Write("      Indique una opción y presione 'Enter':  ");
                        menu = Console.ReadLine();

                        break;

                    case "3":
                        
                        Opciones("INVOICES");
                        decision = Console.ReadLine();
                        invoicesLogic.Menu(decision);
                        Console.Write("      Indique una opción y presione 'Enter':  ");
                        menu = Console.ReadLine();

                        break;
                    
                    case "4":

                        Console.Write("\n Precione una tecla para continuar... ");
                        Console.ReadKey();
                        Console.Clear();
                        Console.Write("\n            MENU  \n\n     [1] TRANSPORTES \n     [2] CLIENTES \n     [3] FACTURAS \n\n     [0]SALIR\n\n     Indique la opcion deseada y precione 'Enter': ");
                        menu = Console.ReadLine();
                        break;

                    case "0":
                        Console.WriteLine(" Salir ");
                        menu = Console.ReadLine(); ;
                        break;

                    default:

                        Console.Write("        Indique una opción valida y presione 'Enter':  ");
                        menu = Console.ReadLine(); ;

                        break;
                }

            }
            Console.WriteLine("\n Presione un tecla para finalizar");
            Console.ReadKey();

        }

        private static void Opciones(string opcion)
        {
            Console.Write($"\n\n            {opcion}  \n\n     [1] MOSTRAR VALORES  \n     [2] INGRESAR   \n     [3] MODIFICAR  \n     [4] ELIMINAR  \n\n     [0]SALIR\n\n");
            Console.Write($"\n seleccione una opcion y presione Enter ");
        }
    }
}
