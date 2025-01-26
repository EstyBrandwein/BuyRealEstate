using BuyRealEstate.Domain.Interfaces;
using BuyRealEstate.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Domain.Repositories
{
    public class GuaranteesRepository : IGuaranteesRepository
    {
        private readonly AppDbContext _context;

        public GuaranteesRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Guarantees>> GetAllGuaranteessAsync()
        {
            return await _context.Guarantees.ToListAsync();
        }
        public async Task<IEnumerable<Guarantees>> GetAllGuaranteessByIdAsync(int id)
        {
            return await _context.Guarantees.Where(c=>c.Id == id).ToListAsync();
        }
        public async Task AddGuaranteesAsync(Guarantees guarantees)
        {
            await _context.Guarantees.AddAsync(guarantees);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteGuaranteesAsync(int id)
        {
            var guarantees = await _context.Guarantees.FindAsync(id);
            if (guarantees != null)
            {
                _context.Guarantees.Remove(guarantees);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Guarantees> GetGuaranteestByIdAsync(int id)
        {
            return await _context.Guarantees.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task UpdateGuaranteesAsync(Guarantees guarantees)
        {
            _context.Guarantees.Update(guarantees);
            _context.SaveChanges();
        }
    }
}

