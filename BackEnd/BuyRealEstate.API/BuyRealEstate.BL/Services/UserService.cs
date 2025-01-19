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

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDto> GetByIdAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            return _mapper.Map<UserDto>(user);
        }

        public async Task<IEnumerable<UserDto>> GetAllAsync()
        {
            var users = await _userRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<UserDto>>(users);
        }

        public async Task AddAsync(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);

            // גיבוב הסיסמה
            user.Password = HashPassword(userDto.Password);

            await _userRepository.AddAsync(user);
        }

        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public async Task UpdateAsync(UserDto userDto)
        {
            var existingUser = await _userRepository.GetByIdAsync(userDto.ID);
            if (existingUser == null)
            {
                throw new Exception($"User with ID {userDto.ID} not found.");
            }

            existingUser.PermissionId = userDto.PermissionId;
            existingUser.Username = userDto.Username;

            // אם יש סיסמה חדשה, גיבוב מחדש
            if (!string.IsNullOrEmpty(userDto.Password))
            {
                existingUser.Password = HashPassword(userDto.Password);
            }

            existingUser.FirstName = userDto.FirstName;
            existingUser.LastName = userDto.LastName;
            existingUser.Email = userDto.Email;
            existingUser.FirstPhone = userDto.FirstPhone;

            await _userRepository.UpdateAsync(existingUser);
        }

        public async Task DeleteAsync(int id)
        {
            await _userRepository.DeleteAsync(id);
        }

        public async Task<User> LoginAsync(string username, string password)
        {
            var user = await _userRepository.GetByUsernameAsync(username);
            if (user != null && VerifyPassword(password, user.Password))
            {
                return user;
            }
            return null;

        }

        private bool VerifyPassword(string enteredPassword, string storedHash)
        {
            return BCrypt.Net.BCrypt.Verify(enteredPassword, storedHash);
        }
    }
}
