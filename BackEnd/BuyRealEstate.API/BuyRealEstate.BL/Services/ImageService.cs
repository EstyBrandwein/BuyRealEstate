using AutoMapper;
using BuyRealEstate.Core.DTos;
using BuyRealEstate.Core.Interfaces;
using BuyRealEstate.Domain.Interfaces;
using BuyRealEstate.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuyRealEstate.Core.Services
{
    public class ImageService : IImageService
    {
        private readonly IImageRepository _imageRepository;
        private readonly IMapper _mapper;

        public ImageService(IImageRepository imageRepository, IMapper mapper)
        {
            _imageRepository = imageRepository;
            _mapper = mapper;
        }

        public async Task<ImageDTO> GetImageByIdAsync(int id)
        {
            var image = await _imageRepository.GetByIdAsync(id);
            if (image == null)
                return null;

            var imageDto = _mapper.Map<ImageDTO>(image);
            imageDto.FileType = GetMimeType(image.FileType); // Convert file type to MIME type
            return imageDto;
        }

        public async Task<IEnumerable<ImageDTO>> GetImagesByProjectIdAsync(int projectId)
        {
            var images = await _imageRepository.GetByProjectIdAsync(projectId);
            return images.Select(img =>
            {
                var imageDto = _mapper.Map<ImageDTO>(img);
                imageDto.FileType = GetMimeType(img.FileType); // Ensure proper MIME type
                return imageDto;
            });
        }

        public async Task AddImageAsync(ImageDTO imageDTO)
        {
            var image = _mapper.Map<Image>(imageDTO);
            image.FileType = GetMimeType(imageDTO.FileType); // Ensure correct file type before saving
            await _imageRepository.AddAsync(image);
            await _imageRepository.SaveChangesAsync();
        }

        public async Task DeleteImageAsync(int id)
        {
            await _imageRepository.DeleteAsync(id);
            await _imageRepository.SaveChangesAsync();
        }

        /// <summary>
        /// Maps file extensions to MIME types.
        /// </summary>
        /// <param name="fileType">File extension (e.g., .jpg)</param>
        /// <returns>Valid MIME type (e.g., image/jpeg)</returns>
        private string GetMimeType(string fileType)
        {
            return fileType.ToLower() switch
            {
                ".jpg" or ".jpeg" => "image/jpeg",
                ".png" => "image/png",
                ".gif" => "image/gif",
                ".bmp" => "image/bmp",
                ".svg" => "image/svg+xml",
                ".webp" => "image/webp",
                _ => "application/octet-stream" // Default MIME type
            };
        }
    }
}
