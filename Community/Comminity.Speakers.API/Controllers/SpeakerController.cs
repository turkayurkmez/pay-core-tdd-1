using Community.Application;
using Microsoft.AspNetCore.Mvc;

namespace Comminity.Speakers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpeakerController : ControllerBase
    {
        private readonly ISpeakerService speakerService;

        public SpeakerController(ISpeakerService speakerService)
        {
            this.speakerService = speakerService;
        }
        [HttpGet("{keyword}")]
        public IActionResult Search(string keyword)
        {
            var speakers = speakerService.GetSpeakersByName(keyword);

            //  var result = speakers.Where(speaker => speaker.FirstName == keyword).ToList();
            return Ok(speakers);
        }
    }
}
