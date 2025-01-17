﻿using BuyRealEstate.Core.Interfaces;
using BuyRealEstate.Domain.Models;
using BuyRealEstate.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace BuyRealEstate.Domain.Repositories

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
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
        return await _context.Users
                             .FirstOrDefaultAsync(u => u.Username == username);
    }

    // שיטה חדשה לעדכון קוד האימות וסטטוס האימות
    public async Task UpdateVerificationCodeAsync(int userId, string verificationCode, bool isVerified)
    {
        var user = await _context.Users.FindAsync(userId);
        if (user != null)
        {
            user.VerificationCode = verificationCode;
            user.VerificationCodeExpiry = DateTime.UtcNow.AddMinutes(10); // עדכון תוקף
            user.IsVerified = isVerified;
            await _context.SaveChangesAsync();
        }
    }

}
