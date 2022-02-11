using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja vanust;
            //Pragramm arvutab kasutaja sünnaastat;
            //Programm kuvab sünniaastat konsoolis;
            //Oled sündinud aastal {yearOfBirth}

            Console.WriteLine("Palun, sisestage oma vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            int yearOfBirth = 2022 - userAge;

            Console.WriteLine($"Oled sündinud {yearOfBirth} aastal.");

            




        }
    }
}
