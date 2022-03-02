using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoituksia_sivu68
{
    internal class Program
    {
        Main(string[] args)
        {
            string kysymys;
            do
            {
            alku:
                string numero;
                int nro;
                Console.WriteLine("Valitse jokin alla olevista 10. tehtävästä: (1-10): ");
                Console.WriteLine(" 1. Lasketaan kaksi numeroa yhteen.");
                Console.WriteLine(" 2. Muutetaan Celsius-asteet Fahrenheiteiksi.");
                Console.WriteLine(" 3. Tehdään kaikki 4. peruslaskutoimitusta.");
                Console.WriteLine(" 4. Lasketaan jakojäännös.");
                Console.WriteLine(" 5. Kirjoitetaan viesti käyttäjälle.");
                Console.WriteLine(" 6. Kuten tehtävä 01., mutta käyttäjä antaa numerot.");
                Console.WriteLine(" 7. Kuten tehtävä 02., mutta käyttäjä antaa asteet.");
                Console.WriteLine(" 8. Kuten tehtävä 03., mutta käyttäjä antaa numerot.");
                Console.WriteLine(" 9. Kuten tehtävä 04., mutta käyttäjä antaa numerot.");
                Console.WriteLine("10. Lasketaan käyttäjän antamasta luvusta kertotaulu. ");
                try
                {
                    numero = Console.ReadLine();
                    nro = Int32.Parse(numero);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Console.WriteLine("Antamasi syöte ei kelvannut. ");
                    goto alku;
                }
                switch (nro)
                {
                    case 1:
                        LaskeYhteen(3, 5);
                        break;
                    case 2:
                        Fahrenheiteiksi(10);
                        break;
                    case 3:
                        Peruslaskutoimitukset(8, 5);
                        break;
                    case 4:
                        JakoJaannos(5, 2);
                        break;
                    case 5:
                        Viesti();
                        break;
                    case 6:
                        LaskeYhteenKayttajanLuvut();
                        break;
                    case 7:
                        FahrenheiteiksiKayttajanLuku();
                        break;
                    case 8:
                        PeruslaskutoimituksetKayttajanLuvuista();
                        break;
                    case 9:
                        JakoJaannosKayttajanLuvuista();
                        break;
                    case 10:
                        KertotauluKayttajanLuvusta();
                        break;
                    default:
                        Console.WriteLine("Et antanut luvua välillä 1-10");
                        goto alku;
                }
                
                Console.WriteLine("Haluatko lopettaa? 0 + Enter lopettaaksesi");
                kysymys = Console.ReadLine();
            } while (kysymys != "0");

        }
        static void LaskeYhteen(int a, int b)
        {
            Console.WriteLine("Tulos on: " + (a + b));
        }
        static void Fahrenheiteiksi(int a)
        {
            Console.WriteLine(a + " Celsiusta on " + ((a * 1.8) + 32) + " Fahrenheit astetta");
        }
        static void Peruslaskutoimitukset(int a, int b)
        {
            int summa, tulo, erotus;
            double jako;
            summa = a + b;
            tulo = a * b;
            erotus = a - b;
            jako = (double)a / b;
            Console.WriteLine("Lukujen " + a + " ja " + b);
            Console.WriteLine("Summa on " + summa);
            Console.WriteLine("Erotus on " + erotus);
            Console.WriteLine("Tulo on " + tulo);
            Console.WriteLine("Osamäärä on " + jako);
        }
        static void JakoJaannos(int a, int b)
        {
            int jakoj = a % b;
            Console.WriteLine("Lukujen " + a + " ja " + b);
            Console.WriteLine("Jakojäännös on " + jakoj);
        }
        static void Viesti()
        {
            string viesti;
            Console.Write("Anna etunimesi: ");
            viesti = Console.ReadLine();
            Console.WriteLine("Hei " + viesti);
        }
        static void LaskeYhteenKayttajanLuvut()
        {
            int luku1, luku2, summa;
            Console.WriteLine("Tämä ohjelma laskee yhteen antamasi luvut.");
        lyalku:
            try
            {
                Console.Write("Anna 1. luku: ");
                luku1 = Int32.Parse(Console.ReadLine());
                Console.Write("Anna 2. luku: ");
                luku2 = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi luvut eivät olleet kokonaislukuja. Yritä uudelleen.");
                goto lyalku;
            }
            summa = luku1 + luku2;
            Console.WriteLine("Lukujen " + luku1 + " ja " + luku2 + " summa on " + summa);
        }
        static void FahrenheiteiksiKayttajanLuku()
        {
            double kaluku, fhluku;
            Console.WriteLine("Tämä ohjelma muuntaa antamasi Celsiusarvon Fahrenheitasteeksi.");
        fhalku:
            try
            {
                Console.WriteLine("Anna Celsiusaste: ");
                kaluku = Double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Et antanut numeerista arvoa. Yritä uudelleen.");
                goto fhalku;
            }
            fhluku = (kaluku * 1.8) + 32;
            Console.WriteLine(kaluku + " Celsiusta on " + fhluku + " Fahrenheitia");
        }
        static void PeruslaskutoimituksetKayttajanLuvuista()
        {
            Console.WriteLine("Tämä ohjelma laskee peruslaskutoimitukset antamistasi kokonaisluvuista.");
            int l1, l2, summa, erotus, tulo;
            double osamaara;
        plalku:
            try
            {
                Console.Write("Anna ensimmäinen kokonaisluku: ");
                l1 = Int32.Parse(Console.ReadLine());
                Console.Write("Anna toinen kokonaisluku: ");
                l2 = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi luvut eivät olleet kokonaislukuja, yritä uudelleen.");
                goto plalku;
            }
            summa = l1 + l2;
            erotus = l1 - l2;
            tulo = l1 * l2;
            osamaara = (double)l1 / l2;
            Console.WriteLine("Lukujen {0} ja {1} peruslaskutoimitusten arvot ovat seuraavat:", l1, l2);
            Console.WriteLine("Summa: {0} ", summa);
            Console.WriteLine("Erotus: {0} ", erotus);
            Console.WriteLine("Tulo: {0} ", tulo);
            Console.WriteLine("Osamäärä: {0} ", osamaara);

        }
        static void JakoJaannosKayttajanLuvuista()
        {
            Console.WriteLine("Tämä ohjelma laskee jakojäännöksen antamistasi kahdesta luvusta.");
            int lu1, lu2, jakoj;
        jjalku:
            try
            {
                Console.Write("Anna jaettava luku: ");
                lu1 = Int32.Parse(Console.ReadLine());
                Console.Write("Anna jakava luku: ");
                lu2 = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi luvut eivät olleet kokonaislukuja. Yritä uudelleen.");
                goto jjalku;
            }
            jakoj = lu1 % lu2;
            Console.WriteLine("Lukujen {0} ja {1} jakojäännös on {2}.", lu1, lu2, jakoj);
        }
        static void KertotauluKayttajanLuvusta()
        {
            Console.WriteLine("Tämä ohjelma tekee 10-kertotaulun antamastasi kokonaisluvusta.");
            int kluku;
        kalku:
            try
            {
                kluku = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi luku ei ollut kokonaisluku. Yritä uudelleen.");
                goto kalku;
            }
            Console.WriteLine(" 1 x " + kluku + " = " + (1 * kluku));
            Console.WriteLine(" 2 x " + kluku + " = " + (2 * kluku));
            Console.WriteLine(" 3 x " + kluku + " = " + (3 * kluku));
            Console.WriteLine(" 4 x " + kluku + " = " + (4 * kluku));
            Console.WriteLine(" 5 x " + kluku + " = " + (5 * kluku));
            Console.WriteLine(" 6 x " + kluku + " = " + (6 * kluku));
            Console.WriteLine(" 7 x " + kluku + " = " + (7 * kluku));
            Console.WriteLine(" 8 x " + kluku + " = " + (8 * kluku));
            Console.WriteLine(" 9 x " + kluku + " = " + (9 * kluku));
            Console.WriteLine("10 x " + kluku + " = " + (10 * kluku));
        }
    }
}
