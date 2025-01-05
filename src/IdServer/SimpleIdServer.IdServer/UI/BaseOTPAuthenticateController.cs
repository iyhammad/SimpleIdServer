﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using FormBuilder;
using FormBuilder.Repositories;
using FormBuilder.Stores;
using MassTransit;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using SimpleIdServer.IdServer.Api;
using SimpleIdServer.IdServer.Helpers;
using SimpleIdServer.IdServer.Jwt;
using SimpleIdServer.IdServer.Options;
using SimpleIdServer.IdServer.Resources;
using SimpleIdServer.IdServer.Stores;
using SimpleIdServer.IdServer.UI.Infrastructures;
using SimpleIdServer.IdServer.UI.Services;
using SimpleIdServer.IdServer.UI.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleIdServer.IdServer.UI
{
    public abstract class BaseOTPAuthenticateController<T> : BaseAuthenticationMethodController<T> where T : BaseOTPAuthenticateViewModel
    {
        private readonly IEnumerable<IUserNotificationService> _notificationServices;
        private readonly IEnumerable<IOTPAuthenticator> _otpAuthenticators;

        protected BaseOTPAuthenticateController(
            IConfiguration configuration,
            IEnumerable<IUserNotificationService> notificationServices,
            IEnumerable<IOTPAuthenticator> otpAuthenticators,
            IUserAuthenticationService userAuthenticationService,
            IAuthenticationSchemeProvider authenticationSchemeProvider,
            IOptions<IdServerHostOptions> options,
            IDataProtectionProvider dataProtectionProvider,
            IAuthenticationHelper authenticationHelper,
            IClientRepository clientRepository,
            IAmrHelper amrHelper,
            IUserRepository userRepository,
            IUserSessionResitory userSessionRepository,
            IUserTransformer userTransformer,
            ITokenRepository tokenRepository,
            ITransactionBuilder transactionBuilder,
            IJwtBuilder jwtBuilder,
            IBusControl busControl,
            IAntiforgery antiforgery,
            IAuthenticationContextClassReferenceRepository authenticationContextClassReferenceRepository,
            ISessionManager sessionManager,
            IWorkflowStore workflowStore,
            IFormStore formStore,
            IOptions<FormBuilderOptions> formBuilderOptions) : base(configuration, options, authenticationSchemeProvider, userAuthenticationService, dataProtectionProvider, tokenRepository, transactionBuilder, jwtBuilder, authenticationHelper, clientRepository, amrHelper, userRepository, userSessionRepository, userTransformer, busControl, antiforgery, authenticationContextClassReferenceRepository, sessionManager, workflowStore, formStore, formBuilderOptions)
        {
            _notificationServices = notificationServices;
            _otpAuthenticators = otpAuthenticators;
        }

        protected abstract string FormattedMessage { get; }

        protected override async Task<UserAuthenticationResult> CustomAuthenticate(string prefix, string authenticatedUserId, T viewModel, CancellationToken cancellationToken)
        {
            var authenticatedUser = await UserAuthenticationService.GetUser(authenticatedUserId, viewModel, prefix, cancellationToken);
            if (authenticatedUser == null)
            {
                return UserAuthenticationResult.Error(Global.UserDoesntExist);
            }

            var activeOtp = authenticatedUser.ActiveOTP;
            if(activeOtp == null)
            {
                return UserAuthenticationResult.Error(Global.NoActiveOtp);
            }

            var otpAuthenticator = _otpAuthenticators.Single(a => a.Alg == activeOtp.OTPAlg);
            switch(viewModel.Action)
            {
                case "SENDCONFIRMATIONCODE":
                    var notificationService = _notificationServices.First(n => n.Name == Amr);
                    var otpCode = otpAuthenticator.GenerateOtp(activeOtp);
                    await notificationService.Send("One Time Password", string.Format(FormattedMessage, otpCode), new Dictionary<string, string>(), authenticatedUser);
                    if(activeOtp.OTPAlg == Domains.OTPAlgs.TOTP) viewModel.TOTPStep = activeOtp.TOTPStep;
                    return UserAuthenticationResult.Success(Global.ConfirmationcodeSent);
                default:
                    var errors = viewModel.CheckConfirmationCode();
                    if (errors.Any()) return UserAuthenticationResult.Error(errors);
                    break;
            }

            return UserAuthenticationResult.Ok(authenticatedUser);
        }

        protected override void EnrichViewModel(T viewModel)
        {

        }
    }
}
