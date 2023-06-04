using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Impl
{
    public class UserRepositoryImpl : IUserRepository
    {

        private readonly studentDBContext _dbContext ;

        public UserRepositoryImpl()
        {
            _dbContext = studentDBContext.Instance;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            return _dbContext.Users.ToArray();
        }

        public User GetById()
        {
            throw new NotImplementedException();
        }

        public void Insert(User input)
        {
            throw new NotImplementedException();
        }

        public void Update(User input)
        {
            throw new NotImplementedException();
        }
        public bool ExistsByUsername(string username) => _dbContext.Users.Any(u => u.Username.ToLower() == username.ToLower());


        public User FindByUsername(string username) => _dbContext.Users.SingleOrDefault(u => u.Username.ToLower() == username.ToLower());

        public User FindById(int id) => _dbContext.Users.SingleOrDefault(u => u.Id == id);

    }
}
