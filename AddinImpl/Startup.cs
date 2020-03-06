
namespace Addin
{
   using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public  class Startup : ServiceInterfaces.IAddInStartup
    {
        public string Name => "Addin Implementation";

        public void ConfigureServices(IConfiguration configuration, IServiceCollection services) {   
             services.AddScoped<ServiceInterfaces.Addins.Addin1, AddinImpl.WaitingControl>();            
        }
        
    }   
}
