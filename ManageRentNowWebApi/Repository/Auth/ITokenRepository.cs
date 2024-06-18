﻿using Microsoft.AspNetCore.Identity;

namespace ManageRentNow.Api.Repository.Auth
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
