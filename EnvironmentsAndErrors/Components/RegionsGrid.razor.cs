namespace EnvironmentsAndErrors.Components;

using EnvironmentsAndErrors.Models;
using EnvironmentsAndErrors.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

public partial class RegionsGrid
{
    ErrorBoundary? errorBoundary;

    RegionsService? RegionsService { get; set; } = new();

    [Parameter]
    public Country? Country { get; set; }

    protected override void OnParametersSet() =>
        this.errorBoundary?.Recover();
}
