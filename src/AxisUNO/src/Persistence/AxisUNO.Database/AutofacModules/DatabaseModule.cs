using Autofac;
using AxisUNO.Database.Domain.Products;
using AxisUNO.Database.Domain.UnitOfWorks.DataStorage;
using AxisUNO.Database.Domain.UnitOfWorks.DomainEventsDispatching;
using AxisUNO.Database.Services.DatabaseMigration;
using AxisUNO.Domain.Products;
using BuildingBlocks.Application.Services.DatabaseMigration;
using BuildingBlocks.Infrastructure.Domain.UnitOfWorks.DataStorage;
using BuildingBlocks.Infrastructure.Domain.UnitOfWorks.DomainEventsDispatching;
using Microsoft.EntityFrameworkCore;

namespace AxisUNO.Database.AutofacModules;

public sealed class DatabaseModule : Module
{
    private readonly DbContextOptions<DatabaseContext> _dbContextOptions;

    public DatabaseModule(DbContextOptions<DatabaseContext> dbContextOptions)
    {
        _dbContextOptions = dbContextOptions;
    }

    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<DatabaseContext>().WithParameter("options", _dbContextOptions).SingleInstance();

        builder.RegisterType<DomainEventsProvider>().As<IDomainEventsProvider>().InstancePerLifetimeScope();
        builder.RegisterType<DatabaseMigrationService>().As<IDatabaseMigrationService>().InstancePerLifetimeScope();
        builder.RegisterType<DataStorage>().As<IDataStorage>().InstancePerLifetimeScope();

        builder.RegisterType<ProductRepository>().As<IProductRepository>().InstancePerLifetimeScope();
    }
}