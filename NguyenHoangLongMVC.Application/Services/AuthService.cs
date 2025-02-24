using AutoMapper;
using NguyenHoangLongMVC.Application.DTOs;
using NguyenHoangLongMVC.Application.Interfaces;
using NguyenHoangLongMVC.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHoangLongMVC.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly ISystemAccountRepository _systemAccountRepository;
        private readonly IMapper _mapper;

        public AuthService(ISystemAccountRepository systemAccountRepository, IMapper mapper)
        {
            _systemAccountRepository = systemAccountRepository;
            _mapper = mapper;
        }

        public Task<bool> IsAuthenticated {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }

        public async Task<SystemAccountDto> AuthenticateAsync(string email, string password)
        {
            var systemAccount = await _systemAccountRepository.GetSystemAccountByEmail(email);
            if(systemAccount == null || systemAccount.AccountPassword != password)
            {
                return null;
            }
            return _mapper.Map<SystemAccountDto>(systemAccount);
        }

        public Task<bool> ChangePassword(string username, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ForgotPassword(string username)
        {
            throw new NotImplementedException();
        }

        public Task Logout()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Register(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ResetPassword(string username, string newPassword)
        {
            throw new NotImplementedException();
        }
    }
}
