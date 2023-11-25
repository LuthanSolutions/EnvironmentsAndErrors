namespace EnvironmentsAndErrors.Services;

using EnvironmentsAndErrors.Models;

public class RegionsService
{
    public IEnumerable<Region>? GetRegionsByCountry(Country country)
    {
        List<Region>? regions;
        switch (country.Name)
        {
            case "United Kingdom":
                {
                    regions = new List<Region>()
                    {
                        new(){ Id = 1, Name = "Northumberland"},
                        new(){ Id = 2, Name = "Durham"},
                        new(){ Id = 3, Name = "Cumbria"}
                    };
                    break;
                }
            case "United States":
                {
                    throw new ArgumentException();
                    regions = new List<Region>()
                    {
                        new(){ Id = 4, Name = "New York"},
                        new(){ Id = 5, Name = "Connecticut"},
                        new(){ Id = 6, Name = "New Jersey"}
                    };
                    break;
                }
            case "India":
                {
                    regions = new List<Region>()
                    {
                        new(){ Id = 7, Name = "Bihar"},
                        new(){ Id = 8, Name = "Jharkhand"},
                        new(){ Id = 9, Name = "West Bengal"}
                    };
                    break;
                }
            default:
                {
                    return null;
                }
        }

        return regions;
    }
}
