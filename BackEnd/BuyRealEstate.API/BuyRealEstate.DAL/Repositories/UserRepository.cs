﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuyRealEstate.Domain.Models;
using Microsoft.EntityFrameworkCore;
using BuyRealEstate.Core.Interfaces;



namespace BuyRealEstate.Domain.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BuyRealEstateDbContext _context;

        public UserRepository(BuyRealEstateDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var user = await GetByIdAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<User> GetByUsernameAsync(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(c => c.Username == username);
        }
    }
}