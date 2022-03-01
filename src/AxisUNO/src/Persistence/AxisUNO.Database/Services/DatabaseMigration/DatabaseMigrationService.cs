﻿using BuildingBlocks.Application.Services.DatabaseMigration;
using HarabaSourceGenerators.Common.Attributes;
using Microsoft.EntityFrameworkCore;

namespace AxisUNO.Database.Services.DatabaseMigration;

[Inject]
public partial class DatabaseMigrationService : IDatabaseMigrationService
{
    private readonly DatabaseContext _context;

    public async Task MigrateAsync()
    {
        await _context.Database.MigrateAsync();
    }
}