namespace EnvironmentsAndErrors.Services;

using EnvironmentsAndErrors.Models;

public interface IConnectionStringsService
{
    ConnectionStrings ConnectionStrings { get; }
}

public class ConnectionStringsService : IConnectionStringsService
{
    public ConnectionStrings ConnectionStrings { get; private set; } = new();

    public ConnectionStringsService(IConfiguration configuration) => 
        configuration.GetSection(nameof(this.ConnectionStrings)).Bind(this.ConnectionStrings);
}
