namespace EnvironmentsAndErrors.Pages;

using EnvironmentsAndErrors.Models;
using EnvironmentsAndErrors.Services;
using Microsoft.AspNetCore.Components.Web;

public partial class Index
{
    ErrorBoundary? errorBoundary;

    CountriesService CountriesService { get; set; } = new();
    IEnumerable<Country>? Countries { get; set; }

    protected override void OnInitialized() => 
        this.Countries = this.CountriesService.GetAllCountries();

    protected override void OnParametersSet() => 
        this.errorBoundary?.Recover();

}
