using BuyRealEstate.Domain.Interfaces;
using BuyRealEstate.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuyRealEstate.Domain.Repositories
{
    public class PlotRepository : IPlotRepository
    {
        private readonly AppDbContext _context;

        public PlotRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Plot>> GetAllPlotsAsync()
        {
            return await _context.Plots.Include(p => p.Project).ToListAsync();
        }

        public async Task<Plot> GetPlotByIdAsync(int id)
        {
            return await _context.Plots.Include(p => p.Project).FirstOrDefaultAsync(p => p.ID == id);
        }

        public async Task AddPlotAsync(Plot plot)
        {
            await _context.Plots.AddAsync(plot);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePlotAsync(Plot plot)
        {
            _context.Plots.Update(plot);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePlotAsync(int id)
        {
            var plot = await _context.Plots.FindAsync(id);
            if (plot != null)
            {
                _context.Plots.Remove(plot);
                await _context.SaveChangesAsync();
            }
        }
    }
}
