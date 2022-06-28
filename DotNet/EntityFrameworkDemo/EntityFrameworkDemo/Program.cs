using EntityFrameworkDemo.Models;

NorthwindContext konteksti = new();

// LINQ-kysely (kyselysyntaksi)
var suomalaiset = from a in konteksti.Customers
                  where a.Country == "Finland"
                  select a;

// sama LINQ-kysely, mutta metodisyntaksilla
var suomalaiset2 = konteksti.Customers.
    Where(a => a.Country == "Finland");

//foreach (Customer asiakas in suomalaiset2)
foreach (Customer asiakas in suomalaiset)
{
    Console.Write(asiakas.CompanyName);
    Console.Write(" => ");
    Console.WriteLine(asiakas.Country);
}

/*   *** Huonoa, joskin toimivaa koodia. ***
foreach (Customer asiakas in konteksti.Customers)
{
    if (asiakas.Country == "Finland")
    {
        Console.Write(asiakas.CompanyName);
        Console.Write(" => ");
        Console.WriteLine(asiakas.Country);
    }
}
*/















/*
int[] luvut = {1, 2, 3, 4, 5 };
for (int i = 0; i < luvut.Length; i++)
{
    int luku = luvut[i];
}

foreach (int luku in luvut)
{
    Console.WriteLine(luku);
}*/