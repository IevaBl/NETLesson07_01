// See https://aka.ms/new-console-template for more information
/* Sukurti struktūrą BibliotekosKyga su laukais ID,
 * pavadinimas,  skaitytojo vardas, paėmimo data.
 * Struktūroje sukurti metodą, kuris gražina kiek dienų knyga jau pas skaitytoją.
 * Padaryti kintamąjį, rezultatą išvesti į konsolę. */

BibliotekosKnyga knyga1 = new BibliotekosKnyga("135gat369", "Naujoji Zeme", "Ieva", new DateTime(2022,08,01));
Console.WriteLine($"Knygos Id: {knyga1.ID}");
Console.WriteLine($"Knygos pavadinimas:{knyga1.Pavadinimas}");
Console.WriteLine($"Skaitytojo vardas: {knyga1.SkaitytojoVardas}");
Console.WriteLine($"Knygos paemimo data: {knyga1.Data}");
Console.WriteLine($"knyga pas skaitytoja yra: {knyga1.Laikas()} dienas");
struct BibliotekosKnyga
{
    public string ID;
    public string Pavadinimas;
    public string SkaitytojoVardas;
    public DateTime Data;
    
    public BibliotekosKnyga(string id, string pavadinimas, string skaitytojoVardas, DateTime data)
    {
        ID = id;
        Pavadinimas = pavadinimas;
        SkaitytojoVardas = skaitytojoVardas;
        Data = data;
    }


    public int Laikas()
    {
        return (DateTime.Today - Data).Days;
    }
}
