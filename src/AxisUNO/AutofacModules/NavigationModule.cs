using Autofac;
using AxisUNO.Application.Services.Navigation;
using AxisUNO.Presentation.Views.MainViews;
using AxisUNO.Services.Navigation;
using Microsoft.UI.Xaml;

namespace AxisUNO.AutofacModules;

internal class NavigationModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterInstance(App.MainWindow).As<Window>();

        builder.RegisterType<ViewsService>().As<IViewsService>().InstancePerLifetimeScope();
        builder.RegisterType<NavigationViewService>().As<INavigationViewService>().InstancePerLifetimeScope();
        builder.RegisterType<NavigationService>().As<INavigationService>().InstancePerLifetimeScope();

        builder.RegisterType<MainView>().InstancePerDependency();
    }
}