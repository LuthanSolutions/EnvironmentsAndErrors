namespace EnvironmentsAndErrors.Services;

using EnvironmentsAndErrors.Models;

public class CountriesService
{
    RegionsService RegionsService { get; set; } = new();
    public IEnumerable<Country> GetAllCountries()
    {
        var countries = new List<Country>
        {
            new() {Id = 1, Name = "United Kingdom" },
            new() {Id = 2, Name = "United States" },
            new() {Id = 3, Name = "India" }
        };

        return countries;
    }
}
