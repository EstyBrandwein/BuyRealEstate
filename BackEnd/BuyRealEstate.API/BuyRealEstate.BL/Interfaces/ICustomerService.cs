using System.Threading.Tasks;
using BuyRealEstate.Domain.Models;

namespace BuyRealEstate.Core.Interfaces
{
    public interface ICustomerService
    {
        Task<Customer> GetByIdAsync(int id);
        Task<IEnumerable<Customer>> GetAllAsync();
        Task AddAsync(Customer customer);
        Task UpdateAsync(Customer customer);
        Task DeleteAsync(int id);
        Task<Customer> LoginAsync(string username, string password);
    }
}
  
