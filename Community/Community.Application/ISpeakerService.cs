using Community.Entities;

namespace Community.Application
{
    public interface ISpeakerService
    {
        List<Speaker> GetSpeakers();
        List<Speaker> GetSpeakersByName(string name);
    }
}