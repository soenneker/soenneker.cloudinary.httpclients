[![](https://img.shields.io/nuget/v/soenneker.cloudinary.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.cloudinary.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.cloudinary.httpclients/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.cloudinary.httpclients/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.cloudinary.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.cloudinary.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.cloudinary.httpclients/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.cloudinary.httpclients/actions/workflows/codeql.yml)

# Soenneker.Cloudinary.HttpClients

Provides an owned, configured `HttpClient` for Cloudinary's generated OpenAPI client.

## Installation

```bash
dotnet add package Soenneker.Cloudinary.HttpClients
```

## Configuration

```json
{
  "Cloudinary": {
    "ApiKey": "your-api-token",
    "ClientBaseUrl": "https://api.cloudinary.com",
    "AuthHeaderName": "Authorization",
    "AuthHeaderValueTemplate": "Bearer {token}"
  }
}
```

`ApiKey` is required. The other values show their defaults. `{token}` in the header template is replaced with the configured key, allowing integrations that require a different authorization scheme. Keep the resulting credential in a secret provider.

## Registration and usage

```csharp
using Soenneker.Cloudinary.HttpClients.Abstract;
using Soenneker.Cloudinary.HttpClients.Registrars;

services.AddCloudinaryOpenApiHttpClientAsSingleton();

HttpClient httpClient = await clientProvider.Get(cancellationToken);
```

`Get` returns the same client for the lifetime of the provider instance. It has the configured base address and authorization header but does not expose Cloudinary resource-specific convenience methods; `Soenneker.Cloudinary.OpenApiClientUtil` is the normal entry point for generated API operations.

The provider owns its cached client. Do not dispose the returned `HttpClient` directly. Let dependency injection dispose `ICloudinaryOpenApiHttpClient`, which removes and disposes that exact cache entry. Scoped providers use isolated entries, so disposing one scope does not tear down another provider's client.
