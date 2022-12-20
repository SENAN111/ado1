using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adonet.Abstraction
{
    internal interface IService<T>
    {
        void Add(T model);
        void Delete(int id);
        List<T> GetAll();
    }
}
