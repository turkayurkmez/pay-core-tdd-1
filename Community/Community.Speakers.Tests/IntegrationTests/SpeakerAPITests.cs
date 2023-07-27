using System.Net;

namespace Community.Speakers.Tests.IntegrationTests
{
    public class SpeakerAPITests : IClassFixture<InMemoryApplicationFactory<Program>>
    {
        private readonly InMemoryApplicationFactory<Program> _factory;
        public SpeakerAPITests(InMemoryApplicationFactory<Program> factory)
        {
            _factory = factory;
        }
        [Fact]
        public async Task Get_Speakers_ByName()
        {
            var client = _factory.CreateClient();
            var response = await client.GetAsync("/api/speaker/A");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }

}
