using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers
{
    [Route("xyz")]
    [ApiController]
    public class OmaController : ControllerBase
    {
        [HttpGet]
        [Route("aaa")]
        public string Moi()
        {
            return "Moikka!";
        }

        [HttpPut]
        [Route("bbb")]
        public string Terve()
        {
            return "Heissan!";
        }
    }
}
