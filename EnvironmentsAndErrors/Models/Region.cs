namespace EnvironmentsAndErrors.Models;

public class Region
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public IEnumerable<City>? Cities { get; set; }
}
