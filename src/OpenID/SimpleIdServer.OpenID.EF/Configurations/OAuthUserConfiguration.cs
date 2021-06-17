﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleIdServer.OAuth.Domains;
namespace SimpleIdServer.OpenID.EF.Configurations
{
    public class OAuthUserConfiguration : IEntityTypeConfiguration<OAuthUser>
    {
        public void Configure(EntityTypeBuilder<OAuthUser> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Ignore(u => u.Claims);
            builder.HasMany(u => u.Consents).WithOne().OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(u => u.Sessions).WithOne().OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(u => u.OAuthUserClaims).WithOne().OnDelete(DeleteBehavior.Cascade);
        }
    }
}