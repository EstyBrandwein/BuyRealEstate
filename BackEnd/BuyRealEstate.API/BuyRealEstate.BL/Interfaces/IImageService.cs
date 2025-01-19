using BuyRealEstate.Core.DTos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Core.Interfaces
{
    public interface IImageService
    {
        Task<ImageDTO> GetImageByIdAsync(int id);
        Task<IEnumerable<ImageDTO>> GetImagesByProjectIdAsync(int projectId);
        Task AddImageAsync(ImageDTO image);
        Task DeleteImageAsync(int id);
    }
}
