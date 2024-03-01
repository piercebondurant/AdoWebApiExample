using Microsoft.Extensions.Configuration;

namespace AdoWebApiExample.Repositories.Repositories.Common;

public class BaseRepository
{
    private readonly IConfiguration _configuration;
    protected readonly string DB_CONNECTION_STRING;
    public BaseRepository(IConfiguration configuration)
    {
        _configuration = configuration;
        DB_CONNECTION_STRING = GetConnectionString();
    }

    private string? GetConnectionString()
    {
        return _configuration.GetConnectionString("LocalConnection");
    }

}
