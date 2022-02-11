using System;

namespace DrivingLicence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja sünniaastat
            //Programm arvutab kasutaja vanust
            //Kui kasutaja on noorem kui 18, siis programm kuvab konsoolis
            //"Oled liiga noor, et juhilube saada."
            //Kui kasutaja on vanem kui 18, siis programm kuvab konsoolis
            //"Oled piisavalt vana, et juhilube saada."
            //Kui kasutaja on 18, siis programm kuvab konsoolis
            //"Palju õnne! Nüüd sa saad ka juhilube taotleda!"

            Console.WriteLine("Palun, sisestage oma sünniaasta:");

            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2022 - yearOfBirth;

            if (userAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube saada.");
            }

            else if (userAge < 18)
            {
             Console.WriteLine("Oled liiga noor, et juhilube saada.");
            }

            else
            {
                Console.WriteLine("Palju õnne! Nüüd saad ka juhilube taotleda!");
            }
                
            








        }
    }
}
