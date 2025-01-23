using BCrypt.Net;
using BuyRealEstate.Domain.Interfaces;
using BuyRealEstate.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BuyRealEstate.Domain.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<User> GetAsync(int id) => await _context.Users.FindAsync(id);

    public async Task<IEnumerable<User>> GetAllAsync() => await _context.Users.ToListAsync();

    public async Task AddAsync(User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
    }

    //פונקציה לאימות הסיסמה
    public async Task<bool> VerifyPasswordAsync(string username, string password)
    {
        var user = await GetAsync(username);
        if (user == null) return false;
        return BCrypt.Net.BCrypt.Verify(password, user.Password); // אימות הסיסמה
    }


    public async Task UpdateAsync(int id, User user)
    {
        var existingUser = await _context.Users.FindAsync(id);
        if (existingUser == null)
        {
            throw new KeyNotFoundException($"User with ID {id} not found.");
        }

        _context.Entry(existingUser).CurrentValues.SetValues(user);

        await _context.SaveChangesAsync();
    }



    public async Task DeleteAsync(int id)
    {
        var user = await GetAsync(id);
        if (user != null)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<User> GetAsync(string username) => await _context.Users.FirstOrDefaultAsync(u => u.Username == username);



}
