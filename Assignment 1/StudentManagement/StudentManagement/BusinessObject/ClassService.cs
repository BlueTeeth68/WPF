using DataAccess;
using DataAccess.Repository;
using DataAccess.Repository.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class ClassService
    {
        private IClassRepository _classRepository;

        public ClassService()
        {
            this._classRepository = new ClassRepositoryImpl();
        }

        public List<Class> GetAll()
        {


            List<Class> result = (List<Class>)_classRepository.GetAll();
            Console.WriteLine(result.Capacity);
            return result;
        }

        public List<Class> FindByClassName(string className)
        {
            if (className == null)
                return null;
            return _classRepository.FindByNameIgnoreCase(className);
        }

        public (bool status, string message) UpdateClass(Class input)
        {
            bool status = false;
            string message;
            if (input == null)
            {
                status = false;
                message = "input class is null.";
            }
            else if (input.ClassName == null)
            {
                status = false;
                message = "input class name is null.";
            }
            else
            {
                _classRepository.Update(input);
                status = true;
                message = "Ok";
            }
            return (status, message);
        }

        public void DeleteClass(int id)
        {
            _classRepository.Delete(id);
        }

        public bool ExistByClassName(String className)
        {
            if (className == null || _classRepository.ExistByClassName(className))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddNew(Class input)
        {
            _classRepository.Insert(input);
        }
    }
}
