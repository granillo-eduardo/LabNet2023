using Lab.Demo.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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

        public void Delete(int a,string id_s)
        {
            MostraValor(id_s, "\n Se eliminó el registro : \n");

            var custommerEliminar = context.Customers.FirstOrDefault(c => c.CustomerID == id_s);
            context.Customers.Remove(custommerEliminar);
                
            context.SaveChanges();
        }

        public void Update(Customers entidad)
        {
            var custommerUpdate = context.Customers.Find(entidad.CustomerID);

            custommerUpdate.CompanyName= entidad.CompanyName;
            custommerUpdate.ContactName= entidad.ContactName;
            custommerUpdate.City= entidad.City; 
            custommerUpdate.Country= entidad.Country;
            custommerUpdate.Phone= entidad.Phone;

            context.SaveChanges();
        }

        public void Menu(string decision)
        {
            string id_s;

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

                        id_s = Console.ReadLine();
                        MostraValor(id_s, "");
                        ModificarValores(id_s);
                        MostraValor(id_s, "\n Modifico el registro: ");
                        decision = "5";

                        break;

                    case "4"://                  ELIMINAR

                        Console.WriteLine("\n           ELIMINAR ");
                        Console.Write("\n Indique el Id del cliente que desea ELIMINAR: ");
                        //ValidarId(); ENTERO/NO NULL/NO LETRAS/NO MAYOR/ QUE EXISTA EN LA DB

                        id_s = Console.ReadLine();

                        Delete(0,id_s);
                        decision = "5";

                        break;

                    case "5": //                   SALIR

                        Console.WriteLine("\n   Presione una tecla para continuar... ");
                        Console.ReadKey();
                        //Console.Clear();
                        Console.Write($"\n\n            CLIENTES  \n\n     [1] MOSTRAR VALORES  \n     [2] INGRESAR   \n     [3] MODIFICAR  \n     [4] ELIMINAR     \n\n     [0] SALIR\n\n");
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

        string identificador; string nombre; string nombreContacto;string city; string country; string cadena; string telefono;

        Customers customers1 = new Customers(); 

        private void ModificarValores(string id_s)
        {
            Console.WriteLine("\n            MODIFICAR CLIENTE   \n");
            Console.Write($"  Ingrese el nombre de la compañía: "); nombre = Console.ReadLine();
            Console.Write($"  Ingrese el nombre de contacto : "); nombreContacto = Console.ReadLine();
            Console.Write($"  Ingrese la ciudad : "); city = Console.ReadLine();
            Console.Write($"  Ingrese el pais : "); country = Console.ReadLine();
            Console.Write($"  Ingrese el número de telefono : "); telefono = Console.ReadLine();

            customers1.CustomerID = id_s;
            customers1.CompanyName = nombre;
            customers1.ContactName = nombreContacto;
            customers1.City = city;
            customers1.Country = country;   
            customers1.Phone = telefono;

            Update(customers1);
            
        }

        private void MostraValor(string id_s, string mensaje)
        {
            var customerMostrar = new Customers();

            customerMostrar.CustomerID = id_s;
            customerMostrar.CompanyName = context.Customers.FirstOrDefault(context => context.CustomerID == id_s).CompanyName;
            customerMostrar.Phone = context.Customers.FirstOrDefault(context => context.CustomerID == id_s).Phone;
            

            Console.WriteLine(mensaje);
            Console.WriteLine($" Id: {customerMostrar.CustomerID} \n Company: {customerMostrar.CompanyName} \n Phone: {customerMostrar.Phone} \n");// Order: {chippers.Orders}");
        }

        private void CargarValores()
        {
            Console.WriteLine("\n            NUEVO CLIENTE   \n");
            Console.Write($"  Ingrese el identificador: "); identificador = Console.ReadLine();
            Console.Write($"  Ingrese el nombre de la compañía: "); nombre = Console.ReadLine();
            Console.Write($"  Ingrese el nombre de contacto : "); nombreContacto = Console.ReadLine();
            Console.Write($"  Ingrese la ciudad : "); city = Console.ReadLine();
            Console.Write($"  Ingrese el pais : "); country = Console.ReadLine();
            Console.Write($"  Ingrese el número de telefono : "); telefono = Console.ReadLine();

            customers1.CustomerID = identificador;
            customers1.CompanyName = nombre;
            customers1.ContactName = nombreContacto;
            customers1.City = city;
            customers1.Country = country;
            customers1.Phone = telefono;

            Add(customers1);
            MostrarValores();

        }

        private void MostrarValores()
        {
            foreach (var item in GetAll())
            {
                Console.WriteLine($"\n   Id: {item.CustomerID} - Nombre de la compania: {item.CompanyName} - Nombre de concatacto: {item.ContactName} - \n   Ciudad: {item.City} - Pais: {item.Country} - Telefono: {item.Phone}  ");
            }
        }
    }
}
