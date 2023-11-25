namespace EnvironmentsAndErrors.Services;

using EnvironmentsAndErrors.Models;

public class CitiesService
{
    public IEnumerable<City>? GetCityByRegion(Region region)
    {
        switch (region.Name)
        {
            case "Northumberland":
                {
                    return new List<City>()
                    {
                        new(){ Id = 1, Name = "Newcastle"},
                        new(){ Id = 2, Name = "Alnwick"},
                        new(){ Id = 3, Name = "Morpeth"}
                    };
                }
            case "Durham":
                {
                    return new List<City>()
                    {
                        new(){ Id = 1, Name = "Durham"},
                        new(){ Id = 2, Name = "Sunderland"},
                        new(){ Id = 3, Name = "Darlington"}
                    };
                }
            case "Cumbria":
                {
                    throw new ArgumentException();
                    return new List<City>()
                    {
                        new(){ Id = 1, Name = "Carlisle"},
                        new(){ Id = 2, Name = "Brampton"},
                        new(){ Id = 3, Name = "Alston"}
                    };
                }
            case "New York":
                {
                    return new List<City>()
                    {
                        new(){ Id = 1, Name = "New York"},
                        new(){ Id = 2, Name = "Albany"},
                        new(){ Id = 3, Name = "Buffalo"}
                    };
                }
            case "New Jersey":
                {
                    return new List<City>()
                    {
                        new(){ Id = 1, Name = "Newark"},
                        new(){ Id = 2, Name = "Hoboken"},
                        new(){ Id = 3, Name = "Atlantic City"}
                    };
                }
            case "Connecticut":
                {
                    return new List<City>()
                    {
                        new(){ Id = 1, Name = "New Haven"},
                        new(){ Id = 2, Name = "Hartford"},
                        new(){ Id = 3, Name = "Danbury"}
                    };
                }
            case "Bihar":
                {
                    return new List<City>()
                    {
                        new(){ Id = 1, Name = "Patna"},
                        new(){ Id = 2, Name = "Bhagalpur"},
                        new(){ Id = 3, Name = "Chapra"}
                    };
                }
            case "Jharkhand":
                {
                    return new List<City>()
                    {
                        new(){ Id = 1, Name = "Ranchi"},
                        new(){ Id = 2, Name = "Hazaribagh"},
                        new(){ Id = 3, Name = "Dhanbad"}
                    };
                }
            case "West Bengal":
                {
                    return new List<City>()
                    {
                        new(){ Id = 1, Name = "Kolkata"},
                        new(){ Id = 2, Name = "Bardhaman"},
                        new(){ Id = 3, Name = "Durgapur"}
                    };
                }
            default:
                {
                    return null;
                }
        }
    }
}
