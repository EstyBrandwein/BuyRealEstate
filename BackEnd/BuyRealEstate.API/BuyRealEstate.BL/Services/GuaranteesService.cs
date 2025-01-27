using AutoMapper;
using BuyRealEstate.Core.DTos;
using BuyRealEstate.Core.DTOs;
using BuyRealEstate.Core.Interfaces;
using BuyRealEstate.Domain.Interfaces;
using BuyRealEstate.Domain.Migrations;
using BuyRealEstate.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BuyRealEstate.Core.Services
{
    public class GuaranteesService : IGuaranteesService
    {
        private readonly IGuaranteesRepository _guaranteesRepository;
        private readonly IMapper _mapper;
        public GuaranteesService(IGuaranteesRepository guaranteesRepository, IMapper mapper)
        {
            _guaranteesRepository = guaranteesRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<GuaranteesDTO>> GetAllGuaranteessAsync()
        {
            var guaranteess = await _guaranteesRepository.GetAllGuaranteessAsync();
            return guaranteess.Select(p => _mapper.Map<GuaranteesDTO>(p));
        }
        public async Task<IEnumerable<GuaranteesDTO>> GetAllGuaranteesByUserIdAsync(int id)
        {
            var guaranteess = await _guaranteesRepository.GetAllGuaranteessByIdAsync(id);
            return guaranteess.Select(p => _mapper.Map<GuaranteesDTO>(p));
        }
        public async Task<GuaranteesDTO> GetGuaranteesByIdAsync(int id)
        {
            var guarantees = await _guaranteesRepository.GetGuaranteestByIdAsync(id);
            if (guarantees == null) return null;
            return _mapper.Map<GuaranteesDTO>(guarantees);
        }
        public async Task AddGuaranteesAsync(GuaranteesDTO guaranteesDTO)
        {
            var guarantees = _mapper.Map<Domain.Models.Guarantees>(guaranteesDTO);
            await _guaranteesRepository.AddGuaranteesAsync(guarantees);
        }
        public async Task UpdateGuaranteesAsync(GuaranteesDTO guaranteesDTO)
        {
            var guarantees = _mapper.Map<Domain.Models.Guarantees>(guaranteesDTO);
            await _guaranteesRepository.UpdateGuaranteesAsync(guarantees);
        }
        public async Task DeleteGuaranteesAsync(int id)
        {
            await _guaranteesRepository.DeleteGuaranteesAsync(id);
        }
    }
}










