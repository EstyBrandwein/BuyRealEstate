using AutoMapper;
using BuyRealEstate.Domain.Models;
using BuyRealEstate.Core.Interfaces;
using BuyRealEstate.Core.DTos;
using System.Collections.Generic;
using System.Threading.Tasks;
using BuyRealEstate.Domain.Repositories;
namespace BuyRealEstate.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        // הזרקת AutoMapper לשירות
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<UserDto> GetByIdAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            return _mapper.Map<UserDto>(user); // מיפוי אוטומטי מ-User ל-UserDto
        }
        public async Task<IEnumerable<UserDto>> GetAllAsync()
        {
            var users = await _userRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<UserDto>>(users); // מיפוי אוטומטי לכל המשתמשים
        }
        public async Task AddAsync(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto); // מיפוי חזרה ל-User
            await _userRepository.AddAsync(user);
        }
        public async Task UpdateAsync(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto); // מיפוי חזרה ל-User
            await _userRepository.UpdateAsync(user);
        }
        public async Task DeleteAsync(int id)
        {
            await _userRepository.DeleteAsync(id);
        }
        public async Task<User> LoginAsync(string username, string password)
        {
            var user = await _userRepository.GetByUsernameAsync(username);
            if (user != null && VerifyPassword(user, password))
            {
                return _mapper.Map<User>(user); // מיפוי למידע שמתאים ל-DTO
            }
            return null;
        }
        private bool VerifyPassword(User user, string password)
        {
            return user.Password == password; // Simplified password verification
        }
    }
}