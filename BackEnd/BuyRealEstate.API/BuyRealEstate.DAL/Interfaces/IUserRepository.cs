using BuyRealEstate.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuyRealEstate.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(int id);
        Task<IEnumerable<User>> GetAllAsync();
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(int id);
        Task<User> GetByUsernameAsync(string username);
    }
}

