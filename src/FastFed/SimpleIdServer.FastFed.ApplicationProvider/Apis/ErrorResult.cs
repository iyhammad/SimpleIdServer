﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System.Text.Json.Serialization;

namespace SimpleIdServer.FastFed.ApplicationProvider.Apis;

public class ErrorResult
{
    [JsonPropertyName("error_code")]
    public string ErrorCode { get; set; }
    [JsonPropertyName("error_description")]
    public string ErrorDescription { get; set; }
}
