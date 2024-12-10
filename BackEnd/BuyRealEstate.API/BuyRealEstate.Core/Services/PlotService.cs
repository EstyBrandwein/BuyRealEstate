using BuyRealEstate.Core.DTOs;
using BuyRealEstate.Core.Interfaces;
using BuyRealEstate.Domain.Interfaces;
using BuyRealEstate.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuyRealEstate.Core.Services
{
    public class PlotService : IPlotService
    {
        private readonly IPlotRepository _plotRepository;

        public PlotService(IPlotRepository plotRepository)
        {
            _plotRepository = plotRepository;
        }

        public async Task<IEnumerable<PlotDTO>> GetAllPlotsAsync()
        {
            var plots = await _plotRepository.GetAllPlotsAsync();
            return plots.Select(p => new PlotDTO
            {
                ID = p.ID,
                PlotCost = p.PlotCost,
                MonthlyFundingCost = p.MonthlyFundingCost,
                MonthsForFundingCost = p.MonthsForFundingCost,
                PlotValue = p.PlotValue,
                PlotSize = p.PlotSize,
                PlotNumber = p.PlotNumber,
            });
        }

        public async Task<PlotDTO> GetPlotByIdAsync(int id)
        {
            var plot = await _plotRepository.GetPlotByIdAsync(id);
            if (plot == null) return null;

            return new PlotDTO
            {
                ID = plot.ID,
                PlotCost = plot.PlotCost,
                MonthlyFundingCost = plot.MonthlyFundingCost,
                MonthsForFundingCost = plot.MonthsForFundingCost,
                PlotValue = plot.PlotValue,
                PlotSize = plot.PlotSize,
                PlotNumber = plot.PlotNumber,
            };
        }

        public async Task AddPlotAsync(PlotDTO plotDTO)
        {
            var plot = new Plot
            {
                PlotCost = plotDTO.PlotCost,
                MonthlyFundingCost = plotDTO.MonthlyFundingCost,
                MonthsForFundingCost = plotDTO.MonthsForFundingCost,
                PlotValue = plotDTO.PlotValue,
                PlotSize = plotDTO.PlotSize,
                PlotNumber = plotDTO.PlotNumber
            };

            await _plotRepository.AddPlotAsync(plot);
        }

        public async Task UpdatePlotAsync(PlotDTO plotDTO)
        {
            var plot = new Plot
            {
                ID = plotDTO.ID,
                PlotCost = plotDTO.PlotCost,
                MonthlyFundingCost = plotDTO.MonthlyFundingCost,
                MonthsForFundingCost = plotDTO.MonthsForFundingCost,
                PlotValue = plotDTO.PlotValue,
                PlotSize = plotDTO.PlotSize,
                PlotNumber = plotDTO.PlotNumber
            };

            await _plotRepository.UpdatePlotAsync(plot);
        }

        public async Task DeletePlotAsync(int id)
        {
            await _plotRepository.DeletePlotAsync(id);
        }
    }
}
