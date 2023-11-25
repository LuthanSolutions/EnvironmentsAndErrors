namespace EnvironmentsAndErrors.Pages;

using EnvironmentsAndErrors.ViewModels;
using Microsoft.AspNetCore.Components.Web;

public partial class Index
{
    private ErrorBoundary? errorBoundary;

    public IndexViewModel ViewModel { get; set; } = new();

    protected override void OnParametersSet() =>
        this.errorBoundary?.Recover();

}
