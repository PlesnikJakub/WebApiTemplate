using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests
{
    public class UnitTest1 : IClassFixture<WebApplicationFactory<WebApi.Startup>>
    {
        private readonly WebApplicationFactory<WebApi.Startup> _factory;

        public UnitTest1(WebApplicationFactory<WebApi.Startup> factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData("/api/v1/Users")]
        public async Task Test1(string url)
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync(url);

            // Assert
            response.EnsureSuccessStatusCode();
        }
    }
}
