using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Threading.Tasks;
using Xunit;

namespace End2EndTests.Tests
{
    public class GetUserTests : IClassFixture<WebApplicationFactory<WebApi.Startup>>
    {
        private readonly string _url = "/api/v1/Users/";
        private readonly WebApplicationFactory<WebApi.Startup> _factory;

        public GetUserTests(WebApplicationFactory<WebApi.Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GetUser_ExistingUser_ShouldReturnUser()
        {
            // Arrange
            var userGuid = Guid.Parse("1f26b2d6-42a6-4c58-a23a-3c00dd54f349");
            var url = _url + userGuid;
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync(url);

            // Assert
            response.EnsureSuccessStatusCode();
        }
    }
}
