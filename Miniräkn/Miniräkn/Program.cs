using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniräkn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // meny
            Console.WriteLine("Välj en operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");

            // här ska användarens val läsas in och valideras
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Ogiltigt val. Vänligen välj ett nummer mellan 1 och 4.");
            }

            // läs in två tal från användaren och validera
            int x, y;
            Console.WriteLine("Ange det första talet:");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Ogiltigt tal. Vänligen ange ett heltal.");
            }

            Console.WriteLine("Ange det andra talet:");
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Ogiltigt tal. Vänligen ange ett heltal.");
            }



        }
    }
}
