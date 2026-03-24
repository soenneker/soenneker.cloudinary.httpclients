using Soenneker.Cloudinary.HttpClients.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Cloudinary.HttpClients.Tests;

[Collection("Collection")]
public sealed class CloudinaryOpenApiHttpClientTests : FixturedUnitTest
{
    private readonly ICloudinaryOpenApiHttpClient _httpclient;

    public CloudinaryOpenApiHttpClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _httpclient = Resolve<ICloudinaryOpenApiHttpClient>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
