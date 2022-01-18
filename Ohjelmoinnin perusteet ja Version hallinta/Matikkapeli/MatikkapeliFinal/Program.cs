using System;

namespace MatikkapeliFinal
{
    class Program
    {
        //Valikko valinnat.
        enum Valinnat
        {
            yhteenlasku = 1, vähennyslasku, kertolasku, jakolasku, poistu
        }
        //Tervehdys ja valikko.
        static int Tervehdys()
        {            
            int valinta = 0;
            bool oikea = true;
            while (oikea)
            {
                try
                {
                    Console.WriteLine("Tervetuloa matematiikkapeliin! Valitse numeronäppäimellä, mitä laskuja haluat harjoitella tai voit myös lopettaa ohjelman.");
                    Console.WriteLine("\n1) Yhteenlaskuja \n2) Vähennyslaskuja \n3) Kertolaskuja \n4) Jakolaskuja \n5) Lopeta ohjelma");
                    valinta = Convert.ToInt32(Console.ReadLine());
                    if (valinta <= 5)
                    {
                        oikea = false;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Syötä numero 1 - 5 väliltä!");                   
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Syötä numero 1 - 5 väliltä!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Syötä numero 1 - 5 väliltä!");
                }
            }
            return valinta;
        }
        //Yhteenlasku kysymys ja kaava.
        static int Yhteen(int ekaYhteen, int tokaYhteen)
        {
            string syote;
            int summaYhteen = ekaYhteen + tokaYhteen;
            int pisteet = 0;

            Console.WriteLine("\npaljon on " + ekaYhteen + " + " + tokaYhteen + "?");
            syote = Console.ReadLine();
            bool oikein = Int32.TryParse(syote, out int vastaus);

            if (vastaus == summaYhteen)
            {
                Console.WriteLine("Vastaus oli oikein!");
                pisteet++;
            }
            else
            {
                Console.Write("Vastaus oli väärin.");
                Console.WriteLine("\nOikea vastaus olisi ollut: " + summaYhteen);
            }
            return pisteet;
        }
        //Vähennyslasku ja kaava.
        static int Vahennys(int ekaVahennys, int tokaVahennys)
        {
            string syote;
            int summaVahennys = ekaVahennys - tokaVahennys;
            int pisteet = 0;

            Console.WriteLine("\npaljon on " + ekaVahennys + " - " + tokaVahennys + "?");
            syote = Console.ReadLine();
            bool oikein = Int32.TryParse(syote, out int vastaus);

            if (vastaus == summaVahennys)
            {
                Console.WriteLine("Vastaus oli oikein!");
                pisteet++;
            }
            else
            {
                Console.Write("Vastaus oli väärin.");
                Console.WriteLine("\nOikea vastaus olisi ollut: " + summaVahennys);
            }
            return pisteet;
        }
        //Kertolasku ja kaava.
        static int Kerto(int ekaKerto, int tokaKerto)
        {
            string syote;
            int summaKerto = ekaKerto * tokaKerto;
            int pisteet = 0;

            Console.WriteLine("\npaljon on " + ekaKerto + " * " + tokaKerto + "?");
            syote = Console.ReadLine();
            bool oikein = Int32.TryParse(syote, out int vastaus);

            if (vastaus == summaKerto)
            {
                Console.WriteLine("Vastaus oli oikein!");
                pisteet++;
            }
            else
            {
                Console.Write("Vastaus oli väärin.");
                Console.WriteLine("\nOikea vastaus olisi ollut: " + summaKerto);
            }
            return pisteet;
        }
        //Jakolasku ja kaava
        static int Jako(double ekaJako, double tokaJako)
        {
            string syote;
            double summaJako = ekaJako / tokaJako;
            int pisteet = 0;

            Console.WriteLine("\npaljon on " + ekaJako + "/" + tokaJako + "?");
            syote = Console.ReadLine();
            bool oikein = Int32.TryParse(syote, out int vastaus);

            if (vastaus == summaJako)
            {
                Console.WriteLine("Vastaus oli oikein!");
                pisteet++;
            }
            else
            {
                Console.Write("Vastaus oli väärin.");
                Console.WriteLine("\nOikea vastaus olisi ollut: {0:0.00} ", + summaJako);
            }
            return pisteet;
        }
        //Piste tulokset
        static bool Pisteet(int pisteet)
        {           
            bool tulos = false;

            if (pisteet == 5)
            {
                Console.WriteLine("Loistavaa, sait kaikki oikein!");
                tulos = true;
            }
            else if (pisteet >= 1 || pisteet == 4)
            {
                Console.WriteLine("Vähän lisää harjoitusta!");
                tulos = true;
            }
            else
            {
                Console.WriteLine("Ei tainnut mennä ihan putkeen?");
                tulos = true;
            }
            return tulos;
        }
        //Valikko
        static int Valikko()
        {
            int valinta = 0;
            bool oikea = true;
            while (oikea)
            {
                try
                {
                    Console.WriteLine("==============================================================");
                    Console.WriteLine("Valitse numeronäppäimellä mitä laskuja haluat harjoitella tai voit myös lopettaa ohjelman.");
                    Console.WriteLine("\n1) Yhteenlaskuja \n2) Vähennyslaskuja \n3) Kertolaskuja \n4) Jakolaskuja \n5) Lopeta ohjelma");
                    valinta = Convert.ToInt32(Console.ReadLine());
                    if (valinta <= 5)
                    {
                        oikea = false;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Syötä numero 1 - 5 väliltä!");

                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Syötä numero 1 - 5 väliltä!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Syötä numero 1 - 5 väliltä!");
                }

            }
            return valinta;
        }
        static void Main(string[] args)
        {
            int valinta;
            valinta = Tervehdys();

            bool jatkuu = true;
            while (jatkuu)
            {
                int kierros = 5;
                int pisteet = 0;
                
                bool kysymykset = true;
                while (kysymykset)
                {
                    double ekaJako, tokaJako;
                    int ekaYhteen, tokaYhteen, ekaVahennys, tokaVahennys, ekaKerto, tokaKerto;

                    //Lukujen arvonta.
                    Random arpaHattu = new Random();
                    //Yhteen
                    ekaYhteen = arpaHattu.Next(1, 51);
                    tokaYhteen = arpaHattu.Next(1, 51);
                    //Vähennys
                    ekaVahennys = arpaHattu.Next(51, 101);
                    tokaVahennys = arpaHattu.Next(1, 51);
                    //Kerto
                    ekaKerto = arpaHattu.Next(1, 11);
                    tokaKerto = arpaHattu.Next(1, 11);
                    //jako
                    tokaJako = arpaHattu.Next(2, 11);
                    ekaJako = arpaHattu.Next(11, 101);

                    //Laskujen pisteytys
                    switch (valinta)
                    {
                        //Yhteenlasku
                        case ((int)Valinnat.yhteenlasku):

                            pisteet = pisteet + Yhteen(ekaYhteen, tokaYhteen);
                            kierros--;
                            if (kierros == 0)
                            {
                                Console.WriteLine("\nSait " + pisteet + " pistettä!");
                                kysymykset = false;
                            }
                            break;

                        //Vähennyslasku
                        case ((int)Valinnat.vähennyslasku):

                            pisteet = pisteet + Vahennys(ekaVahennys, tokaVahennys);
                            kierros--;
                            if (kierros == 0)
                            {
                                Console.WriteLine("\nSait " + pisteet + " pistettä!");
                                kysymykset = false;
                            }
                            break;

                        //Kertolasku
                        case ((int)Valinnat.kertolasku):

                            pisteet = pisteet + Kerto(ekaKerto, tokaKerto);
                            kierros--;
                            if (kierros == 0)
                            {
                                Console.WriteLine("\nSait " + pisteet + " pistettä!");
                                kysymykset = false;
                            }
                            break;

                        case ((int)Valinnat.jakolasku):

                            pisteet = pisteet + Jako(ekaJako, tokaJako);
                            kierros--;
                            if (kierros == 0)
                            {
                                Console.WriteLine("\nSait " + pisteet + " pistettä!");
                                kysymykset = false;
                            }
                            break;

                        case ((int)Valinnat.poistu):

                            Console.WriteLine("\n==============================================================");
                            Console.WriteLine("Kiitos Ohjelman käytöstä!");
                            Environment.Exit(0);
                            break;
                    }
                }
                //Tulokset                
                Pisteet(pisteet);
                
                //Valikko ja lopetus
                valinta = Valikko();
            }
        }
    }
}