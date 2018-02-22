using Microsoft.AspNetCore.Mvc;

namespace Prerequisites
{
    public class Controller
    {
        [HttpGet]
        [Route("")]
        public string Get() => "I'm installing dependencies";
    }
}