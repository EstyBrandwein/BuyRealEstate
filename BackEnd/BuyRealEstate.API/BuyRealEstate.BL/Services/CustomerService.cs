using System.Collections.Generic;
using System.Threading.Tasks;
using BuyRealEstate.Domain.Models;
using BuyRealEstate.Core.Interfaces;

namespace BuyRealEstate.Core.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _customerRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _customerRepository.GetAllAsync();
        }

        public async Task AddAsync(Customer customer)
        {
            // You can add validation or business rules here
            await _customerRepository.AddAsync(customer);
        }

        public async Task UpdateAsync(Customer customer)
        {
            // You can add validation or business rules here
            await _customerRepository.UpdateAsync(customer);
        }

        public async Task DeleteAsync(int id)
        {
            await _customerRepository.DeleteAsync(id);
        }

        public async Task<Customer> LoginAsync(string username, string password)
        {
            var customer = await _customerRepository.GetByUsernameAsync(username);
            if (customer != null && VerifyPassword(customer, password))
            {
                return customer; // Return customer if login is successful
            }
            return null; // Or throw an exception, or return an error object
        }

        private bool VerifyPassword(Customer customer, string password)
        {
            // Implement password verification logic
            return customer.Password == password; // Simplified for example
        }
    }
}
