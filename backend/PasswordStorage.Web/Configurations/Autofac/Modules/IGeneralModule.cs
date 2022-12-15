using Autofac;

namespace PasswordStorage.Web.Configurations.Autofac.Modules
{
    public interface IGeneralModule
    {
        void Build(ContainerBuilder builder);
    }
}
