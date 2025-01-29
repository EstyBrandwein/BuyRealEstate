using System.Threading.Tasks;
using BuyRealEstate.Core.DTos;
using BuyRealEstate.Domain.Models;

namespace BuyRealEstate.Core.Interfaces
{
    public interface IUserService
    {
        Task<UsersDTO> GetAsync(int id);
        Task<UsersDTO> GetUserAsync(string userName);
        Task<IEnumerable<UsersDTO>> GetAllAsync();
        Task AddAsync(UsersDTO userDto);
        Task UpdateAsync(int id, UsersDTO userDto);
        Task DeleteAsync(int id);
        Task<bool> LoginAsync(string username, string password);
    }
}



