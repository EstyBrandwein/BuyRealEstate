using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuyRealEstate.Domain.Models;
using Microsoft.EntityFrameworkCore;
using BuyRealEstate.Core.Interfaces;


namespace BuyRealEstate.Domain.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly BuyRealEstateDbContext _context;

        public CustomerRepository(BuyRealEstateDbContext context)
        {
            _context = context;
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task AddAsync(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Customer customer)
        {
            _context.Customers.Update(customer);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var customer = await GetByIdAsync(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Customer> GetByUsernameAsync(string username)
        {
            return await _context.Customers.FirstOrDefaultAsync(c => c.Username == username);
        }
    }
}
