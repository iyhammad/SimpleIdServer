﻿using FormBuilder.Components.FormElements;
using FormBuilder.Repositories;
using FormBuilder.Startup.Controllers.ViewModels;
using FormBuilder.Stores;
using FormBuilder.UIs;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace FormBuilder.Startup.Controllers;

public class AuthController : BaseWorkflowController
{
    public AuthController(IAntiforgery antiforgery, IWorkflowStore workflowStore, IFormStore formStore, IOptions<FormBuilderOptions> options) : base(antiforgery, workflowStore, formStore, options)
    {
    }

    public async Task<IActionResult> Index(string workflowId, string stepName, CancellationToken cancellationToken)
    {
        var viewModel = await Get(workflowId, stepName, cancellationToken);
        var authViewModel = new AuthViewModel
        {
            ReturnUrl = "http://localhost:5000",
            ExternalIdProviders = new List<ExternalIdProviderViewModel>
            {
                new ExternalIdProviderViewModel { AuthenticationScheme = "facebook", DisplayName = "Facebook" }
            }
        };
        viewModel.SetInput(authViewModel);
        return View(viewModel);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Confirm(AuthViewModel viewModel, CancellationToken cancellationToken)
    {
        var result = await GetNextWorkflowStep(cancellationToken);
        if (result == null) return Content("finish");
        return RedirectToAction("Index", new { workflowId = result.Value.Item1.Id, stepName = result.Value.Item2.FormRecordName });
    }

    [HttpGet]
    public IActionResult Callback(string scheme)
    {
        return NoContent();
    }
}
