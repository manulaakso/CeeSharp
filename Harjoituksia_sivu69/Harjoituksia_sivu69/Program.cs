using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoituksia_sivu69
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kysymys;
            do
            {
                int valinta;
            kaikenalku:
                Console.Clear();
                Console.WriteLine("Valitse alla olevista vaihtoehdoista ohjelma, jonka haluat ajaa:");
                Console.WriteLine("1. Käyttäjän ikä.");
                Console.WriteLine("2. Luvun toisto.");
                Console.WriteLine("3. Sanan ensimmäisen ja viimeisen kirjaimen vaihto.");
                Console.WriteLine("4. Tarkistus, ovatko annetut luvut positiivisia vai negatiivisia.");
                Console.WriteLine("5. Pisimmän sanan tulostus.");
                Console.WriteLine("6. Parittomien lukujen tulostus.");
                Console.WriteLine("7. Kolmella jaollisten lukujen tulostus.");
                try
                {
                    valinta = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Antamasi luku ei ollut kokonaisluku. Yritä uudelleen.");
                    goto kaikenalku;
                }
                switch (valinta)
                {
                    case 1:
                        KayttajanIka();
                        break;
                    case 2:
                        LuvunToisto();
                        break;
                    case 3:
                        KirjaintenVaihto();
                        break;
                    case 4:
                        LuvunEtumerkki();
                        break;
                    case 5:
                        PisinSana();
                        break;
                    case 6:
                        Parittomat();
                        break;
                    case 7:
                        KolmellaJaolliset();
                        break;
                    default:
                        Console.WriteLine("Et valinnut lukua väliltä 1-7. Yritä uudeleen.");
                        goto kaikenalku;
                        break;
                }
            }
    }
}
