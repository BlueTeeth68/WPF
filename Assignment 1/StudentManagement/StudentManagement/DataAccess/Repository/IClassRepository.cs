using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IClassRepository:IBaseRepository<Class, int>
    {
        List<Class> FindByNameIgnoreCase(string name);
        bool ExistByClassName(String className);
    }
}
