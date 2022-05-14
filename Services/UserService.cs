using System;
using System.Collections.Generic;
using System.Linq;
using AssetManager.Data;
using AssetManager.Interfaces;
using AssetManager.Models;
using Microsoft.EntityFrameworkCore;

namespace AssetManager.Services
{
    public class UserService : IUserRepository
    {
        private readonly AssetsDbContext _context;

        public UserService(AssetsDbContext context)
        {
            _context = context;
        }
        
        public void CreateUser(User newUser)
        {
            if (newUser == null)
                throw new ArgumentNullException(nameof(newUser));

            newUser.UserId = Guid.NewGuid();
            
            _context.Users.Add(newUser);
            _context.SaveChanges();
        }

        public bool DeleteUser(int id)
        {
            var userToDelete = _context.Users.FirstOrDefault(p => p.Id == id);
            if (userToDelete != null) 
            {
                _context.Users.Remove(userToDelete);
                _context.SaveChanges();
            }
            else
                return false;

            return true;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users;
        }

        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(p => p.Id == id);
        }

        public bool ReplaceUserById(int id, User replacementUser)
        {
            _context.Entry(replacementUser).State = EntityState.Modified;

            try 
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_context.Users.FirstOrDefault(p => p.Id == id) == null)
                    return false;
                else
                    throw;                
            }

            return true;
        }

        public void UpdateUserbyId(int id, User asset)
        {
            throw new System.NotImplementedException();
        }
    }
}