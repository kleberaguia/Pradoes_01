using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Xml.Linq;

namespace CrossCutting
{
    public static class AppDenpendencyInjection
    {



        public static IServiceCollection AddInfraStructure(this IServiceCollection services, IConfiguration configure)
        {
    
            var builder = Configurations();
            configure = builder.Build();
            var MySqlConnection =  configure.GetValue<string>("ConnectionStrings:DefaultConnection");       
            return services;
        }


        public static string NameSpacesConsole()
        {
            var builder = Configurations();
            IConfiguration configure = builder.Build();
            return configure.GetValue<string>("nameSpaces:EntidadesClass");
        }


        public static IConfigurationBuilder Configurations()
        {
            var builder = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return builder;
        }

    }
}
