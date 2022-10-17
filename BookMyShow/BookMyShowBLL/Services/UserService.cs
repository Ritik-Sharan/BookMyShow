using BookMyShowDAL.Repository;
using BookMyShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShowBLL.Services
{
    public class UserService
    {
        IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        //add location
        public void AddUser(Users users)
        {
            _userRepository.addUser(users);
        }
        //update location
        public void UpdateUser(Users users)
        {
            _userRepository.updateUser(users);
        }
        //delete location
        public void DeleteUser(int userId)
        {
            _userRepository.deleteUser(userId);
        }
        //getlocationbyid location
        public Users GetUsernById(int userId)
        {
            return _userRepository.getUserById(userId);
        }
        //get locations
        public IEnumerable<Users> GetUsers()
        {
            return _userRepository.GetUsers();
        }
    }
}
