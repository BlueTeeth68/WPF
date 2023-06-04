using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IClassMemberRepository:IBaseRepository<ClassMember, String>
    {
        List<ClassMember> FindByRole(String role);

        List<ClassMember> FindByRoleAndName(String role, String name);

        bool ExistById(String id);
    }
}
