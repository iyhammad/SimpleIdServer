﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using SimpleIdServer.IdServer.Resources;
using System.Collections.Generic;

namespace SimpleIdServer.IdServer.UI.ViewModels
{
    public abstract class BaseOTPAuthenticateViewModel : BaseAuthenticateViewModel, IOTPViewModel
    {
        public string Action { get; set; }
        public string? OTPCode { get; set; }
        public int? TOTPStep { get; set; }

        public override List<string> Validate()
        {
            var errors = new List<string>();
            if (string.IsNullOrWhiteSpace(ReturnUrl))
                errors.Add(Global.MissingReturnUrl);

            if (string.IsNullOrWhiteSpace(Login))
                errors.Add(Global.MissingLogin);

            errors.AddRange(SpecificValidate());
            return errors;
        }

        public abstract List<string> SpecificValidate();

        public List<string> CheckConfirmationCode()
        {
            var errors = new List<string>();
            if (OTPCode == null)
                errors.Add(Global.MissingConfirmationCode);
            return errors;
        }
    }
}
