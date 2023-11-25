namespace EnvironmentsAndErrors.Services;

using EnvironmentsAndErrors.Models;

public class CitiesService
{
    public IEnumerable<City>? GetCityByRegion(Region? region)
    {
        switch (region?.Name)
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
                        new(){ Id = 4, Name = "Durham"},
                        new(){ Id = 5, Name = "Sunderland"},
                        new(){ Id = 6, Name = "Darlington"}
                    };
                }
            case "Cumbria":
                {
                    throw new IndexOutOfRangeException();
                    return new List<City>()
                    {
                        new(){ Id = 7, Name = "Carlisle"},
                        new(){ Id = 8, Name = "Brampton"},
                        new(){ Id = 9, Name = "Alston"}
                    };
                }
            case "New York":
                {
                    return new List<City>()
                    {
                        new(){ Id = 10, Name = "New York"},
                        new(){ Id = 11, Name = "Albany"},
                        new(){ Id = 12, Name = "Buffalo"}
                    };
                }
            case "New Jersey":
                {
                    return new List<City>()
                    {
                        new(){ Id = 13, Name = "Newark"},
                        new(){ Id = 14, Name = "Hoboken"},
                        new(){ Id = 15, Name = "Atlantic City"}
                    };
                }
            case "Connecticut":
                {
                    return new List<City>()
                    {
                        new(){ Id = 16, Name = "New Haven"},
                        new(){ Id = 17, Name = "Hartford"},
                        new(){ Id = 18, Name = "Danbury"}
                    };
                }
            case "Bihar":
                {
                    return new List<City>()
                    {
                        new(){ Id = 19, Name = "Patna"},
                        new(){ Id = 20, Name = "Bhagalpur"},
                        new(){ Id = 21, Name = "Chapra"}
                    };
                }
            case "Jharkhand":
                {
                    return new List<City>()
                    {
                        new(){ Id = 22, Name = "Ranchi"},
                        new(){ Id = 23, Name = "Hazaribagh"},
                        new(){ Id = 24, Name = "Dhanbad"}
                    };
                }
            case "West Bengal":
                {
                    return new List<City>()
                    {
                        new(){ Id = 25, Name = "Kolkata"},
                        new(){ Id = 26, Name = "Bardhaman"},
                        new(){ Id = 27, Name = "Durgapur"}
                    };
                }
            default:
                {
                    return null;
                }
        }
    }
}
