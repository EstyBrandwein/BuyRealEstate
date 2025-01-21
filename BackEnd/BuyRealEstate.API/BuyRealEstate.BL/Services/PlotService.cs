using AutoMapper;
using BuyRealEstate.Core.DTos;
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
        private readonly IMapper _mapper;
        public PlotService(IPlotRepository plotRepository, IMapper mapper)
        {
            _plotRepository = plotRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<PlotDTO>> GetAllPlotsAsync()
        {
            var plots = await _plotRepository.GetAllPlotsAsync();
            return plots.Select(p => _mapper.Map<PlotDTO>(p));
        }
        public async Task<IEnumerable<PlotDTO>> GetAllPlotByUserIdAsync(int id)
        {
            var plots = await _plotRepository.GetAllPlotsByIdAsync(id);
            return plots.Select(p => _mapper.Map<PlotDTO>(p));
        }
        public async Task<PlotDTO> GetPlotByIdAsync(int id)
        {
            var plot = await _plotRepository.GetPlotByIdAsync(id);
            if (plot == null) return null;
            return _mapper.Map<PlotDTO>(plot);
        }
        public async Task AddPlotAsync(PlotDTO plotDTO)
        {
            var plot = _mapper.Map<Plot>(plotDTO);
            await _plotRepository.AddPlotAsync(plot);
        }
        public async Task UpdatePlotAsync(PlotDTO plotDTO)
        {
            var plot = _mapper.Map<Plot>(plotDTO);
            await _plotRepository.UpdatePlotAsync(plot);
        }
        public async Task DeletePlotAsync(int id)
        {
            await _plotRepository.DeletePlotAsync(id);
        }
    }
}










