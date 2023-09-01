using Lab.Demo.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.Logic
{
    public class CustomersLogic : BaseLogic, IABMLogic<Customers>
    {
        public List<Customers> GetAll()
        { 
            return context.Customers.ToList();
        }

        public void Add(Customers customers) 
        { 
            context.Customers.Add(customers);   
            context.SaveChanges();  
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customers entidad)
        {
            throw new NotImplementedException();
        }

        public void Menu(string decision)
        {
            int id;

            while (decision != "0")
            {
                switch (decision)
                {
                    case "1": //      MOSTRAR VALORES

                        Console.WriteLine("\n           MOSTRAR");

                        MostrarValores();
                        decision = "5";

                        break;

                    case "2":  //                    ALTA

                        Console.WriteLine("\n           INGRESAR");
                        //mostrae el registro cargado
                        CargarValores();
                        decision = "5";

                        break;

                    case "3": //                  MODIFICAR

                        Console.WriteLine("\n           MODIFICAR");
                        Console.Write("\n Indique el Id que desea MODIFICAR: ");
                        //ValidarId(); ENTERO/NO NULL/NO LETRAS/NO MAYOR/ QUE EXISTA EN LA DB

                        id = Convert.ToInt32(Console.ReadLine());
                        MostraValor(id, "");
                        ModificarValores(id);
                        MostraValor(id, "\n Modifico el registro: ");
                        decision = "5";

                        break;

                    case "4"://                  ELIMINAR

                        Console.WriteLine("\n           ELIMINAR ");
                        Console.Write("\n Indique el Id que desea ELIMINAR: ");
                        //ValidarId(); ENTERO/NO NULL/NO LETRAS/NO MAYOR/ QUE EXISTA EN LA DB

                        id = Convert.ToInt32(Console.ReadLine());

                        Delete(id);
                        decision = "5";

                        break;

                    case "5": //                   SALIR

                        Console.WriteLine("\n   Presione una tecla para continuar... ");
                        Console.ReadKey();
                        //Console.Clear();
                        Console.Write($"\n\n            TRANSPORTISTAS  \n\n     [1] MOSTRAR VALORES  \n     [2] INGRESAR   \n     [3] MODIFICAR  \n     [4] ELIMINAR     \n\n     [0]SALIR\n\n");
                        Console.Write("      Indique una opción y presione 'Enter':  ");
                        decision = Console.ReadLine();

                        break;

                    case "0":

                        Console.WriteLine("\n        SALIR");
                        decision = "0";
                        break;

                    default:
                        Console.Write("\n Ingrese una desicón valida: ");
                        decision = Console.ReadLine();
                        break;
                }
            }

        }

        private void ModificarValores(int id)
        {
            throw new NotImplementedException();
        }

        private void MostraValor(int id, string v)
        {
            throw new NotImplementedException();
        }

        private void CargarValores()
        {
            throw new NotImplementedException();
        }

        private void MostrarValores()
        {
            throw new NotImplementedException();
        }
    }
}
