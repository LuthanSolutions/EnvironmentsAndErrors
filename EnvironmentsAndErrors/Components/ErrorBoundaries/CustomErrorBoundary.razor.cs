namespace EnvironmentsAndErrors.Components.ErrorBoundaries;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Serilog;
using System;
using System.Threading.Tasks;

public partial class CustomErrorBoundary : ErrorBoundary
{
    [Inject]
    private IWebHostEnvironment? WebHostEnvironment { get; set; }

    private string ErrorMessage =>
        this.WebHostEnvironment!.IsDevelopment()
            ? $"Error: {this.CurrentException?.Message!} Target: {this.CurrentException?.TargetSite}"
            : "An error has occurred!";

    protected override Task OnErrorAsync(Exception exception)
    {
        Log.Error(this.CurrentException, this.CurrentException?.Message!);
        return Task.CompletedTask;
    }
}
