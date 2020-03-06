namespace WpfNetCore.Addins
{
    using System;
    using System.IO;
    using System.Reflection;
    using System.Runtime.Loader;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using ServiceInterfaces;

    public class AddinManager {

        public static void ConfigureServices(IConfiguration configuration, IServiceCollection services) {

            var addinConfiguration = configuration.GetSection(nameof(AddinConfiguration)).Get<AddinConfiguration>();

            foreach(var addinAssembly in addinConfiguration.AddinsDefinition.Split(';')) {
                var addin = AssemblyLoadContext.Default.LoadFromAssemblyPath(Path.Join(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), addinAssembly));                
                var myInstance = (IAddInStartup)Activator.CreateInstance(addin.GetType("Addin.Startup"));

                myInstance.ConfigureServices(configuration, services);
            }

        }
    }
}