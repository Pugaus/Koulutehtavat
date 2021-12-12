using System;

namespace _05_Ehtolause
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vaihe 1.Tee ohjelma joka kysyy käyttäjän iän.Jos käyttäjä on alle 13 vuotta, ohjelma tervehtii "Mitä poitsu".
            //Jos käyttäjä on 14 - 25, ohjelma tervehtii "Mitä nuorimies".Jos käyttäjä on 26 - 56, ohjelma tervehtii "Olet mies parhaassa iässä".

            //Vaihe 2.Lisää ohjelmaan toiminne, joka kysyy aluksi onko käyttäjä mies vai nainen.Naiselle lisää samoihin ikäjakaumiin sopivat tervehdykset.

            //Vaihe 3.Lisää vielä tervehdys kaikille yli 56 vuotiaille
            
            int numero, sukupuoli;
            
            Console.WriteLine("Paina 1 jos olet mies. Paina 2 jos olet nainen: ");
            while (!int.TryParse(Console.ReadLine(), out sukupuoli) || sukupuoli > 2)
            {
                Console.Write("Paina 1 jos olet mies. Paina 2 jos olet nainen: ");
            }
            
            Console.WriteLine("Kerro ikäsi");          
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Syötä vain numeroita: ");
            }

            
            switch (sukupuoli)
            {
                case 1:
                    if (numero <= 12)
                    {
                        Console.WriteLine("Mitä poitsu");
                    }
                    else if (numero == 14 || numero <= 25)
                    {
                        Console.WriteLine("Mitä nuorimies");
                    }
                    else if (numero == 26 || numero <= 56)
                    {
                        Console.WriteLine("Olet mies parhaassa iässä");
                    }
                    else
                    {
                        Console.WriteLine("Hei ukki!");
                    }
                    break;
                case 2:
                    if (numero <= 12)
                    {
                        Console.WriteLine("Mitä tytsy");
                    }
                    else if (numero == 14 || numero <= 25)
                    {
                        Console.WriteLine("Mitä nuorinainen");
                    }
                    else if (numero == 26 || numero <= 56)
                    {
                        Console.WriteLine("Olet nainen parhaassa iässä");
                    }
                    else
                    {
                        Console.WriteLine("Hei mummo");
                    }
                    break;
            }         
        }
    }
}
