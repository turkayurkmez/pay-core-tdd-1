using Community.Entities;

namespace Community.Application
{
    public class RealSpeakerService : ISpeakerService
    {
        private List<Speaker> speakers;
        public RealSpeakerService()
        {
            speakers = new List<Speaker> {
                new Speaker(){ FirstName ="A", LastName="B" },
                new Speaker(){ FirstName ="A", LastName="C" },
                new Speaker(){ FirstName ="A", LastName="D" },
                };
        }
        public List<Speaker> GetSpeakers()
        {
            return speakers;
        }

        public List<Speaker> GetSpeakersByName(string name)
        {
            return speakers.Where(sp => sp.FirstName.Contains(name)).ToList();
        }
    }
}
