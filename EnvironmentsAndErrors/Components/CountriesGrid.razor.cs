namespace EnvironmentsAndErrors.Components;

using EnvironmentsAndErrors.Services;
using Microsoft.AspNetCore.Components.Web;

public partial class CountriesGrid
{
    private ErrorBoundary? errorBoundary;

    private CountriesService CountriesService { get; set; } = new();

    protected override void OnParametersSet() =>
        this.errorBoundary?.Recover();
}
