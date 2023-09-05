using Lab.Linq.Data;
using Lab.Linq.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Lab.Linq.UI;
using System.Data.Entity;
using Lab.Linq.Logic.CUSTOMERS;

namespace Lab.Linq.UI
{
    public class CUSTOMER : BaseLogic
    {
        public void Ejercicio_1()
        {   
            var custumer = context.Customers;
            var quer = custumer.FirstOrDefault();

            Console.WriteLine("\n         CLIENTE ");

            Console.WriteLine($"\n  CustomerId: {quer.CustomerID}\n " +
                $" CompanyName: {quer.CompanyName}\n " +
                $" ContactName: {quer.ContactName}\n " +
                $" ContactTitle: {quer.ContactTitle}\n " +
                $" Address: {quer.Address}\n " +
                $" City: {quer.City}\n " +
                $" Region: {quer.Region}\n " +
                $" PostalCode: {quer.PostalCode}\n " +
                $" Country: {quer.Country}\n " +
                $" Phone: {quer.Phone}\n " +
                $" Fax: {quer.Fax}");
            
        }

        public void Ejercicio_4() 
        {
            var custumer = context.Customers;

            var quer = custumer.Where( x => x.Region=="WA" );

            Console.WriteLine("\n             CLIENTES DE LA REGION 'WA'\n");
            foreach( var x in quer ) 
            {
                Console.WriteLine($" CompanyName: {x.CompanyName} - Region: {x.Region}");
            }
            
        }

        public void Ejercicio_6()
        {
            var custumer = context.Customers;

            var quer = custumer.ToList();

            foreach (var x in quer)
            {
                Console.WriteLine($"\n MAYUSCULAS: {x.CompanyName.ToUpper()} \n minusculas: {x.CompanyName.ToLower()}");
            }

        }

        public void Ejercicio_7()
        {
            var custumer = context.Customers;
            var order = context.Orders;
            
            DateTime fechaOrden = new DateTime(1997, 1, 1);

            List<Customers> l_customer = custumer.Where(x => x.Region == "WA").ToList();
            List<Orders> l_order = order.ToList();

            var result = from l_c in l_customer
                         join l_o in l_order
                         on l_c.CustomerID equals l_o.CustomerID

                         where l_o.OrderDate > fechaOrden
                         select l_o;
                         //select (l_o => new Ejercicio_7_Dto
                         //{
                         //    Nombre = l_o.Nombre,
                         //    Region = l_o.Region,
                         //    Fecha = fechaOrden,
                         //});
 
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Customers.CompanyName} - ");
            }

        }
    }
}