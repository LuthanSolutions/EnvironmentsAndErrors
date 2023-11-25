﻿namespace EnvironmentsAndErrors.Components.ErrorBoundaries;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Serilog;
using System;
using System.Threading.Tasks;

public partial class CustomErrorBoundary : ErrorBoundary
{
    [Inject]
    private IWebHostEnvironment? WebHostEnvironment { get; set; }

    [Parameter]
    public string? NonDevelopmentErrorMessage { get; set; }

    private string ErrorMessage =>
        this.WebHostEnvironment!.IsDevelopment()
            ? $"Error: {this.CurrentException?.Message!} Target: {this.CurrentException?.TargetSite}"
            : $"{(string.IsNullOrEmpty(this.NonDevelopmentErrorMessage) ? "An error has occurred!" : this.NonDevelopmentErrorMessage)}";

    protected override Task OnErrorAsync(Exception exception)
    {
        Log.Error(this.CurrentException, this.CurrentException?.Message!);
        return Task.CompletedTask;
    }
}
