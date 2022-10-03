// See https://aka.ms/new-console-template for more information

/* Sukurti struktūrą Studentas, su laukais ID ir įskaitos rezultatas (bool). 
 * Sukurti studentų sąrašą List<Studentas>, pridėti 5 studentus į sąrašą. 
 * Atskiroje funkcijoje išvesti sąrašą į konsolę. */

static void AtspausdinkSarasa(List<Studentas> studentas)
{
    foreach(Studentas elem in studentas)
    {
        Console.WriteLine($"Id yra lygus : {elem.Id}, Rezultatas: {elem.Rezultatas}");
    }    
}

List<Studentas> studentas = new List<Studentas>();
studentas.Add(new Studentas(123, true));
studentas.Add(new Studentas(124, false));
studentas.Add(new Studentas(125, false));
studentas.Add(new Studentas(126, true));
studentas.Add(new Studentas(127, false));

AtspausdinkSarasa(studentas);

struct Studentas
{
    public int Id;
    public bool Rezultatas;

    public Studentas(int id, bool rezultatas)
    {
        Id = id; 
        Rezultatas = rezultatas;
    }
 }


