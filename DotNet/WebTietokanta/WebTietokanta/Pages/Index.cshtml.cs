using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebTietokanta.Models;

namespace WebTietokanta.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<string> Asiakasnimet { get; set; }

        public void OnGet()
        {
            NorthwindContext konteksti = new();
            var suomalaiset = from a in konteksti.Customers
                              where a.Country == "Finland"
                              select a;

            Asiakasnimet = new();
            foreach (Customer asiakas in suomalaiset)
            {
                Asiakasnimet.Add(asiakas.CompanyName);
            }
        }
    }
}