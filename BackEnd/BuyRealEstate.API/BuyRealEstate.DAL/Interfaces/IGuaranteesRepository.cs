using BuyRealEstate.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Domain.Interfaces
{
    public interface IGuaranteesRepository
    {
        Task<IEnumerable<Guarantees>> GetAllGuaranteessAsync();
        Task<IEnumerable<Guarantees>> GetAllGuaranteessByIdAsync(int id);
        Task<Guarantees> GetGuaranteestByIdAsync(int id);
        Task AddGuaranteesAsync(Guarantees guarantees);
        Task UpdateGuaranteesAsync(Guarantees guarantees);
        Task DeleteGuaranteesAsync(int id);
    }
}

