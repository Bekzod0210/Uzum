﻿using Uzum.Aplication.Abstractions;
using Uzum.Infrastructure.Abstractions;
using Uzum.Infrastructure.Persistence;

namespace Uzum.Infrastructure.Services
{
    public class AuthService : IAuthService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ITokenService _tokenService;
        private readonly IHashProvider _hashProvider;

        public AuthService(ApplicationDbContext dbContext, ITokenService tokenService, IHashProvider hashProvider)
        {
            _dbContext = dbContext;
            _tokenService = tokenService;
            _hashProvider = hashProvider;
        }

        public async Task<string> LoginAsync(string username, string password)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.UserName == username);

            if (user == null)
            {
                throw new Exception("User not found");
            }

            if (user.PasswordHash != _hashProvider.GetHash(password))
            {
                throw new Exception("Password is wrong");
            }

            return _tokenService.GenerateAccessToken(user);
        }
    }
}