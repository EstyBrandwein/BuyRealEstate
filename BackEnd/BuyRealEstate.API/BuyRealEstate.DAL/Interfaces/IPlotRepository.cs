using BuyRealEstate.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuyRealEstate.Domain.Interfaces
{
    public interface IPlotRepository
    {
        Task<IEnumerable<Plot>> GetAllPlotsAsync();
        Task<IEnumerable<Plot>> GetAllPlotsByIdAsync(int id);
        Task<Plot> GetPlotByIdAsync(int id);
        Task AddPlotAsync(Plot plot);
        Task UpdatePlotAsync(Plot plot);
        Task DeletePlotAsync(int id);
    }
}
