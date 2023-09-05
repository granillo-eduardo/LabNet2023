using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Linq.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = "";

            CUSTOMER customer = new CUSTOMER();
            PRODUCT product = new PRODUCT();
            //Ejercicio3 ejercicio3 = new Ejercicio3();

            Console.Write("\n                                                         MENU  \n\n" +
                          "                                                    [1] EJERCICIO 1 \n" +
                          "                                                    [2] EJERCICIO 2 \n" +
                          "                                                    [3] EJERCICIO 3 \n" +
                          "                                                    [4] EJERCICIO 4 \n" +
                          "                                                    [5] EJERCICIO 5\n" +
                          "                                                    [6] EJERCICIO 6\n" +
                          "                                                    [7] EJERCICIO 7\n" +
                          "                                                    [8] EJERCICIO 8\n" +
                          "                                                    [9] EJERCICIO 9\n" +
                          "                                                    [10] EJERCICIO 10\n" +
                          "                                                    [11] EJERCICIO 11\n" +
                          "                                                    [12] EJERCICIO 12\n" +
                          "                                                    [13] EJERCICIO 13\n" +
                          "                                                    [0]SALIR\n\n" +
                          "                                   Indique la opcion deseada y precione 'Enter': ");
            menu = Console.ReadLine();

            while (menu!="0") 
            {
                switch (menu)
                {
                    case "1":
                            customer.Ejercicio_1();
                            menu = "14";
                        break;
                    case "2":
                            product.Ejercicio_2(); 
                            menu = "14";
                        break;
                    case "3":
                        product.Ejercicio_3();
                        menu = "14";
                        break;
                        
                    case "4":
                        customer.Ejercicio_4();
                        menu = "14";

                        break;
                    case "5":
                        product.Ejercicio_5();
                        menu = "14";
                        break;
                    case "6":
                        customer.Ejercicio_6();
                        menu = "14";
                        break;
                    case "7":
                        customer.Ejercicio_7();
                        menu = "14";
                        break;
                    case "8":
                        menu = "14";
                        break;
                    case "9":
                        menu = "14";
                        break;
                    case "10":
                        menu = "14";
                        break;
                    case "11":
                        menu = "14";
                        break;
                    case "12":
                        menu = "14";
                        break;
                    case "13":
                        menu = "14";
                        break;
                    case "14":
                        
                        Console.WriteLine("\n                          mostrrar el menu y colocarle un case para este mssg");
                        menu = Console.ReadLine();
                        Console.ReadKey();
                        break;
                    default:
                        

                        Console.Write("                                    Indique el ejercicio valido y presione 'Enter':  ");
                        menu = Console.ReadLine(); ;

                        break;
                }
                Console.WriteLine("\n\n\n\n                                        Presione un tecla para finalizar");
                Console.ReadKey();
            }
        }
    }
}
