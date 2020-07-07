using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;


namespace DistanceCalculator.Extensions
{
    public static class ServiceExtensions
    {
        // CORS configuration to allow access from any origin
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
        }

        // IIS configuration for IIS deployment. Default initalization properties are applied
        // AutomaticAuthentication: true, AuthenticationDisplayName: null, ForwardClientCertificate: true
        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {

            });
        }
    }
}
