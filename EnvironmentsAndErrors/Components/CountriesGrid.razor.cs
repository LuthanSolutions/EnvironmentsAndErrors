namespace EnvironmentsAndErrors.Components;

using EnvironmentsAndErrors.Services;
using EnvironmentsAndErrors.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

public partial class CountriesGrid
{
    private ErrorBoundary? errorBoundary;

    [CascadingParameter(Name = "ViewModel")]
    private IndexViewModel? ViewModel { get; set; }

    protected override void OnParametersSet() =>
        this.errorBoundary?.Recover();
}
