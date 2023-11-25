namespace EnvironmentsAndErrors.Components;

using EnvironmentsAndErrors.Models;
using EnvironmentsAndErrors.Services;
using EnvironmentsAndErrors.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

public partial class RegionsGrid
{
    private ErrorBoundary? errorBoundary;

    [CascadingParameter(Name = "ViewModel")]
    private IndexViewModel? ViewModel { get; set; }

    [Parameter]
    public Country? Country { get; set; }

    protected override void OnParametersSet() =>
        this.errorBoundary?.Recover();
}
