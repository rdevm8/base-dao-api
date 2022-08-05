﻿using AutoMapper;
using base_dao_api.GraphQl.Mutations.Payloads;
using base_dao_api.GraphQl.Validators;
using base_dao_api.Models;
using base_dao_api.Repositories.UnitOfWork.Interfaces;
using FluentValidation.Results;
using AppAny.HotChocolate.FluentValidation;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Options;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace base_dao_api.GraphQl.Mutations
{
    [ExtendObjectType(typeof(Mutation))]
    public class LoginMutation
    {
        private readonly IMapper _mapper;

        public LoginMutation(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<string> Login([Service] IUnitOfWork _unitOfWork,
            [Service] IOptions<TokenSettings> tokenSettings,
            [UseFluentValidation, UseValidator<LoginPayloadValidator>]  LoginPayload login)
        {
            string res = String.Empty;
            string claimRole = String.Empty;

            // USER VALIDATION
            User user = (await _unitOfWork.User.GetAsync(
                filter: x => x.WalletAddress == login.WalletAddress,
                include: x => x.Include(y => y.UserRoles).ThenInclude(z => z.Role)
                )).FirstOrDefault();

            if (user != null)
            {
                claimRole = user.UserRoles.ToList()[0].Role.DetailCd;
            }

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenSettings.Value.Key));
            var credentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var claims = new Claim[]
            {
                new Claim(ClaimTypes.Role, claimRole),
                new Claim(ClaimTypes.NameIdentifier, (user == null ? login.WalletAddress : user.WalletAddress))
            };

            var jwtToken = new JwtSecurityToken(
                issuer: tokenSettings.Value.Issuer,
                audience: tokenSettings.Value.Audience,
                expires: DateTime.Now.AddMinutes(tokenSettings.Value.Expiration),
                signingCredentials: credentials,
                claims: claims
            );

            string token = new JwtSecurityTokenHandler().WriteToken(jwtToken);
            return token;
        }       
    }

}

