using Lab.Demo.EF.Data;
using Lab.Demo.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.Logic
{
    public class InvoicesLogic:BaseLogic, IABMLogic<Invoices>
    {   
        public List<Invoices> GetAll() 
        { 
            return context.Invoices.ToList();   
        }

        public void Add(Invoices invoice) 
        { 
            context.Invoices.Add(invoice); 
            context.SaveChanges();
        }
        
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Invoices entidad)
        {
            throw new NotImplementedException();
        }

        public void Menu(string decision)
        {
            throw new NotImplementedException();
        }
    }
}
