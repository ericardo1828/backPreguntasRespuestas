﻿using BackEnd.Domain.IRepositories;
using BackEnd.Domain.IServices;
using BackEnd.Domain.Models;
using System.Threading.Tasks;

namespace BackEnd.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public async Task<Usuario> ValidarUser(Usuario usuario)
        {
            return await _loginRepository.ValidarUser(usuario);
        }
    }
}
