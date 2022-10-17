using BookMyShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShowDAL.Repository
{
    public interface IUserRepository
    {
        void addUser(Users users);
        void updateUser(Users users);
        void deleteUser(int userId);
        Users getUserById(int userId);
        IEnumerable<Users> GetUsers();
    }
}
