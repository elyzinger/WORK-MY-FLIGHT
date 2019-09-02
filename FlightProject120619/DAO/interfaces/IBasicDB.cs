using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightProject120619
{
    public interface IBasicDB<T> where T : IPoco
    {
         
        long ADD(T t);
        T Get(long id);
        IList<T> GetAll();
        void Remove(T t);
        void Update(T t);
    }
}
