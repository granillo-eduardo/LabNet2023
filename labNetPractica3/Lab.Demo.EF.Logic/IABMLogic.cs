using Lab.Demo.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.Logic
{
    interface IABMLogic<T>
    {
        List<T> GetAll();
        void Add(T entidad);        
        void Delete(int id);
        void Update(T entidad);
        void Menu(string decision);
        
    }
}
