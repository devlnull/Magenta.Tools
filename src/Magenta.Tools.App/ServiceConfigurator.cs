using Magenta.Tools.Text;
using Magenta.Tools.Text.Distinct;

namespace Magenta.Tools.App
{
    public static class ServiceConfigurator
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddTransient<ITextTransformer, TextDistinctTransformer>();
            services.AddTransient<ITextTransformerFactory, DistinctTransformerFactory>();

            return services;
        }
    }
}
