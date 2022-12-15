using Autofac;
using PasswordStorage.Web.Configurations.Autofac.Modules;

namespace PasswordStorage.Web.Configurations.Autofac
{
    public static class AutofacBuilder
    {
        public static void LoadBuilders(this ContainerBuilder containerBuilder, IEnumerable<IGeneralModule> builders)
        {
            foreach (var builder in builders)
            {
                builder.Build(containerBuilder);
            }
        }
    }
}
