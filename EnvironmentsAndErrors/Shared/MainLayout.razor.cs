namespace EnvironmentsAndErrors.Shared;

using EnvironmentsAndErrors.Models;
using EnvironmentsAndErrors.Services;
using Microsoft.AspNetCore.Components;

public partial class MainLayout
{
    [Inject]
    private IConnectionStringsService? ConnectionStringsService { get; set; }

    public ConnectionStrings? ConnectionStrings { get; set; }

    protected override void OnInitialized() => 
        this.ConnectionStrings = this.ConnectionStringsService?.ConnectionStrings;
}
