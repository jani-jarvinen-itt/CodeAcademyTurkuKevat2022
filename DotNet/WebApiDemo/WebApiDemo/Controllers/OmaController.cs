using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Mallit;

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

        [HttpGet]
        [Route("henkilöt")]
        public List<Henkilö> PalautaKaikkiHenkilöt()
        {
            return new()
            {
                new()
                {
                    HenkilöId = 123,
                    Nimi = "Teppo Testaaja",
                    Kengännumero = 43
                },
                new()
                {
                    HenkilöId = 234,
                    Nimi = "Teija Testaaja",
                    Kengännumero = 39
                }
            };
        }
    }
}
