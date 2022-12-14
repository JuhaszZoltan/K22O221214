using BukkMaraton2019;
const int IndulokSzama = 691;

List<Versenyzo> versenyzok = new();
StreamReader sr = new("..\\..\\..\\RES\\bukkm2019.txt");
_ = sr.ReadLine();
while (!sr.EndOfStream) versenyzok.Add(new Versenyzo(sr.ReadLine()!));

Console.WriteLine("4. feladat: " +
    $"Versenytávot nem teljesítők: {100 - (versenyzok.Count / (double)IndulokSzama * 100)}%");

int nvszrv = versenyzok.Count(x => x.Kategoria.Last() == 'n' && x.Tav == "Rövid");
Console.WriteLine("5. feladat: " +
    $"Női versenyzők száma a rövid távú versenyen: {nvszrv} fő");

bool vtm6o = versenyzok.Any(x => x.Ido.TotalHours >= 6);
Console.WriteLine("6. feladat: " +
    (vtm6o ? "Volt ilyen versenyző" : "Nem volt ilyen versenyző"));

Versenyzo ffrgy = versenyzok.Where(x => x.Kategoria == "ff" && x.Tav == "Rövid")
    .OrderBy(x => x.Ido).First();
Console.WriteLine("7. feladat: " +
    "A felnőtt férfi (ff) kategóriagyőztese rövid távon:\n" +
    $"\tRajtszám: {ffrgy.Rajtszam}\n" +
    $"\tNév: {ffrgy.Nev}\n" +
    (ffrgy.Egyesulet is not null ? $"\tEgyesület: {ffrgy.Egyesulet}\n" : null) + 
    $"\tIdő: {ffrgy.Ido}");

var fks = versenyzok.Where(x => x.Kategoria.Last() == 'f')
    .GroupBy(x => x.Kategoria)
    .ToDictionary(x => x.Key, x => x.Count());
Console.WriteLine("8. feladat: Statisztika");
foreach (var kvp in fks) Console.WriteLine($"\t{kvp.Key, -4} - {kvp.Value, 3} fő");