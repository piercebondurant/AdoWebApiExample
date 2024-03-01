﻿using AdoWebApiExample.Repositories.Repositories.Common;
using Microsoft.Extensions.Configuration;

namespace AdoWebApiExample.Repositories.Repositories;

public class ExampleRepository : BaseRepository
{
    public ExampleRepository(IConfiguration configuration) : base(configuration) { }

    public async Task<int> Create()
    {
        var connectionString = GetConnectionString();
        return -1;
    }
}
