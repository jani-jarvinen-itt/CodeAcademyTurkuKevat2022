// Harjoitus 1 (kalvo 19)
int n = 0;
while (n < 5)
{
    Console.WriteLine(n);
    n++; // n = n + 1;
}

// Harjoitus 2
Console.WriteLine("-------------");
string a = "abcd";
string b = "abcd";

if (a == b)
{
    Console.WriteLine("Merkkijonojen sisältö on sama!");
}

// Harjoitus 3
Console.WriteLine("-------------");
int luku1 = 100;
int luku2 = 200;

if (luku1 != luku2)
// if (!(luku1 == luku2))
// if (luku1 is not luku2)
{
    Console.WriteLine("Luvut 1 ja 2 ovat erisuuret!");
}

// Harjoitus 4
Console.WriteLine("-------------");
byte henkilö1 = 200;
byte henkilö2 = 100;

byte iätYhteensä = (byte)(henkilö1 + henkilö2);
Console.WriteLine(iätYhteensä);


// Harjoitus 5
Console.WriteLine("-------------");

/*
public string SanoMoi()
{
    return "Moi Turku!";
}

public string SanoMoi() => "Moi Turku!";
*/

// tietotyypit
int muuttuja = 1234;

muuttuja = "ABCD"; // <-- virhe
