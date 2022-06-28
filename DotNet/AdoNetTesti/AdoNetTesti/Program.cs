using System.Data.SqlClient;

// yhteysden avaaminen Northwind-tietokantaa
string yhteysMerkkijono =
    @"Server=localhost\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;";
SqlConnection yhteys = new(yhteysMerkkijono);
yhteys.Open();

// valmistellaan SQL-komento
string sql = "SELECT CompanyName FROM Customers WHERE Country = 'Finland'";
SqlCommand komento = new(sql, yhteys);

// suoritetaan SQL-komento
SqlDataReader lukija = komento.ExecuteReader();
while (lukija.Read())
{
    string tyyppi = lukija.GetDataTypeName(0);
    Console.Write(tyyppi + ": ");

    // Console.WriteLine(lukija.GetString(0));
    // Console.WriteLine(lukija.GetInt32(2));
    Console.WriteLine(lukija["CompanyName"]);
}
