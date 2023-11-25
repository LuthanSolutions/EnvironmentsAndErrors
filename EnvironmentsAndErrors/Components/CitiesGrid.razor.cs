namespace EnvironmentsAndErrors.Components;

using EnvironmentsAndErrors.Models;
using EnvironmentsAndErrors.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

public partial class CitiesGrid
{
    private ErrorBoundary? errorBoundary;

    private CitiesService? CitiesService { get; set; } = new();

    [Parameter]
    public Region? Region { get; set; }

    protected override void OnParametersSet() =>
        this.errorBoundary?.Recover();
}
