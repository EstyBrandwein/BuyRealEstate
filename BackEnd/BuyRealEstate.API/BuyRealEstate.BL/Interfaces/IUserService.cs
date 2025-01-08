using System.Threading.Tasks;
using BuyRealEstate.Core.DTos;
using BuyRealEstate.Domain.Models;

namespace BuyRealEstate.Core.Interfaces
{
    public interface IUserService
    {
        Task<UsersDTO> GetByIdAsync(int id);
        Task<IEnumerable<UsersDTO>> GetAllAsync();
        Task AddAsync(UsersDTO userDto);
        Task UpdateAsync(UsersDTO userDto);
        Task DeleteAsync(int id);
        Task<User> LoginAsync(string username, string password);
    }
}



