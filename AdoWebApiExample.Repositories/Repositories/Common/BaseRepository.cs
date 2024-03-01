using Microsoft.Extensions.Configuration;

namespace AdoWebApiExample.Repositories.Repositories.Common;

public class BaseRepository
{
    private readonly IConfiguration _configuration;
    public BaseRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string? GetConnectionString()
    {
        return _configuration.GetConnectionString("LocalConnection");
    }

}
