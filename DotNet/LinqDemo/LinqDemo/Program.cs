int[] luvut = { 1, 2, 3, 4 };

/*
int summa = 0;
for (int i = 0; i < luvut.Length; i++)
{
    int luku = luvut[i];
    summa += luku;
}
*/

int summa = luvut.Sum();
double keskiarvo = luvut.Average();

Console.WriteLine(summa);
Console.WriteLine(keskiarvo);
Console.WriteLine("---------------------------------");

// ---------------------------------
int[] satunnaiset = { 5, 10, 7, 2, 3, 9, 11, 6, 1, 9, 2 };

/*
Array.Sort(satunnaiset);
foreach (int luku in satunnaiset)
{
    if (luku > 5)
    {
        Console.WriteLine(luku);
    }
}
*/

/*
// LINQ-kysely (kyselysyntaksi -> query syntax)
var viittäSuuremmat = from luku in satunnaiset
                      where luku > 5
                      orderby luku
                      select luku;
foreach (int luku in viittäSuuremmat)
{
    Console.WriteLine(luku);
}
*/

// LINQ-kysely (metodisyntaksi -> method syntax)
var viittäSuuremmat =
    satunnaiset.Where(x => x > 5).OrderBy(x => x);
foreach (int luku in viittäSuuremmat)
{
    Console.WriteLine(luku);
}
