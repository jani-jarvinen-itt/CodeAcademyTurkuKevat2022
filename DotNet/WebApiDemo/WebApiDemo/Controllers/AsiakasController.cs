﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Entities;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsiakasController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public List<Customer> KaikkiAsikkaat()
        {
            NorthwindContext context = new();
            List<Customer> asiakkaat = context.Customers.ToList();

            return asiakkaat;
        }

        [HttpGet]
        [Route("{asiakasId}")]
        public Customer YksiAsiakas(string asiakasId)
        {
            NorthwindContext context = new();
            Customer asiakas = context.Customers.Find(asiakasId)!;

            return asiakas;
        }
    }
}
