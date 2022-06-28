// using System.IO;

string tiedosto = @"C:\Academy\Turku\DotNet\Luvut.txt";
string[] rivit = File.ReadAllLines(tiedosto);

int summa = 0;
foreach (string rivi in rivit)
{
    // Console.WriteLine(rivi);
    int luku = int.Parse(rivi);
    summa += luku;  // summa = summa + luku;
}

Console.WriteLine($"Summa on: {summa}.");
Console.ReadLine();

/*
string luku = "1234";
int summa = 100 + int.Parse(luku);
*/
