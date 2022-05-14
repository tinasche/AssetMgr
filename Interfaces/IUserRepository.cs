using System.Collections.Generic;
using AssetManager.Models;

namespace AssetManager.Interfaces
{
    public interface IUserRepository
    {
         
        // GET: Returns all Users
        public IEnumerable<User> GetAllUsers();

        // GET: Returns an User by its id
        public User GetUserById(int id);

        // POST: Create a new User record
        public void CreateUser(User User);
        
        // PUT: Full update of entire User record 
        public bool ReplaceUserById(int id, User User);

        // PATCH: Partial update of User record
        public void UpdateUserbyId(int id, User User);

        // DELETE: Delete a record by its id
        public bool DeleteUser(int id);
    }
}