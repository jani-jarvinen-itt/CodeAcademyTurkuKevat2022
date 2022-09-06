using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Mallit;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestausController : ControllerBase
    {
        [HttpGet]
        [Route("kellonaika")]
        public DateTime Kellonaika()
        {
            return DateTime.Now;
        }

        [HttpGet]
        [Route("luvut")]
        public int[] Luvut()
        {
            int[] luvut = { 1, 3, 5, 7, 9 };
            return luvut;
        }

        [HttpGet]
        [Route("anonyymi")]
        public object AnonyymiOlio()
        {
            return new
            {
                Ominaisuus1 = 9876,
                Ominaisuus2 = "ABCD"
            };
        }

        [HttpGet]
        [Route("parametritesti/{asiakasId:int}")]
        public int[] ParametriTesti(int asiakasId)
        {
            int[] luvut = { 1, 3, 5, 7, 9 };
            luvut[0] = asiakasId;

            return luvut;
        }

        [HttpPost]
        [Route("datasisään")]
        public string DatanLukuSisään(SisääntulevaData data)
        {
            return $"Moi {data.Nimi}! Soitan sinulle pian numeroon {data.Puhelinnumero}.";
        }
    }
}
