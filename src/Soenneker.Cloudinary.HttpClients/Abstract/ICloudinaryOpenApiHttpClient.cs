using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace Soenneker.Cloudinary.HttpClients.Abstract;

/// <summary>
/// Provides an owned, configured <see cref="HttpClient"/> for the Cloudinary OpenAPI client.
/// </summary>
public interface ICloudinaryOpenApiHttpClient: IDisposable, IAsyncDisposable
{
    /// <summary>
    /// Gets the HTTP client owned by this provider instance.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A task containing the result of the operation.</returns>
    ValueTask<HttpClient> Get(CancellationToken cancellationToken = default);
}
