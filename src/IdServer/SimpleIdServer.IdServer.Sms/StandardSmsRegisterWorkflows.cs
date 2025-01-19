﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using FormBuilder.Link;
using FormBuilder.Models;
using FormBuilder.Models.Rules;
using FormBuilder.Models.Transformer;
using FormBuilder.Transformers;
using SimpleIdServer.IdServer.Sms;
using SimpleIdServer.IdServer.Sms.UI.ViewModels;
using System.Collections.ObjectModel;

namespace FormBuilder.Builders;

public static class StandardSmsRegisterWorkflows
{
    public static string workflowId = "0ba03d04-2990-4153-8484-0cb8092959cd";

    public static WorkflowRecord DefaultWorkflow = WorkflowBuilder.New(workflowId)
        .AddStep(Constants.EmptyStep, new Coordinate(100, 100))
        .AddSmsRegistration()
        .Build();

    public static WorkflowBuilder AddSmsRegistration(this WorkflowBuilder builder)
    {
        builder.AddStep(StandardSmsRegisterForms.SmsForm, new Coordinate(100, 100))
            .AddLinkHttpRequestAction(StandardSmsRegisterForms.SmsForm, FormBuilder.Constants.EmptyStep, StandardSmsRegisterForms.smsSendConfirmationCodeFormId, new WorkflowLinkHttpRequestParameter
            {
                Method = HttpMethods.POST,
                IsAntiforgeryEnabled = true,
                Target = "/{realm}/" + SimpleIdServer.IdServer.Sms.Constants.AMR + "/Register",
                Transformers = new List<ITransformerParameters>
                {
                    new RegexTransformerParameters()
                    {
                        Rules = new ObservableCollection<MappingRule>
                        {
                            new MappingRule { Source = $"$.{nameof(RegisterSmsViewModel.Realm)}", Target = "realm" }
                        }
                    },
                    new RelativeUrlTransformerParameters()
                }
            })
            .AddLinkHttpRequestAction(StandardSmsRegisterForms.SmsForm, FormBuilder.Constants.EmptyStep, StandardSmsRegisterForms.smsRegisterFormId, new WorkflowLinkHttpRequestParameter
            {
                Method = HttpMethods.POST,
                IsAntiforgeryEnabled = true,
                Target = "/{realm}/" + SimpleIdServer.IdServer.Sms.Constants.AMR + "/Register",
                Transformers = new List<ITransformerParameters>
                {
                    new RegexTransformerParameters()
                    {
                        Rules = new ObservableCollection<MappingRule>
                        {
                            new MappingRule { Source = $"$.{nameof(RegisterSmsViewModel.Realm)}", Target = "realm" }
                        }
                    },
                    new RelativeUrlTransformerParameters()
                }
            });
        return builder;
    }
}
