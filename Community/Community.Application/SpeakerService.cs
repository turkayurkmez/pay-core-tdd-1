using Community.Entities;

namespace Community.Application
{
    public class SpeakerService : ISpeakerService
    {
        public List<Speaker> GetSpeakers()
        {
            return new List<Speaker>()
            {
                 new(){ FirstName="Murat", LastName="Muratoğlu"},
                 new(){ FirstName="Mahmut", LastName="Tuncer"},
                 new(){ FirstName="Mehmet", LastName="Ekici"},

            };
        }

        public List<Speaker> GetSpeakersByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}