using System;

namespace DrivingLicence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //kui kasutaja on noorem kui 18, siis programm kuvab konsoolis
            //"oled liiga noor, et juhilube saada";
            //kui kasutaja on vanem, kui 18, siis programm kuvab konsoolis
            //"Oled piisavalt vana, et juhilube saada"
            //kui kasutaja on 18, siis programm kuvab konsoolis
            //"palju õnne, nüüd sa saad ka juhiluba taotleda"

            Console.WriteLine("Mis su sünniaasta on?");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            if (yearOfBirth > 2003)
            {
                Console.WriteLine("Oled liiga noor, et juhilube teha.");
            }
            else if (yearOfBirth < 2003)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube teha.");
            }
            else
            {
                Console.WriteLine("Palju õnne, nüüd saad juhilube taotleda!");
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
