// using System.Net.Http;

// ** vaihe 1: luetaan HTML-koodi
HttpClient client = new HttpClient();
string url = "https://yle.fi/saa/suomi/turku/";
string html = await client.GetStringAsync(url);
// string html = client.GetStringAsync(url).Result;
Console.WriteLine(html[..500]);

// ** vaihe 2: etsitään HTML-koodista lämpötilatieto
string[] rivit = html.Split('\n');
Console.WriteLine(rivit.Length);

foreach (string rivi in rivit)
{
    if (rivi.StartsWith("<span class=\"feelslike\">"))
    {
        Console.WriteLine(rivi);
        break;
        // return;
    }
}

Console.WriteLine("Suoritus päättyy.");
