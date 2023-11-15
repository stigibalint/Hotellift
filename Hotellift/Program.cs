using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Hotellift;

List<Lift> adatok = new List<Lift>();
try
{
    File.ReadAllLines("lift.txt").ToList().ForEach(x => adatok.Add(new Lift(x)));
}
catch (IOException e)
{
    Console.WriteLine($"Hiba történt a fájl olvasása közben: {e.Message}");
}

Console.WriteLine($"3. feladat: Összes lifthasználat: {adatok.Count}");

Console.WriteLine($"4. feladat: {adatok.MaxBy(x => x.Idopont).Idopont} - {adatok.MinBy(x => x.Idopont).Idopont}");

Console.WriteLine($"5. feladat: Célszint max: {adatok.Max(x => x.Celszint)}");


int kartyaBekeres = 0;
int celBekeres = 0;
try
{
    kartyaBekeres = Convert.ToInt32(Console.ReadLine());
    celBekeres = Convert.ToInt32(Console.ReadLine());
}
catch (Exception)
{
    kartyaBekeres = 5;
    celBekeres = 5; 

}
Console.WriteLine( $"6. feladat: \n\t Kártya száma: {kartyaBekeres} \n\t Célszint száma: {celBekeres}" );

    Console.WriteLine(adatok.Any(x => x.Kartyasorszam == kartyaBekeres && x.Celszint == celBekeres)
        ? $"7. feladat: A/Az {kartyaBekeres}. kártyával utaztak a/az {celBekeres} emeletre"
        : "7. feladat: Nem utaztak.");

File.WriteAllLines("statisztika.txt", adatok.GroupBy(x => x.Idopont).Select(x => $"\t{x.Key} - {x.Count()}x"));
