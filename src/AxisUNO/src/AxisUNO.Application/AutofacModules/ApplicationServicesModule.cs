using Autofac;
using AxisUNO.Application.ProdcutGroups;
using AxisUNO.Application.Services.ThemeSelector;
using AxisUNO.Application.ViewModels.DashboardViewModels;
using AxisUNO.Application.ViewModels.MainViewModels;
using AxisUNO.Application.ViewModels.ProductsViewModels;
using AxisUNO.Application.ViewModels.ProductViewModels;
using AxisUNO.Application.ViewModels.SettingsViewModels;
using AxisUNO.Domain.ProductGroups;

namespace AxisUNO.Application.AutofacModules;

public class ApplicationServicesModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<MainViewModel>().InstancePerDependency();
        builder.RegisterType<DashboardViewModel>().InstancePerDependency();
        builder.RegisterType<ProductsViewModel>().InstancePerDependency();
        builder.RegisterType<ProductViewModel>().InstancePerDependency();
        builder.RegisterType<SettingsViewModel>().InstancePerDependency();

        builder.RegisterType<ThemeSelectorService>().As<IThemeSelectorService>().InstancePerDependency();

        builder.RegisterType<GroupPathGenerator>().As<IGroupPathGenerator>().InstancePerDependency();

        base.Load(builder);
    }
}
