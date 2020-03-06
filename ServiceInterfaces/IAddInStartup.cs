using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ServiceInterfaces
{
    public interface IAddInStartup
    {
        void ConfigureServices(IConfiguration configuration, IServiceCollection services);

        string Name {get;}
    }
}