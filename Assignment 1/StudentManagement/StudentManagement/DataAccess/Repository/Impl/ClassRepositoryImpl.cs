using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Impl
{
    public class ClassRepositoryImpl : IClassRepository
    {

        private readonly studentDBContext _dbContext;

        public ClassRepositoryImpl()
        {
            _dbContext = studentDBContext.Instance;
        }

        public void Delete(int id)
        {
            var classToDelete = _dbContext.Classes.Include(c => c.Members).FirstOrDefault(c => c.ClassId == id);
            if (classToDelete != null && classToDelete.Members.Count == 0)
            {
                _dbContext.Classes.Remove(classToDelete);
                _dbContext.SaveChanges();
            }
        }

        public bool ExistByClassName(string className)
        {
            return _dbContext.Classes.Any(c => c.ClassName.ToLower() == className.ToLower());
        }

        public Class FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Class> FindByNameIgnoreCase(string name)
        {
            return _dbContext.Classes.Where(c => c.ClassName.ToLower().Contains(name.ToLower().Trim())).ToList();
        }

        public IEnumerable<Class> GetAll() => _dbContext.Classes.ToList();

        public void Insert(Class input)
        {
            _dbContext.Classes.Add(input);
            _dbContext.SaveChanges();
        }

        public void Update(Class input)
        {
            Class classDB = _dbContext.Classes.SingleOrDefault(c => c.ClassId == input.ClassId);
            if (classDB != null)
            {
                classDB.ClassName = input.ClassName;
                _dbContext.SaveChanges();
            }
        }
    }
}
