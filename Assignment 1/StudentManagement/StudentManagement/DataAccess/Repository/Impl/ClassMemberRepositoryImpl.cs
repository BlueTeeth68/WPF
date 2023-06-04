using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Impl
{
    public class ClassMemberRepositoryImpl : IClassMemberRepository
    {

        private readonly studentDBContext _dbContext;

        public ClassMemberRepositoryImpl()
        {
            _dbContext = studentDBContext.Instance;
        }

        public void Delete(String id)
        {
            var classToDelete = _dbContext.ClassMembers.FirstOrDefault(c => c.MemberId == id);
            if (classToDelete != null )
            {
                _dbContext.ClassMembers.Remove(classToDelete);
                _dbContext.SaveChanges();
            }
        }

        public IEnumerable<ClassMember> GetAll() => _dbContext.ClassMembers.ToList();


        //Is there anyway to modify null id in this code?

        public ClassMember FindById(String id)
        {
            return _dbContext.ClassMembers.SingleOrDefault(c => (c.MemberId.ToLower() == id.ToLower()));
        }

        public void Insert(ClassMember input)
        {
            if (!ExistById(input.MemberId))
            {
                _dbContext.ClassMembers.Add(input);
                _dbContext.SaveChanges();
            }
        }

        public void Update(ClassMember input)
        {

            ClassMember classMember = _dbContext.ClassMembers.SingleOrDefault(c => c.MemberId == input.MemberId);
            if (classMember != null)
            {
                classMember.FirstName = input.FirstName;
                classMember.LastName = input.LastName;
                classMember.Gender = input.Gender;
                _dbContext.SaveChanges();
            }
        }

        public List<ClassMember> FindByRole(String role) => _dbContext.ClassMembers.Where(
            c => (c.Role.ToLower() == role.ToLower()))
            .ToList();

        public List<ClassMember> FindByRoleAndName(String role, String name) => _dbContext.ClassMembers.Where(
        c => (c.Role.ToLower().Equals(role.ToLower())
        && (String.Concat(c.FirstName, " ", c.LastName).ToLower().Contains(name.ToLower()))))
        .ToList();

        public bool ExistById(string id)
        {
            return _dbContext.ClassMembers.Any(c => c.MemberId.ToLower() == id.ToLower());
        }
    }
}
