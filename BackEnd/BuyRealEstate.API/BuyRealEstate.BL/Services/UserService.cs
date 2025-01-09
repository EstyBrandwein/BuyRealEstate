using AutoMapper;
using BuyRealEstate.Domain.Models;
using BuyRealEstate.Core.Interfaces;
using BuyRealEstate.Core.DTos;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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

        public async Task<UsersDTO> GetByIdAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            return _mapper.Map<UsersDTO>(user); // מיפוי אוטומטי מ-User ל-UserDto
        }

        public async Task<IEnumerable<UsersDTO>> GetAllAsync()
        {
            var users = await _userRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<UsersDTO>>(users); // מיפוי אוטומטי לכל המשתמשים
        }

        public async Task AddAsync(UsersDTO userDto)
        {
            var user = _mapper.Map<User>(userDto); // מיפוי חזרה ל-User
            await _userRepository.AddAsync(user);
        }

        public async Task UpdateAsync(UsersDTO userDto)
        {
            // חפש את המשתמש הקיים במסד הנתונים לפי ה-ID
            var existingUser = await _userRepository.GetByIdAsync(userDto.ID);
            if (existingUser == null)
            {
                // מחזיר תשובה מתאימה אם המשתמש לא נמצא
                throw new Exception($"User with ID {userDto.ID} not found.");
            }

            // עדכון השדות של המשתמש הקיים עם הנתונים מ-UserDto
            existingUser.PermissionId = userDto.PermissionId;
            existingUser.Username = userDto.Username;
            existingUser.Password = userDto.Password;
            existingUser.FirstName = userDto.FirstName;
            existingUser.LastName = userDto.LastName;
            existingUser.Email = userDto.Email;
            existingUser.FirstPhone = userDto.FirstPhone;

            // שמור את השינויים
            await _userRepository.UpdateAsync(existingUser);
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
