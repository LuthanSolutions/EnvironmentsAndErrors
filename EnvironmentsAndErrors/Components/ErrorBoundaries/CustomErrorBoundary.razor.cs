namespace EnvironmentsAndErrors.Components.ErrorBoundaries;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

public partial class CustomErrorBoundary : ErrorBoundary
{
    [Inject]
    IWebHostEnvironment? WebHostEnvironment { get; set; }

    private string ErrorMessage => 
        this.WebHostEnvironment.IsDevelopment() ? $"Error: {this.CurrentException?.Message!} Target: {this.CurrentException?.TargetSite}" : "An error has occurred!";
}
