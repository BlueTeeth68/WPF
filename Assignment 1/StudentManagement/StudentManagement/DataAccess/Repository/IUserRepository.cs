using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IUserRepository:IBaseRepository<User, int>
    {

        User FindByUsername(String username);

        bool ExistsByUsername(String username);
    }
}
