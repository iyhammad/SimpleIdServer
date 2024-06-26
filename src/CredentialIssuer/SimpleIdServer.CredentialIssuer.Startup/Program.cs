﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SimpleIdServer.CredentialIssuer.Startup;
using SimpleIdServer.Did.Key;
using System.Net.Http;

var builder = WebApplication.CreateBuilder(args);

var ignoreCertificateError = bool.Parse(builder.Configuration["Authorization:IgnoreCertificateError"]);
builder.Services.AddAuthentication(o =>
{
    o.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    o.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    o.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
})
.AddCookie()
.AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, o =>
{
    o.Authority = builder.Configuration["Authorization:Issuer"];
    o.RequireHttpsMetadata = false;
    o.TokenValidationParameters.ValidateAudience = false;
    if (ignoreCertificateError)
    {
        var handler = new HttpClientHandler
        {
            ServerCertificateCustomValidationCallback = (httpRequestMessage, cert, cetChain, policyErrors) =>
            {
                return true;
            }
        };
        o.BackchannelHttpHandler = handler;
    }
})
.AddOpenIdConnect(OpenIdConnectDefaults.AuthenticationScheme, options =>
{
    if (ignoreCertificateError)
    {
        var handler = new HttpClientHandler
        {
            ServerCertificateCustomValidationCallback = (httpRequestMessage, cert, cetChain, policyErrors) =>
            {
                return true;
            }
        };
        options.BackchannelHttpHandler = handler;
    }

    options.ClientId = builder.Configuration["Authorization:ClientId"];
    options.ClientSecret = builder.Configuration["Authorization:ClientSecret"];
    options.Authority = builder.Configuration["Authorization:Issuer"];
    options.ResponseType = "code";
    options.ResponseMode = "query";
    options.SaveTokens = true;
    options.Scope.Clear();
    options.Scope.Add("openid");
    options.Scope.Add("profile");
});
builder.Services.AddAuthorization(b =>
{
    b.AddDefaultCredentialIssuerAuthorization();
});
builder.Services.AddLocalization();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRazorPages();
builder.Services.AddControllers();

builder.Services.AddCredentialIssuer(o =>
{
    o.Version = SimpleIdServer.IdServer.CredentialIssuer.CredentialIssuerVersion.ESBI;
    o.ClientId = builder.Configuration["Authorization:ClientId"];
    o.ClientSecret = builder.Configuration["Authorization:ClientSecret"];
    o.AuthorizationServer = builder.Configuration["Authorization:Issuer"];
    o.IgnoreHttpsCertificateError = ignoreCertificateError;
    o.IsDeveloperModeEnabled = true;
})
.UseInMemoryStore(c =>
{
    c.AddCredentialConfigurations(CredentialIssuerConfiguration.CredentialConfigurations);
    c.AddUserCredentialClaims(CredentialIssuerConfiguration.CredentialClaims);
    c.AddDeferredCredentials(CredentialIssuerConfiguration.DeferredCredentials);
});

builder.Services.AddDidKey();

var app = builder.Build();
app.UseStaticFiles();
app.UseRequestLocalization(e =>
{
    e.SetDefaultCulture("en-US");
    e.AddSupportedCultures("en-US");
    e.AddSupportedUICultures("en-US");
});
app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthentication();

app.UseRouting();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});
app.Run();