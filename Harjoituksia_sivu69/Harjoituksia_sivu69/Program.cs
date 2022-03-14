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
            static void KayttajanIka()
            {
                string ika;
                Console.Clear();
                Console.Write("Anna ikäsi: ");
                ika = Console.ReadLine();
                Console.WriteLine("{0} - näytät ikäistäsi nuoremmalta", ika);
            }
            static void LuvunToisto()
            {
                int luku;
            ltalku:
                try
                {
                    Console.Clear();
                    Console.WriteLine("Ole hyvä ja anna 10:ntä suurempi luku: ");
                    luku = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Antamasi luku ei ollut kokonaisluku. Yritä uudelleen.");
                    goto ltalku;
                }
                for (int i = 0; i < luku; i++)
                {
                    for (int j = 0; j < luku; j++)
                    {
                        Console.Write(luku + " ");
                    }
                    Console.WriteLine();
                    for (int k = 0; k < luku; k++)
                    {
                        Console.Write(luku);
                    }
                    Console.WriteLine();
                }
            }
            static void KirjaintenVaihto()
            {
                string sana, uusisana;
                int pituus;
                Console.Clear();
                Console.Write("Anna sana, jonka ensimmäinen ja viimeinen kirjain vaihdetaan keskenään: ");
                sana = Console.ReadLine();
                pituus = sana.Length;
                char[] taulu = new char[pituus];
                for (int i = 0; i < pituus; i++)
                    taulu[i] = sana[i];
                taulu[0] = sana[pituus - 1];
                taulu[pituus - 1] = sana[0];
                uusisana = String.Join("", taulu);
                Console.WriteLine("Annoit sanan {0} ja se on muutettuja {1}", sana, uusisana);
            }
            static void LuvunEtumerkki()
            {
                int lk1, lk2;
            lealku:
                Console.Clear();
                Console.WriteLine("Tämä ohjelma pyytää käyttäjältä kahta lukua ja tarkastaa niiden etumerkit.");
                try
                {
                    Console.Write("Ole hyvä ja anna ensimmäinen kokonaisluku: ");
                    lk1 = Int32.Parse(Console.ReadLine());
                    Console.Write("Ole hyvä ja anna toinen kokonaisluku: ");
                    lk2 = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Antamasi arvot eivät olleet kokonaislukuja. Yritä uudelleen: ");
                    goto lealku;
                }
                if (lk1 >= 0 && lk2 >= 0)
                {
                    Console.WriteLine("Luvut ovat positiivisia");
                }
                else if (lk1 < 0 && lk2 < 0)
                {
                    Console.WriteLine("Luvut ovat negatiivisia");
                }
                else
                {
                    Console.WriteLine("Luvuista toinen on positiivinen ja toinen negatiivinen");
                }

            }
            static void PisinSana()
            {
                Console.Clear();
                Console.WriteLine("Tämä ohjelma pyytää käyttäjältä lausetta ja palauttaa lauseen pisimmin sanan.");
                string lause;
                Console.Write("Anna lause: ");
                lause = Console.ReadLine();
                string[] taulu = lause.Split(' ');
                string pisin = taulu[0];
                for (int i = 1; i < taulu.Length; i++)
                {
                    if (taulu[i].Length > pisin.Length)
                    {
                        pisin = taulu[i];
                    }
                }
                Console.WriteLine("Antamasi lause oli {0}, jonka pisin sana oli {1}.", lause, pisin);
            }
            static void Parittomat()
            {
                Console.Clear();
                Console.WriteLine("Tämä ohjelma tulostaa parittomat luvut väliltä 1-99.");
                for (int i = 1; i <= 99; i += 2)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            static void KolmellaJaolliset()
            {
                Console.Clear();
                Console.WriteLine("Tämä ohjelma tulostaa kolmella jaolliset luvut väliltä 1-99.");
                for (int i = 3; i <= 99; i += 3)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Haluatko lopettaa? 0 + Enter lopettaaksesi. Mikä muu tahansa jatkaa.");
            kysymys = Console.ReadLine();
        }while(kysymys != "0");
        }
    }
}