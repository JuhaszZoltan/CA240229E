//elvis operator
//ismétlés nélküli generálás (majd a ciklusoknál)

// Lakcim();
// Fizetes();
// KorKerTer();
// Pitagorasz();
// TesttomegIndex();
// Bankjegyautomata();
// SzeretszProgramozni();
// Oszthato3Al();
// Szokoev();
// Veletlenek();
// VeletlenOsszeadas();

static void VeletlenOsszeadas()
{
    Random rnd = new();

    int a = rnd.Next(10, 51);
    int b = rnd.Next(10, 51);

    Console.Write($"{a} + {b} = ");
    int eredmeny = int.Parse(Console.ReadLine());

    if (eredmeny == a + b) Console.WriteLine("helyes!");
    else Console.WriteLine($"nem, a válasz {a + b} :(");
}
static void Veletlenek()
{
    Random rnd = new();

    // 64 bites, lebegőpontois szám 0 és 1 között:
    double rszm01 = rnd.NextDouble();

    //32 bites egész szám [minValue, maxValue) intervallumból.
    int rszm02 = rnd.Next(minValue: 100, maxValue: 200);

    //r31
    Console.WriteLine(rnd.Next(100, 1000));
    //r33/2
    Console.WriteLine(rnd.Next(150, 251) / 10f);
    //r34
    Console.WriteLine(rnd.Next(50) * 2);
    //r35
    Console.WriteLine(rnd.Next(20, 41) * 5);
}
static void Szokoev()
{
    //400 -> igen  //2000
    //100 -> nem   //1900
    //  4 -> igen  //2024
    //    -> nem   //2023

    Console.Write("írja be az évszámot: ");
    int ev = int.Parse(Console.ReadLine());

    //if (ev % 400 == 0) Console.WriteLine($"{ev} szökőév");
    //else if (ev % 100 == 0) Console.WriteLine($"{ev} nem szökőév");
    //else if (ev % 4 == 0) Console.WriteLine($"{ev} szökőév");
    //else Console.WriteLine($"{ev} nem szökőév");

    if ((ev % 400 == 0) || (ev % 4 == 0 && ev % 100 != 0)) Console.WriteLine("szökőév");
    else Console.WriteLine("nem szökőév");
}
static void Oszthato3Al()
{
    Console.Write("írjon be egy számot: ");
    if (int.Parse(Console.ReadLine()) % 3 == 0) Console.WriteLine("osztható 3-al");
    else Console.WriteLine("nem osztható 3al");
}
static void SzeretszProgramozni()
{
    string[] igenek = ["igen", "nagyon", "aha", "persze", "szeret", "yes", "ja"];
    
    Console.Write("Szia, hogy hívnak?\n - ");
    string nev = Console.ReadLine();
    Console.Write($"Szeretsz programozni {nev}?\n - ");
    string valasz = Console.ReadLine().ToLower();

    int i = 0;
    while (i < igenek.Length && !valasz.StartsWith(igenek[i])) i++;
    if (i < igenek.Length) Console.WriteLine("Akkor még sokra viheted az életben!");
    else Console.WriteLine("Akkor nem sok értelme volt erre a tanfolyamra beiratkozni... :(");
    Console.WriteLine($"Viszlát {nev}, legyen szép napod! <3");
}
static void Bankjegyautomata()
{
    int teljesOsszeg;
    do
    {
        Console.Write("írja be a felvenni kívánt összeget: ");
        teljesOsszeg = int.Parse(Console.ReadLine());
        if (teljesOsszeg <= 0) Console.WriteLine("HIBA! Ez az felvevőhely nem alkalmas befizetésre!");
        if (teljesOsszeg > 300000) Console.WriteLine("HIBA! kézpénzfelvételi limit. 300 000 HUF");
        if (teljesOsszeg % 1000 != 0) Console.WriteLine("HIBA! Csak kerek 1000es összeget tud felvenni!");
    } while (teljesOsszeg > 300000 || teljesOsszeg % 1000 != 0 || teljesOsszeg <= 0);

    int b10K = teljesOsszeg / 10000;
    teljesOsszeg -= b10K * 10000;
    int b05K = teljesOsszeg / 5000;
    teljesOsszeg -= b05K * 5000;
    int b01K = teljesOsszeg / 1000;

    Console.WriteLine("kiadott bankjegyek:");
    Console.WriteLine($"{b10K, 2} * 10 000 = {b10K * 10000, 6}");
    Console.WriteLine($"{b05K, 2} *  5 000 = {b05K *  5000, 6}");
    Console.WriteLine($"{b01K, 2} *  1 000 = {b01K *  1000, 6}");
    Console.WriteLine("--------------------");
    Console.WriteLine($"összesen:     {10000*b10K + 5000*b05K + 1000*b01K}");
}
static void TesttomegIndex()
{
    Console.Write("írja be a magasságát (cm): ");
    float magassag = int.Parse(Console.ReadLine()) / 100f;
    Console.Write("írja be a testsúlyát (kg): ");
    int tomeg = int.Parse(Console.ReadLine());
    float tti = tomeg / (float)Math.Pow(magassag, 2);

    Console.WriteLine($"testtömeg index: {tti:0.00} kg/m^2");
    Console.Write("testsúlyosztály: ");
    if (tti < 16) Console.WriteLine("súlyos soványság");
    else if (tti < 17) Console.WriteLine("mérsékelt soványság");
    else if (tti < 18.5) Console.WriteLine("enyhe soványság");
    else if (tti < 25) Console.WriteLine("normál testsúly");
    else if (tti < 30) Console.WriteLine("túlsúlyos");
    else if (tti < 35) Console.WriteLine("I. fokú elhízás");
    else if (tti < 40) Console.WriteLine("II. fokú elhízás");
    else Console.WriteLine("III. fokú (súlyos) elhízás");
}
static void Pitagorasz()
{
    Console.Write("írja be a derékszögű 3szög egyik befogójának hosszát (cm): ");
    float a = float.Parse(Console.ReadLine());
    Console.Write("írja be a derékszögű 3szög másik befogójának hosszát (cm): ");
    float b = float.Parse(Console.ReadLine());
    float c = (float)Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
    Console.WriteLine($"a 3szög átfogójának hossza: {c:0.000} cm");
}
static void KorKerTer()
{
    Console.Write("írja be a kör sugarának hozzát (cm): ");
    float r = float.Parse(Console.ReadLine());
    Console.WriteLine($"kör kerülete: {2 * r * Math.PI:0.00} cm");
    Console.WriteLine($"kör területe: {Math.Pow(r, 2) * Math.PI:0.00} cm^2");
}
static void Fizetes()
{
    Console.Write("írja be a havi bruttó fizetését (HUF): ");
    int haviBruttoFizetes = int.Parse(Console.ReadLine());
    Console.WriteLine($"havi nettó fizetése: {haviBruttoFizetes * .675:N0} HUF");
    Console.WriteLine($"éves bruttó fizetése: {12 * haviBruttoFizetes:N0} HUF");
    Console.WriteLine($"éves nettó jövedelme: {12 * haviBruttoFizetes * .675:N0} HUF");
}
static void Lakcim()
{
    Console.WriteLine("Írja be a lakcíméhez tartozó alábbi adatokat:");
    Console.Write("Irányítószám: ");
    string irsz = Console.ReadLine();
    Console.Write("Település neve: ");
    string varos = Console.ReadLine();
    Console.Write("Közterület neve: ");
    string ktnev = Console.ReadLine();
    Console.Write("Közterület jellege: ");
    string ktjelleg = Console.ReadLine();
    Console.Write("Házszám: ");
    string hsz = Console.ReadLine();

    string cim01 = irsz + " " + varos + " " + ktnev + " " + ktjelleg + " " + hsz + ".";
    string cim02 = string.Format("{0} {1} {2} {3} {4}.", irsz, varos, ktnev, ktjelleg, hsz);
    string cim03 = $"{irsz} {varos} {ktnev} {ktjelleg} {hsz}.";

    Console.WriteLine(cim01);
    Console.WriteLine(cim02);
    Console.WriteLine(cim03);
}