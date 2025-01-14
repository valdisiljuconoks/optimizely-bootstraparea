using AlloySampleSite.Business;
using AlloySampleSite.Business.Channels;
using AlloySampleSite.Business.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection;

namespace AlloySampleSite.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAlloy(this IServiceCollection services)
        {
            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.ViewLocationExpanders.Add(new SiteViewEngineLocationExpander());
            });

            services.Configure<MvcOptions>(options =>
            {
                options.Filters.Add<PageContextActionFilter>();
            });

            services.AddDisplayResolutions();
            services.AddDetection();

            return services;
        }

        private static void AddDisplayResolutions(this IServiceCollection services)
        {
            services.AddSingleton<StandardResolution>();
            services.AddSingleton<IpadHorizontalResolution>();
            services.AddSingleton<IphoneVerticalResolution>();
            services.AddSingleton<AndroidVerticalResolution>();
        }

    }
}
