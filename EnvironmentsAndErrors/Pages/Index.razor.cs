namespace EnvironmentsAndErrors.Pages;

using EnvironmentsAndErrors.Models;
using EnvironmentsAndErrors.Services;
using EnvironmentsAndErrors.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

public partial class Index
{
    private ErrorBoundary? errorBoundary;

    [CascadingParameter(Name = nameof(ConnectionStrings))]
    public ConnectionStrings? ConnectionStrings { get; set; }

    public IndexViewModel ViewModel { get; set; } = new();

    protected override void OnParametersSet() =>
        this.errorBoundary?.Recover();

}
