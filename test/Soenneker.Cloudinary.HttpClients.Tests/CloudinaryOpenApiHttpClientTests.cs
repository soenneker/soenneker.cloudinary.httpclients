using Soenneker.Cloudinary.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Cloudinary.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class CloudinaryOpenApiHttpClientTests : HostedUnitTest
{
    private readonly ICloudinaryOpenApiHttpClient _httpclient;

    public CloudinaryOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<ICloudinaryOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
