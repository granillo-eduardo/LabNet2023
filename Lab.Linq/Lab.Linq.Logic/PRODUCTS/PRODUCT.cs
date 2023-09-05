using Lab.Linq.Data;
using Lab.Linq.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Lab.Linq.UI;

namespace Lab.Linq.UI
{
    public class PRODUCT:BaseLogic
    {
        public void Ejercicio_2()
        {   
            var products=context.Products;

            var query=products.Where(p=>p.UnitsInStock == 0);

            Console.WriteLine("\n\n              PRODUCTOS SIN STOCK");

            foreach (var item in query)
            {   
                Console.WriteLine($"\n      {item.ProductName} - {item.UnitPrice}");
            }

        }

        public void Ejercicio_3() 
        {
            var products = context.Products;
            var query = products.Where(p => p.UnitsInStock > 0).Where(p => p.UnitPrice > 3);
            
            Console.WriteLine("\n\n              PRODUCTOS CON STOCK Y PRECIO MAYOR A $3 ");

            foreach (var item in query)
            {
                Console.WriteLine($"      {item.ProductName} - STOCK: {item.UnitsInStock} - PRECIO X UND: ${item.UnitPrice}");
            }
        }

        public void Ejercicio_5()
        {
            int valor = 789;

            var products = context.Products;
            var query = products.FirstOrDefault(p => p.ProductID == valor);

            if (query != null)
            {
                Console.Write($"\n                             El producto con Id = {valor} : {query.ProductName} \n");
            }
            else
            {
                Console.WriteLine("\n                                                  Producto Inexistente ");    
            }
        }
    }
}
