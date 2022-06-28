public class Henkilö
{
    // ominaisuus eli property
    public string Name { get; set; } = "";

    // metodi
    public void SanoMoi() 
    {
        Console.WriteLine($"Moi {Name}!");
    }
}