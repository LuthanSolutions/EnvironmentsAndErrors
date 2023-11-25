namespace EnvironmentsAndErrors.ViewModels;

using EnvironmentsAndErrors.Services;

public class IndexViewModel
{
    public CountriesService CountriesService { get; set; } = new();

    public RegionsService RegionsService { get; set; } = new();

    public CitiesService CitiesService { get; set; } = new();
}
