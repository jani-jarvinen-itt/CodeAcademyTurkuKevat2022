using PalkkatiedotXmlJsonKonversio;
using System.Text.Json;
using System.Xml.Linq;

// vaihe 1: USD-valuuttakurssin luku XML-tiedostosta
string tiedostoNimi = @"C:\Academy\Turku\DotNet\PalkkatiedotXmlJsonKonversio\PalkkatiedotXmlJsonKonversio\Aineisto\Valuuttakurssi.xml";
XDocument xmlDokumentti = XDocument.Load(tiedostoNimi);

XNamespace gesmes = "http://www.gesmes.org/xml/2002-08-01";
XNamespace ns = "http://www.ecb.int/vocabulary/2002-08-01/eurofxref";
var cubes = xmlDokumentti.Descendants(ns + "Cube")
               .Where(x => x.Attribute("currency") != null)
               .Select(x => new
               {
                   Currency = (string)x.Attribute("currency"),
                   Rate = (double)x.Attribute("rate")
               });

double usdKurssi = 0.0;
foreach (var result in cubes)
{
    // Console.WriteLine($"{result.Currency}: {result.Rate}");
    if (result.Currency == "USD")
    {
        usdKurssi = result.Rate;
        break;
    }
}
Console.WriteLine(usdKurssi);

// vaihe 2: palkkatietojen luku XML-tiedostosta
tiedostoNimi = @"C:\Academy\Turku\DotNet\PalkkatiedotXmlJsonKonversio\PalkkatiedotXmlJsonKonversio\Aineisto\Palkanlaskenta.xml";
xmlDokumentti = XDocument.Load(tiedostoNimi);
var työntekijät = xmlDokumentti.Descendants("palkka")
               .Select(x => new
               {
                   PersonName = (string)x.Descendants("nimi").First(),
                   Salary = (double)x.Descendants("kuukausittain").First(),
                   HireDate = (string)x.Descendants("työsuhdealkoi").FirstOrDefault()
               });

// muunnetaan luettu XML-data olioksi
List<Palkkatiedot> tiedot = new();
foreach (var työntekijä in työntekijät)
{
    tiedot.Add(new Palkkatiedot()
    {
        personName = työntekijä.PersonName,
        hiredate = työntekijä.HireDate,
        salary = new Kuukausipalkka()
        {
            monthly = työntekijä.Salary * usdKurssi
        }
    });
}

// vaihe 3: palkkatietojen kirjoitus JSON-muotoon
string json = JsonSerializer.Serialize(tiedot);
Console.WriteLine(json);
