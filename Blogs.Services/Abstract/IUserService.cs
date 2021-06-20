﻿using Blogs.Services.Dto;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Blogs.Services.Abstract
{
    public interface IUserService
    {
        Task<UserObject> ValidateUserCredentials(string email, string password);
        ClaimsPrincipal GetUserIdentity(UserObject user, string authType);
    }
}
