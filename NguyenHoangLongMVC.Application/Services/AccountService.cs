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
   

    public class AccountService : IAccountService
    {

        private readonly ISystemAccountRepository _systemAccountRepository;

        private readonly IMapper _mapper;

        public AccountService(ISystemAccountRepository systemAccountRepository, IMapper mapper)
        {
            _systemAccountRepository = systemAccountRepository;
            _mapper = mapper;
        }


        public string getRoleName(int roleId)
        {
            return roleId switch
            {
                0 => "Admin",
                1 => "Staff",
                2 => "Lecture",
                _ => "Guest"
            };
        }

        public string getRoleName(int? roleId)
        {
            return roleId switch
            {
                0 => "Admin",
                1 => "Staff",
                2 => "Lecture",
                _ => "Guest"
            };
        }

        public async Task<IEnumerable<SystemAccountDto>> GetAllSystemAccountAsync()
        {
            var accounts = await _systemAccountRepository.GetAllSystemAccount();
            return _mapper.Map<IEnumerable<SystemAccountDto>>(accounts);
        }

        public async Task<SystemAccountDto> GetSystemAccountByIdAsync(int id)
        {
            var account = await _systemAccountRepository.GetSystemAccountById(id);
            return _mapper.Map<SystemAccountDto>(account);
        }
    }
}
