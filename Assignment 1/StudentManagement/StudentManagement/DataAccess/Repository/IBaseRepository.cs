using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IBaseRepository<E, T>
    {
        IEnumerable<E> GetAll();
        E FindById(T id);
        void Insert(E input);
        void Update(E input);
        void Delete(T id);


    }
}
