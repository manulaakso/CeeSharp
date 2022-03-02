alku:
string kluku;
int luku;
Console.WriteLine("Valitse ohjelma, jonka suoritat:");
Console.WriteLine("1. Lukujen järjestäminen");
Console.WriteLine("2. Suurimman luvun etsiminen 3:sta");
Console.WriteLine("3. Luvun (0-9) muunto sanaksi");
Console.WriteLine("4. Suurimman luvun etsiminen 5:stä");
Console.WriteLine("5. Käyttäjän syöttövalinta");
Console.WriteLine("6. Bonuspisteet");
Console.WriteLine("7. Luvun (0-999) muunto sanaksi");
kluku = Console.ReadLine();
try
{
    luku = Int32.Parse(kluku);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Syöttöarvon pitää olla lukuarvo");
    goto alku;
}
switch (luku)
{
    case 1:
        LukujenJarjestys();
        break;
    case 2:
        SuurimmanEtsinta3();
        break;
    case 3:
        SanaksiPieni();
        break;
    case 4:
        SuurimmanEtsinta5();
        break;
    case 5:
        SyottoValinta();
        break;
    case 6:
        Bonuspisteet();
        break;
    case 7:
        SanaksiIso();
        break;
    default:
        Console.WriteLine("Antamasi arvo ei ole väliltä 1-7");
        goto alku;
}
static void LukujenJarjestys()
{
    string kluku1, kluku2;
    int luku1, luku2;
ljalku:
    Console.WriteLine("Ohjelma pyytää sinulta kahta kokonaislukua ja tulostaa ne suuruusjärjestyksessä.");
    Console.Write("Anna luku 1.");
    kluku1 = Console.ReadLine();
    Console.Write("Anna luku 2.");
    kluku2 = Console.ReadLine();
    try
    {
        luku1 = Int32.Parse(kluku1);
        luku2 = Int32.Parse(kluku2);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine("Antamasi arvot eivät olleet kokonaislukuja");
        goto ljalku;
    }
    if (luku2 > luku1)
    {
        Console.WriteLine("Lukujen järjestys {0}, {1}", luku1, luku2);
    }
    else
    {
        Console.WriteLine("Lukujen järjestys {0}, {1}", luku2, luku1);
    }

}
static void SuurimmanEtsinta3()
{
    int[] luvut = new int[3];
suualku:
    try
    {
        Console.WriteLine("Anna 1. kokonaisluku: ");
        luvut[0] = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Anna 2. kokonaisluku: ");
        luvut[1] = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Anna 3. kokonaisluku: ");
        luvut[2] = Int32.Parse(Console.ReadLine());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine("Antamasi luvut eivät olleet kokonaislukuja!");
        goto suualku;
    }

    Array.Sort(luvut);
    int viimeinen = luvut.Length;
    Console.WriteLine("Suurin luku oli: " + luvut[viimeinen - 1]);
}
static void SanaksiPieni()
{
    string kluku1;
    int luku1;
spalku:
    Console.WriteLine("Ohjelma pyytää sinulta lukua ja muuttaa sen sanaksi.");
    Console.Write("Anna luku 1.");
    kluku1 = Console.ReadLine();
    try
    {
        luku1 = Int32.Parse(kluku1);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine("Antamasi arvot eivät olleet kokonaislukuja");
        goto spalku;
    }
    switch (luku1)
    {
        case 1:
            Console.WriteLine("Yksi");
            break;
        case 2:
            Console.WriteLine("Kaksi");
            break;
        case 3:
            Console.WriteLine("Kolme");
            break;
        case 4:
            Console.WriteLine("Neljä");
            break;
        case 5:
            Console.WriteLine("Viisi");
            break;
        case 6:
            Console.WriteLine("Kuusi");
            break;
        case 7:
            Console.WriteLine("Seitsemän");
            break;
        default:
            Console.WriteLine("Antamasi arvo ei ole väliltä 1-7");
            goto spalku;
    }
}
static void SuurimmanEtsinta5() { }
static void SyottoValinta()
{
    int kluku;
    double dluku;
    string mjono, syote;
syottoalku:
    Console.WriteLine("Minkä tyyppisen tiedon haluat syöttää (double, int, string (d/i/s)): ");
    syote = Console.ReadLine();
    if (syote == "s" || syote == "d" || syote == "i" || syote == "S" || syote == "D" || syote == "I")
    {
        switch (syote)
        {
            case "s":
            case "S":
                Console.Write("Syötä merkkijono: ");
                mjono = Console.ReadLine();
                mjono += "*";
                Console.WriteLine("Uusi merkkijono on: " + mjono);
                break;
            case "d":
            case "D":
            doublealku:
                Console.Write("Syötä doubleluku: ");
                try
                {
                    dluku = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Annoit luvun " + dluku + " ja tulos on " + (dluku + 1));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Ole hyvä ja anna doubleluku!");
                    goto doublealku;
                }
                break;
            case "i":
            case "I":
            intalku:
                Console.Write("Syötä kokonaisluku: ");
                try
                {
                    kluku = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Annoin luvun " + kluku + " ja tulos on " + (kluku + 1));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Ole hyvä ja anna kokonaisluku!");
                    goto intalku;
                }
                break;
            default:
                Console.WriteLine("Jos päädyt tänne, jossakin on virhe!");
                break;

        }
    }
    else
    {
        Console.WriteLine("Annoit väärän syötteen. Anna vain kirjain: (d/i/s): ");
        goto syottoalku;
    }
}
static void Bonuspisteet()
{
    int ibonus;
bonusalku:
    Console.Write("Anna bonusten määrä: (1-9): ");
    try
    {
        ibonus = Int32.Parse(Console.ReadLine());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine("Antamasi arvo ei ollut kokonaisluku.");
        goto bonusalku;
    }
    switch (ibonus)
    {
        case 1:
        case 2:
        case 3:
            ibonus *= 3;
            break;
        case 4:
        case 5:
        case 6:
            ibonus *= 100;
            break;
        case 7:
        case 8:
        case 9:
            ibonus *= 1000;
            break;
        default:
            Console.WriteLine("Antamasi arvo ei ole välillä 1-9.");
            goto bonusalku;
            break;
    }
    Console.WriteLine("Lopullinen bonus on: " + ibonus);

}
static void SanaksiIso()
{
    int numero;
alkusana:
    Console.Write("Anna numero (0-999), jonka ohjelma muuntaa sanaksi: ");
    try
    {
        numero = Int32.Parse(Console.ReadLine());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine("Antamasi arvo ei ole kokonaisluku!");
        goto alkusana;
    }
    if (numero > 999 || numero < 0)
    {
        Console.WriteLine("Annoit luvun, joka ei ole välillä 0-999.");
        goto alkusana;
    }
    else if (numero < 10)
    {
        string ykkonen;
        ykkonen = ykkoset(numero);
        Console.WriteLine(ykkonen);
    }
    else if (numero < 20)
    {
        string pkymmenen;
        pkymmenen = poikkeuskymmenet(numero);
        //pkymmenen = kymmenet(numero);
        Console.WriteLine(pkymmenen);
    }
    else if (numero < 100)
    {
        string kymmenen;
        kymmenen = kymmenet(numero);
        Console.WriteLine(kymmenen);
    }
    else if (numero < 1000)
    {
        string sata;
        sata = sadat(numero);
        Console.WriteLine(sata);
    }
    static string ykkoset(int number)
    {
        switch (number)
        {
            case 1:
                return "Yksi";
                break;
            case 2:
                return "Kaksi";
                break;
            case 3:
                return "Kolme";
                break;
            case 4:
                return "Neljä";
                break;
            case 5:
                return "Viisi";
                break;
            case 6:
                return "Kuusi";
                break;
            case 7:
                return "Seitsemän";
                break;
            case 8:
                return "Kahdeksan";
                break;
            case 9:
                return "Yhdeksän";
                break;
            default:
                return "Puppua";
                break;
        }
    }
    static string poikkeuskymmenet(int number)
    {
        switch (number)
        {
            case 10:
                return "Kymmenen";
                break;
            case 11:
                return "Yksitoista";
                break;
            case 12:
                return "Kaksitoista";
                break;
            case 13:
                return "Kolmetoista";
                break;
            case 14:
                return "Neljätoista";
                break;
            case 15:
                return "Viisitoista";
                break;
            case 16:
                return "Kuusitoista";
                break;
            case 17:
                return "Seitsemäntoista";
                break;
            case 18:
                return "Kahdeksantoista";
                break;
            case 19:
                return "Yhdeksäntoista";
                break;
            default:
                return "Puttu";
                break;
        }
    }
    static string kymmenet(int number)
    {
        string x = Convert.ToString(number);
        string eka = x.Substring(0, 1);
        string toka = x.Substring(1, 1);
        number = Int32.Parse(eka);
        int toinen = Int32.Parse(toka);
        string y = ykkoset(toinen);
        switch (number)
        {
            case 2:
                return "Kaksikymmentä " + y;
                break;
            case 3:
                return "Kolmekymmentä " + y;
                break;
            case 4:
                return "Neljäkymmentä " + y;
                break;
            case 5:
                return "Viisikymmentä " + y;
                break;
            case 6:
                return "Kuusikymmentä " + y;
                break;
            case 7:
                return "Seitsemänkymmentä " + y;
                break;
            case 8:
                return "Kahdeksankymmentä " + y;
                break;
            case 9:
                return "Yhdeksänkymmentä " + y;
                break;
            default:
                return "puppua";
                break;
        }

    }
    static string sadat(int number)
    {
        string x = Convert.ToString(number);
        string y;
        string eka = x.Substring(0, 1);
        string toka = x.Substring(1, 2);
        string ptoka = x.Substring(1, 1);
        number = Int32.Parse(eka);
        int toinen = Int32.Parse(toka);
        if (ptoka == "1")
        {
            y = poikkeuskymmenet(toinen);
        }
        else
        {
            y = kymmenet(toinen);
        }
        switch (number)
        {
            case 1:
                return "Sata" + y;
                break;
            case 2:
                return "Kaksisataa " + y;
                break;
            case 3:
                return "Kolmesataa " + y;
                break;
            case 4:
                return "Neljäsataa " + y;
                break;
            case 5:
                return "Viisisataa " + y;
                break;
            case 6:
                return "Kuusisataa " + y;
                break;
            case 7:
                return "Seitsemänsataa " + y;
                break;
            case 8:
                return "Kahdeksansata a" + y;
                break;
            case 9:
                return "Yhdeksänsataa " + y;
                break;
            default:
                return "puppua";
                break;
        }
    }
    Console.Write("Aloitetaanko alusta (k/e)?");
    string vastaus = Console.ReadLine();
    if (vastaus == "k" || vastaus == "K")
    {
        goto alkusana;
    }
}