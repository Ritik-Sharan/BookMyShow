using BookMyShowEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookMyShowDAL.Repository
{
    public class UserRepository : IUserRepository
    {
        BookMyShowDB_Context _bookMyShowDB_Context;
        public UserRepository(BookMyShowDB_Context bookMyShowDB_Context)
        {
            _bookMyShowDB_Context = bookMyShowDB_Context;
        }
        public void addUser(Users users)
        {
            _bookMyShowDB_Context.users.Add(users);
            _bookMyShowDB_Context.SaveChanges();
        }

        public void deleteUser(int userId)
        {
            var user = _bookMyShowDB_Context.users.Find(userId);
            _bookMyShowDB_Context.users.Remove(user);
            _bookMyShowDB_Context.SaveChanges();
        }

        public Users getUserById(int userId)
        {
            return _bookMyShowDB_Context.users.Find(userId);
        }

        public IEnumerable<Users> GetUsers()
        {
            return _bookMyShowDB_Context.users.ToList();
        }

        public void updateUser(Users users)
        {
            _bookMyShowDB_Context.Entry(users).State = EntityState.Modified;
            _bookMyShowDB_Context.SaveChanges();
        }
    }
}
