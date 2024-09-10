﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using Microsoft.AspNetCore.Mvc;
using SimpleIdServer.FastFed.ApplicationProvider.Resolvers;
using SimpleIdServer.FastFed.ApplicationProvider.Services;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleIdServer.FastFed.ApplicationProvider.Apis.FastFed;

public class FastFedController : BaseController
{
    private readonly IFastFedService _fastFedService;
    private readonly IIssuerResolver _issuerResolver;
    private readonly IGetApplicationProviderMetadataQuery _getApplicationProviderMetadataQuery;

    public FastFedController(IFastFedService fastFedService, IIssuerResolver issuerResolver, IGetApplicationProviderMetadataQuery getApplicationProviderMetadataQuery)
    {
        _fastFedService = fastFedService;
        _issuerResolver = issuerResolver;
    }

    [HttpGet]
    public IActionResult GetMetadata()
    {
        var result = _getApplicationProviderMetadataQuery.Get();
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Resolve([FromBody] ResolveFastFedProvidersRequest request, CancellationToken cancellationToken)
    {
        var result = await _fastFedService.ResolveProviders(request.Email, cancellationToken);
        return BuildResult(result);   
    }

    [HttpPost]
    public async Task<IActionResult> Whitelist([FromBody] WhitelistIdentityProviderRequest request, CancellationToken cancellationToken)
    {
        // TODO - TRY TO AUTHENTICATE.
        var issuer = _issuerResolver.Get();
        var validationResult = await _fastFedService.StartWhitelist(issuer, request.IdentityProviderUrl, cancellationToken);
        if (validationResult.HasError) return null;
        var builder = new UriBuilder(validationResult.Result.fastFedHandshakeStartUri);
        builder.Query = validationResult.Result.request.ToQueryParameters();
        return Redirect(builder.Uri.ToString());
    }

    [HttpPost]
    public IActionResult Register()
    {
        return null;
    }
}
