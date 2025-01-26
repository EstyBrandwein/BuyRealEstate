using BuyRealEstate.Core.DTos;
using BuyRealEstate.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace BuyRealEstate.Core.Interfaces
{
    public interface IGuaranteesService
    {
        Task<IEnumerable<GuaranteesDTO>> GetAllGuaranteessAsync();
        Task<IEnumerable<GuaranteesDTO>> GetAllGuaranteesByUserIdAsync(int id);
        Task<GuaranteesDTO> GetGuaranteesByIdAsync(int id);
        Task AddGuaranteesAsync(GuaranteesDTO guarantees);
        Task UpdateGuaranteesAsync(GuaranteesDTO guarantees);
        Task DeleteGuaranteesAsync(int id);
    }
}