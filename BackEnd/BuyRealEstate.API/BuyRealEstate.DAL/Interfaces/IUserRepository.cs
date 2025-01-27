using BuyRealEstate.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuyRealEstate.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetAsync(int id); // חיפוש משתמש לפי id    
        Task<IEnumerable<User>> GetAllAsync();
        Task AddAsync(User user);
        Task UpdateAsync(int id, User user);
        Task DeleteAsync(int id);
        Task<User> GetAsync(string username); // חיפוש משתמש לפי שם משתמש בלבד
        Task<bool> VerifyPasswordAsync(string username, string password);


    }
}
