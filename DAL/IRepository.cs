using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication9.Models;

namespace WebApplication9.DAL
{
    public interface IRepository<T>:IDisposable where T:class 
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        T Create(T item);
        bool Update(T item);
        void Delete(int id);
    }
}
