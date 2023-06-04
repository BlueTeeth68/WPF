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
    public class UserService
    {

        private IUserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepositoryImpl();
        }

        public bool ExistsByUsername(String username) => _userRepository.ExistsByUsername(username);

        public User GetUserByUsername(String username) => _userRepository.FindByUsername(username);

        public (bool result, string message) existsByUsernameAndPassword(string? username, string? password)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                return (false, "Username is empty!");
            }
            if (string.IsNullOrEmpty(password))
            {
                return (false, "Password is empty!");
            }
            if (!ExistsByUsername(username))
            {
                return (false, $"{username} does not exist.");
            }
            else
            {
                User user = GetUserByUsername(username);
                if (user.Password.Equals(password))
                {
                    return (true, "Success");
                }
                else
                {
                    return (false, "Incorrect Password");
                }
            }
        }

    }
}
