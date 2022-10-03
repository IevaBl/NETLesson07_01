// See https://aka.ms/new-console-template for more information
/* Sukurti struktūrą Stačiakampis su laukais ilgis ir plotis.
 * Struktūroje sukurti metodą Plotas(). 
 * Sukurti 3 kintamuosius stčiakampis1-staciakamis3,
 * užpildyti laukus ir išvesti plotus į konsolę. */

Staciakampis staciakampis1 = new Staciakampis(15, 10);
Staciakampis staciakampis2 = new Staciakampis(25, 5);
Staciakampis staciakampis3 = new Staciakampis(14, 8);
Console.WriteLine(staciakampis1.Ilgis);
Console.WriteLine(staciakampis1.Plotis);
Console.WriteLine(staciakampis1.Plotas(staciakampis1.Ilgis, staciakampis1.Plotis));
Console.WriteLine(staciakampis1.Plotas(staciakampis2.Ilgis, staciakampis2.Plotis));
Console.WriteLine(staciakampis1.Plotas(staciakampis3.Ilgis, staciakampis3.Plotis));
struct Staciakampis
{
    public double Ilgis;
    public double Plotis;

    public Staciakampis(double ilgis, double plotis)
    {
        Ilgis = ilgis;
        Plotis = plotis;
        
    }

    internal double Plotas(double ilgis, double plotis)
    {
        return ilgis * plotis;
    }

}
