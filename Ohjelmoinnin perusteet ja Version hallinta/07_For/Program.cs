using System;

namespace _07_For
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tehtävä 7.1
            //Vaihe 1.Toteuta ohjelma, joka kirjoittaa numerot 1 - 10 jokaisen omalle rivilleen.Käytä toteutuksessa for silmukkaa.
            //Vaihe 2. Toteuta ohjelma niin, että se kysyy aloituslukua käyttäjältä ja tulostaa sen ja seuraavat 9 lukua omille riveilleen.

            int i,j,num;

            Console.WriteLine("Hei! Anna jokin luku.");
            j = int.Parse(Console.ReadLine());

            for (i = 1; i < 10; i++)
            {
                Console.WriteLine(i + j);
            }

            //Tee ohjelma joka tulostaa annetun luvun mukaan lukupyramidin. Joudut käyttämään sisäkkäisiä for silmukoita tehtävässä.
            //Eli tulostetaan jokaiselle riville tulostetaan rivi numeroon asti lukuja. 

            Console.WriteLine("Anna jokin luku.");
            num = int.Parse(Console.ReadLine());

            for (i = 1; i <= num; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j + "");
                }
                Console.WriteLine();
            }
        }
    }
}
