using System.Threading.Tasks;
using BuyRealEstate.Core.DTos;
using BuyRealEstate.Domain.Models;
namespace BuyRealEstate.Core.Interfaces
{
    public interface IUserService
    {
        Task<UserDto> GetByIdAsync(int id);
        Task<IEnumerable<UserDto>> GetAllAsync();
        Task AddAsync(UserDto userDto);
        Task UpdateAsync(UserDto userDto);
        Task DeleteAsync(int id);
        Task<User> LoginAsync(string username, string password);
    }
}