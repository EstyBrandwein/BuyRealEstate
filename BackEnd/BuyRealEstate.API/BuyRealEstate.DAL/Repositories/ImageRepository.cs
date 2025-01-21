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
    public class ImageRepository : IImageRepository
    {
        private readonly AppDbContext _context;
        public ImageRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Image> GetByIdAsync(int id)
        {
            return await _context.Images.FindAsync(id);
        }
        public async Task<IEnumerable<Image>> GetByProjectIdAsync(int projectId)
        {
            return await _context.Images
                .Where(img => img.ProjectID == projectId)
                .ToListAsync();
        }
        public async Task AddAsync(Image image)
        {
            await _context.Images.AddAsync(image);
        }
        public async Task DeleteAsync(int id)
        {
            var image = await _context.Images.FindAsync(id);
            if (image != null)
            {
                _context.Images.Remove(image);
            }
        }
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}