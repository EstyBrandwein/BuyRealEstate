﻿using BuyRealEstate.Core.DTos;
using BuyRealEstate.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace BuyRealEstate.Core.Interfaces
{
    public interface IPlotService
    {
        Task<IEnumerable<PlotDTO>> GetAllPlotsAsync();
        Task<IEnumerable<PlotDTO>> GetAllPlotByUserIdAsync(int id);
        Task<PlotDTO> GetPlotByIdAsync(int id);
        Task AddPlotAsync(PlotDTO plot);
        Task UpdatePlotAsync(PlotDTO plot);
        Task DeletePlotAsync(int id);
    }
}