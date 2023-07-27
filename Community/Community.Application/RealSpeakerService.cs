using Community.Entities;

namespace Community.Application
{
    public class RealSpeakerService : ISpeakerService
    {
        public List<Speaker> GetSpeakers()
        {
            return new List<Speaker>();
        }

        public List<Speaker> GetSpeakersByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
