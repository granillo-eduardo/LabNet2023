using Lab.Demo.EF.Data;
using Lab.Demo.EF.Logic;
using Lab.Demo.EF.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static Lab.Demo.EF.Logic.Validaciones;
using System.Windows.Forms;

namespace Lab.Demo.EF.Logic
{
    public class ShippersLogic: BaseLogic, IABMLogic<Shippers>
    {        
        public List<Shippers> GetAll() 
        {
            return context.Shippers.ToList();   
        }

        public void Add(Shippers shippers)
        {
            context.Shippers.Add(shippers);
            context.SaveChanges();  
        }

        string nombre; string prefijo; string cadena; int telefono;
        
        Shippers shippers = new Shippers();

        public void CargarValores()
        {
            Console.WriteLine("\n           NUEVO TRANSPORTISTA   \n");

            Console.Write($"  Ingrese el nombre de la compañía: "); nombre = Console.ReadLine();
            Console.Write($"  Ingrese el prefijo del telefono : "); prefijo = Console.ReadLine();
            Console.Write($"  Ingrese el número de telefono : "); telefono = int.Parse(Console.ReadLine());

            #region edicion_numero

            int largonumero = (int)Math.Floor(Math.Log10(telefono) + 1);

            string numero = Convert.ToString(telefono);
            cadena = "";

            for (int i = 0; i < largonumero; i++)
            {
                if (i == 3)
                {
                    cadena =cadena+ "-"+ numero[i];
                }
                else
                {
                    cadena += numero[i];
                }
            }
            #endregion

            shippers.CompanyName = nombre;
            shippers.Phone = $"({prefijo}) {cadena}";

            Add(shippers);

            MostrarValores();
            
        }
        
        public void ModificarValores(int id)
        {
            Console.WriteLine("\n            MODIFICAR TRANSPORTISTAS   \n");
            Console.Write($"  Ingrese el nombre de la compañía: "); nombre = Console.ReadLine();
            Console.Write($"  Ingrese el prefijo del telefono : "); prefijo = Console.ReadLine();
            Console.Write($"  Ingrese el número de telefono : "); telefono = int.Parse(Console.ReadLine());
            
            #region EDICION_TELEFONO

            int largonumero = (int)Math.Floor(Math.Log10(telefono) + 1);
                       
            string numero = Convert.ToString(telefono);
            cadena = "";

            for (int i = 0; i < largonumero; i++)
            {
                if (i == 3)
                {
                    cadena = cadena + "-" + numero[i];
                }
                else
                {
                    cadena += numero[i];
                }
            }
            #endregion

            shippers.ShipperID = id;
            shippers.CompanyName = nombre;
            shippers.Phone = $"({prefijo}) {cadena}";

            Update(shippers);

        }

        public void Delete(int id,string id_s)
        {
            MostraValor(id, "\n Se eliminó el registro : \n");

            var shippersEliminar = context.Shippers.FirstOrDefault(s => s.ShipperID == id);
            context.Shippers.Remove(shippersEliminar);
            context.SaveChanges();

        }

        public void MostrarValores()
        {
            foreach (var item in GetAll())
            {
                Console.WriteLine($"\n Id: {item.ShipperID} - Nombre de la compania: {item.CompanyName} - Telefono: {item.Phone}");
            }
        }

        public void MostraValor(int id,string mensaje)
        { 
            var shippersMostrar = new Shippers();
            
            //Validar que exista el dato en la db

            shippersMostrar.ShipperID=id;
            shippersMostrar.CompanyName = context.Shippers.FirstOrDefault(context => context.ShipperID == id).CompanyName;
            shippersMostrar.Phone = context.Shippers.FirstOrDefault(context => context.ShipperID == id).Phone;
            shippersMostrar.Orders=context.Shippers.FirstOrDefault(context => context.ShipperID==id).Orders;

            Console.WriteLine(mensaje);
            Console.WriteLine($" Id: {shippersMostrar.ShipperID} \n Company: {shippersMostrar.CompanyName} \n Phone: {shippersMostrar.Phone} \n");// Order: {chippers.Orders}");
            
        }

        public void Update(Shippers entidad)
        {
            var shippersUpdate = context.Shippers.Find(entidad.ShipperID);

            shippersUpdate.CompanyName= entidad.CompanyName;
            shippersUpdate.Phone = entidad.Phone;   
            shippersUpdate.Orders= entidad.Orders;

            context.SaveChanges();              
        }

        public void Menu(string decision)
        {
            int id;
            
            while (decision!="0")
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

                        //Validar();

                        try
                        {
                            id = Convert.ToInt32(Console.ReadLine());
                            var shippersEliminar = context.Shippers.FirstOrDefault(s => s.ShipperID == id);

                            Delete(id, "");
                            decision = "5";

                        }
                        catch (NullReferenceException)
                        {
                            Console.WriteLine(" Intentalo otra vez! pero con un id válido.");
                            Console.ReadLine();
                        }
                        catch (Exception)
                        {

                            Console.WriteLine(" Intentalo otra vez! pero con un id válido.");
                            Console.ReadLine();
                        }

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

    }
}
