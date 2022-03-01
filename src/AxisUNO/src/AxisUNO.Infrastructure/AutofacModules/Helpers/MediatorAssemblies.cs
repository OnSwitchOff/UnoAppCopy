using System.Reflection;
using AxisUNO.Application.ViewModels.MainViewModels;

namespace AxisUNO.Infrastructure.AutofacModules.Helpers;

internal static class MediatorAssemblies
{
    internal static readonly Assembly ApplicationLayer = typeof(MainViewModel).Assembly;
}