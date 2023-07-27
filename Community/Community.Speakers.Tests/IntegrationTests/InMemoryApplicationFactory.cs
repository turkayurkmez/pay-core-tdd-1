using Community.Application;
using Community.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace Community.Speakers.Tests.IntegrationTests
{
    public class InMemoryApplicationFactory<T> : WebApplicationFactory<T> where T : class
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.UseEnvironment("Testing")
                   .ConfigureTestServices(sp =>
                   {
                       Mock<ISpeakerService> mockSpeakerService = new Mock<ISpeakerService>();
                       Speaker speaker = new Speaker { FirstName = "Mock", LastName = "Speaker" };

                       mockSpeakerService.Setup(sp => sp.GetSpeakersByName(It.IsAny<string>())).Returns(() => new List<Speaker>() { speaker });
                       sp.AddScoped(mockSpeakerService.Object.GetType());
                   });
        }
    }
}
