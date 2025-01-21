using BuyRealEstate.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Domain.Interfaces
{
    public interface IImageRepository
    {
        Task<Image> GetByIdAsync(int id);
        Task<IEnumerable<Image>> GetByProjectIdAsync(int projectId);
        Task AddAsync(Image image);
        Task DeleteAsync(int id);
        Task SaveChangesAsync();
    }
}
