using BuyRealEstate.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuyRealEstate.Core.Interfaces
{
    public interface ICustomerRepository
    {
        Task<Customer> GetByIdAsync(int id);
        Task<IEnumerable<Customer>> GetAllAsync();
        Task AddAsync(Customer customer);
        Task UpdateAsync(Customer customer);
        Task DeleteAsync(int id);
        Task<Customer> GetByUsernameAsync(string username);
    }
}

