namespace Addin {

    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using ServiceImpl;
    using ServiceInterfaces;

    public  class Startup : ServiceInterfaces.IAddInStartup
    {
        public string Name => "Default Service Implementation";

        public void ConfigureServices(IConfiguration configuration, IServiceCollection services) {
             services.AddScoped<ISampleService, SampleService>();             
        }
        
    }   
}