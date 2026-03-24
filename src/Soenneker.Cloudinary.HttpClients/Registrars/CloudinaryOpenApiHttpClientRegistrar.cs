using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Cloudinary.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.Cloudinary.HttpClients.Registrars;

/// <summary>
/// Registers the OpenAPI HttpClient wrapper for dependency injection.
/// </summary>
public static class CloudinaryOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds <see cref="CloudinaryOpenApiHttpClient"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddCloudinaryOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<ICloudinaryOpenApiHttpClient, CloudinaryOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="CloudinaryOpenApiHttpClient"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddCloudinaryOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<ICloudinaryOpenApiHttpClient, CloudinaryOpenApiHttpClient>();

        return services;
    }
}
