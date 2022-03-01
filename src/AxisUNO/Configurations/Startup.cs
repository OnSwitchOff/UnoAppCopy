using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using AxisUNO.Application.AutofacModules;
using AxisUNO.AutofacModules;
using AxisUNO.Configurations.Database;
using AxisUNO.Database.AutofacModules;
using AxisUNO.Infrastructure.AutofacModules;

namespace AxisUNO.Configurations;

internal static class Startup
{
    internal static IServiceProvider ConfigureServices()
    {
        var builder = new ContainerBuilder();

        builder.RegisterModule<ActivationModule>();

        builder.RegisterModule<NavigationModule>();

        builder.RegisterModule<LoggingModule>();

        builder.RegisterModule<MediatorModule>();

        builder.RegisterModule<ProcessingModule>();

        builder.RegisterModule<ApplicationServicesModule>();

        builder.RegisterModule(
            new DatabaseModule(
                DatabaseConfiguration.GetOprions()));

        return new AutofacServiceProvider(builder.Build());
    }
}