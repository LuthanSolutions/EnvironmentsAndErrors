﻿namespace EnvironmentsAndErrors.Components;

using EnvironmentsAndErrors.Models;
using EnvironmentsAndErrors.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

public partial class CitiesGrid
{
    private ErrorBoundary? errorBoundary;

    [CascadingParameter(Name = "ViewModel")]
    private IndexViewModel? ViewModel { get; set; }

    [Parameter]
    public Region? Region { get; set; }

    private IEnumerable<City>? Cities => this.ViewModel?.CitiesService?.GetCityByRegion(this.Region!);

    protected override void OnParametersSet() =>
        this.errorBoundary?.Recover();
}
