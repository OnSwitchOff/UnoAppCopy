using Autofac;
using AxisUNO.Application.Services.Activation;
using AxisUNO.Services.Activation;
using AxisUNO.Services.Activation.Handlers;
using BuildingBlocks.Application.Services.Activation.Handlers;
using Microsoft.UI.Xaml;

namespace AxisUNO.AutofacModules;

public sealed class ActivationModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<ActivationService>().As<IActivationService>().InstancePerLifetimeScope();

        builder.RegisterType<DefaultActivationHandler>().As<ActivationHandler<LaunchActivatedEventArgs>>().InstancePerDependency();
    }
}