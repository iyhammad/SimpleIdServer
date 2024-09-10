﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using System;
using System.Collections.Generic;
using System.Globalization;

namespace SimpleIdServer.FastFed.ApplicationProvider;

public class FastFedApplicationProviderOptions
{
    public TimeSpan WhitelistingExpirationTime { get; set; } = TimeSpan.FromSeconds(60 * 5);
    public List<CultureInfo> SupportedCultures { get; set; } = new List<CultureInfo>();
    public string ProviderDomain { get; set; }
    public FastFed.Models.Capabilities Capabilities { get; set; }
    public FastFed.Models.DisplaySettings DisplaySettings { get; set; }
    public FastFed.Models.ProviderContactInformation ContactInformation { get; set; }
}
