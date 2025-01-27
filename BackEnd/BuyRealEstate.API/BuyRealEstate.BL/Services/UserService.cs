using AutoMapper;
using BuyRealEstate.Domain.Models;
using BuyRealEstate.Core.Interfaces;
using BuyRealEstate.Core.DTos;
using System.Collections.Generic;
using System.Threading.Tasks;
using BuyRealEstate.Domain.Repositories;
using BuyRealEstate.Domain.Interfaces;
namespace BuyRealEstate.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<UsersDTO> GetAsync(int id)
        {
            var user = await _userRepository.GetAsync(id);
            return _mapper.Map<UsersDTO>(user); 
        }
        public async Task<IEnumerable<UsersDTO>> GetAllAsync()
        {
            var users = await _userRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<UsersDTO>>(users); 
        }
        public async Task AddAsync(UsersDTO userDto)
        {
            var user = _mapper.Map<User>(userDto);
            user.Password = BCrypt.Net.BCrypt.HashPassword(userDto.Password);
            await _userRepository.AddAsync(user);
        }


        public async Task UpdateAsync(int id, UsersDTO userDto)
        {
            var user = _mapper.Map<User>(userDto); 
            await _userRepository.UpdateAsync(id, user);
        }
        public async Task DeleteAsync(int id) => await _userRepository.DeleteAsync(id);

        public async Task<bool> LoginAsync(string username, string password)
        {
            return await _userRepository.VerifyPasswordAsync(username, password);
        }


        //public async Task<User> LoginAsync(string username, string password)
        //{
        //    var user = await _userRepository.GetAsync(username);
        //    if (user != null && VerifyPassword(user, password))
        //    {
        //        return _mapper.Map<User>(user); // מיפוי למידע שמתאים ל-DTO
        //    }
        //    return null;
        //}
        //private bool VerifyPassword(User user, string password)
        //{
        //    return user.Password == password; // Simplified password verification
        //}
    }
}